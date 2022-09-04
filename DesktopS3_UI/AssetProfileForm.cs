using System.Diagnostics.CodeAnalysis;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.DisplayDto.AssetProfileForm;
using static DesktopS3_BLL.AssetStatisticsFormBll;
using static DesktopS3_UI.AssetStatisticsForm;
using UpkeepDataGridViewDisplayDto = DesktopS3_Models.DisplayDto.AssetProfileForm.UpkeepDataGridViewDisplayDto;

namespace DesktopS3_UI
{
    [SuppressMessage("ReSharper", "ConditionIsAlwaysTrueOrFalseAccordingToNullableAPIContract")]
    public partial class AssetProfileForm : ParentForm
    {
        private readonly AssetDataGridViewDisplayDto _dto;

        private readonly List<Image> _assetImages = new();
        private int _nextPage = 0;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0X02000000;
                return cp;
            }
        }
        public AssetProfileForm()
        {
            InitializeComponent();
        }

        public AssetProfileForm(AssetDataGridViewDisplayDto dto)
        {
            InitializeComponent();
            _dto = dto ?? throw new ArgumentNullException(nameof(dto));
        }
        
        private void AssetProfileForm_Load(object sender, EventArgs e)
        {
            Task loadInformationTask = new(LoadInformationPanel);
            Parallel.Invoke(loadInformationTask.Start,LoadPicture);

            loadInformationTask.ContinueWith(t =>
            {
                Parallel.Invoke(LoadTransferDataGridView, LoadUpkeepDataGridView);
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        /// <summary>
        /// 控制资产图片往前走一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeftClick_PictureBox_Click(object sender, EventArgs e)
        {
            if (_nextPage == 0 || _assetImages.Count == 1)
            {
                MessageBox.Show(@"已经是第一页", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _nextPage--;
            Asset_PictureBox.Image = _assetImages[_nextPage];//后一张
        }

        /// <summary>
        /// 控制资产图片往前走一张
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RightClick_PictureBox_Click(object sender, EventArgs e)
        {
            if (_nextPage == _assetImages.Count-1)
            {
                MessageBox.Show(@"已经是最后一张", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _nextPage++;
            Asset_PictureBox.Image = _assetImages[_nextPage];//前一张
        }

        private void AssetProfileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            InstanceForm.Show();
        }

        /*-------------------------------------加载Information_Panel里的各个文本控件的值--------------------------------------*/
        private void LoadInformationPanel()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                BeginInvoke(() =>
                {
                    Control con = AssetNumber_Label;
                    for (int i = 0; i < 7; i++)
                    {
                        con!.Text = (string)_dto[i];
                        con = Information_Panel.GetNextControl(con, true)!;
                        if (con == null)
                        {
                            var message = MessageBox.Show(@"数据出错，请稍后重试!!!", @"错误", MessageBoxButtons.RetryCancel,
                                MessageBoxIcon.Error);
                            if (message == DialogResult.Retry)
                                AssetProfileForm_Load(null!, null!);
                        }
                    }
                });
            });
        }

        /*------------------------------------------加载Asset_PictureBox里的图片-------------------------------------------*/
        async void LoadPicture()
        {
            var assets = await GetAssetIdByAssetNameAsync((string)_dto[1]);
            int assetId = assets.ToList()[0].Id; //获取AssetId

            DirectoryInfo dir = new($"{Application.StartupPath}/../../../AssetPhoto");//获取该文件下的所有文件
            var fileInfos = dir.GetFiles().ToList();
            foreach (var fileInfo in fileInfos)
            {
                if (fileInfo.Name.Split("-")[0] == assetId.ToString())
                    _assetImages.Add(Image.FromFile($"{Application.StartupPath}/../../../AssetPhoto/{fileInfo.Name}"));
            }

            if (_assetImages.Count <= 0)
            {
                Asset_PictureBox.Image = Asset_PictureBox.ErrorImage;
                return;
            }

            BeginInvoke(() =>
            {
                Asset_PictureBox.Image = _assetImages[_nextPage]; //初始化第一张图片
            });
        }

        /*----------------------------------------加载Transfer_DataGridView里的图片-----------------------------------------*/
        private void LoadTransferDataGridView()
        {
            BeginInvoke(async () =>
            {
                string assetName = AssetName_Label.Text.Trim();
                IEnumerable<TransferDataGridViewDisplayDto> dtoCollection = await GetTransferDataGridViewInformation(assetName);
                if (dtoCollection == null)
                    return;

                dtoCollection = dtoCollection.OrderBy(r => r.TransferTime);
                foreach (var dto in dtoCollection)
                {
                    int row = Transfer_DataGridView.Rows.Add();
                    for (int column = 0; column < Transfer_DataGridView.Columns.Count; column++)
                    {
                        Transfer_DataGridView.Rows[row].Cells[column].Value = dto[column];
                    }
                }
            });
        }

        /*-----------------------------------------加载Upkeep_DataGridView里的信息------------------------------------------*/
        private void LoadUpkeepDataGridView()
        {
            BeginInvoke(async () =>
            {
                string assetName = AssetName_Label.Text.Trim();//assetName为空
                IEnumerable<UpkeepDataGridViewDisplayDto> dtoCollection =
                    await GetUpkeepHistoryDataGridViewInformation(assetName);
                if (dtoCollection == null)
                    return;

                dtoCollection = dtoCollection.OrderBy(r => r.UpkeepDate);
                foreach (var dto in dtoCollection)
                {
                    int row = Upkeep_DataGridView.Rows.Add();
                    for (int column = 0; column < Upkeep_DataGridView.Columns.Count; column++)
                    {
                        Upkeep_DataGridView.Rows[row].Cells[column].Value = dto[column];
                    }
                }
            });
        }
    }

}

