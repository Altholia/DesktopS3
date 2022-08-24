using System.Net;
using System.Web.Script.Serialization;
using DesktopS3_Helper;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Entities;
using static DesktopS3_Helper.HttpUrl;

namespace DesktopS3_DAL;

public class DesktopDal
{
    public static DesktopDal InstanceDal => Singleton<DesktopDal>.Instance;

    private readonly JavaScriptSerializer _js = new();

    /// <summary>
    /// 获取全部的 UpkeepType 信息
    /// </summary>
    /// <returns>返回 UpkeepType 集合</returns>
    public async Task<IEnumerable<UpkeepType>> GetUpkeepTypesAsync()
    {
        const string _uri = $"UpkeepTypes";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message.StatusCode == HttpStatusCode.NotFound)
            return null!;

        string upkeepType = await message.Content.ReadAsStringAsync();
        IEnumerable<UpkeepType> dtoCollection = _js.Deserialize<IEnumerable<UpkeepType>>(upkeepType);
        if (!dtoCollection.Any())
            return null!;

        return dtoCollection;
    }

    /// <summary>
    /// 查询出所有的 Asset 信息，包括它的子资源Department
    /// </summary>
    /// <returns>返回查询到的 Asset 集合</returns>
    public async Task<IEnumerable<Asset>> GetAssetCollectionAsync()
    {
        const string _uri = $"Asset";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message.StatusCode == HttpStatusCode.NotFound)
            return null!;

        string assetString = await message.Content.ReadAsStringAsync();
        IEnumerable<Asset> dtoCollection = _js.Deserialize<IEnumerable<Asset>>(assetString);
        if (!dtoCollection.Any())
            return null!;

        return dtoCollection;
    }
}