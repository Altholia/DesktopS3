namespace DesktopS3_Models.Entities;

public class AssetTransfer
{
    public int Id { get; set; }
    public int AssetId { get; set; }
    public int FromDepartmentId { get; set; }
    public int ToDepartmentId { get; set; }
    public DateTime TransferTime { get; set; }
}