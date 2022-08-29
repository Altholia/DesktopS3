using System.Reflection.Metadata.Ecma335;

namespace DesktopS3_Models.DisplayDto;

public class UpkeepDataGridViewDisplayDto
{
    public string AssetNumber { get; set; }
    public string AssetName { get; set; }
    public string Department { get; set; }
    public string LastUpkeepDate { get; set; }
    public string UpkeepCircle { get; set; }
    public int TimeFromTheNext { get; set; }
    public int Length { get; set; } = 6;

    public object this[int index]
    {
        get
        {
            return index switch
            {
                0 => AssetNumber,
                1 => AssetName,
                2 => Department,
                3 => LastUpkeepDate,
                4 => UpkeepCircle,
                5 => TimeFromTheNext,
                _ => throw new IndexOutOfRangeException(nameof(index))
            };
        }
    }
}