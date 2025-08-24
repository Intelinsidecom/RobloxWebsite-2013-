using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetsAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssetsAudit;

	internal long ID { get; set; }

	internal Guid AssetsAuditEntryPublicID { get; set; }

	internal long AssetID { get; set; }

	internal long? ActorUserID { get; set; }

	internal byte AssetChangeTypeID { get; set; }

	internal bool IsLegacyValue { get; set; }

	internal DateTime Created { get; set; }

	private static AssetsAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AssetsAuditMetadataDAL
		{
			ID = (long)record["ID"],
			AssetsAuditEntryPublicID = (Guid)record["AssetsAuditEntryPublicID"],
			AssetID = (long)record["AssetID"],
			ActorUserID = (long?)record["ActorUserID"],
			AssetChangeTypeID = (byte)record["AssetChangeTypeID"],
			IsLegacyValue = (bool)record["IsLegacyValue"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAssetsAudit.Delete("AssetsAuditMetadata_DeleteAssetsAuditMetadataByID", ID);
	}

	internal static AssetsAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAssetsAudit.Get("AssetsAuditMetadata_GetAssetsAuditMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AssetsAuditEntryPublicID", AssetsAuditEntryPublicID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@AssetChangeTypeID", AssetChangeTypeID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAssetsAudit.Insert<long>("AssetsAuditMetadata_InsertAssetsAuditMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AssetsAuditEntryPublicID", AssetsAuditEntryPublicID),
			new SqlParameter("@AssetID", AssetID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@AssetChangeTypeID", AssetChangeTypeID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAssetsAudit.Update("AssetsAuditMetadata_UpdateAssetsAuditMetadataByID", queryParameters);
	}

	internal static ICollection<AssetsAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAssetsAudit.MultiGet("AssetsAuditMetadata_GetAssetsAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAssetsAuditMetadataIDsByAssetIDAndAssetChangeTypeID(long assetId, byte assetChangeTypeId, int count, long? exclusiveStartId)
	{
		if (assetId == 0L)
		{
			throw new ArgumentException("Parameter 'assetId' cannot be null, empty or the default value.");
		}
		if (assetChangeTypeId == 0)
		{
			throw new ArgumentException("Parameter 'assetChangeTypeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@AssetID", assetId),
			new SqlParameter("@AssetChangeTypeID", assetChangeTypeId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAssetsAudit.GetIDCollection<long>("AssetsAuditMetadata_GetAssetsAuditMetadataIDsByAssetIDAndAssetChangeTypeID", queryParameters);
	}
}
