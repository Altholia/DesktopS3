namespace DesktopS3_Models.Entities;

public class TransporationTask
{
    public string Name { get; set; }
    public int StartDistrictId { get; set; }
    public string StartStreetAddress { get; set; }
    public int DestinationDistrictId { get; set; }
    public string DestinationStreetAddress { get; set; }
    public int Weight { get; set; }
    public string RequiredCompletionDate { get; set; }
    public string ActualCompletionDate { get; set; }
    public int VehicleTeamAdministrator { get; set; }
    public string Remark { get; set; }
    public int StatusId { get; set; }
}