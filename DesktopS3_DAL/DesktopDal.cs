using System.Diagnostics;
using System.Net;
using System.Web.Script.Serialization;
using System.Xml;
using DesktopS3_Helper;
using DesktopS3_Models.DisplayDto;
using DesktopS3_Models.Entities;
using DesktopS3_Models.Parameter;
using static DesktopS3_Helper.HttpUrl;
// ReSharper disable All

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
        const string _uri = $"/UpkeepTypes";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message == null||message.StatusCode == HttpStatusCode.NotFound)
            return null;

        string upkeepType = await message.Content.ReadAsStringAsync();
        IEnumerable<UpkeepType> dtoCollection = _js.Deserialize<IEnumerable<UpkeepType>>(upkeepType);
        if (!dtoCollection.Any())
            return null;

        return dtoCollection;
    }

    /// <summary>
    /// 通过Name属性查找对应的 UpkeepType 实体信息
    /// </summary>
    /// <param name="name">UpkeepType 的Name 字段</param>
    /// <returns>如果有，则返回查找到的实体。否则返回null</returns>
    public async Task<UpkeepType> GetUpkeepTypeByNameAsync(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            Debug.WriteLine($"{nameof(GetUpkeepTypeByNameAsync)}：查询条件{nameof(name)}为空");
            return null;
        }

        string[] names = name.Split(' ');
        string uri = $"/UpkeepType/Name/?Name={names[0]}+{names[1]}";
        HttpResponseMessage message = await HttpGet(uri);
        if (message == null!)
            return null;

        if (message.StatusCode != HttpStatusCode.OK)
            return null;

        string upkeepTypeString = await message.Content.ReadAsStringAsync();
        UpkeepType dto = _js.Deserialize<UpkeepType>(upkeepTypeString);

        return dto;
    }


    /// <summary>
    /// 查询出所有的 Asset 信息，包括它的子资源Department、upkeepRecord
    /// </summary>
    /// <returns>返回查询到的 Asset 集合</returns>
    public async Task<IEnumerable<Asset>> GetAssetCollectionAsync(int? assetId = null, int? upkeepTypeId = null,
        string assetName=null!,int? assetCategoryId=null)
    {
        const string _uri = $"/Assets";

        GetAssetCollectionParameter parameter = new()
        {
            AssetId = assetId,
            UpkeepTypeId = upkeepTypeId,
            AssetName=assetName,
            CategoryId = assetCategoryId
        };
        var body = _js.Serialize(parameter);

        HttpResponseMessage message = await HttpPost(_uri, body);
        if (message == null!||message.StatusCode != HttpStatusCode.OK)
            return null;

        string assetString = await message.Content.ReadAsStringAsync();
        IEnumerable<Asset> dtoCollection = _js.Deserialize<IEnumerable<Asset>>(assetString);
        if (!dtoCollection.Any())
            return null;

        return dtoCollection;
    }

    /// <summary>
    /// 根据Name字段查询Asset
    /// </summary>
    /// <param name="assetName">Asset的Name字段</param>
    /// <returns>返回Asset</returns>
    public async Task<Asset> GetAssetByNameAsync(string assetName)
    {
        string[] names = assetName.Split(' ');
        string uri = $"/Asset?assetName={names[0]}";
        for (int i = 1; i < names.Length; i++)
        {
            uri += $"+{names[i]}";
        }

        HttpResponseMessage message = await HttpGet(uri);
        if (message == null || message.StatusCode != HttpStatusCode.OK)
            return null;

        string assetString = await message.Content.ReadAsStringAsync();
        Asset asset = _js.Deserialize<Asset>(assetString);
        if (asset == null)
            return null;

        return asset;
    }

    /// <summary>
    /// 查询所有的 AssetCategory 信息
    /// </summary>
    /// <returns>返回查询到的集合</returns>
    public async Task<IEnumerable<AssetCategory>> GetAssetCategoryCollectionAsync()
    {
        const string _uri = $"/AssetCategories";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message == null! || message.StatusCode != HttpStatusCode.OK)
            return null;

        string assetCategoryString = await message.Content.ReadAsStringAsync();
        IEnumerable<AssetCategory> dtoCollection = _js.Deserialize<IEnumerable<AssetCategory>>(assetCategoryString);
        if (!dtoCollection.Any())
            return null;

        return dtoCollection;
    }

    /// <summary>
    /// 根据Name字段查询对应的AssetCategory信息
    /// </summary>
    /// <param name="name">查询条件</param>
    /// <returns>返回查询到的AssetCategory信息</returns>
    public async Task<AssetCategory> GetAssetCategoryAsync(string name)
    {
        string _uri = $"/AssetCategory/{name}";

        HttpResponseMessage message = await HttpGet(_uri);
        if (message.StatusCode != HttpStatusCode.OK || message == null!)
            return null;

        string assetCategoryString = await message.Content.ReadAsStringAsync();
        if (assetCategoryString == null)
            return null;

        AssetCategory dto = _js.Deserialize<AssetCategory>(assetCategoryString);
        if (dto == null)
            return null;

        return dto;
    }

    /// <summary>
    /// 根据Department的Id字段查询对应的Department
    /// </summary>
    /// <param name="id">Department的Id字段</param>
    /// <returns>返回查询到的Department信息</returns>
    public async Task<Department> GetDepartmentByIdAsync(int id)
    {
        string uri = $"/Department/{id}";

        HttpResponseMessage message = await HttpGet(uri);
        if (message == null || message.StatusCode != HttpStatusCode.OK)
            return null;

        string departmentString = await message.Content.ReadAsStringAsync();
        if (departmentString == null)
            return null;

        Department dto = _js.Deserialize<Department>(departmentString);
        if (dto == null)
            return null;

        return dto;
    }

    /// <summary>
    /// 根据assetId查询AssetTransfer
    /// </summary>
    /// <param name="assetId">资产ID</param>
    /// <returns>返回AssetTransfer集合</returns>
    public async Task<IEnumerable<AssetTransfer>> GetAssetTransferByAssetIdAsync(int assetId)
    {
        string uri = $"/AssetTransfers?assetId={assetId}";

        HttpResponseMessage message = await HttpGet(uri);
        if (message == null || message.StatusCode != HttpStatusCode.OK)
            return null;

        string assetTransferString = await message.Content.ReadAsStringAsync();
        if (string.IsNullOrEmpty(assetTransferString))
            return null;

        IEnumerable<AssetTransfer> assetTransfer = _js.Deserialize<IEnumerable<AssetTransfer>>(assetTransferString);
        if (assetTransfer == null)
            return null;

        return assetTransfer;
    }

    public async Task<IEnumerable<UpkeepRecord>> GetUpkeepRecordByAssetIdAsync(int assetId)
    {
        string uri = $"/UpkeepRecords?assetId={assetId}";

        HttpResponseMessage message = await HttpGet(uri);
        if (message == null || message.StatusCode != HttpStatusCode.OK)
            return null;

        string upkeepRecordString = await message.Content.ReadAsStringAsync();
        IEnumerable<UpkeepRecord> dtoCollection = _js.Deserialize<IEnumerable<UpkeepRecord>>(upkeepRecordString);
        if (dtoCollection == null)
            return null;
        return dtoCollection;
    }
}