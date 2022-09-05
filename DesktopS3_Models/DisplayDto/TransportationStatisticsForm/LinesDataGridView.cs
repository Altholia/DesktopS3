using System.Reflection.Metadata.Ecma335;

namespace DesktopS3_Models.DisplayDto.TransportationStatisticsForm;

public class LinesDataGridView
{
    public string StartCity { get; set; }
    public string DestinationCity { get; set; }
    public int TaskAmount { get; set; }
    public int TotalTaskAmount { get; set; }
}