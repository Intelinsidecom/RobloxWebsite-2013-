using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.XboxLive.Entities;

internal class XboxExclusiveCatalogAssetDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxXbox;

	internal int ID { get; set; }

	internal long AssetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static XboxExclusiveCatalogAssetDAL BuildDAL(IDictionary<string, object> record)
	{
		return new XboxExclusiveCatalogAssetDAL
		{
			ID = (int)record["ID"],
			AssetID = (long)record["AssetID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxXbox.Delete("XboxExclusiveCatalogAssets_DeleteXboxExclusiveCatalogAssetByID", ID);
	}

	internal static XboxExclusiveCatalogAssetDAL Get(int id)
	{
		return RobloxDatabase.RobloxXbox.Get("XboxExclusiveCatalogAssets_GetXboxExclusiveCatalogAssetByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxXbox.Insert<int>("XboxExclusiveCatalogAssets_InsertXboxExclusiveCatalogAsset", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxXbox.Update("XboxExclusiveCatalogAssets_UpdateXboxExclusiveCatalogAssetByID", queryParameters);
	}

	internal static ICollection<XboxExclusiveCatalogAssetDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxXbox.MultiGet("XboxExclusiveCatalogAssets_GetXboxExclusiveCatalogAssetsByIDs", ids, BuildDAL);
	}

	internal static XboxExclusiveCatalogAssetDAL GetXboxExclusiveCatalogAssetByAssetID(long assetID)
	{
		if (assetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetID", assetID)
		};
		return RobloxDatabase.RobloxXbox.Lookup("XboxExclusiveCatalogAssets_GetXboxExclusiveCatalogAssetByAssetID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetXboxExclusiveCatalogAssetIDs(int count, int exclusiveStartId)
	{
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartXboxExclusiveCatalogAssetID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartID", exclusiveStartId)
		};
		return RobloxDatabase.RobloxXbox.GetIDCollection<int>("XboxExclusiveCatalogAssets_GetXboxExclusiveCatalogAssetIDs", queryParameters);
	}
}
