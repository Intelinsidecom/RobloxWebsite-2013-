using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Entities;

internal class AssetVersionMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssets;

	internal long ID { get; set; }

	internal long AssetVersionID { get; set; }

	internal string Hash { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AssetVersionMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AssetVersionMetadataDAL
		{
			ID = (long)record["ID"],
			AssetVersionID = (long)record["AssetVersionID"],
			Hash = (string)record["Hash"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAssets.Delete("AssetVersionMetadata_DeleteAssetVersionMetadataByID", ID);
	}

	internal static AssetVersionMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAssets.Get("AssetVersionMetadata_GetAssetVersionMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetVersionID", AssetVersionID),
			new SqlParameter("@Hash", Hash),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAssets.Insert<long>("AssetVersionMetadata_InsertAssetVersionMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetVersionID", AssetVersionID),
			new SqlParameter("@Hash", Hash),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAssets.Update("AssetVersionMetadata_UpdateAssetVersionMetadataByID", queryParameters);
	}

	internal static ICollection<AssetVersionMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAssets.MultiGet("AssetVersionMetadata_GetAssetVersionMetadataByIDs", ids, BuildDAL);
	}

	internal static AssetVersionMetadataDAL GetAssetVersionMetadataByAssetVersionID(long assetVersionID)
	{
		if (assetVersionID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AssetVersionID", assetVersionID)
		};
		return RobloxDatabase.RobloxAssets.Lookup("AssetVersionMetadata_GetAssetVersionMetadataByAssetVersionID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AssetVersionMetadataDAL> GetOrCreateAssetVersionMetadata(long assetVersionID)
	{
		if (assetVersionID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetVersionID", assetVersionID)
		};
		return RobloxDatabase.RobloxAssets.GetOrCreate("AssetVersionMetadata_GetOrCreateAssetVersionMetadata", BuildDAL, queryParameters);
	}
}
