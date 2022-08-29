namespace DesktopS3_Models.Parameter;

public class GetAssetCollectionParameter
{
    public int? AssetId { get; set; }
    public int? UpkeepTypeId { get; set; }
    public string AssetName { get; set; }
    public int? CategoryId { get; set; }
}