using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class ReceiverTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal int ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static ReceiverTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverTypeDAL
		{
			ID = (int)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("ReceiverTypes_DeleteReceiverTypeByID", ID);
	}

	internal static ReceiverTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxNotifications.Get("ReceiverTypes_GetReceiverTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<int>("ReceiverTypes_InsertReceiverType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxNotifications.Update("ReceiverTypes_UpdateReceiverTypeByID", queryParameters);
	}

	internal static ICollection<ReceiverTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("ReceiverTypes_GetReceiverTypesByIDs", ids, BuildDAL);
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
		return RobloxDatabase.RobloxNotifications.Lookup("ReceiverTypes_GetReceiverTypeByValue", BuildDAL, queryParameters);
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
		return RobloxDatabase.RobloxNotifications.GetOrCreate("ReceiverTypes_GetOrCreateReceiverType", BuildDAL, queryParameters);
	}
}
