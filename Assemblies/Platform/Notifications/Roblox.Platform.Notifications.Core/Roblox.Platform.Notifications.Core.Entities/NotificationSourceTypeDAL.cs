using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class NotificationSourceTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal short ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static NotificationSourceTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new NotificationSourceTypeDAL
		{
			ID = (short)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("NotificationSourceTypes_DeleteNotificationSourceTypeByID", ID);
	}

	internal static NotificationSourceTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxNotifications.Get("NotificationSourceTypes_GetNotificationSourceTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", SqlDbType.SmallInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<short>("NotificationSourceTypes_InsertNotificationSourceType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxNotifications.Update("NotificationSourceTypes_UpdateNotificationSourceTypeByID", queryParameters);
	}

	internal static ICollection<NotificationSourceTypeDAL> MultiGet(ICollection<short> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("NotificationSourceTypes_GetNotificationSourceTypesByIDs", ids, BuildDAL);
	}

	internal static NotificationSourceTypeDAL GetNotificationSourceTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("NotificationSourceTypes_GetNotificationSourceTypeByValue", BuildDAL, queryParameters);
	}
}
