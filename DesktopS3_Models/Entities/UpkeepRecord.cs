namespace DesktopS3_Models.Entities;

public class UpkeepRecord
{
    public int Id { get; set; }
    public int AssetId { get; set; }
    public string Remark { get; set; }
    public DateTime UpkeepTime { get; set; }
}