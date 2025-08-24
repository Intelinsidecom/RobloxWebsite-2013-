using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class ReceiverDestinationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal short ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static ReceiverDestinationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverDestinationTypeDAL
		{
			ID = (short)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("ReceiverDestinationTypes_DeleteReceiverDestinationTypeByID", ID);
	}

	internal static ReceiverDestinationTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxNotifications.Get("ReceiverDestinationTypes_GetReceiverDestinationTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxNotifications.Insert<short>("ReceiverDestinationTypes_InsertReceiverDestinationType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxNotifications.Update("ReceiverDestinationTypes_UpdateReceiverDestinationTypeByID", queryParameters);
	}

	internal static ICollection<ReceiverDestinationTypeDAL> MultiGet(ICollection<short> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("ReceiverDestinationTypes_GetReceiverDestinationTypesByIDs", ids, BuildDAL);
	}

	internal static ReceiverDestinationTypeDAL GetReceiverDestinationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("ReceiverDestinationTypes_GetReceiverDestinationTypeByValue", BuildDAL, queryParameters);
	}
}
