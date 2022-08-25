using System.Windows.Forms;

namespace DesktopS3_Helper;

public class AutoLockScreen
{
    public static AutoLockScreen Instance => Singleton<AutoLockScreen>.Instance;
    public static bool IsHide { get; set; } = false;
    public Form? FormObject { get; set; }
    public int Hover { get; set; } = 3000;//解决鼠标停留问题
}