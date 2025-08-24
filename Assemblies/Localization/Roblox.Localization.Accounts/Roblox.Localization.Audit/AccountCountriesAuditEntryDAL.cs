using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountCountriesAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountCountriesAudit;

	internal long ID { get; set; }

	internal Guid PublicId { get; set; }

	internal long AuditId { get; set; }

	internal long AuditAccountId { get; set; }

	internal int? AuditCountryId { get; set; }

	internal bool AuditIsVerified { get; set; }

	internal DateTime AuditCreated { get; set; }

	internal DateTime AuditUpdated { get; set; }

	internal DateTime Created { get; set; }

	private static AccountCountriesAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountCountriesAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicId = (Guid)record["PublicID"],
			AuditId = (long)record["Audit-ID"],
			AuditAccountId = (long)record["Audit-AccountID"],
			AuditCountryId = (int?)record["Audit-CountryID"],
			AuditIsVerified = (bool)record["Audit-IsVerified"],
			AuditCreated = (DateTime)record["Audit-Created"],
			AuditUpdated = (DateTime)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountCountriesAudit.Delete("AccountCountriesAuditEntries_DeleteAccountCountriesAuditEntryByID", ID);
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
			new SqlParameter("@Audit_CountryID", AuditCountryId.HasValue ? ((object)AuditCountryId) : DBNull.Value),
			new SqlParameter("@Audit_IsVerified", AuditIsVerified),
			new SqlParameter("@Audit_Created", AuditCreated),
			new SqlParameter("@Audit_Updated", AuditUpdated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountCountriesAudit.Insert<long>("AccountCountriesAuditEntries_InsertAccountCountriesAuditEntry", queryParameters);
	}

	internal static AccountCountriesAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.Get("AccountCountriesAuditEntries_GetAccountCountriesAuditEntryByID", id, BuildDAL);
	}

	internal static ICollection<AccountCountriesAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.MultiGet("AccountCountriesAuditEntries_GetAccountCountriesAuditEntriesByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountCountriesAuditEntryIDsByAuditId(long auditId, int count, long? exclusiveStartId)
	{
		if (auditId == 0L)
		{
			throw new PlatformArgumentException("Parameter 'audit_Id' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new PlatformArgumentException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new PlatformArgumentException("Parameter 'ExclusiveStartID' cannot be negative.");
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
		return RobloxDatabase.RobloxAccountCountriesAudit.GetIDCollection<long>("AccountCountriesAuditEntries_GetAccountCountriesAuditEntryIDsByAudit-ID", queryParameters);
	}

	internal static AccountCountriesAuditEntryDAL GetAccountCountriesAuditEntryByPublicId(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxAccountCountriesAudit.Lookup("AccountCountriesAuditEntries_GetAccountCountriesAuditEntryByPublicID", BuildDAL, queryParameters);
	}
}
