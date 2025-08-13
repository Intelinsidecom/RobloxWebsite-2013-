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
internal class AccountCountriesAutomationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountCountriesAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountCountriesAutomationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountCountriesAutomationTypeDAL
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
		RobloxDatabase.RobloxAccountCountriesAudit.Delete("AutomationTypes_DeleteAutomationTypeByID", ID);
	}

	internal static AccountCountriesAutomationTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.Get("AutomationTypes_GetAutomationTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAccountCountriesAudit.Insert<byte>("AutomationTypes_InsertAutomationType", queryParameters);
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
		RobloxDatabase.RobloxAccountCountriesAudit.Update("AutomationTypes_UpdateAutomationTypeByID", queryParameters);
	}

	internal static ICollection<AccountCountriesAutomationTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.MultiGet("AutomationTypes_GetAutomationTypesByIDs", ids, BuildDAL);
	}

	internal static AccountCountriesAutomationTypeDAL GetAutomationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountCountriesAudit.Lookup("AutomationTypes_GetAutomationTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountCountriesAutomationTypeDAL> GetOrCreateAutomationType(string value)
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
		return RobloxDatabase.RobloxAccountCountriesAudit.GetOrCreate("AutomationTypes_GetOrCreateAutomationType", BuildDAL, queryParameters);
	}
}
