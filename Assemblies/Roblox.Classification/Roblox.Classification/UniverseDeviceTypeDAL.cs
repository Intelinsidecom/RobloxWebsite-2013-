using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Classification;

public class UniverseDeviceTypeDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal long DeviceTypes { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UniverseDeviceTypeDAL BuildDAL(SqlDataReader reader)
	{
		UniverseDeviceTypeDAL dal = new UniverseDeviceTypeDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UniverseID = (long)reader["UniverseID"];
			dal.DeviceTypes = (long)reader["DeviceTypes"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static UniverseDeviceTypeDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UniverseDeviceTypes_GetUniverseDeviceTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@DeviceTypes", DeviceTypes),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "UniverseDeviceTypes_InsertUniverseDeviceType", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@DeviceTypes", DeviceTypes),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "UniverseDeviceTypes_UpdateUniverseDeviceTypeByID", queryParameters));
	}

	internal static EntityHelper.GetOrCreateDALWrapper<UniverseDeviceTypeDAL> GetOrCreateUniverseDeviceType(long universeId)
	{
		if (universeId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "UniverseDeviceTypes_GetOrCreateUniverseDeviceType", queryParameters), BuildDAL);
	}

	internal static UniverseDeviceTypeDAL GetUniverseDeviceTypeByUniverseID(long universeId)
	{
		if (universeId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UniverseDeviceTypes_GetUniverseDeviceTypeByUniverseID", queryParameters), BuildDAL);
	}
}
