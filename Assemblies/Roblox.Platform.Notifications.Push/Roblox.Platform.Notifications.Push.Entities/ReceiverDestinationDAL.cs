using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class ReceiverDestinationDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal long ID { get; set; }

	internal int ReceiverTypeID { get; set; }

	internal long ReceiverTargetID { get; set; }

	internal long DestinationID { get; set; }

	internal bool IsAuthorizedByReceiver { get; set; }

	internal bool IsActive { get; set; }

	internal int AuthenticationTypeID { get; set; }

	internal string AuthenticationValue { get; set; }

	internal string Name { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ReceiverDestinationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverDestinationDAL
		{
			ID = (long)record["ID"],
			ReceiverTypeID = (int)record["ReceiverTypeID"],
			ReceiverTargetID = (long)record["ReceiverTargetID"],
			DestinationID = (long)record["DestinationID"],
			IsAuthorizedByReceiver = (bool)record["IsAuthorizedByReceiver"],
			IsActive = (bool)record["IsActive"],
			AuthenticationTypeID = (int)record["AuthenticationTypeID"],
			AuthenticationValue = (string)record["AuthenticationValue"],
			Name = (string)record["Name"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("ReceiverDestinations_DeleteReceiverDestinationByID", ID);
	}

	internal static ReceiverDestinationDAL Get(long id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("ReceiverDestinations_GetReceiverDestinationByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[11]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ReceiverTypeID", ReceiverTypeID),
			new SqlParameter("@ReceiverTargetID", ReceiverTargetID),
			new SqlParameter("@DestinationID", DestinationID),
			new SqlParameter("@IsAuthorizedByReceiver", IsAuthorizedByReceiver),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@AuthenticationTypeID", AuthenticationTypeID),
			new SqlParameter("@AuthenticationValue", string.IsNullOrEmpty(AuthenticationValue) ? ((IConvertible)DBNull.Value) : ((IConvertible)AuthenticationValue)),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxPushNotifications.Insert<long>("ReceiverDestinations_InsertReceiverDestination", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[11]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReceiverTypeID", ReceiverTypeID),
			new SqlParameter("@ReceiverTargetID", ReceiverTargetID),
			new SqlParameter("@DestinationID", DestinationID),
			new SqlParameter("@IsAuthorizedByReceiver", IsAuthorizedByReceiver),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@AuthenticationTypeID", AuthenticationTypeID),
			new SqlParameter("@AuthenticationValue", string.IsNullOrEmpty(AuthenticationValue) ? ((IConvertible)DBNull.Value) : ((IConvertible)AuthenticationValue)),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxPushNotifications.Update("ReceiverDestinations_UpdateReceiverDestinationByID", queryParameters);
	}

	internal static ICollection<ReceiverDestinationDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("ReceiverDestinations_GetReceiverDestinationsByIDs", ids, BuildDAL);
	}

	internal static ReceiverDestinationDAL GetReceiverDestinationByReceiverTypeIDReceiverTargetIDAndDestinationID(int receiverTypeID, long receiverTargetID, long destinationID)
	{
		if (receiverTypeID == 0)
		{
			return null;
		}
		if (receiverTargetID == 0L)
		{
			return null;
		}
		if (destinationID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ReceiverTypeID", receiverTypeID),
			new SqlParameter("@ReceiverTargetID", receiverTargetID),
			new SqlParameter("@DestinationID", destinationID)
		};
		return RobloxDatabase.RobloxPushNotifications.Lookup("ReceiverDestinations_GetReceiverDestinationByReceiverTypeIDReceiverTargetIDAndDestinationID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetReceiverDestinationIDsByDestinationIDAndIsActivePaged(long destinationID, bool isActive, long startRowIndex, long maximumRows)
	{
		if (destinationID == 0L)
		{
			throw new ArgumentException("Parameter 'destinationID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@DestinationID", destinationID),
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxPushNotifications.GetIDCollection<long>("ReceiverDestinations_GetReceiverDestinationIDsByDestinationIDAndIsActive_Paged", queryParameters);
	}

	internal static ICollection<long> GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDAndIsActivePaged(int receiverTypeID, long receiverTargetID, bool isActive, long startRowIndex, long maximumRows)
	{
		if (receiverTypeID == 0)
		{
			throw new ArgumentException("Parameter 'receiverTypeID' cannot be null, empty or the default value.");
		}
		if (receiverTargetID == 0L)
		{
			throw new ArgumentException("Parameter 'receiverTargetID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ReceiverTypeID", receiverTypeID),
			new SqlParameter("@ReceiverTargetID", receiverTargetID),
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxPushNotifications.GetIDCollection<long>("ReceiverDestinations_GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDAndIsActive_Paged", queryParameters);
	}

	internal static ICollection<long> GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverAndIsActivePaged(int receiverTypeID, long receiverTargetID, bool isAuthorizedByReceiver, bool isActive, long startRowIndex, long maximumRows)
	{
		if (receiverTypeID == 0)
		{
			throw new ArgumentException("Parameter 'receiverTypeID' cannot be null, empty or the default value.");
		}
		if (receiverTargetID == 0L)
		{
			throw new ArgumentException("Parameter 'receiverTargetID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ReceiverTypeID", receiverTypeID),
			new SqlParameter("@ReceiverTargetID", receiverTargetID),
			new SqlParameter("@IsAuthorizedByReceiver", isAuthorizedByReceiver),
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxPushNotifications.GetIDCollection<long>("ReceiverDestinations_GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDIsAuthorizedByReceiverAndIsActive_Paged", queryParameters);
	}

	internal static ICollection<long> GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAndAuthenticationValuePaged(int receiverTypeID, long receiverTargetID, int authenticationTypeID, string authenticationValue, long startRowIndex, long maximumRows)
	{
		if (receiverTypeID == 0)
		{
			throw new ArgumentException("Parameter 'receiverTypeID' cannot be null, empty or the default value.");
		}
		if (receiverTargetID == 0L)
		{
			throw new ArgumentException("Parameter 'receiverTargetID' cannot be null, empty or the default value.");
		}
		if (authenticationTypeID == 0)
		{
			throw new ArgumentException("Parameter 'authenticationTypeID' cannot be null, empty or the default value.");
		}
		if (string.IsNullOrEmpty(authenticationValue))
		{
			throw new ArgumentException("Parameter 'authenticationValue' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ReceiverTypeID", receiverTypeID),
			new SqlParameter("@ReceiverTargetID", receiverTargetID),
			new SqlParameter("@AuthenticationTypeID", authenticationTypeID),
			new SqlParameter("@AuthenticationValue", string.IsNullOrEmpty(authenticationValue) ? ((IConvertible)DBNull.Value) : ((IConvertible)authenticationValue)),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxPushNotifications.GetIDCollection<long>("ReceiverDestinations_GetReceiverDestinationIDsByReceiverTypeIDReceiverTargetIDAuthenticationTypeIDAndAuthenticationValue_Paged", queryParameters);
	}
}
