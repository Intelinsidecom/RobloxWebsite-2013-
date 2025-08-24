using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Audit;

[ExcludeFromCodeCoverage]
internal class AccountLocalesAuditMetadataTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalesAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountLocalesAuditMetadataTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountLocalesAuditMetadataTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Description = (string)record["Description"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountLocalesAudit.Delete("AccountLocalesAuditMetadataTypes_DeleteAccountLocalesAuditMetadataTypeByID", ID);
	}

	internal static AccountLocalesAuditMetadataTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.Get("AccountLocalesAuditMetadataTypes_GetAccountLocalesAuditMetadataTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountLocalesAudit.Insert<byte>("AccountLocalesAuditMetadataTypes_InsertAccountLocalesAuditMetadataType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountLocalesAudit.Update("AccountLocalesAuditMetadataTypes_UpdateAccountLocalesAuditMetadataTypeByID", queryParameters);
	}

	internal static ICollection<AccountLocalesAuditMetadataTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.MultiGet("AccountLocalesAuditMetadataTypes_GetAccountLocalesAuditMetadataTypesByIDs", ids, BuildDAL);
	}

	internal static AccountLocalesAuditMetadataTypeDAL GetAccountLocalesAuditMetadataTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountLocalesAudit.Lookup("AccountLocalesAuditMetadataTypes_GetAccountLocalesAuditMetadataTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountLocalesAuditMetadataTypeDAL> GetOrCreateAccountLocalesAuditMetadataType(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountLocalesAudit.GetOrCreate("AccountLocalesAuditMetadataTypes_GetOrCreateAccountLocalesAuditMetadataType", BuildDAL, queryParameters);
	}
}
