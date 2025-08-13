using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

internal class LocationDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxFileLocations.GetConnectionString();

	internal short ID { get; set; }

	internal byte LocationTypeID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	private static LocationDAL GetDALFromReader(SqlDataReader reader)
	{
		LocationDAL dal = new LocationDAL
		{
			ID = (short)reader["ID"],
			LocationTypeID = (byte)reader["LocationTypeID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static LocationDAL BuildDAL(SqlDataReader reader)
	{
		LocationDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<LocationDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<LocationDAL> dals = new List<LocationDAL>();
		while (reader.Read())
		{
			LocationDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "Locations_DeleteLocationByID", queryParameters));
	}

	internal static LocationDAL Get(short id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Locations_GetLocationByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@LocationTypeID", LocationTypeID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "Locations_InsertLocation", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<short>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@LocationTypeID", LocationTypeID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "Locations_UpdateLocationByID", queryParameters));
	}

	internal static ICollection<LocationDAL> MultiGet(ICollection<short> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "Locations_GetLocationsByIDs"), ids, BuildDALCollection);
	}

	internal static LocationDAL GetLocationByLocationTypeIDAndValue(byte locationTypeID, string value)
	{
		if (locationTypeID == 0)
		{
			return null;
		}
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@LocationTypeID", locationTypeID),
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Locations_GetLocationByLocationTypeIDAndValue", queryParameters), BuildDAL);
	}
}
