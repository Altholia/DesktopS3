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
        /// 调用自动锁屏方法
        /// </summary>
        protected async void AutoLockScreen()
        {
            _cts = new();

            _lockScreenTask = new(LockScreenTask,_cts.Token);
            _lockScreenTask.Start();
            Debug.WriteLine($"{nameof(AutoLockScreen)}：锁屏任务正在启动");

            try
            {
                await Task.WhenAny(_lockScreenTask);
            }
            catch (AggregateException ex)
            {
                Debug.WriteLine($"锁屏任务被取消：" + ex.Message);
            }
        }

        /// <summary>
        /// 自动锁屏的任务
        /// </summary>
        protected void LockScreenTask(/*object? sender, ElapsedEventArgs e*/)
        {
            if (!IsHide)
            {
                Task.Delay(5000).Wait();

                CancellationToken token = _cts.Token;
                if (token.IsCancellationRequested)
                {
                    Debug.WriteLine($"{nameof(LockScreenTask)}：锁屏任务已被取消");
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
        /// 当窗体关闭时释放任务
        /// </summary>
        protected void ReleaseTask()
        {
            if (_lockScreenTask == null || _cts == null || _lockScreenTask.Status == TaskStatus.Canceled)
            {
                Debug.WriteLine($"{nameof(ReleaseTask)}：任务为空或取消令牌为空或任务已被取消");
                return;
            }

            try
            {
                _cts.Cancel();
            }
            catch (ObjectDisposedException)
            {
                Debug.WriteLine($"{nameof(ReleaseTask)}：令牌已被释放");
            }
        }
    }
}