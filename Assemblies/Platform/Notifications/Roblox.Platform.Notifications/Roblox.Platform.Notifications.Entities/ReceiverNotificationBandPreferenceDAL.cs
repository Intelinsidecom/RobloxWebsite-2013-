using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Entities;

internal class ReceiverNotificationBandPreferenceDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal long ID { get; set; }

	internal long ReceiverID { get; set; }

	internal int NotificationBandID { get; set; }

	internal bool IsEnabled { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ReceiverNotificationBandPreferenceDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverNotificationBandPreferenceDAL
		{
			ID = (long)record["ID"],
			ReceiverID = (long)record["ReceiverID"],
			NotificationBandID = (int)record["NotificationBandID"],
			IsEnabled = (bool)record["IsEnabled"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("ReceiverNotificationBandPreferences_DeleteReceiverNotificationBandPreferenceByID", ID);
	}

	internal static ReceiverNotificationBandPreferenceDAL Get(long id)
	{
		return RobloxDatabase.RobloxNotifications.Get("ReceiverNotificationBandPreferences_GetReceiverNotificationBandPreferenceByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@NotificationBandID", NotificationBandID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<long>("ReceiverNotificationBandPreferences_InsertReceiverNotificationBandPreference", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@NotificationBandID", NotificationBandID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxNotifications.Update("ReceiverNotificationBandPreferences_UpdateReceiverNotificationBandPreferenceByID", queryParameters);
	}

	internal static ICollection<ReceiverNotificationBandPreferenceDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("ReceiverNotificationBandPreferences_GetReceiverNotificationBandPreferencesByIDs", ids, BuildDAL);
	}

	internal static ReceiverNotificationBandPreferenceDAL GetReceiverNotificationBandPreferenceByReceiverIDAndNotificationBandID(long receiverID, int notificationBandID)
	{
		if (receiverID == 0L)
		{
			return null;
		}
		if (notificationBandID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ReceiverID", receiverID),
			new SqlParameter("@NotificationBandID", notificationBandID)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("ReceiverNotificationBandPreferences_GetReceiverNotificationBandPreferenceByReceiverIDAndNotificationBandID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetReceiverNotificationBandPreferenceIDsByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
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
		return RobloxDatabase.RobloxNotifications.GetIDCollection<long>("ReceiverNotificationBandPreferences_GetReceiverNotificationBandPreferenceIDsByReceiverID_Paged", queryParameters);
	}
}
