using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ApplicationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ApplicationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ApplicationTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("ApplicationTypes_DeleteApplicationTypeByID", ID);
	}

	internal static ApplicationTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("ApplicationTypes_GetApplicationTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxPushNotifications.Insert<int>("ApplicationTypes_InsertApplicationType", queryParameters);
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
		RobloxDatabase.RobloxPushNotifications.Update("ApplicationTypes_UpdateApplicationTypeByID", queryParameters);
	}

	internal static ICollection<ApplicationTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("ApplicationTypes_GetApplicationTypesByIDs", ids, BuildDAL);
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
		return RobloxDatabase.RobloxPushNotifications.Lookup("ApplicationTypes_GetApplicationTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ApplicationTypeDAL> GetOrCreateApplicationType(string value)
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
		return RobloxDatabase.RobloxPushNotifications.GetOrCreate("ApplicationTypes_GetOrCreateApplicationType", BuildDAL, queryParameters);
	}
}
