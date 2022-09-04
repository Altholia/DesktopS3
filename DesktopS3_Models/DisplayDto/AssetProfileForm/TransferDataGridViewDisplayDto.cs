using System.Security.Cryptography;

namespace DesktopS3_Models.DisplayDto.AssetProfileForm;

public class TransferDataGridViewDisplayDto
{
    public string Start { get; set; }
    public string Destination { get; set; }
    public DateTime TransferTime { get; set; }

    public object this[int index]
    {
        get
        {
            return index switch
            {
                0 => Start,
                1 => Destination,
                2 => TransferTime,
                _ => throw new IndexOutOfRangeException(nameof(index))
            };
        }
    }
}