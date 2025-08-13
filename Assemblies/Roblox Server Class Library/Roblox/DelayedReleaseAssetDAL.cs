using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class DelayedReleaseAssetDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssets;

	public long ID { get; set; }

	public long AssetID { get; set; }

	public int AssetTypeID { get; set; }

	public DateTime ReleaseDate { get; set; }

	public int PriceInRobux { get; set; }

	public int PriceInTickets { get; set; }

	public bool IsLimited { get; set; }

	public long TotalAvailable { get; set; }

	public DateTime? LeaseExpiration { get; set; }

	public Guid? WorkerID { get; set; }

	public DateTime? Completed { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public byte MinMembershipType { get; set; }

	public bool IsForSale { get; set; }

	public bool IsPublicDomain { get; set; }

	public DateTime? OffSaleDeadline { get; set; }

	private static DelayedReleaseAssetDAL BuildDAL(IDictionary<string, object> record)
	{
		return new DelayedReleaseAssetDAL
		{
			ID = (long)record["ID"],
			AssetID = (long)record["AssetID"],
			AssetTypeID = (int)record["AssetTypeID"],
			ReleaseDate = (DateTime)record["ReleaseDate"],
			PriceInRobux = (int)record["PriceInRobux"],
			PriceInTickets = (int)record["PriceInTickets"],
			IsLimited = (bool)record["IsLimited"],
			TotalAvailable = (long)record["TotalAvailable"],
			LeaseExpiration = (DateTime?)record["LeaseExpiration"],
			WorkerID = (Guid?)record["WorkerID"],
			Completed = (DateTime?)record["Completed"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			MinMembershipType = (byte)record["MinMembershipType"],
			IsForSale = (bool)record["IsForSale"],
			IsPublicDomain = (bool)record["IsPublicDomain"],
			OffSaleDeadline = (DateTime?)record["OffSaleDeadline"]
		};
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[17]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@AssetTypeID", AssetTypeID),
			new SqlParameter("@ReleaseDate", ReleaseDate),
			new SqlParameter("@PriceInRobux", PriceInRobux),
			new SqlParameter("@PriceInTickets", PriceInTickets),
			new SqlParameter("@IsLimited", IsLimited),
			new SqlParameter("@TotalAvailable", TotalAvailable),
			new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration) : DBNull.Value),
			new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value),
			new SqlParameter("@Completed", Completed.HasValue ? ((object)Completed) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@MinMembershipType", MinMembershipType),
			new SqlParameter("@IsForSale", IsForSale),
			new SqlParameter("@IsPublicDomain", IsPublicDomain),
			new SqlParameter("@OffSaleDeadline", OffSaleDeadline.HasValue ? ((object)OffSaleDeadline) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxAssets.Insert<long>("DelayedReleaseAssets_InsertDelayedReleaseAsset", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[17]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@AssetTypeID", AssetTypeID),
			new SqlParameter("@ReleaseDate", ReleaseDate),
			new SqlParameter("@PriceInRobux", PriceInRobux),
			new SqlParameter("@PriceInTickets", PriceInTickets),
			new SqlParameter("@IsLimited", IsLimited),
			new SqlParameter("@TotalAvailable", TotalAvailable),
			new SqlParameter("@LeaseExpiration", LeaseExpiration.HasValue ? ((object)LeaseExpiration) : DBNull.Value),
			new SqlParameter("@WorkerID", WorkerID.HasValue ? ((object)WorkerID) : DBNull.Value),
			new SqlParameter("@Completed", Completed.HasValue ? ((object)Completed) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@MinMembershipType", MinMembershipType),
			new SqlParameter("@IsForSale", IsForSale),
			new SqlParameter("@IsPublicDomain", IsPublicDomain),
			new SqlParameter("@OffSaleDeadline", OffSaleDeadline.HasValue ? ((object)OffSaleDeadline) : DBNull.Value)
		};
		RobloxDatabase.RobloxAssets.Update("DelayedReleaseAssets_UpdateDelayedReleaseAssetByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxAssets.Delete("DelayedReleaseAssets_DeleteDelayedReleaseAssetByID", ID);
	}

	public static DelayedReleaseAssetDAL Get(long id)
	{
		return RobloxDatabase.RobloxAssets.Get("DelayedReleaseAssets_GetDelayedReleaseAssetByID", id, BuildDAL);
	}

	internal static ICollection<DelayedReleaseAssetDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAssets.MultiGet("DelayedReleaseAssets_GetDelayedReleaseAssetsByIDs", ids, BuildDAL);
	}

	public static ICollection<long> GetDelayedReleaseAssetIDsPaged(int? assetTypeId, int startRowIndex, int maximumRows)
	{
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@AssetTypeID", assetTypeId.HasValue ? ((object)assetTypeId.Value) : DBNull.Value),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAssets.GetIDCollection<long>("[dbo].[DelayedReleaseAssets_GetDelayedReleaseAssetIDs_Paged]", queryParameters);
	}

	public static int GetTotalNumberOfDelayedReleaseAssets(int? assetTypeId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetTypeID", assetTypeId.HasValue ? ((object)assetTypeId.Value) : DBNull.Value)
		};
		return RobloxDatabase.RobloxAssets.GetCount<int>("[dbo].[DelayedReleaseAssets_GetTotalNumberOfDelayedReleaseAssets]", queryParameters);
	}

	public static ICollection<long> LeaseDelayedReleaseAssetToRelease(Guid workerId, int numberOfItems, int leaseDurationInMinutes)
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@WorkerID", workerId),
			new SqlParameter("@NumberOfItems", numberOfItems),
			new SqlParameter("@LeaseDurationInMinutes", leaseDurationInMinutes)
		};
		return RobloxDatabase.RobloxAssets.GetIDCollection<long>("[dbo].[DelayedReleaseAssets_LeaseDelayedReleaseAssetToRelease]", queryParameters);
	}
}
