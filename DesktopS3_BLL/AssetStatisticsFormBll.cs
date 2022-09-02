using System.ComponentModel;
using System.Diagnostics;
using DesktopS3_Models.Entities;
using System.Net;
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
    public static async Task<IEnumerable<UpkeepDataGridViewDisplayDto>> GetUpkeepDataGridViewInformation(string upkeepTypeName)
    {
        UpkeepType upkeepType = await InstanceDal.GetUpkeepTypeByNameAsync(upkeepTypeName);
        if (upkeepType == null)
            return null;

        switch (upkeepType.Id)
        {
            case 1://By Running
                IEnumerable<Asset> assetCollection = await InstanceDal.GetAssetCollectionAsync(null, upkeepType.Id);
                if (!assetCollection.Any())
                    return null;

                List<UpkeepDataGridViewDisplayDto> dtoCollection = new();
                Parallel.ForEach(assetCollection, asset =>
                {
                    double upkeepCircle = Math.Ceiling(asset.UpkeepCircle / 8D); //保养周期：以每天运行8h进行计算出需要隔多久进行下一次保养
                    DateTime lastUpkeepDate = asset.UpkeepRecords //最近一次保养时间
                        .OrderByDescending(r => r.UpkeepTime)
                        .Select(r => r.UpkeepTime)
                        .FirstOrDefault();

                    DateTime upkeepDateStart = lastUpkeepDate.AddDays(1); //保养开始时间：为上次保养时间的后一天
                    DateTime upkeepDateEnd = upkeepDateStart.AddDays(upkeepCircle); //下次保养时间

                    DateTime currentDateTime = new(2022,7,31);//假定这是现在的日期
                    int day = (upkeepDateEnd - currentDateTime.AddDays(-1)).Days;

                    UpkeepDataGridViewDisplayDto dto = new()
                    {
                        AssetName = asset.Name,
                        AssetNumber = asset.AssetNumber,
                        Department = asset.Department.Name,
                        LastUpkeepDate = lastUpkeepDate.ToString("yyyy/MM/dd"),
                        UpkeepCircle = $"{asset.UpkeepCircle}h",
                        TimeFromTheNext = day <= 0 ? 0 : day
                    };
                    lock (dtoCollection)
                    {
                        dtoCollection.Add(dto);
                    }

                });
                return dtoCollection;

            case 2://By Mileage
                IEnumerable<Asset> assetCollection2 = await InstanceDal.GetAssetCollectionAsync(null, upkeepType.Id);
                if (!assetCollection2.Any())
                    return null;

                List<UpkeepDataGridViewDisplayDto> dtoCollection2 = new();
                Parallel.ForEach(assetCollection2, asset =>
                {
                    DateTime lastUpkeepDate = asset.UpkeepRecords //最近一次保养时间
                        .OrderByDescending(r => r.UpkeepTime)
                        .Select(r => r.UpkeepTime)
                        .FirstOrDefault();

                    DateTime upkeepDateStart = lastUpkeepDate.AddDays(1); //下次开始保养时间
                    DateTime upkeepDateEnd = new DateTime(2022, 7, 31).AddDays(-1); //当前时间的前一天

                    int day = (upkeepDateEnd - upkeepDateStart).Days; //间隔时间
                    int km = day * 300; //这几天一共行驶了多少公里

                    UpkeepDataGridViewDisplayDto dto = new()
                    {
                        AssetName = asset.Name,
                        AssetNumber = asset.AssetNumber,
                        Department = asset.Department.Name,
                        LastUpkeepDate = lastUpkeepDate.ToString("yyyy/MM/dd"),
                        UpkeepCircle = $"{asset.UpkeepCircle}km",
                        TimeFromTheNext = (asset.UpkeepCircle - km) <= 0 ? 0 : (asset.UpkeepCircle - km)
                    };
                    lock (dtoCollection2)
                    {
                        dtoCollection2.Add(dto);
                    }
                });
                return dtoCollection2;
            default:
                return null;
        }
    }

    /// <summary>
    /// 获取用来填充 Asset_DataGridView 的数据
    /// </summary>
    /// <param name="assetName">资产名称</param>
    /// <param name="categoryName">类别名称</param>
    /// <returns>返回信息</returns>
    public static async Task<IEnumerable<AssetDataGridViewDisplayDto>> GetAssetDataGridViewInformationAsync(string assetName,string categoryName)
    {
        var assetCategory = await InstanceDal.GetAssetCategoryAsync(categoryName);
        int? assetCategoryId = assetCategory?.Id;

        IEnumerable<Asset> assets =
            await InstanceDal.GetAssetCollectionAsync(assetName: assetName, assetCategoryId: assetCategoryId);
        if (assets==null)
            return null;

        List<AssetDataGridViewDisplayDto> dtoCollection = new();
        Parallel.ForEach(assets, asset =>
        {
            AssetDataGridViewDisplayDto dto = new()
            {
                AssetCategory = asset.Category.Name,
                AssetName = asset.Name,
                AssetNumber = asset.AssetNumber,
                Department = asset.Department.Name,
                ManufactureDate = asset.ManufactureDate.ToString("yyyy/MM/dd"),
                RegistrationTime = asset.RegistrationTime.ToString("yyyy/MM/dd hh:mm:ss"),
                ServiceDate = asset.ServiceDate.ToString("yyyy/MM/dd")
            };
            lock (dtoCollection)
            {
                dtoCollection.Add(dto);
            }
        });

        return dtoCollection;
    }

    /// <summary>
    /// 根据AssetName查询对应的Asset信息
    /// </summary>
    /// <param name="assetName">资产姓名</param>
    /// <returns>返回查询到的资产信息</returns>
    public static async Task<IEnumerable<Asset>> GetAssetIdByAssetNameAsync(string assetName) =>
        await InstanceDal.GetAssetCollectionAsync(assetName: assetName);
}