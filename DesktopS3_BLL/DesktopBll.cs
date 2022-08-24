using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Entities;
using System.Net;
using System.Web.Script.Serialization;
using DesktopS3_Helper;
using static DesktopS3_DAL.DesktopDal;
using static DesktopS3_Helper.HttpUrl;

namespace DesktopS3_BLL;

public class DesktopBll
{
    public static DesktopBll InstanceBll => Singleton<DesktopBll>.Instance;

    private readonly JavaScriptSerializer _js = new();

    /// <summary>
    /// 获取全部的 UpkeepType 信息
    /// </summary>
    /// <returns>返回 UpkeepType 集合</returns>
    public async Task<IEnumerable<UpkeepType>> GetUpkeepTypesAsync()
    {
        const string _uri = $"/UpkeepTypes";

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
        const string _uri = $"/Asset";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message.StatusCode != HttpStatusCode.OK)
            return null!;

        string assetString = await message.Content.ReadAsStringAsync();
        IEnumerable<Asset> dtoCollection = _js.Deserialize<IEnumerable<Asset>>(assetString);
        if (!dtoCollection.Any())
            return null!;

        return dtoCollection;
    }

    /// <summary>
    /// 查询所有的 AssetCategory 信息
    /// </summary>
    /// <returns>返回查询到的集合</returns>
    public async Task<IEnumerable<AssetCategory>> GetAssetCategoryCollectionAsync()
    {
        const string _uri = $"/AssetCategories";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message.StatusCode != HttpStatusCode.OK)
            return null!;

        string assetCategoryString = await message.Content.ReadAsStringAsync();
        IEnumerable<AssetCategory> dtoCollection = _js.Deserialize<IEnumerable<AssetCategory>>(assetCategoryString);
        if (!dtoCollection.Any())
            return null!;

        return dtoCollection;
    }
}