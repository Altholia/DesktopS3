namespace DesktopS3_UI
{
    public partial class LockScreenForm : ParentForm
    {
        public static LockScreenForm? Instance { get; private set; }
        private readonly Form _form;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0X02000000;
                return cp;
            }
        }

        public LockScreenForm(Form form)
        {
            InitializeComponent();

            _form = form;
            Instance = this;
        }

        private void LockScreenForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _form.Show();
            AutoLockScreen();

            DesktopS3_Helper.AutoLockScreen.IsHide = false;
        }
    }
}
