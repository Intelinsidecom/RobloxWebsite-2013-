using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AccountPins.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPinHashesAuditDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountPinHashesAudit;

	internal long ID { get; set; }

	internal Guid PublicID { get; set; }

	internal long Audit_ID { get; set; }

	internal long Audit_AccountID { get; set; }

	internal string Audit_PinHash { get; set; }

	internal bool Audit_IsValid { get; set; }

	internal DateTime Audit_Created { get; set; }

	internal DateTime Audit_Updated { get; set; }

	internal DateTime Created { get; set; }

	private static AccountPinHashesAuditDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountPinHashesAuditDAL
		{
			ID = (long)record["ID"],
			PublicID = (Guid)record["PublicID"],
			Audit_ID = (long)record["Audit-ID"],
			Audit_AccountID = (long)record["Audit-AccountID"],
			Audit_PinHash = (string)record["Audit-PinHash"],
			Audit_IsValid = (bool)record["Audit-IsValid"],
			Audit_Created = (DateTime)record["Audit-Created"],
			Audit_Updated = (DateTime)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountPinHashesAudit.Delete("AccountPinHashesAudit_DeleteAccountPinHashesAuditByID", ID);
	}

	internal static AccountPinHashesAuditDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountPinHashesAudit.Get("AccountPinHashesAudit_GetAccountPinHashesAuditByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AccountID", Audit_AccountID),
			new SqlParameter("@Audit_PinHash", Audit_PinHash),
			new SqlParameter("@Audit_IsValid", Audit_IsValid),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountPinHashesAudit.Insert<long>("AccountPinHashesAudit_InsertAccountPinHashesAudit", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AccountID", Audit_AccountID),
			new SqlParameter("@Audit_PinHash", Audit_PinHash),
			new SqlParameter("@Audit_IsValid", Audit_IsValid),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountPinHashesAudit.Update("AccountPinHashesAudit_UpdateAccountPinHashesAuditByID", queryParameters);
	}

	internal static ICollection<AccountPinHashesAuditDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountPinHashesAudit.MultiGet("AccountPinHashesAudit_GetAccountPinHashesAuditByIDs", ids, BuildDAL);
	}

	internal static AccountPinHashesAuditDAL GetAccountPinHashesAuditByPublicID(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxAccountPinHashesAudit.Lookup("AccountPinHashesAudit_GetAccountPinHashesAuditByPublicID", BuildDAL, queryParameters);
	}
}
