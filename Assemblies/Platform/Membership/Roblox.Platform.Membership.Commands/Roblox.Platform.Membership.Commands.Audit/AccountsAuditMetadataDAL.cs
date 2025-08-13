using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountsAudit;

	internal long ID { get; set; }

	internal Guid AccountsAuditEntriesPublicID { get; set; }

	internal byte AccountsChangeTypeID { get; set; }

	internal long? ActorUserID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	private static AccountsAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountsAuditMetadataDAL
		{
			ID = (long)record["ID"],
			AccountsAuditEntriesPublicID = (Guid)record["AccountsAuditEntriesPublicID"],
			AccountsChangeTypeID = (byte)record["AccountsChangeTypeID"],
			ActorUserID = (long?)record["ActorUserID"],
			UserID = (long)record["UserID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountsAudit.Delete("AccountsAuditMetadata_DeleteAccountsAuditMetadataByID", ID);
	}

	internal static AccountsAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountsAudit.Get("AccountsAuditMetadata_GetAccountsAuditMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountsAuditEntriesPublicID", AccountsAuditEntriesPublicID),
			new SqlParameter("@AccountsChangeTypeID", AccountsChangeTypeID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountsAudit.Insert<long>("AccountsAuditMetadata_InsertAccountsAuditMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountsAuditEntriesPublicID", AccountsAuditEntriesPublicID),
			new SqlParameter("@AccountsChangeTypeID", AccountsChangeTypeID),
			new SqlParameter("@ActorUserID", ActorUserID.HasValue ? ((object)ActorUserID) : DBNull.Value),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountsAudit.Update("AccountsAuditMetadata_UpdateAccountsAuditMetadataByID", queryParameters);
	}

	internal static ICollection<AccountsAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountsAudit.MultiGet("AccountsAuditMetadata_GetAccountsAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountsAuditMetadataIDsByAccountsChangeTypeIDAndUserID(byte accountsChangeTypeId, long userId, int count, long? exclusiveStartId)
	{
		if (accountsChangeTypeId == 0)
		{
			throw new ArgumentException("Parameter 'accountsChangeTypeId' cannot be null, empty or the default value.");
		}
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
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@AccountsChangeTypeID", accountsChangeTypeId),
			new SqlParameter("@UserID", userId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountsAudit.GetIDCollection<long>("AccountsAuditMetadata_GetAccountsAuditMetadataIDsByChangeTypeIDAndUserID", queryParameters);
	}
}
