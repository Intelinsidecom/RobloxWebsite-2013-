using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.TwoStepVerification.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingsAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxTwoStepVerificationSettingsAudit;

	internal long ID { get; set; }

	internal Guid PublicID { get; set; }

	internal long Audit_ID { get; set; }

	internal long Audit_UserID { get; set; }

	internal bool Audit_IsEnabled { get; set; }

	internal byte? Audit_TwoStepVerificationMediaTypeID { get; set; }

	internal DateTime Audit_Created { get; set; }

	internal DateTime Audit_Updated { get; set; }

	internal DateTime Created { get; set; }

	private static TwoStepVerificationSettingsAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new TwoStepVerificationSettingsAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicID = (Guid)record["PublicID"],
			Audit_ID = (long)record["Audit-ID"],
			Audit_UserID = (long)record["Audit-UserID"],
			Audit_IsEnabled = (bool)record["Audit-IsEnabled"],
			Audit_TwoStepVerificationMediaTypeID = (byte?)record["Audit-TwoStepVerificationMediaTypeID"],
			Audit_Created = (DateTime)record["Audit-Created"],
			Audit_Updated = (DateTime)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Delete("TwoStepVerificationSettingsAuditEntries_DeleteTwoStepVerificationSettingsAuditEntryByID", ID);
	}

	internal static TwoStepVerificationSettingsAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Get("TwoStepVerificationSettingsAuditEntries_GetTwoStepVerificationSettingsAuditEntryByID", id, BuildDAL);
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
			new SqlParameter("@Audit_UserID", Audit_UserID),
			new SqlParameter("@Audit_IsEnabled", Audit_IsEnabled),
			new SqlParameter("@Audit_TwoStepVerificationMediaTypeID", Audit_TwoStepVerificationMediaTypeID.HasValue ? ((object)Audit_TwoStepVerificationMediaTypeID) : DBNull.Value),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Insert<long>("TwoStepVerificationSettingsAuditEntries_InsertTwoStepVerificationSettingsAuditEntry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_UserID", Audit_UserID),
			new SqlParameter("@Audit_IsEnabled", Audit_IsEnabled),
			new SqlParameter("@Audit_TwoStepVerificationMediaTypeID", Audit_TwoStepVerificationMediaTypeID.HasValue ? ((object)Audit_TwoStepVerificationMediaTypeID) : DBNull.Value),
			new SqlParameter("@Audit_Created", Audit_Created),
			new SqlParameter("@Audit_Updated", Audit_Updated),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Update("TwoStepVerificationSettingsAuditEntries_UpdateTwoStepVerificationSettingsAuditEntryByID", queryParameters);
	}

	internal static ICollection<TwoStepVerificationSettingsAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.MultiGet("TwoStepVerificationSettingsAuditEntries_GetTwoStepVerificationSettingsAuditEntriesByIDs", ids, BuildDAL);
	}

	internal static TwoStepVerificationSettingsAuditEntryDAL GetTwoStepVerificationSettingsAuditEntryByPublicID(Guid publicId)
	{
		if (publicId == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicId)
		};
		return RobloxDatabase.RobloxTwoStepVerificationSettingsAudit.Lookup("TwoStepVerificationSettingsAuditEntries_GetTwoStepVerificationSettingsAuditEntryByPublicID", BuildDAL, queryParameters);
	}
}
