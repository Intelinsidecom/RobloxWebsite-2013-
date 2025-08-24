using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Core.Entities;

internal class ReceiverDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal long ID { get; set; }

	internal int ReceiverTypeID { get; set; }

	internal long ReceiverTargetID { get; set; }

	internal DateTime Created { get; set; }

	private static ReceiverDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverDAL
		{
			ID = (long)record["ID"],
			ReceiverTypeID = (int)record["ReceiverTypeID"],
			ReceiverTargetID = (long)record["ReceiverTargetID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("Receivers_DeleteReceiverByID", ID);
	}

	internal static ReceiverDAL Get(long id)
	{
		return RobloxDatabase.RobloxNotifications.Get("Receivers_GetReceiverByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ReceiverTypeID", ReceiverTypeID),
			new SqlParameter("@ReceiverTargetID", ReceiverTargetID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<long>("Receivers_InsertReceiver", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReceiverTypeID", ReceiverTypeID),
			new SqlParameter("@ReceiverTargetID", ReceiverTargetID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxNotifications.Update("Receivers_UpdateReceiverByID", queryParameters);
	}

	internal static ICollection<ReceiverDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("Receivers_GetReceiversByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ReceiverDAL> GetOrCreateReceiver(int receiverTypeID, long receiverTargetID)
	{
		if (receiverTypeID == 0)
		{
			return null;
		}
		if (receiverTargetID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ReceiverTypeID", receiverTypeID),
			new SqlParameter("@ReceiverTargetID", receiverTargetID)
		};
		return RobloxDatabase.RobloxNotifications.GetOrCreate("Receivers_GetOrCreateReceiver", BuildDAL, queryParameters);
	}
}
