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
    }
}
