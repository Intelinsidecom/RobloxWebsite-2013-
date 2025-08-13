using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Studio.Entities;

internal class UniverseCloudEditStatusDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxStudio;

	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal bool IsEnabled { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UniverseCloudEditStatusDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UniverseCloudEditStatusDAL
		{
			ID = (long)record["ID"],
			UniverseID = (long)record["UniverseID"],
			IsEnabled = (bool)record["IsEnabled"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxStudio.Delete("UniverseCloudEditStatuses_DeleteUniverseCloudEditStatusByID", ID);
	}

	internal static UniverseCloudEditStatusDAL Get(long id)
	{
		return RobloxDatabase.RobloxStudio.Get("UniverseCloudEditStatuses_GetUniverseCloudEditStatusByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxStudio.Insert<long>("UniverseCloudEditStatuses_InsertUniverseCloudEditStatus", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxStudio.Update("UniverseCloudEditStatuses_UpdateUniverseCloudEditStatusByID", queryParameters);
	}

	internal static ICollection<UniverseCloudEditStatusDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxStudio.MultiGet("UniverseCloudEditStatuses_GetUniverseCloudEditStatusesByIDs", ids, BuildDAL);
	}

	internal static UniverseCloudEditStatusDAL GetUniverseCloudEditStatusByUniverseID(long universeID)
	{
		if (universeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeID)
		};
		return RobloxDatabase.RobloxStudio.Lookup("UniverseCloudEditStatuses_GetUniverseCloudEditStatusByUniverseID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<UniverseCloudEditStatusDAL> GetOrCreateUniverseCloudEditStatus(long universeID)
	{
		if (universeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UniverseID", universeID)
		};
		return RobloxDatabase.RobloxStudio.GetOrCreate("UniverseCloudEditStatuses_GetOrCreateUniverseCloudEditStatus", BuildDAL, queryParameters);
	}
}
