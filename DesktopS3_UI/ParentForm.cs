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
        /// �����Զ���������
        /// </summary>
        protected async void AutoLockScreen()
        {
            try
            {
                _task?.Dispose(); //��ʼǰҲ��Ҫ���ͷ�һ��

                var token = _source.Token;

                _task = new(LockScreenTask, token);
                _task.Start(); //��������
                Debug.WriteLine($"��������������������IDΪ��{_task.Id}������ʱ��Ϊ��{DateTime.Now}");

                await Task.WhenAny(_task); //�ȴ��������
                if (_task.Status == TaskStatus.RanToCompletion) //���������ɣ����ͷ��߳�
                {
                    _task.Dispose();
                    Debug.WriteLine($"�����������ͷţ�����IDΪ��{_task.Id}���ͷ�ʱ��Ϊ��{DateTime.Now}");
                }
            }
            catch (InvalidOperationException e)
            {
                await Console.Error.WriteLineAsync(e.ToString());
            }
        }

        /// <summary>
        /// �Զ�����������
        /// </summary>
        protected async void LockScreenTask()
        {
            await Task.Delay(6000);//�ȴ�ʮ���Ժ�ִ���������
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
        /// ������ر�ʱ�ͷ�����
        /// </summary>
        protected async void ReleaseTask()
        {
            _task?.Dispose();
            try
            {
                Debug.WriteLine($"�����������ͷţ�����IDΪ��{_task.Id}���ͷ�ʱ��Ϊ��{DateTime.Now}");
            }
            catch (ArgumentNullException e)
            {
                await Console.Error.WriteLineAsync($"��������Ϊ�գ��޷��ͷš�������Ϣ��{e.Message}");
            }
        }
    }
}