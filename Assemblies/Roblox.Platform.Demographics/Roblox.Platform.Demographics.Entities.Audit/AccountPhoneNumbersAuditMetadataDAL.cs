using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountPhoneNumbersAudit;

	internal long ID { get; set; }

	internal Guid AccountPhoneNumbersAuditEntriesPublicID { get; set; }

	internal long UserID { get; set; }

	internal long? ActorUserID { get; set; }

	internal byte AccountPhoneNumbersChangeTypeID { get; set; }

	internal bool IsLegacyValue { get; set; }

	internal DateTime Created { get; set; }

	private static AccountPhoneNumbersAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountPhoneNumbersAuditMetadataDAL
		{
			ID = (long)record["ID"],
			AccountPhoneNumbersAuditEntriesPublicID = (Guid)record["AccountPhoneNumbersAuditEntriesPublicID"],
			UserID = (long)record["UserID"],
			ActorUserID = (long?)record["ActorUserID"],
			AccountPhoneNumbersChangeTypeID = (byte)record["AccountPhoneNumbersChangeTypeID"],
			IsLegacyValue = (bool)record["IsLegacyValue"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountPhoneNumbersAudit.Delete("AccountPhoneNumbersAuditMetadata_DeleteAccountPhoneNumbersAuditMetadataByID", ID);
	}

	internal static AccountPhoneNumbersAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.Get("AccountPhoneNumbersAuditMetadata_GetAccountPhoneNumbersAuditMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountPhoneNumbersAuditEntriesPublicID", AccountPhoneNumbersAuditEntriesPublicID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@AccountPhoneNumbersChangeTypeID", AccountPhoneNumbersChangeTypeID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountPhoneNumbersAudit.Insert<long>("AccountPhoneNumbersAuditMetadata_InsertAccountPhoneNumbersAuditMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountPhoneNumbersAuditEntriesPublicID", AccountPhoneNumbersAuditEntriesPublicID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@AccountPhoneNumbersChangeTypeID", AccountPhoneNumbersChangeTypeID),
			new SqlParameter("@IsLegacyValue", IsLegacyValue),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountPhoneNumbersAudit.Update("AccountPhoneNumbersAuditMetadata_UpdateAccountPhoneNumbersAuditMetadataByID", queryParameters);
	}

	internal static ICollection<AccountPhoneNumbersAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.MultiGet("AccountPhoneNumbersAuditMetadata_GetAccountPhoneNumbersAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountPhoneNumbersAuditMetadataIDsByUserID(long userId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountPhoneNumbersAuditMetadataId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountPhoneNumbersAuditMetadataID.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartAccountPhoneNumbersAuditMetadataId;
		obj[2] = new SqlParameter("@ExclusiveStartAccountPhoneNumbersAuditMetadataID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.GetIDCollection<long>("AccountPhoneNumbersAuditMetadata_GetAccountPhoneNumbersAuditMetadataIDsByUserID", queryParameters);
	}

	internal static ICollection<long> GetAccountPhoneNumbersAuditMetadataIDsByUserIDAndAccountPhoneNumbersChangeTypeID(long userId, byte accountPhoneNumbersChangeTypeId, int count, long? exclusiveStartAccountPhoneNumbersAuditMetadataId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (accountPhoneNumbersChangeTypeId == 0)
		{
			throw new ArgumentException("Parameter 'accountPhoneNumbersChangeTypeId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountPhoneNumbersAuditMetadataId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountPhoneNumbersAuditMetadataID.");
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@AccountPhoneNumbersChangeTypeID", accountPhoneNumbersChangeTypeId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartAccountPhoneNumbersAuditMetadataId;
		obj[3] = new SqlParameter("@ExclusiveStartAccountPhoneNumbersAuditMetadataID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.GetIDCollection<long>("AccountPhoneNumbersAuditMetadata_GetAccountPhoneNumbersAuditMetadataIDsByUserIDAndAccountPhoneNumbersChangeTypeID", queryParameters);
	}
}
