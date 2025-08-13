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
internal class AccountCountriesAuditMetadataTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountCountriesAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountCountriesAuditMetadataTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountCountriesAuditMetadataTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Description = (string)record["Description"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountCountriesAudit.Delete("AccountCountriesAuditMetadataTypes_DeleteAccountCountriesAuditMetadataTypeByID", ID);
	}

	internal static AccountCountriesAuditMetadataTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.Get("AccountCountriesAuditMetadataTypes_GetAccountCountriesAuditMetadataTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAccountCountriesAudit.Insert<byte>("AccountCountriesAuditMetadataTypes_InsertAccountCountriesAuditMetadataType", queryParameters);
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
		RobloxDatabase.RobloxAccountCountriesAudit.Update("AccountCountriesAuditMetadataTypes_UpdateAccountCountriesAuditMetadataTypeByID", queryParameters);
	}

	internal static ICollection<AccountCountriesAuditMetadataTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.MultiGet("AccountCountriesAuditMetadataTypes_GetAccountCountriesAuditMetadataTypesByIDs", ids, BuildDAL);
	}

	internal static AccountCountriesAuditMetadataTypeDAL GetAccountCountriesAuditMetadataTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountCountriesAudit.Lookup("AccountCountriesAuditMetadataTypes_GetAccountCountriesAuditMetadataTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountCountriesAuditMetadataTypeDAL> GetOrCreateAccountCountriesAuditMetadataType(string value)
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
		return RobloxDatabase.RobloxAccountCountriesAudit.GetOrCreate("AccountCountriesAuditMetadataTypes_GetOrCreateAccountCountriesAuditMetadataType", BuildDAL, queryParameters);
	}
}
