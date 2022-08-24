using System.Diagnostics;
using System.Timers;
using static DesktopS3_Helper.AutoLockScreen;
using Timer = System.Timers.Timer;

namespace DesktopS3_UI
{
    public partial class ParentForm : Form
    {
        private Timer _timer;

        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �����Զ���������
        /// </summary>
        protected void AutoLockScreen()
        {
            if (Instance.Hover == 0)
            {
                _timer = new(5000);
                _timer.Elapsed += LockScreenTask;
            }

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
                    Instance.FormObject.Hide();

                    var lockScreenForm = new LockScreenForm(Instance.FormObject);
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