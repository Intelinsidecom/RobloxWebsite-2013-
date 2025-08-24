using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ReceiverTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ReceiverTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("ReceiverTypes_DeleteReceiverTypeByID", ID);
	}

	internal static ReceiverTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("ReceiverTypes_GetReceiverTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxPushNotifications.Insert<int>("ReceiverTypes_InsertReceiverType", queryParameters);
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
		RobloxDatabase.RobloxPushNotifications.Update("ReceiverTypes_UpdateReceiverTypeByID", queryParameters);
	}

	internal static ICollection<ReceiverTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("ReceiverTypes_GetReceiverTypesByIDs", ids, BuildDAL);
	}

	internal static ReceiverTypeDAL GetReceiverTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxPushNotifications.Lookup("ReceiverTypes_GetReceiverTypeByValue", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ReceiverTypeDAL> GetOrCreateReceiverType(string value)
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
		return RobloxDatabase.RobloxPushNotifications.GetOrCreate("ReceiverTypes_GetOrCreateReceiverType", BuildDAL, queryParameters);
	}
}
