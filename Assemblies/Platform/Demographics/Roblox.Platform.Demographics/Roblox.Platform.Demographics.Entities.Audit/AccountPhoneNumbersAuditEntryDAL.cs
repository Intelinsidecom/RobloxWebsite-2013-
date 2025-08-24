using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Demographics.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumbersAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountPhoneNumbersAudit;

	internal long ID { get; set; }

	internal Guid PublicID { get; set; }

	internal long Audit_ID { get; set; }

	internal long Audit_AccountID { get; set; }

	internal long? Audit_PhoneNumberID { get; set; }

	internal bool? Audit_IsVerified { get; set; }

	internal string Audit_Phone { get; set; }

	internal DateTime Audit_Created { get; set; }

	internal DateTime Audit_Updated { get; set; }

	internal DateTime Created { get; set; }

	private static AccountPhoneNumbersAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountPhoneNumbersAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicID = (Guid)record["PublicID"],
			Audit_ID = (long)record["Audit-ID"],
			Audit_AccountID = (long)record["Audit-AccountID"],
			Audit_PhoneNumberID = (long?)record["Audit-PhoneNumberID"],
			Audit_IsVerified = (bool?)record["Audit-IsVerified"],
			Audit_Phone = (string)record["Audit-Phone"],
			Audit_Created = (DateTime)record["Audit-Created"],
			Audit_Updated = (DateTime)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountPhoneNumbersAudit.Delete("AccountPhoneNumbersAuditEntries_DeleteAccountPhoneNumbersAuditEntryByID", ID);
	}

	internal static AccountPhoneNumbersAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.Get("AccountPhoneNumbersAuditEntries_GetAccountPhoneNumbersAuditEntryByID", id, BuildDAL);
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
			new SqlParameter("@Audit_AccountID", Audit_AccountID),
			new SqlParameter("@Audit_PhoneNumberID", Audit_PhoneNumberID.HasValue ? ((object)Audit_PhoneNumberID) : DBNull.Value),
			new SqlParameter("@Audit_IsVerified", Audit_IsVerified.HasValue ? ((object)Audit_IsVerified) : DBNull.Value),
			new SqlParameter("@Audit_Phone", Audit_Phone),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxAccountPhoneNumbersAudit.Insert<long>("AccountPhoneNumbersAuditEntries_InsertAccountPhoneNumbersAuditEntry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AccountID", Audit_AccountID),
			new SqlParameter("@Audit_PhoneNumberID", Audit_PhoneNumberID.HasValue ? ((object)Audit_PhoneNumberID) : DBNull.Value),
			new SqlParameter("@Audit_IsVerified", Audit_IsVerified.HasValue ? ((object)Audit_IsVerified) : DBNull.Value),
			new SqlParameter("@Audit_Phone", Audit_Phone),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxAccountPhoneNumbersAudit.Update("AccountPhoneNumbersAuditEntries_UpdateAccountPhoneNumbersAuditEntryByID", queryParameters);
	}

	internal static ICollection<AccountPhoneNumbersAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.MultiGet("AccountPhoneNumbersAuditEntries_GetAccountPhoneNumbersAuditEntriesByIDs", ids, BuildDAL);
	}

	internal static AccountPhoneNumbersAuditEntryDAL GetAccountPhoneNumbersAuditEntryByPublicID(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxAccountPhoneNumbersAudit.Lookup("AccountPhoneNumbersAuditEntries_GetAccountPhoneNumbersAuditEntryByPublicID", BuildDAL, queryParameters);
	}
}
