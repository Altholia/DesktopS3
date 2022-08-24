using System.Diagnostics;
using System.Net;
using System.Runtime.InteropServices;
using System.Text.Json;
using DesktopS3_Helper;
using DesktopS3_Models.Models;
using System.Web.Script.Serialization;
using DesktopS3_Models.DisplayDto;
using static DesktopS3_Helper.AutoLockScreen;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;
using Timer = System.Timers.Timer;

namespace DesktopS3_UI
{
    public partial class LoginForm : ParentForm
    {
        [DllImport("user32.dll", EntryPoint = "FindWindow", CharSet = CharSet.Unicode)]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);//查找窗体

        [DllImport("user32.dll")]
        private static extern int PostMessage(IntPtr hWnd, int msg, IntPtr wParam, IntPtr lParam);//发送信息

        public const int WM_CLOSE = 0X10;
        public const int WM_MOUSEMOVE = 0X200;

        private static readonly JavaScriptSerializer _js = new();
        public LoginForm()
        {
            InitializeComponent();
;        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Instance.FormObject = this;
        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Login_Button_Click(object sender, EventArgs e)
        {
            LoginModel login = new()
            {
                Telephone = Telephone_TextBox.Text.Trim(),
                Password = Password_TextBox.Text.Trim()
            };

            var body = JsonSerializer.Serialize(login);

            Task<HttpResponseMessage> httpPost = HttpUrl.HttpPost("/Staff", body);
            Task continueWith = httpPost.ContinueWith(r => //任务延续，当post请求完成时则执行以下语句，杀死提示框
            {
                IntPtr ptr = FindWindow(null!, "提示");
                if (ptr != IntPtr.Zero)
                {
                    Debug.WriteLine("关闭登录提示框");
                    int postMessage = PostMessage(ptr, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                }

            });
            MessageBox.Show(@"正在登录中……", @"提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            HttpResponseMessage response = await httpPost;
            if (response.StatusCode == HttpStatusCode.OK)
            {
                string staffString = await response.Content.ReadAsStringAsync();

                StaffDisplayDto staff = _js.Deserialize<StaffDisplayDto>(staffString);
                if (staff == null)
                    MessageBox.Show(@"查询数据为空", @"错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {

                }
            }

            MessageBox.Show(@"登录失败，请确认输入的账号和密码正确", @"警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            Password_TextBox.Clear();
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Cancel_Button_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 当鼠标停留一段时间后，应当执行某些操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_MouseHover(object sender, EventArgs e)
        {
            AutoLockScreen();
        }

        /// <summary>
        /// 当窗体隐藏时，应当释放某些东西
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_Deactivate(object sender, EventArgs e)
        {
            StopTask();
        }

        /// <summary>
        /// 当鼠标移动时，应当执行一些操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginForm_MouseMove(object sender, MouseEventArgs e)
        {
            StopTask();
        }
    }
}
