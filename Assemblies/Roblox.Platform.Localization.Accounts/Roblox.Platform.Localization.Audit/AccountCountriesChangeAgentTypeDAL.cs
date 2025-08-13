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
internal class AccountCountriesChangeAgentTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountCountriesAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountCountriesChangeAgentTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountCountriesChangeAgentTypeDAL
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
		RobloxDatabase.RobloxAccountCountriesAudit.Delete("ChangeAgentTypes_DeleteChangeAgentTypeByID", ID);
	}

	internal static AccountCountriesChangeAgentTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.Get("ChangeAgentTypes_GetChangeAgentTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAccountCountriesAudit.Insert<byte>("ChangeAgentTypes_InsertChangeAgentType", queryParameters);
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
		RobloxDatabase.RobloxAccountCountriesAudit.Update("ChangeAgentTypes_UpdateChangeAgentTypeByID", queryParameters);
	}

	internal static ICollection<AccountCountriesChangeAgentTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAccountCountriesAudit.MultiGet("ChangeAgentTypes_GetChangeAgentTypesByIDs", ids, BuildDAL);
	}

	internal static AccountCountriesChangeAgentTypeDAL GetChangeAgentTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountCountriesAudit.Lookup("ChangeAgentTypes_GetChangeAgentTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountCountriesChangeAgentTypeDAL> GetOrCreateChangeAgentType(string value)
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
		return RobloxDatabase.RobloxAccountCountriesAudit.GetOrCreate("ChangeAgentTypes_GetOrCreateChangeAgentType", BuildDAL, queryParameters);
	}
}
