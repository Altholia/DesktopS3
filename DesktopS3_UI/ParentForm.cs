using System.Diagnostics;
using static DesktopS3_Helper.AutoLockScreen;

namespace DesktopS3_UI
{
    public partial class ParentForm : Form
    {
        private readonly CancellationTokenSource _source = new();
        private Task? _task;

        public ParentForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 调用自动锁屏方法
        /// </summary>
        protected async void AutoLockScreen()
        {
            try
            {
                _task?.Dispose(); //开始前也需要先释放一遍

                var token = _source.Token;

                _task = new(LockScreenTask, token);
                _task.Start(); //任务启动
                Debug.WriteLine($"锁屏任务已启动，任务ID为：{_task.Id}，启动时间为：{DateTime.Now}");

                await Task.WhenAny(_task); //等待任务完成
                if (_task.Status == TaskStatus.RanToCompletion) //如果任务完成，则释放线程
                {
                    _task.Dispose();
                    Debug.WriteLine($"锁屏任务已释放，任务ID为：{_task.Id}，释放时间为：{DateTime.Now}");
                }
            }
            catch (InvalidOperationException e)
            {
                await Console.Error.WriteLineAsync(e.ToString());
            }
        }

        /// <summary>
        /// 自动锁屏的任务
        /// </summary>
        protected async void LockScreenTask()
        {
            await Task.Delay(6000);//等待十秒以后执行以下语句
            if (!IsHide)
            {
                Instance.FormObject?.BeginInvoke(() =>
                {
                    Instance.FormObject.Hide();

                    var lockScreenForm = new LockScreenForm(Instance.FormObject);
                    LockScreenForm.Instance?.Show();
                });

                IsHide = true;
                _source.Cancel();
            }
        }

        /// <summary>
        /// 当窗体关闭时释放任务
        /// </summary>
        protected async void ReleaseTask()
        {
            _task?.Dispose();
            try
            {
                Debug.WriteLine($"锁屏任务已释放，任务ID为：{_task.Id}，释放时间为：{DateTime.Now}");
            }
            catch (ArgumentNullException e)
            {
                await Console.Error.WriteLineAsync($"锁屏任务为空，无法释放。错误信息：{e.Message}");
            }
        }
    }
}