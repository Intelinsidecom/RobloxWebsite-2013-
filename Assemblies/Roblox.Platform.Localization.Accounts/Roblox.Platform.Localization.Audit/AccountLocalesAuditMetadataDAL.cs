using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadataDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalesAudit;

	internal long ID { get; set; }

	internal Guid AccountLocalesAuditEntryPublicId { get; set; }

	internal long AccountLocalesAuditEntryAuditId { get; set; }

	internal byte AccountLocalesAuditMetadataTypeId { get; set; }

	internal byte ChangeAgentTypeId { get; set; }

	internal long? ChangeAgentTargetId { get; set; }

	internal DateTime Created { get; set; }

	private static AccountLocalesAuditMetadataDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountLocalesAuditMetadataDAL
		{
			ID = (long)record["ID"],
			AccountLocalesAuditEntryPublicId = (Guid)record["AccountLocalesAuditEntryPublicID"],
			AccountLocalesAuditEntryAuditId = (long)record["AccountLocalesAuditEntryAudit-ID"],
			AccountLocalesAuditMetadataTypeId = (byte)record["AccountLocalesAuditMetadataTypeID"],
			ChangeAgentTypeId = (byte)record["ChangeAgentTypeID"],
			ChangeAgentTargetId = (long?)record["ChangeAgentTargetID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountLocalesAudit.Delete("AccountLocalesAuditMetadata_DeleteAccountLocalesAuditMetadataByID", ID);
	}

	internal static AccountLocalesAuditMetadataDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.Get("AccountLocalesAuditMetadata_GetAccountLocalesAuditMetadataByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountLocalesAuditEntryPublicID", AccountLocalesAuditEntryPublicId),
			new SqlParameter("@AccountLocalesAuditEntryAudit_ID", AccountLocalesAuditEntryAuditId),
			new SqlParameter("@AccountLocalesAuditMetadataTypeID", AccountLocalesAuditMetadataTypeId),
			new SqlParameter("@ChangeAgentTypeID", ChangeAgentTypeId),
			new SqlParameter("@ChangeAgentTargetID", ChangeAgentTargetId.HasValue ? ((object)ChangeAgentTargetId) : DBNull.Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountLocalesAudit.Insert<long>("AccountLocalesAuditMetadata_InsertAccountLocalesAuditMetadata", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountLocalesAuditEntryPublicID", AccountLocalesAuditEntryPublicId),
			new SqlParameter("@AccountLocalesAuditEntryAudit_ID", AccountLocalesAuditEntryAuditId),
			new SqlParameter("@AccountLocalesAuditMetadataTypeID", AccountLocalesAuditMetadataTypeId),
			new SqlParameter("@ChangeAgentTypeID", ChangeAgentTypeId),
			new SqlParameter("@ChangeAgentTargetID", ChangeAgentTargetId.HasValue ? ((object)ChangeAgentTargetId) : DBNull.Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountLocalesAudit.Update("AccountLocalesAuditMetadata_UpdateAccountLocalesAuditMetadataByID", queryParameters);
	}

	internal static ICollection<AccountLocalesAuditMetadataDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.MultiGet("AccountLocalesAuditMetadata_GetAccountLocalesAuditMetadataByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountLocalesAuditMetadataIdsByAccountLocalesAuditEntryAuditIdAndAccountLocalesAuditMetadataTypeId(long accountLocalesAuditEntryAuditId, byte accountLocalesAuditMetadataTypeId, int count, long? exclusiveStartId)
	{
		if (accountLocalesAuditEntryAuditId == 0L)
		{
			throw new ArgumentException("Parameter 'accountLocalesAuditEntryAudit_Id' cannot be null, empty or the default value.");
		}
		if (accountLocalesAuditMetadataTypeId == 0)
		{
			throw new ArgumentException("Parameter 'accountLocalesAuditMetadataTypeId' cannot be null, empty or the default value.");
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
			new SqlParameter("@AccountLocalesAuditEntryAudit_ID", accountLocalesAuditEntryAuditId),
			new SqlParameter("@AccountLocalesAuditMetadataTypeID", accountLocalesAuditMetadataTypeId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountLocalesAudit.GetIDCollection<long>("AccountLocalesAuditMetadata_GetAccountLocalesAuditMetadataIDsByAudit-IDAndMetadataTypeID", queryParameters);
	}
}
