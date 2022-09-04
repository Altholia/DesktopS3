using System.Runtime.CompilerServices;

namespace DesktopS3_Models.DisplayDto.AssetProfileForm;

public class UpkeepDataGridViewDisplayDto
{
    public string UpkeepRemark { get; set; }
    public DateTime UpkeepDate { get; set; }

    public object this[int index]
    {
        get
        {
            return index switch
            {
                0 => UpkeepRemark,
                1 => UpkeepDate,
                _ => throw new IndexOutOfRangeException(nameof(index))
            };
        }
    }
}