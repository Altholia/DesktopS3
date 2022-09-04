using System.Collections;
using System.Diagnostics;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Entities;
using static DesktopS3_BLL.AssetStatisticsFormBll;
using static DesktopS3_Helper.AutoLockScreen;
// ReSharper disable All

namespace DesktopS3_UI
{
    public partial class AssetStatisticsForm : ParentForm
    {
        public static AssetStatisticsForm InstanceForm { get; private set; }//单例
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0X02000000;
                return cp;
            }
        }

        public AssetStatisticsForm()
        {
            InitializeComponent();
            InstanceForm = this;
        }

        private void AssetStatisticsForm_Load(object sender, EventArgs e)
        {
            /*--------------------用于给UpkeepType_ComboBox、Name_ComboBox和Category_ComboBox赋初值-------------------------*/
            (Task<IEnumerable<UpkeepType>> upkeepTypeTask,
                Task<IEnumerable<Asset>> assetTask,
                Task<IEnumerable<AssetCategory>> assetCategoryTask) = GetAssetStatisticsComboBoxInformation();

            Parallel.Invoke(AssignUpkeepTypeComboBox, AssignNameComboBox, AssignCategoryComboBox);

            async void AssignUpkeepTypeComboBox()//用于给UpkeepType_ComboBox赋值
            {
                try
                {
                    IEnumerable<UpkeepType> dtoCollection = await upkeepTypeTask;
                    if (dtoCollection == null)
                        return;

                    if (UpkeepType_ComboBox.Items.Count == dtoCollection.Count())
                        return;

                    BeginInvoke(() => { UpkeepType_ComboBox.Items.Clear(); });
                    Parallel.ForEach(dtoCollection,
                        dto => { BeginInvoke(() => { UpkeepType_ComboBox.Items.Add(dto.Name); }); });
                }
                finally
                {
                    upkeepTypeTask.Dispose();;
                }
            }

            async void AssignNameComboBox()//用于给Name_ComboBox赋值
            {
                try
                {
                    IEnumerable<Asset> dtoCollection = await assetTask;
                    if (Name_Combox.Items.Count == dtoCollection.Count())
                        return;

                    BeginInvoke(() =>
                    {
                        Name_Combox.Items.Clear();
                        Name_Combox.Items.Add("All");
                    });
                    Parallel.ForEach(dtoCollection,
                        dto => 
                        { 
                            BeginInvoke(() =>
                            {
                                Name_Combox.Items.Add(dto.Name);
                            });
                        });
                }
                catch (ArgumentNullException)
                {
                    var message = MessageBox.Show(@"数据加载出错，请重试！！！", @"错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (message == DialogResult.Retry)
                        AssignNameComboBox();
                    else
                        return;
                }
                finally
                {
                    assetTask.Dispose();
                }
            }

            async void AssignCategoryComboBox()//用于给 Category_ComboBox 控件赋初值
            {
                try
                {
                    IEnumerable<AssetCategory> dtoCollection = await assetCategoryTask;
                    if (Category_ComboBox.Items.Count == dtoCollection.Count())
                        return;

                    BeginInvoke(() =>
                    {
                        Category_ComboBox.Items.Clear();
                        Category_ComboBox.Items.Add("All");
                    });
                    Parallel.ForEach(dtoCollection,
                        dto => { BeginInvoke(() => { Category_ComboBox.Items.Add(dto.Name); }); });
                }
                catch(ArgumentNullException)
                {
                    var message = MessageBox.Show(@"数据加载出错，请重试！！！", @"错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (message == DialogResult.Retry)
                        AssignCategoryComboBox();
                    else
                        return;
                }
                finally
                {
                    assetCategoryTask.Dispose();
                }
            }
        }
        private async void UpkeepType_ComboBox_TextChanged(object sender, EventArgs e)
        {
            string upkeepTypeName = UpkeepType_ComboBox.Text.Trim();

            IEnumerable<UpkeepDataGridViewDisplayDto> dtoCollection = await 
                GetUpkeepDataGridViewInformation(upkeepTypeName);
            if (dtoCollection == null)
            {
                MessageBox.Show(@"数据出错，请稍后重试……", @"错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                return;
            }

            /*----------------------------------用于给Upkeep_DataGridView控件填充数据---------------------------------------*/
            int row;
            Upkeep_DataGridView.Rows.Clear();//清除一波，以免重复添加
            Parallel.ForEach(dtoCollection, dto =>
            {
                BeginInvoke(() =>
                {
                    lock (Upkeep_DataGridView.Rows)
                    {
                        row = Upkeep_DataGridView.Rows.Add();
                        for (int column = 0; column < dto.Length; column++)
                        {
                            if (Convert.ToInt32(dto[5]) <= 0 && column == 5)
                                Upkeep_DataGridView.Rows[row].Cells[5].Style = new()
                                {
                                    BackColor = Color.Red
                                };

                            Upkeep_DataGridView.Rows[row].Cells[column].Value = dto[column];
                        }
                    }
                });
            });
        }

        private async void Search_Button_Click(object sender, EventArgs e)
        {
            /*-----------------------------------用于给Asset_DataGridView控件填充数据----------------------------------------*/
            Asset_DataGridView.Rows.Clear();//清除一波

            string assetName = Name_Combox.Text.Trim();
            string categoryName = Category_ComboBox.Text.Trim();
            if (assetName == "All")
                assetName = null!;

            if (categoryName == "All")
                categoryName = null!;

            IEnumerable<AssetDataGridViewDisplayDto> dtoCollection = 
                await GetAssetDataGridViewInformationAsync(assetName, categoryName);

            if (dtoCollection==null)
            {
                MessageBox.Show(@"没有查找到相关的信息", @"错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                return;
            }

            Parallel.ForEach(dtoCollection, dto =>
            {
                BeginInvoke(() =>
                {
                    lock (Asset_DataGridView.Rows)
                    {
                        int row = Asset_DataGridView.Rows.Add();
                        for (int column = 0; column < Asset_DataGridView.Columns.Count; column++)
                        {
                            Asset_DataGridView.Rows[row].Cells[column].Value = dto[column];
                        }
                    }
                });
            });
        }

        private void Asset_DataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            if (rowIndex < 0 || columnIndex != 7)
                return;

            AssetDataGridViewDisplayDto dto = new();
            for (int column = 0; column < Asset_DataGridView.Columns.Count-1; column++)
            {
                dto[column] = Asset_DataGridView.Rows[rowIndex].Cells[column].Value;
            }

            Hide();
            new AssetProfileForm(dto).Show();
        }

        private async void AssetStatisticsForm_MouseHover(object sender, EventArgs e)
        {
            await Task.Delay(Instance.Hover);//停留，解决鼠标停留问题
            AutoLockScreen(this);//当鼠标停留一段时间后则开启自动锁屏
        }

        private void AssetStatisticsForm_MouseMove(object sender, MouseEventArgs e)
        {
            StopTask();//当鼠标移动时重置自动锁屏的时间
        }

        private void AssetStatisticsForm_Deactivate(object sender, EventArgs e)
        {
            ReleaseTask();//当窗体隐藏时释放锁屏任务
        }

        private void AssetStatisticsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new NavigationScreenForm().Show();
        }
    }
}
