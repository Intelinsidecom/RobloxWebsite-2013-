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
internal class AccountLocalesAutomationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalesAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountLocalesAutomationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountLocalesAutomationTypeDAL
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
		RobloxDatabase.RobloxAccountLocalesAudit.Delete("AutomationTypes_DeleteAutomationTypeByID", ID);
	}

	internal static AccountLocalesAutomationTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.Get("AutomationTypes_GetAutomationTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAccountLocalesAudit.Insert<byte>("AutomationTypes_InsertAutomationType", queryParameters);
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
		RobloxDatabase.RobloxAccountLocalesAudit.Update("AutomationTypes_UpdateAutomationTypeByID", queryParameters);
	}

	internal static ICollection<AccountLocalesAutomationTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.MultiGet("AutomationTypes_GetAutomationTypesByIDs", ids, BuildDAL);
	}

	internal static AccountLocalesAutomationTypeDAL GetAutomationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountLocalesAudit.Lookup("AutomationTypes_GetAutomationTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountLocalesAutomationTypeDAL> GetOrCreateAutomationType(string value)
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
		return RobloxDatabase.RobloxAccountLocalesAudit.GetOrCreate("AutomationTypes_GetOrCreateAutomationType", BuildDAL, queryParameters);
	}
}
