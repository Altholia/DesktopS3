using System.Diagnostics;
using System.Timers;
using static DesktopS3_Helper.AutoLockScreen;
using Timer = System.Timers.Timer;

namespace DesktopS3_UI
{
    public partial class ParentForm : Form
    {
        private Timer _timer;
        private Form _form;

        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �����Զ���������
        /// </summary>
        protected void AutoLockScreen(Form form)
        {
            _form = form;

            _timer = new(20000000);
            _timer.Elapsed += LockScreenTask;

            _timer.Start();
        }

        /// <summary>
        /// �Զ�����������
        /// </summary>
        protected void LockScreenTask(object? sender, ElapsedEventArgs e)
        {
            if (!IsHide)
            {
                Instance.FormObject?.BeginInvoke(() =>
                {
                    _form.Hide();

                    var lockScreenForm = new LockScreenForm(_form);
                    LockScreenForm.Instance?.Show();
                });

                IsHide = true;
                StopTask();
            }
        }

        /// <summary>
        /// ����������ʱֹͣ����
        /// </summary>
        protected void StopTask()
        {
            if (_timer == null)
                return;

            _timer.Stop();
        }

        /// <summary>
        /// ������ر�ʱ�ͷ�����
        /// </summary>
        protected void ReleaseTask()
        {
            if (_timer == null)
                return; 

            _timer.Stop();
            _timer.Dispose();
        }
    }
}