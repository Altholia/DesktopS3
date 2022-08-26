using System.Collections;
using System.Diagnostics;
using DesktopS3_Models.Entities;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Web.Script.Serialization;
using DesktopS3_Helper;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Parameter;
using static DesktopS3_Helper.HttpUrl;
using static DesktopS3_DAL.DesktopDal;
// ReSharper disable All

namespace DesktopS3_BLL;

public class AssetStatisticsFormBll
{
    public static AssetStatisticsFormBll InstanceBll => Singleton<AssetStatisticsFormBll>.Instance;

    private readonly JavaScriptSerializer _js = new();

    /// <summary>
    /// 为UpkeepType_ComboBox、Name_ComboBox和Category_ComboBox查找用来填充的信息
    /// </summary>
    /// <returns></returns>
    public static (Task<IEnumerable<UpkeepType>>, Task<IEnumerable<Asset>>, Task<IEnumerable<AssetCategory>>) 
        GetAssetStatisticsComboBoxInformation()
    {
        Task<IEnumerable<UpkeepType>> upkeepTypeCollection = InstanceDal.GetUpkeepTypesAsync();
        Task<IEnumerable<Asset>> assetCollection = InstanceDal.GetAssetCollectionAsync();
        Task<IEnumerable<AssetCategory>> assetCategoryCollection = InstanceDal.GetAssetCategoryCollectionAsync();

        return (upkeepTypeCollection, assetCollection, assetCategoryCollection);
    }

    /// <summary>
    /// 获取为Upkeep_DataGridView填充的信息
    /// </summary>
    public async Task<IEnumerable<UpkeepDataGridViewDisplayDto>> GetUpkeepDataGridViewInformation(string upkeepTypeName)
    {
        UpkeepType upkeepType = await InstanceDal.GetUpkeepTypeByNameAsync(upkeepTypeName);
        if (upkeepType == null)
            return null;

        switch (upkeepType.Id)
        {
            case 1:
                const string uri = "/Asset";
                GetUpkeepDataGridViewInformationParameter parameter = new()
                {
                    AssetId = null,
                    UpkeepTypeId = upkeepType.Id
                };

                string body = _js.Serialize(parameter);
                HttpResponseMessage message = await HttpPost(uri, body);
                if (message == null)
                    return null;

                if (message.StatusCode != HttpStatusCode.OK)
                    return null;

                string dtoString = await message.Content.ReadAsStringAsync();
                IEnumerable<Asset> assets =
                    _js.Deserialize<IEnumerable<Asset>>(dtoString);
                if (!assets.Any())
                    return null;

                List<UpkeepDataGridViewDisplayDto> dtoCollection = new();
                Parallel.ForEach(assets, asset =>
                {
                    double upkeepCircle = Math.Ceiling(asset.UpkeepCircle / 8D); //保养周期：以每天运行8h进行计算出需要隔多久进行下一次保养
                    DateTime lastUpkeepDate = asset.UpkeepRecords //最近一次保养时间
                        .OrderByDescending(r => r.UpkeepTime)
                        .Select(r => r.UpkeepTime)
                        .FirstOrDefault();

                    DateTime upkeepDateStart = lastUpkeepDate.AddDays(1); //保养开始时间：为上次保养时间的后一天
                    DateTime upkeepDateEnd = upkeepDateStart.AddDays(upkeepCircle); //保养到期时间

                    int day = (upkeepDateEnd - DateTime.Now.AddDays(-1)).Days;
                    if (day <= 3)
                    {
                        UpkeepDataGridViewDisplayDto dto = new()
                        {
                            AssetName = asset.Name,
                            AssetNumber = asset.AssetNumber,
                            Department = asset.Department.Name,
                            LastUpkeepDate = asset.UpkeepRecords
                                .OrderByDescending(r => r.UpkeepTime)
                                .Select(r => r.UpkeepTime)
                                .FirstOrDefault()
                                .ToString("yyyy/MM/dd"),
                            UpkeepCircle = $"{asset.UpkeepCircle}h",
                            TimeFromTheNext = day <= 0 ? "0d" : $"{day}d"
                        };
                        dtoCollection.Add(dto);
                    }
                });
                return dtoCollection;
            case 2:
                return null;
            default:
                return null;
        }
    }
}