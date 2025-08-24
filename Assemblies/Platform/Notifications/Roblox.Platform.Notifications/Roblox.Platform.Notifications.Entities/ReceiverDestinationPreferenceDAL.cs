using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Entities;

internal class ReceiverDestinationPreferenceDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal long ID { get; set; }

	internal long ReceiverID { get; set; }

	internal short NotificationSourceTypeID { get; set; }

	internal long DestinationID { get; set; }

	internal bool IsEnabled { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ReceiverDestinationPreferenceDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverDestinationPreferenceDAL
		{
			ID = (long)record["ID"],
			ReceiverID = (long)record["ReceiverID"],
			NotificationSourceTypeID = (short)record["NotificationSourceTypeID"],
			DestinationID = (long)record["DestinationID"],
			IsEnabled = (bool)record["IsEnabled"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("ReceiverDestinationPreferences_DeleteReceiverDestinationPreferenceByID", ID);
	}

	internal static ReceiverDestinationPreferenceDAL Get(long id)
	{
		return RobloxDatabase.RobloxNotifications.Get("ReceiverDestinationPreferences_GetReceiverDestinationPreferenceByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@NotificationSourceTypeID", NotificationSourceTypeID),
			new SqlParameter("@DestinationID", DestinationID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<long>("ReceiverDestinationPreferences_InsertReceiverDestinationPreference", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@NotificationSourceTypeID", NotificationSourceTypeID),
			new SqlParameter("@DestinationID", DestinationID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxNotifications.Update("ReceiverDestinationPreferences_UpdateReceiverDestinationPreferenceByID", queryParameters);
	}

	internal static ICollection<ReceiverDestinationPreferenceDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("ReceiverDestinationPreferences_GetReceiverDestinationPreferencesByIDs", ids, BuildDAL);
	}

	internal static ReceiverDestinationPreferenceDAL GetReceiverDestinationPreferenceByReceiverIDNotificationSourceTypeIDAndDestinationID(long receiverID, int notificationSourceTypeID, long destinationID)
	{
		if (receiverID == 0L)
		{
			return null;
		}
		if (notificationSourceTypeID == 0)
		{
			return null;
		}
		if (destinationID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ReceiverID", receiverID),
			new SqlParameter("@NotificationSourceTypeID", notificationSourceTypeID),
			new SqlParameter("@DestinationID", destinationID)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("ReceiverDestinationPreferences_GetReceiverDestinationPreferenceByReceiverIDNotificationSourceTypeIDAndDestinationID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetReceiverDestinationPreferenceIDsByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
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
		return RobloxDatabase.RobloxNotifications.GetIDCollection<long>("ReceiverDestinationPreferences_GetReceiverDestinationPreferenceIDsByReceiverID_Paged", queryParameters);
	}
}
