using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.Entities;

internal class XboxLiveAccountActionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxXbox;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static XboxLiveAccountActionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new XboxLiveAccountActionTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxXbox.Delete("XboxLiveAccountActionTypes_DeleteXboxLiveAccountActionTypeByID", ID);
	}

	internal static XboxLiveAccountActionTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxXbox.Get("XboxLiveAccountActionTypes_GetXboxLiveAccountActionTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxXbox.Insert<byte>("XboxLiveAccountActionTypes_InsertXboxLiveAccountActionType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxXbox.Update("XboxLiveAccountActionTypes_UpdateXboxLiveAccountActionTypeByID", queryParameters);
	}

	internal static ICollection<XboxLiveAccountActionTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxXbox.MultiGet("XboxLiveAccountActionTypes_GetXboxLiveAccountActionTypesByIDs", ids, BuildDAL);
	}

	internal static XboxLiveAccountActionTypeDAL GetXboxLiveAccountActionTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxXbox.Lookup("XboxLiveAccountActionTypes_GetXboxLiveAccountActionTypeByValue", BuildDAL, queryParameters);
	}
}
