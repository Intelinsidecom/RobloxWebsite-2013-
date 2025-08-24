using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class AuthenticationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AuthenticationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AuthenticationTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("AuthenticationTypes_DeleteAuthenticationTypeByID", ID);
	}

	internal static AuthenticationTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("AuthenticationTypes_GetAuthenticationTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxPushNotifications.Insert<int>("AuthenticationTypes_InsertAuthenticationType", queryParameters);
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
		RobloxDatabase.RobloxPushNotifications.Update("AuthenticationTypes_UpdateAuthenticationTypeByID", queryParameters);
	}

	internal static ICollection<AuthenticationTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("AuthenticationTypes_GetAuthenticationTypesByIDs", ids, BuildDAL);
	}

	internal static AuthenticationTypeDAL GetAuthenticationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxPushNotifications.Lookup("AuthenticationTypes_GetAuthenticationTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AuthenticationTypeDAL> GetOrCreateAuthenticationType(string value)
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
		return RobloxDatabase.RobloxPushNotifications.GetOrCreate("AuthenticationTypes_GetOrCreateAuthenticationType", BuildDAL, queryParameters);
	}
}
