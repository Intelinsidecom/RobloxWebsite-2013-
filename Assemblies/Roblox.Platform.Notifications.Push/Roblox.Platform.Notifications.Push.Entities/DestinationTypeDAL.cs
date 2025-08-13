using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Notifications.Push.Entities;

internal class DestinationTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPushNotifications;

	internal int ID { get; set; }

	internal int ApplicationTypeID { get; set; }

	internal int PlatformTypeID { get; set; }

	internal string RegistrationEndpoint { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static DestinationTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new DestinationTypeDAL
		{
			ID = (int)record["ID"],
			ApplicationTypeID = (int)record["ApplicationTypeID"],
			PlatformTypeID = (int)record["PlatformTypeID"],
			RegistrationEndpoint = (string)record["RegistrationEndpoint"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPushNotifications.Delete("DestinationTypes_DeleteDestinationTypeByID", ID);
	}

	internal static DestinationTypeDAL Get(int id)
	{
		return RobloxDatabase.RobloxPushNotifications.Get("DestinationTypes_GetDestinationTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@ApplicationTypeID", ApplicationTypeID),
			new SqlParameter("@PlatformTypeID", PlatformTypeID),
			new SqlParameter("@RegistrationEndpoint", RegistrationEndpoint),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxPushNotifications.Insert<int>("DestinationTypes_InsertDestinationType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@ApplicationTypeID", ApplicationTypeID),
			new SqlParameter("@PlatformTypeID", PlatformTypeID),
			new SqlParameter("@RegistrationEndpoint", RegistrationEndpoint),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxPushNotifications.Update("DestinationTypes_UpdateDestinationTypeByID", queryParameters);
	}

	internal static ICollection<DestinationTypeDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxPushNotifications.MultiGet("DestinationTypes_GetDestinationTypesByIDs", ids, BuildDAL);
	}

	internal static DestinationTypeDAL GetDestinationTypeByApplicationTypeIDAndPlatformTypeID(int applicationTypeID, int platformTypeID)
	{
		if (applicationTypeID == 0)
		{
			return null;
		}
		if (platformTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@ApplicationTypeID", applicationTypeID),
			new SqlParameter("@PlatformTypeID", platformTypeID)
		};
		return RobloxDatabase.RobloxPushNotifications.Lookup("DestinationTypes_GetDestinationTypeByApplicationTypeIDAndPlatformTypeID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetDestinationTypeIDsByApplicationTypeIDPaged(int applicationTypeID, int startRowIndex, int maximumRows)
	{
		if (applicationTypeID == 0)
		{
			throw new ArgumentException("Parameter 'applicationTypeID' cannot be null, empty or the default value.");
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
			new SqlParameter("@ApplicationTypeID", applicationTypeID),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxPushNotifications.GetIDCollection<int>("DestinationTypes_GetDestinationTypeIDsByApplicationTypeID_Paged", queryParameters);
	}
}
