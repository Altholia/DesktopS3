using System.Collections;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Entities;
using static DesktopS3_BLL.DesktopBll;

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
            Task<IEnumerable<UpkeepType>> upkeepTypeTask = InstanceBll.GetUpkeepTypesAsync();
            Task<IEnumerable<Asset>> assetTask = InstanceBll.GetAssetCollectionAsync();
            Task<IEnumerable<AssetCategory>> assetCategoryTask = InstanceBll.GetAssetCategoryCollectionAsync();

            Parallel.Invoke(AssignUpkeepTypeComboBox, AssignNameComboBox, AssignCategoryComboBox);

            /*--------------------用于给UpkeepType_ComboBox、Name_ComboBox和Category_ComboBox赋初值-------------------------*/

            async void AssignUpkeepTypeComboBox()//用于给UpkeepType_ComboBox赋值
            {
                IEnumerable<UpkeepType> dtoCollection = await upkeepTypeTask;
                if (UpkeepType_ComboBox.Items.Count == dtoCollection.Count())
                    return;

                BeginInvoke(() =>
                {
                    UpkeepType_ComboBox.Items.Clear();
                });
                Parallel.ForEach<UpkeepType>(dtoCollection, dto =>
                {
                    BeginInvoke(() =>
                    {
                        UpkeepType_ComboBox.Items.Add(dto.Name);
                    });
                });
            }

            async void AssignNameComboBox()//用于给Name_ComboBox赋值
            {
                IEnumerable<Asset> dtoCollection = await assetTask;
                if (Name_Combox.Items.Count == dtoCollection.Count())
                    return;

                BeginInvoke(() =>
                {
                    Name_Combox.Items.Clear();
                });
                Parallel.ForEach<Asset>(dtoCollection, dto =>
                {
                    BeginInvoke(() =>
                    {
                        Name_Combox.Items.Add(dto.Name);
                    });
                });
            }

            async void AssignCategoryComboBox()//用于给 Category_ComboBox 控件赋初值
            {
                IEnumerable<AssetCategory> dtoCollection = await assetCategoryTask;
                if (Category_ComboBox.Items.Count == dtoCollection.Count())
                    return;

                BeginInvoke(() =>
                {
                    Category_ComboBox.Items.Clear();
                });
                Parallel.ForEach<AssetCategory>(dtoCollection, dto =>
                {
                    BeginInvoke(() =>
                    {
                        Category_ComboBox.Items.Add(dto.Name);
                    });
                });
            }
        }


    }
}
