using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Events.Properties;

namespace Roblox.Platform.Events;

internal class EventCallbackLocationDAL
{
	internal long ID { get; set; }

	internal string Value { get; set; }

	internal byte EventCallbackLocationTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.Roblox_ConnectionString;

	private static EventCallbackLocationDAL GetDALFromReader(SqlDataReader reader)
	{
		EventCallbackLocationDAL dal = new EventCallbackLocationDAL
		{
			ID = (long)reader["ID"],
			Value = (string)reader["Value"],
			EventCallbackLocationTypeID = (byte)reader["EventCallbackLocationTypeID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static EventCallbackLocationDAL BuildDAL(SqlDataReader reader)
	{
		EventCallbackLocationDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<EventCallbackLocationDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<EventCallbackLocationDAL> dals = new List<EventCallbackLocationDAL>();
		while (reader.Read())
		{
			EventCallbackLocationDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "EventCallbackLocations_DeleteEventCallbackLocationByID", queryParameters));
	}

	internal static EventCallbackLocationDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocations_GetEventCallbackLocationByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@EventCallbackLocationTypeID", EventCallbackLocationTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "EventCallbackLocations_InsertEventCallbackLocation", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@EventCallbackLocationTypeID", EventCallbackLocationTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "EventCallbackLocations_UpdateEventCallbackLocationByID", queryParameters));
	}

	internal static ICollection<EventCallbackLocationDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "EventCallbackLocations_GetEventCallbackLocationsByIDs"), ids, BuildDALCollection);
	}

	internal static EventCallbackLocationDAL GetEventCallbackLocationByValueAndEventCallbackLocationTypeID(string value, byte eventCallbackLocationTypeID)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		if (eventCallbackLocationTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Value", value),
			new SqlParameter("@EventCallbackLocationTypeID", eventCallbackLocationTypeID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocations_GetEventCallbackLocationByValueAndEventCallbackLocationTypeID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<EventCallbackLocationDAL> GetOrCreateEventCallbackLocation(string value, byte eventCallbackLocationTypeID)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		if (eventCallbackLocationTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@Value", value),
			new SqlParameter("@EventCallbackLocationTypeID", eventCallbackLocationTypeID)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocations_GetOrCreateEventCallbackLocation", queryParameters), BuildDAL);
	}
}
