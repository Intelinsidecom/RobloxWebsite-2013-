using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Membership.Commands.Audit;

[ExcludeFromCodeCoverage]
internal class AccountsAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountsAudit;

	internal long ID { get; set; }

	internal Guid PublicID { get; set; }

	internal long Audit_ID { get; set; }

	internal string Audit_Name { get; set; }

	internal byte Audit_AccountStatusID { get; set; }

	internal int Audit_RoleSetID { get; set; }

	internal string Audit_Description { get; set; }

	internal DateTime Audit_Created { get; set; }

	internal DateTime Audit_Updated { get; set; }

	internal DateTime Created { get; set; }

	private static AccountsAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountsAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicID = (Guid)record["PublicID"],
			Audit_ID = (long)record["Audit-ID"],
			Audit_Name = (string)record["Audit-Name"],
			Audit_AccountStatusID = (byte)record["Audit-AccountStatusID"],
			Audit_RoleSetID = (int)record["Audit-RoleSetID"],
			Audit_Description = (string)record["Audit-Description"],
			Audit_Created = (DateTime)record["Audit-Created"],
			Audit_Updated = (DateTime)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountsAudit.Delete("AccountsAuditEntries_DeleteAccountsAuditEntryByID", ID);
	}

	internal static AccountsAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountsAudit.Get("AccountsAuditEntries_GetAccountsAuditEntryByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_Name", Audit_Name),
			new SqlParameter("@Audit_AccountStatusID", Audit_AccountStatusID),
			new SqlParameter("@Audit_RoleSetID", Audit_RoleSetID),
			new SqlParameter("@Audit_Description", string.IsNullOrEmpty(Audit_Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Audit_Description)),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountsAudit.Insert<long>("AccountsAuditEntries_InsertAccountsAuditEntry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_Name", Audit_Name),
			new SqlParameter("@Audit_AccountStatusID", Audit_AccountStatusID),
			new SqlParameter("@Audit_RoleSetID", Audit_RoleSetID),
			new SqlParameter("@Audit_Description", string.IsNullOrEmpty(Audit_Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Audit_Description)),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountsAudit.Update("AccountsAuditEntries_UpdateAccountsAuditEntryByID", queryParameters);
	}

	internal static ICollection<AccountsAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountsAudit.MultiGet("AccountsAuditEntries_GetAccountsAuditEntriesByIDs", ids, BuildDAL);
	}

	internal static AccountsAuditEntryDAL GetAccountsAuditEntryByPublicID(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxAccountsAudit.Lookup("AccountsAuditEntries_GetAccountsAuditEntryByPublicID", BuildDAL, queryParameters);
	}
}
