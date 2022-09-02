namespace DesktopS3_Models.DisplayDto;

public class AssetDataGridViewDisplayDto
{
    public string AssetNumber { get; set; }
    public string AssetName { get; set; }
    public string AssetCategory { get; set; }
    public string Department { get; set; }
    public string ManufactureDate { get; set; }
    public string ServiceDate { get; set; }
    public string RegistrationTime { get; set; }
    public string AssetProfile { get; set; } = "View";

    public object this[int index]
    {
        get
        {
            return index switch
            {
                0 => AssetNumber,
                1 => AssetName,
                2 => AssetCategory,
                3 => Department,
                4 => ManufactureDate,
                5 => ServiceDate,
                6 => RegistrationTime,
                7 => AssetProfile,
                _ => throw new IndexOutOfRangeException(nameof(index))
            };
        }
        set
        {
            switch (index)
            {
                case 0:
                    AssetNumber = (string)value;
                    break;
                case 1:
                    AssetName = (string)value;
                    break;
                case 2:
                    AssetCategory = (string)value;
                    break;
                case 3:
                    Department = (string)value;
                    break;
                case 4:
                    ManufactureDate = (string)value;
                    break;
                case 5:
                    ServiceDate = (string)value;
                    break;
                case 6:
                    RegistrationTime= (string)value;
                    break;
                default:
                    throw new IndexOutOfRangeException(nameof(index));
            }
        }
    }
}