using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoSVSettingsAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxTwoStepVerificationSettingsAudit;

	internal long ID { get; set; }

	internal Guid TwoStepVerificationSettingsAuditEntriesPublicID { get; set; }

	internal long UserID { get; set; }

	internal long? ActorUserID { get; set; }

	internal byte TwoStepVerificationChangeTypeID { get; set; }

	internal bool IsLegacyValue { get; set; }

	internal DateTime Created { get; set; }

	private static TwoSVSettingsAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new TwoSVSettingsAuditMetadataDAL
		{
			ID = (long)record["ID"],
			TwoStepVerificationSettingsAuditEntriesPublicID = (Guid)record["TwoStepVerificationSettingsAuditEntriesPublicID"],
			UserID = (long)record["UserID"],
			ActorUserID = (long?)record["ActorUserID"],
			TwoStepVerificationChangeTypeID = (byte)record["TwoStepVerificationChangeTypeID"],
			IsLegacyValue = (bool)record["IsLegacyValue"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Delete("TwoSVSettingsAuditMetadata_DeleteTwoSVSettingsAuditMetadataByID", ID);
	}

	internal static TwoSVSettingsAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Get("TwoSVSettingsAuditMetadata_GetTwoSVSettingsAuditMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@TwoStepVerificationSettingsAuditEntriesPublicID", TwoStepVerificationSettingsAuditEntriesPublicID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@TwoStepVerificationChangeTypeID", TwoStepVerificationChangeTypeID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Insert<long>("TwoSVSettingsAuditMetadata_InsertTwoSVSettingsAuditMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@TwoStepVerificationSettingsAuditEntriesPublicID", TwoStepVerificationSettingsAuditEntriesPublicID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@TwoStepVerificationChangeTypeID", TwoStepVerificationChangeTypeID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Update("TwoSVSettingsAuditMetadata_UpdateTwoSVSettingsAuditMetadataByID", queryParameters);
	}

	internal static ICollection<TwoSVSettingsAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.MultiGet("TwoSVSettingsAuditMetadata_GetTwoSVSettingsAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetTwoSVSettingsAuditMetadataIDsByUserID(long userId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartTwoSVSettingsAuditMetadataId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartTwoSVSettingsAuditMetadataID.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartTwoSVSettingsAuditMetadataId;
		obj[2] = new SqlParameter("@ExclusiveStartTwoSVSettingsAuditMetadataID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.GetIDCollection<long>("TwoSVSettingsAuditMetadata_GetTwoSVSettingsAuditMetadataIDsByUserID", queryParameters);
	}

	internal static ICollection<long> GetTwoSVSettingsAuditMetadataIDsByUserIDAndTwoStepVerificationChangeTypeID(long userId, byte twoStepVerificationChangeTypeId, int count, long? exclusiveStartTwoSVSettingsAuditMetadataId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (twoStepVerificationChangeTypeId == 0)
		{
			throw new ArgumentException("Parameter 'twoStepVerificationChangeTypeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartTwoSVSettingsAuditMetadataId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartTwoSVSettingsAuditMetadataID.");
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@TwoStepVerificationChangeTypeID", twoStepVerificationChangeTypeId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartTwoSVSettingsAuditMetadataId;
		obj[3] = new SqlParameter("@ExclusiveStartTwoSVSettingsAuditMetadataID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.GetIDCollection<long>("TwoSVSettingsAuditMetadata_GetTwoSVSettingsAuditMetadataIDsByUserIDAndTwoStepVerificationChangeTypeID", queryParameters);
	}
}
