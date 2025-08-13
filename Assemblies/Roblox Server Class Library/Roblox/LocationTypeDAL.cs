using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

internal class LocationTypeDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxFileLocations.GetConnectionString();

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static LocationTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		LocationTypeDAL dal = new LocationTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static LocationTypeDAL BuildDAL(SqlDataReader reader)
	{
		LocationTypeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<LocationTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<LocationTypeDAL> dals = new List<LocationTypeDAL>();
		while (reader.Read())
		{
			LocationTypeDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "LocationTypes_DeleteLocationTypeByID", queryParameters));
	}

	internal static LocationTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "LocationTypes_GetLocationTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "LocationTypes_InsertLocationType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "LocationTypes_UpdateLocationTypeByID", queryParameters));
	}

	internal static ICollection<LocationTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "LocationTypes_GetLocationTypesByIDs"), ids, BuildDALCollection);
	}

	internal static LocationTypeDAL GetLocationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "LocationTypes_GetLocationTypeByValue", queryParameters), BuildDAL);
	}
}
