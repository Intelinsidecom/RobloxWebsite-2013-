using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class PlatformTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static PlatformTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new PlatformTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("PlatformTypes_DeletePlatformTypeByID", ID);
	}

	internal static PlatformTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("PlatformTypes_GetPlatformTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxPushNotifications.Insert<int>("PlatformTypes_InsertPlatformType", queryParameters);
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
		RobloxDatabase.RobloxPushNotifications.Update("PlatformTypes_UpdatePlatformTypeByID", queryParameters);
	}

	internal static ICollection<PlatformTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("PlatformTypes_GetPlatformTypesByIDs", ids, BuildDAL);
	}

	internal static PlatformTypeDAL GetPlatformTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxPushNotifications.Lookup("PlatformTypes_GetPlatformTypeByValue", BuildDAL, queryParameters);
	}
}
