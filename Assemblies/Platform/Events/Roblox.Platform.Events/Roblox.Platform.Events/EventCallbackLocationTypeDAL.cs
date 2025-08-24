using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Events.Properties;

namespace Roblox.Platform.Events;

internal class EventCallbackLocationTypeDAL
{
	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.Roblox_ConnectionString;

	private static EventCallbackLocationTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		EventCallbackLocationTypeDAL dal = new EventCallbackLocationTypeDAL
		{
			ID = (byte)reader["ID"],
			Value = (string)reader["Value"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if ((ulong)dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static EventCallbackLocationTypeDAL BuildDAL(SqlDataReader reader)
	{
		EventCallbackLocationTypeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<EventCallbackLocationTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<EventCallbackLocationTypeDAL> dals = new List<EventCallbackLocationTypeDAL>();
		while (reader.Read())
		{
			EventCallbackLocationTypeDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_DeleteEventCallbackLocationTypeByID", queryParameters));
	}

	internal static EventCallbackLocationTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_GetEventCallbackLocationTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_InsertEventCallbackLocationType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_UpdateEventCallbackLocationTypeByID", queryParameters));
	}

	internal static ICollection<EventCallbackLocationTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_GetEventCallbackLocationTypesByIDs"), ids, BuildDALCollection);
	}

	internal static EventCallbackLocationTypeDAL GetEventCallbackLocationTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_GetEventCallbackLocationTypeByValue", queryParameters), BuildDAL);
	}
}
