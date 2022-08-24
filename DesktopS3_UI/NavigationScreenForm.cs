namespace DesktopS3_UI
{
    public partial class NavigationScreenForm : ParentForm
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

        public NavigationScreenForm()
        {
            InitializeComponent();
        }

        private void Navigation_Click(object sender, EventArgs e)
        {
#pragma warning disable CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。
            string name = (sender as Button)?.Name;
#pragma warning restore CS8600 // 将 null 字面量或可能为 null 的值转换为非 null 类型。

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show($@"未选择导航属性", $@"警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }

            switch (name)
            {
                case $"{nameof(Asset_Button)}":
                    break;
                case $"{nameof(Transportation_Button)}":
                    break;
                case $"{nameof(Part_Button)}":
                    break;
                default:
                    MessageBox.Show($@"未选择导航属性", $@"警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    break;
            }
        }
    }
}
