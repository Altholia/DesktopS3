using System.Diagnostics;
using System.Timers;
using static DesktopS3_Helper.AutoLockScreen;
using Timer = System.Timers.Timer;

namespace DesktopS3_UI
{
    public partial class ParentForm : Form
    {
        private Task _lockScreenTask;
        private CancellationTokenSource _cts;

        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// �����Զ���������
        /// </summary>
        protected async void AutoLockScreen()
        {
            _cts = new();

            _lockScreenTask = new(LockScreenTask,_cts.Token);
            _lockScreenTask.Start();
            Debug.WriteLine($"{nameof(AutoLockScreen)}������������������");

            try
            {
                await Task.WhenAny(_lockScreenTask);
            }
            catch (AggregateException ex)
            {
                Debug.WriteLine($"��������ȡ����" + ex.Message);
            }
        }

        /// <summary>
        /// �Զ�����������
        /// </summary>
        protected void LockScreenTask(/*object? sender, ElapsedEventArgs e*/)
        {
            if (!IsHide)
            {
                Task.Delay(5000).Wait();

                CancellationToken token = _cts.Token;
                if (token.IsCancellationRequested)
                {
                    Debug.WriteLine($"{nameof(LockScreenTask)}�����������ѱ�ȡ��");
                    token.ThrowIfCancellationRequested();
                }

                Instance.FormObject?.BeginInvoke(() =>
                {
                    Instance.FormObject.Hide();

                    var lockScreenForm = new LockScreenForm(Instance.FormObject);
                    LockScreenForm.Instance?.Show();
                });

                IsHide = true;
            }
        }

        /// <summary>
        /// ������ر�ʱ�ͷ�����
        /// </summary>
        protected void ReleaseTask()
        {
            if (_lockScreenTask == null || _cts == null || _lockScreenTask.Status == TaskStatus.Canceled)
            {
                Debug.WriteLine($"{nameof(ReleaseTask)}������Ϊ�ջ�ȡ������Ϊ�ջ������ѱ�ȡ��");
                return;
            }

            try
            {
                _cts.Cancel();
            }
            catch (ObjectDisposedException)
            {
                Debug.WriteLine($"{nameof(ReleaseTask)}�������ѱ��ͷ�");
            }
        }
    }
}