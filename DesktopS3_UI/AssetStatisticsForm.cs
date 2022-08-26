using System.Collections;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Entities;
using static DesktopS3_BLL.AssetStatisticsFormBll;
using static DesktopS3_Helper.AutoLockScreen;
// ReSharper disable All

namespace DesktopS3_UI
{
    public partial class AssetStatisticsForm : ParentForm
    {
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
                    if (dtoCollection == null)
                        return;

                    if (Name_Combox.Items.Count == dtoCollection.Count())
                        return;

                    BeginInvoke(() => { Name_Combox.Items.Clear(); });
                    Parallel.ForEach(dtoCollection,
                        dto => { BeginInvoke(() => { Name_Combox.Items.Add(dto.Name); }); });
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

                    BeginInvoke(() => { Category_ComboBox.Items.Clear(); });
                    Parallel.ForEach(dtoCollection,
                        dto => { BeginInvoke(() => { Category_ComboBox.Items.Add(dto.Name); }); });
                }
                finally
                {
                    assetCategoryTask.Dispose();
                }
            }
        }
        private async void UpkeepType_ComboBox_TextChanged(object sender, EventArgs e)
        {
            //string upkeepTypeName = UpkeepType_ComboBox.Text.Trim();
            //UpkeepType upkeepType = await InstanceBll.GetUpkeepTypeByNameAsync(upkeepTypeName);
            //if (upkeepType == null!)
            //{
            //    MessageBox.Show(@"数据出错，请稍后重试……", @"错误", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            //    return;
            //}

            //IEnumerable<Asset> dtoCollection = await InstanceBll.GetAssetCollectionAsync(upkeepTypeId:upkeepType.Id);
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
    }
}
