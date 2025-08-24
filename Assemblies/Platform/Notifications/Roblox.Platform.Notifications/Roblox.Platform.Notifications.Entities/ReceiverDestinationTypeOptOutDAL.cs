using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Entities;

internal class ReceiverDestinationTypeOptOutDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxNotifications;

	internal long ID { get; set; }

	internal long ReceiverID { get; set; }

	internal short ReceiverDestinationTypeID { get; set; }

	internal DateTime Created { get; set; }

	private static ReceiverDestinationTypeOptOutDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ReceiverDestinationTypeOptOutDAL
		{
			ID = (long)record["ID"],
			ReceiverID = (long)record["ReceiverID"],
			ReceiverDestinationTypeID = (short)record["ReceiverDestinationTypeID"],
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxNotifications.Delete("ReceiverDestinationTypeOptOuts_DeleteReceiverDestinationTypeOptOutByID", ID);
	}

	internal static ReceiverDestinationTypeOptOutDAL Get(long id)
	{
		return RobloxDatabase.RobloxNotifications.Get("ReceiverDestinationTypeOptOuts_GetReceiverDestinationTypeOptOutByID", id, BuildDAL);
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
			new SqlParameter("@ReceiverDestinationTypeID", ReceiverDestinationTypeID),
			new SqlParameter("@Created", Created)
		};
		ID = RobloxDatabase.RobloxNotifications.Insert<long>("ReceiverDestinationTypeOptOuts_InsertReceiverDestinationTypeOptOut", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ReceiverID", ReceiverID),
			new SqlParameter("@ReceiverDestinationTypeID", ReceiverDestinationTypeID),
			new SqlParameter("@Created", Created)
		};
		RobloxDatabase.RobloxNotifications.Update("ReceiverDestinationTypeOptOuts_UpdateReceiverDestinationTypeOptOutByID", queryParameters);
	}

	internal static ICollection<ReceiverDestinationTypeOptOutDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxNotifications.MultiGet("ReceiverDestinationTypeOptOuts_GetReceiverDestinationTypeOptOutsByIDs", ids, BuildDAL);
	}

	internal static ReceiverDestinationTypeOptOutDAL GetReceiverDestinationTypeOptOutByReceiverIDAndReceiverDestinationTypeID(long receiverID, int receiverDestinationTypeID)
	{
		if (receiverID == 0L)
		{
			return null;
		}
		if (receiverDestinationTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ReceiverID", receiverID),
			new SqlParameter("@ReceiverDestinationTypeID", receiverDestinationTypeID)
		};
		return RobloxDatabase.RobloxNotifications.Lookup("ReceiverDestinationTypeOptOuts_GetReceiverDestinationTypeOptOutByReceiverIDAndReceiverDestinationTypeID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetReceiverDestinationTypeOptOutIDsByReceiverIDPaged(long receiverID, long startRowIndex, long maximumRows)
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
		return RobloxDatabase.RobloxNotifications.GetIDCollection<long>("ReceiverDestinationTypeOptOuts_GetReceiverDestinationTypeOptOutIDsByReceiverID_Paged", queryParameters);
	}
}
