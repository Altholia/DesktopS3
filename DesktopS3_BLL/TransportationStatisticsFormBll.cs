using System.Diagnostics;
using DesktopS3_Models.DisplayDto.TransportationStatisticsForm;
using DesktopS3_Models.Entities;
using DesktopS3_Models.Parameter;
using static DesktopS3_DAL.DesktopDal;

namespace DesktopS3_BLL;

public class TransportationStatisticsFormBll
{
    public async Task<IEnumerable<LinesDataGridView>> GetLinesDataGridViewTask(string startDate,string endDate)
    {
        GetTransporationTaskCollectionParameter parameter = new()
        {
            StartDate = startDate,
            EndDate = endDate
        };

        IEnumerable<TransporationTask> dtoCollection = await InstanceDal.GetTransporationTaskCollectionAsync(parameter);
        if (dtoCollection == null || !dtoCollection.Any())
            return null;

        List<LinesDataGridView> dtoList = new();
        try
        {
            Parallel.ForEach(dtoCollection, dto =>
            {
                LinesDataGridView line = new()
                {
                    DestinationCity = InstanceDal.GetCityByIdAsync(dto.DestinationDistrictId).Result.Name,
                    StartCity = InstanceDal.GetCityByIdAsync(dto.StartDistrictId).Result.Name,
                    TaskAmount = dtoCollection
                        .Count(r => r.DestinationDistrictId == dto.DestinationDistrictId &&
                                    r.StartDistrictId == dto.StartDistrictId),
                };
            });
        }
        catch (ArgumentNullException exception)
        {
            Debug.WriteLine($"TransporationTask为空：{exception.Message}");
            return null;
        }

        return null;
    }
}