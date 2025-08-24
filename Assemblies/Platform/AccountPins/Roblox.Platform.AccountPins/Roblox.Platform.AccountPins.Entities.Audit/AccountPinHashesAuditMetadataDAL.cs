using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountPinHashesAudit;

	internal long ID { get; set; }

	internal Guid AccountPinHashesAuditPublicID { get; set; }

	internal long UserID { get; set; }

	internal long? ActorUserID { get; set; }

	internal byte AccountPinChangeTypeID { get; set; }

	internal DateTime Created { get; set; }

	private static AccountPinHashesAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountPinHashesAuditMetadataDAL
		{
			ID = (long)record["ID"],
			AccountPinHashesAuditPublicID = (Guid)record["AccountPinHashesAuditPublicID"],
			UserID = (long)record["UserID"],
			ActorUserID = (long?)record["ActorUserID"],
			AccountPinChangeTypeID = (byte)record["AccountPinChangeTypeID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountPinHashesAudit.Delete("AccountPinHashesAuditMetadata_DeleteAccountPinHashesAuditMetadataByID", ID);
	}

	internal static AccountPinHashesAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountPinHashesAudit.Get("AccountPinHashesAuditMetadata_GetAccountPinHashesAuditMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountPinHashesAuditPublicID", AccountPinHashesAuditPublicID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@AccountPinChangeTypeID", AccountPinChangeTypeID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountPinHashesAudit.Insert<long>("AccountPinHashesAuditMetadata_InsertAccountPinHashesAuditMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountPinHashesAuditPublicID", AccountPinHashesAuditPublicID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@AccountPinChangeTypeID", AccountPinChangeTypeID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountPinHashesAudit.Update("AccountPinHashesAuditMetadata_UpdateAccountPinHashesAuditMetadataByID", queryParameters);
	}

	internal static ICollection<AccountPinHashesAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountPinHashesAudit.MultiGet("AccountPinHashesAuditMetadata_GetAccountPinHashesAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountPinHashesAuditMetadataIDsByUserIDAndAccountPinChangeTypeID(long userId, byte accountPinChangeTypeId, int count, long? exclusiveStartId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (accountPinChangeTypeId == 0)
		{
			throw new ArgumentException("Parameter 'accountPinChangeTypeId' cannot be null, empty or the default value.");
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
			new SqlParameter("@UserID", userId),
			new SqlParameter("@AccountPinChangeTypeID", accountPinChangeTypeId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountPinHashesAudit.GetIDCollection<long>("AccountPinHashesAuditMetadata_GetAccountPinHashesAuditMetadataIDsByUserIDAndAccountPinChangeTypeID", queryParameters);
	}

	internal static ICollection<long> GetAccountPinHashesAuditMetadataIDsByUserID(long userId, int count, long? exclusiveStartId)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[2] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountPinHashesAudit.GetIDCollection<long>("AccountPinHashesAuditMetadata_GetAccountPinHashesAuditMetadataIDsByUserID", queryParameters);
	}
}
