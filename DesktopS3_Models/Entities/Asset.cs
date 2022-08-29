using System.Reflection.Metadata.Ecma335;

namespace DesktopS3_Models.Entities;

public class Asset
{
    public int Id { get; set; }
    public string AssetNumber { get; set; }
    public string Name { get; set; }
    public string Specification { get; set; }
    public int UpkeepTypeId { get; set; }
    public decimal Price { get; set; }
    public int UpkeepCircle { get; set; }
    public DateTime ManufactureDate { get; set; }
    public DateTime ServiceDate { get; set; }
    public DateTime RegistrationTime { get; set; }
    public Department Department { get; set; }
    public IEnumerable<UpkeepRecord> UpkeepRecords { get; set; }
    public AssetCategory Category { get; set; }
}