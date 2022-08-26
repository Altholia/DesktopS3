using System.Reflection.Metadata.Ecma335;

namespace DesktopS3_Models.DisplayDto;

public class UpkeepDataGridViewDisplayDto
{
    public string AssetNumber { get; set; }
    public string AssetName { get; set; }
    public string Department { get; set; }
    public string LastUpkeepDate { get; set; }
    public string UpkeepCircle { get; set; }
    public string TimeFromTheNext { get; set; }
}