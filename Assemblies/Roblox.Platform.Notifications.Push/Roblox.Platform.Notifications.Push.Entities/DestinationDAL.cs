using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class DestinationDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal long ID { get; set; }

	internal int DestinationTypeID { get; set; }

	internal string ExternalServiceDestinationID { get; set; }

	internal string NotificationDeliveryEndpoint { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal byte[] ExternalServiceDestinationIDHash { get; set; }

	private static DestinationDAL BuildDAL(IDictionary<string, object> record)
	{
		return new DestinationDAL
		{
			ID = (long)record["ID"],
			DestinationTypeID = (int)record["DestinationTypeID"],
			ExternalServiceDestinationID = (string)record["ExternalServiceDestinationID"],
			NotificationDeliveryEndpoint = (string)record["NotificationDeliveryEndpoint"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			ExternalServiceDestinationIDHash = (byte[])record["ExternalServiceDestinationIDHash"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("Destinations_DeleteDestinationByID", ID);
	}

	internal static DestinationDAL Get(long id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("Destinations_GetDestinationByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@DestinationTypeID", DestinationTypeID),
			new SqlParameter("@ExternalServiceDestinationID", ExternalServiceDestinationID),
			new SqlParameter("@NotificationDeliveryEndpoint", string.IsNullOrEmpty(NotificationDeliveryEndpoint) ? ((IConvertible)DBNull.Value) : ((IConvertible)NotificationDeliveryEndpoint)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@ExternalServiceDestinationIDHash", ((object)ExternalServiceDestinationIDHash) ?? ((object)DBNull.Value))
		};
		ID = RobloxDatabase.RobloxPushNotifications.Insert<long>("Destinations_InsertDestination", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@DestinationTypeID", DestinationTypeID),
			new SqlParameter("@ExternalServiceDestinationID", ExternalServiceDestinationID),
			new SqlParameter("@NotificationDeliveryEndpoint", string.IsNullOrEmpty(NotificationDeliveryEndpoint) ? ((IConvertible)DBNull.Value) : ((IConvertible)NotificationDeliveryEndpoint)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@ExternalServiceDestinationIDHash", ((object)ExternalServiceDestinationIDHash) ?? ((object)DBNull.Value))
		};
		RobloxDatabase.RobloxPushNotifications.Update("Destinations_UpdateDestinationByID", queryParameters);
	}

	internal static ICollection<DestinationDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("Destinations_GetDestinationsByIDs", ids, BuildDAL);
	}

	internal static DestinationDAL GetDestinationByDestinationTypeIDAndExternalServiceDestinationID(int destinationTypeID, string externalServiceDestinationID)
	{
		if (destinationTypeID == 0)
		{
			return null;
		}
		if (string.IsNullOrEmpty(externalServiceDestinationID))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@DestinationTypeID", destinationTypeID),
			new SqlParameter("@ExternalServiceDestinationID", externalServiceDestinationID)
		};
		return RobloxDatabase.RobloxPushNotifications.Lookup("Destinations_GetDestinationByDestinationTypeIDAndExternalServiceDestinationID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetDestinationIDsByDestinationTypeIDAndExternalServiceDestinationIDHash(int destinationTypeID, byte[] externalServiceDestinationIDHash, int count, long exclusiveStartDestinationId)
	{
		if (destinationTypeID == 0)
		{
			throw new ArgumentException("Parameter 'destinationTypeID' cannot be null, empty or the default value.");
		}
		if (externalServiceDestinationIDHash == null)
		{
			throw new ArgumentException("Parameter 'externalServiceDestinationIDHash' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartDestinationId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartDestinationID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@DestinationTypeID", destinationTypeID),
			new SqlParameter("@ExternalServiceDestinationIDHash", externalServiceDestinationIDHash),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartDestinationID", exclusiveStartDestinationId)
		};
		return RobloxDatabase.RobloxPushNotifications.GetIDCollection<long>("Destinations_GetDestinationIDsByDestinationTypeIDAndExternalServiceDestinationIDHash", queryParameters);
	}
}
