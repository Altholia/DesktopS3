using System.Windows.Forms;

namespace DesktopS3_Helper;

public class AutoLockScreen
{
    public static AutoLockScreen Instance => Singleton<AutoLockScreen>.Instance;
    public static bool IsHide { get; set; } = false;
    public Form? FormObject { get; set; }
}