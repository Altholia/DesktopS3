using DesktopS3_Models.DisplayDto;
using static DesktopS3_BLL.AssetStatisticsFormBll;
using static DesktopS3_UI.AssetStatisticsForm;

namespace DesktopS3_UI
{
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
            Parallel.Invoke(LoadInformationPanel,LoadPicture);
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

        /*-----------------------------------加载Information_Panel里的各个文本控件的值------------------------------------*/
        private void LoadInformationPanel()
        {
            Task task = Task.Factory.StartNew(() =>
            {
                BeginInvoke(() =>
                {
                    Control con = AssetNumber_Label;
                    for (int i = 0; i < 7; i++)
                    {
                        con.Text = (string)_dto[i];
                        con = Information_Panel.GetNextControl(con, true);
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

        /*-----------------------------------加载Asset_PictureBox里的图片------------------------------------*/
        private async void LoadPicture()
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
    }
}
