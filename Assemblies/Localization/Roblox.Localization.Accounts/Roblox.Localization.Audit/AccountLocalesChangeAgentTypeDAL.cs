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
internal class AccountLocalesChangeAgentTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalesAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountLocalesChangeAgentTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountLocalesChangeAgentTypeDAL
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
		RobloxDatabase.RobloxAccountLocalesAudit.Delete("ChangeAgentTypes_DeleteChangeAgentTypeByID", ID);
	}

	internal static AccountLocalesChangeAgentTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.Get("ChangeAgentTypes_GetChangeAgentTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAccountLocalesAudit.Insert<byte>("ChangeAgentTypes_InsertChangeAgentType", queryParameters);
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
		RobloxDatabase.RobloxAccountLocalesAudit.Update("ChangeAgentTypes_UpdateChangeAgentTypeByID", queryParameters);
	}

	internal static ICollection<AccountLocalesChangeAgentTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAccountLocalesAudit.MultiGet("ChangeAgentTypes_GetChangeAgentTypesByIDs", ids, BuildDAL);
	}

	internal static AccountLocalesChangeAgentTypeDAL GetChangeAgentTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountLocalesAudit.Lookup("ChangeAgentTypes_GetChangeAgentTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountLocalesChangeAgentTypeDAL> GetOrCreateChangeAgentType(string value)
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
		return RobloxDatabase.RobloxAccountLocalesAudit.GetOrCreate("ChangeAgentTypes_GetOrCreateChangeAgentType", BuildDAL, queryParameters);
	}
}
