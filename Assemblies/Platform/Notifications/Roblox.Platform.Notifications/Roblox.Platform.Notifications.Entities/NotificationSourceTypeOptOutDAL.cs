using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Entities;

internal class NotificationSourceTypeOptOutDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal long ID { get; set; }

	internal long ReceiverID { get; set; }

	internal short NotificationSourceTypeID { get; set; }

	internal DateTime Created { get; set; }

	private static NotificationSourceTypeOptOutDAL BuildDAL(IDictionary<string, object> record)
	{
		return new NotificationSourceTypeOptOutDAL
		{
			ID = (long)record["ID"],
			ReceiverID = (long)record["ReceiverID"],
			NotificationSourceTypeID = (short)record["NotificationSourceTypeID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("NotificationSourceTypeOptOuts_DeleteNotificationSourceTypeOptOutByID", ID);
	}

	internal static NotificationSourceTypeOptOutDAL Get(long id)
	{
		return RobloxDatabase.RobloxNotifications.Get("NotificationSourceTypeOptOuts_GetNotificationSourceTypeOptOutByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@NotificationSourceTypeID", NotificationSourceTypeID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<long>("NotificationSourceTypeOptOuts_InsertNotificationSourceTypeOptOut", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@NotificationSourceTypeID", NotificationSourceTypeID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxNotifications.Update("NotificationSourceTypeOptOuts_UpdateNotificationSourceTypeOptOutByID", queryParameters);
	}

	internal static ICollection<NotificationSourceTypeOptOutDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("NotificationSourceTypeOptOuts_GetNotificationSourceTypeOptOutsByIDs", ids, BuildDAL);
	}

	internal static NotificationSourceTypeOptOutDAL GetNotificationSourceTypeOptOutByReceiverIDAndNotificationSourceTypeID(long receiverID, short notificationSourceTypeID)
	{
		if (receiverID == 0L)
		{
			return null;
		}
		if (notificationSourceTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ReceiverID", receiverID),
			new SqlParameter("@NotificationSourceTypeID", notificationSourceTypeID)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("NotificationSourceTypeOptOuts_GetNotificationSourceTypeOptOutByReceiverIDAndNotificationSourceTypeID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetNotificationSourceTypeOptOutIDsByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
	{
		if (receiverID == 0L)
		{
			throw new ArgumentException("Parameter 'receiverID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ReceiverID", receiverID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxNotifications.GetIDCollection<long>("NotificationSourceTypeOptOuts_GetNotificationSourceTypeOptOutIDsByReceiverID_Paged", queryParameters);
	}
}
