namespace DesktopS3_UI
{
    public partial class TransportationStatisticsForm : ParentForm
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

        public TransportationStatisticsForm()
        {
            InitializeComponent();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            string startDate = FromDate_DateTime.Value.ToString("yyyy-MM-ddThh:mm:ss");
            string endDate = ToDate_DateTime.Value.ToString("yyyy-MM-ddThh:mm:ss");
        }
    }
}
