using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Entities;

internal class NotificationBandDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal int ID { get; set; }

	internal short NotificationSourceTypeID { get; set; }

	internal short ReceiverDestinationTypeID { get; set; }

	internal bool IsEnabledByDefault { get; set; }

	internal bool IsOverridable { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static NotificationBandDAL BuildDAL(IDictionary<string, object> record)
	{
		return new NotificationBandDAL
		{
			ID = (int)record["ID"],
			NotificationSourceTypeID = (short)record["NotificationSourceTypeID"],
			ReceiverDestinationTypeID = (short)record["ReceiverDestinationTypeID"],
			IsEnabledByDefault = (bool)record["IsEnabledByDefault"],
			IsOverridable = (bool)record["IsOverridable"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("NotificationBands_DeleteNotificationBandByID", ID);
	}

	internal static NotificationBandDAL Get(int id)
	{
		return RobloxDatabase.RobloxNotifications.Get("NotificationBands_GetNotificationBandByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@NotificationSourceTypeID", NotificationSourceTypeID),
			new SqlParameter("@ReceiverDestinationTypeID", ReceiverDestinationTypeID),
			new SqlParameter("@IsEnabledByDefault", IsEnabledByDefault),
			new SqlParameter("@IsOverridable", IsOverridable),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<int>("NotificationBands_InsertNotificationBand", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@NotificationSourceTypeID", NotificationSourceTypeID),
			new SqlParameter("@ReceiverDestinationTypeID", ReceiverDestinationTypeID),
			new SqlParameter("@IsEnabledByDefault", IsEnabledByDefault),
			new SqlParameter("@IsOverridable", IsOverridable),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxNotifications.Update("NotificationBands_UpdateNotificationBandByID", queryParameters);
	}

	internal static ICollection<NotificationBandDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("NotificationBands_GetNotificationBandsByIDs", ids, BuildDAL);
	}

	internal static NotificationBandDAL GetNotificationBandByNotificationSourceTypeIDAndReceiverDestinationTypeID(short notificationSourceTypeID, short receiverDestinationTypeID)
	{
		if (notificationSourceTypeID == 0)
		{
			return null;
		}
		if (receiverDestinationTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@NotificationSourceTypeID", notificationSourceTypeID),
			new SqlParameter("@ReceiverDestinationTypeID", receiverDestinationTypeID)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("NotificationBands_GetNotificationBandByNotificationSourceTypeIDAndReceiverDestinationTypeID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetNotificationBandIDsByNotificationSourceTypeIDPaged(short notificationSourceTypeID, int startRowIndex, int maximumRows)
	{
		if (notificationSourceTypeID == 0)
		{
			throw new ArgumentException("Parameter 'notificationSourceTypeID' cannot be null, empty or the default value.");
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
			new SqlParameter("@NotificationSourceTypeID", notificationSourceTypeID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxNotifications.GetIDCollection<int>("NotificationBands_GetNotificationBandIDsByNotificationSourceTypeID_Paged", queryParameters);
	}

	internal static ICollection<int> GetNotificationBandIDsByReceiverDestinationTypeIDPaged(short receiverDestinationTypeID, int startRowIndex, int maximumRows)
	{
		if (receiverDestinationTypeID == 0)
		{
			throw new ArgumentException("Parameter 'receiverDestinationTypeID' cannot be null, empty or the default value.");
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
			new SqlParameter("@ReceiverDestinationTypeID", receiverDestinationTypeID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxNotifications.GetIDCollection<int>("NotificationBands_GetNotificationBandIDsByReceiverDestinationTypeID_Paged", queryParameters);
	}
}
