using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Membership.Audit;

internal class UsersAuditEntryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUsersAudit;

	internal long ID { get; private set; }

	internal Guid PublicID { get; set; }

	internal long Audit_ID { get; set; }

	internal long Audit_AccountID { get; set; }

	internal byte? Audit_AgeBracket { get; set; }

	internal DateTime? Audit_BirthDate { get; set; }

	internal byte? Audit_GenderTypeID { get; set; }

	internal bool Audit_UseSuperSafeConversationMode { get; set; }

	internal bool Audit_UseSuperSafePrivacyMode { get; set; }

	internal DateTime Audit_Created { get; set; }

	internal DateTime? Audit_Updated { get; set; }

	internal DateTime Created { get; set; }

	private static UsersAuditEntryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UsersAuditEntryDAL
		{
			ID = (long)record["ID"],
			PublicID = (Guid)record["PublicID"],
			Audit_ID = (long)record["Audit-ID"],
			Audit_AccountID = (long)record["Audit-AccountID"],
			Audit_AgeBracket = (byte?)record["Audit-AgeBracket"],
			Audit_BirthDate = (DateTime?)record["Audit-BirthDate"],
			Audit_GenderTypeID = (byte?)record["Audit-GenderTypeID"],
			Audit_UseSuperSafeConversationMode = (bool)record["Audit-UseSuperSafeConversationMode"],
			Audit_UseSuperSafePrivacyMode = (bool)record["Audit-UseSuperSafePrivacyMode"],
			Audit_Created = (DateTime)record["Audit-Created"],
			Audit_Updated = (DateTime?)record["Audit-Updated"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxUsersAudit.Delete("UsersAuditEntriesV2_DeleteUsersAuditEntryV2ByID", ID);
	}

	internal static UsersAuditEntryDAL Get(long id)
	{
		return RobloxDatabase.RobloxUsersAudit.Get("UsersAuditEntriesV2_GetUsersAuditEntryV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] obj = new SqlParameter[12]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AccountID", Audit_AccountID),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		byte? audit_AgeBracket = Audit_AgeBracket;
		obj[4] = new SqlParameter("@Audit_AgeBracket", audit_AgeBracket.HasValue ? ((object)audit_AgeBracket.GetValueOrDefault()) : DBNull.Value);
		DateTime? audit_BirthDate = Audit_BirthDate;
		obj[5] = new SqlParameter("@Audit_BirthDate", audit_BirthDate.HasValue ? ((object)audit_BirthDate.GetValueOrDefault()) : DBNull.Value);
		audit_AgeBracket = Audit_GenderTypeID;
		obj[6] = new SqlParameter("@Audit_GenderTypeID", audit_AgeBracket.HasValue ? ((object)audit_AgeBracket.GetValueOrDefault()) : DBNull.Value);
		obj[7] = new SqlParameter("@Audit_UseSuperSafeConversationMode", Audit_UseSuperSafeConversationMode);
		obj[8] = new SqlParameter("@Audit_UseSuperSafePrivacyMode", Audit_UseSuperSafePrivacyMode);
		obj[9] = new SqlParameter("@Audit_Created", Audit_Created);
		audit_BirthDate = Audit_Updated;
		obj[10] = new SqlParameter("@Audit_Updated", audit_BirthDate.HasValue ? ((object)audit_BirthDate.GetValueOrDefault()) : DBNull.Value);
		obj[11] = new SqlParameter("@Created", Created);
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxUsersAudit.Insert<long>("UsersAuditEntriesV2_InsertUsersAuditEntryV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] obj = new SqlParameter[12]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PublicID", PublicID),
			new SqlParameter("@Audit_ID", Audit_ID),
			new SqlParameter("@Audit_AccountID", Audit_AccountID),
			null,
			null,
			null,
			null,
			null,
			null,
			null,
			null
		};
		byte? audit_AgeBracket = Audit_AgeBracket;
		obj[4] = new SqlParameter("@Audit_AgeBracket", audit_AgeBracket.HasValue ? ((object)audit_AgeBracket.GetValueOrDefault()) : DBNull.Value);
		DateTime? audit_BirthDate = Audit_BirthDate;
		obj[5] = new SqlParameter("@Audit_BirthDate", audit_BirthDate.HasValue ? ((object)audit_BirthDate.GetValueOrDefault()) : DBNull.Value);
		audit_AgeBracket = Audit_GenderTypeID;
		obj[6] = new SqlParameter("@Audit_GenderTypeID", audit_AgeBracket.HasValue ? ((object)audit_AgeBracket.GetValueOrDefault()) : DBNull.Value);
		obj[7] = new SqlParameter("@Audit_UseSuperSafeConversationMode", Audit_UseSuperSafeConversationMode);
		obj[8] = new SqlParameter("@Audit_UseSuperSafePrivacyMode", Audit_UseSuperSafePrivacyMode);
		obj[9] = new SqlParameter("@Audit_Created", Audit_Created);
		audit_BirthDate = Audit_Updated;
		obj[10] = new SqlParameter("@Audit_Updated", audit_BirthDate.HasValue ? ((object)audit_BirthDate.GetValueOrDefault()) : DBNull.Value);
		obj[11] = new SqlParameter("@Created", Created);
		SqlParameter[] queryParameters = obj;
		RobloxDatabase.RobloxUsersAudit.Update("UsersAuditEntriesV2_UpdateUsersAuditEntryV2ByID", queryParameters);
	}

	internal static ICollection<UsersAuditEntryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxUsersAudit.MultiGet("UsersAuditEntriesV2_GetUsersAuditEntriesV2ByIDs", ids, BuildDAL);
	}

	internal static UsersAuditEntryDAL GetUsersAuditEntryByPublicID(Guid publicID)
	{
		if (publicID == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PublicID", publicID)
		};
		return RobloxDatabase.RobloxUsersAudit.Lookup("UsersAuditEntriesV2_GetUsersAuditEntryV2ByPublicID", BuildDAL, queryParameters);
	}
}
