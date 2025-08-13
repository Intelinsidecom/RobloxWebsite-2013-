using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalesAudit;

	internal long ID { get; set; }

	internal Guid PublicId { get; set; }

	internal long AuditId { get; set; }

	internal long AuditAccountId { get; set; }

	internal int AuditObservedLocaleId { get; set; }

	internal int? AuditSupportedLocaleId { get; set; }

	internal DateTime AuditCreated { get; set; }

	internal DateTime AuditUpdated { get; set; }

	internal DateTime Created { get; set; }

	private static AccountLocalesAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountLocalesAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicId = (Guid)record["PublicID"],
			AuditId = (long)record["Audit-ID"],
			AuditAccountId = (long)record["Audit-AccountID"],
			AuditObservedLocaleId = (int)record["Audit-ObservedLocaleID"],
			AuditSupportedLocaleId = (int?)record["Audit-SupportedLocaleID"],
			AuditCreated = (DateTime)record["Audit-Created"],
			AuditUpdated = (DateTime)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountLocalesAudit.Delete("AccountLocalesAuditEntries_DeleteAccountLocalesAuditEntryByID", ID);
	}

	internal static AccountLocalesAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.Get("AccountLocalesAuditEntries_GetAccountLocalesAuditEntryByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PublicID", PublicId),
			new SqlParameter("@Audit_ID", AuditId),
			new SqlParameter("@Audit_AccountID", AuditAccountId),
			new SqlParameter("@Audit_ObservedLocaleID", AuditObservedLocaleId),
			new SqlParameter("@Audit_SupportedLocaleID", AuditSupportedLocaleId.HasValue ? ((object)AuditSupportedLocaleId) : DBNull.Value),
			new SqlParameter("@Audit_Created", AuditCreated),
			new SqlParameter("@Audit_Updated", AuditUpdated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountLocalesAudit.Insert<long>("AccountLocalesAuditEntries_InsertAccountLocalesAuditEntry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] obj = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicId),
			new SqlParameter("@Audit_ID", AuditId),
			new SqlParameter("@Audit_AccountID", AuditAccountId),
			new SqlParameter("@Audit_ObservedLocaleID", AuditObservedLocaleId),
			null,
			null,
			null,
			null
		};
		int? auditSupportedLocaleId = AuditSupportedLocaleId;
		obj[5] = new SqlParameter("@Audit_SupportedLocaleID", auditSupportedLocaleId.HasValue ? ((object)auditSupportedLocaleId.GetValueOrDefault()) : DBNull.Value);
		obj[6] = new SqlParameter("@Audit_Created", AuditCreated);
		obj[7] = new SqlParameter("@Audit_Updated", AuditUpdated);
		obj[8] = new SqlParameter("@Created", Created);
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxAccountLocalesAudit.Update("AccountLocalesAuditEntries_UpdateAccountLocalesAuditEntryByID", queryParameters);
	}

	internal static ICollection<AccountLocalesAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.MultiGet("AccountLocalesAuditEntries_GetAccountLocalesAuditEntriesByIDs", ids, BuildDAL);
	}

	internal static AccountLocalesAuditEntryDAL GetAccountLocalesAuditEntryByPublicId(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxAccountLocalesAudit.Lookup("AccountLocalesAuditEntries_GetAccountLocalesAuditEntryByPublicID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetAccountLocalesAuditEntryIdsByAuditId(long auditId, int count, long? exclusiveStartId)
	{
		if (auditId == 0L)
		{
			throw new ArgumentException("Parameter 'audit_Id' cannot be null, empty or the default value.");
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
			new SqlParameter("@Audit_ID", auditId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[2] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountLocalesAudit.GetIDCollection<long>("AccountLocalesAuditEntries_GetAccountLocalesAuditEntryIDsByAudit-ID", queryParameters);
	}
}
