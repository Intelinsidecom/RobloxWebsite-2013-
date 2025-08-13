using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.DataV2.Core;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Devices.Entities;

internal class ApplicationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.Roblox;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ApplicationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ApplicationTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.Roblox.Delete("ApplicationTypes_DeleteApplicationTypeByID", ID);
	}

	internal static ApplicationTypeDAL Get(byte id)
	{
		return RobloxDatabase.Roblox.Get("ApplicationTypes_GetApplicationTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.Roblox.Insert<byte>("ApplicationTypes_InsertApplicationType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.Roblox.Update("ApplicationTypes_UpdateApplicationTypeByID", queryParameters);
	}

	internal static ICollection<ApplicationTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.Roblox.MultiGet("ApplicationTypes_GetApplicationTypesByIDs", ids, BuildDAL);
	}

	internal static ApplicationTypeDAL GetApplicationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.Roblox.Lookup("ApplicationTypes_GetApplicationTypeByValue", BuildDAL, queryParameters);
	}

	internal static ICollection<byte> GetApplicationTypeIDs(byte? exclusiveStartId, int count, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		SqlParameter[] obj = new SqlParameter[2]
		{
			new SqlParameter("@Count", count),
			null
		};
		byte? b = exclusiveStartId;
		obj[1] = new SqlParameter("@ExclusiveStartID", b.HasValue ? ((object)b.GetValueOrDefault()) : (sortOrder.Equals(Roblox.DataV2.Core.SortOrder.Asc) ? ((object)0) : DBNull.Value));
		SqlParameter[] queryParameters = obj;
		string storedProcedureName = (sortOrder.Equals(Roblox.DataV2.Core.SortOrder.Asc) ? "ApplicationTypes_GetApplicationTypeIDs" : "ApplicationTypes_GetApplicationTypeIDs_Desc");
		return RobloxDatabase.Roblox.GetIDCollection<byte>(storedProcedureName, queryParameters);
	}
}
