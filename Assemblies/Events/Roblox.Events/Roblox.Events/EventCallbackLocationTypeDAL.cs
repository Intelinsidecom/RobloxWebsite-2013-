using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Events.Properties;
namespace Roblox.Events {
    internal class EventCallbackLocationTypeDAL

{
    internal byte ID { get; set; }

    internal string Value { get; set; }

    internal DateTime Created { get; set; }

    internal DateTime Updated { get; set; }

    private static string _DbConnectionString => Settings.Default.Roblox_ConnectionString;

    private static EventCallbackLocationTypeDAL GetDALFromReader(Microsoft.Data.SqlClient.SqlDataReader reader)
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

    private static EventCallbackLocationTypeDAL BuildDAL(Microsoft.Data.SqlClient.SqlDataReader reader)
    {
        EventCallbackLocationTypeDAL dal = null;
        while (reader.Read())
        {
            dal = GetDALFromReader(reader);
        }
        return dal;
    }

    private static List<EventCallbackLocationTypeDAL> BuildDALCollection(Microsoft.Data.SqlClient.SqlDataReader reader)
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
        Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[1]
        {
            new Microsoft.Data.SqlClient.SqlParameter("@ID", ID)
        };
        EntityHelper.DoEntityDALAction(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_DeleteEventCallbackLocationTypeByID", queryParameters));
    }

    internal static EventCallbackLocationTypeDAL Get(byte id)
    {
        if (id == 0)
        {
            return null;
        }
        Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[1]
        {
            new Microsoft.Data.SqlClient.SqlParameter("@ID", id)
        };
        return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_GetEventCallbackLocationTypeByID", queryParameters), BuildDAL);
    }

    internal void Insert()
    {
        Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[3]
        {
            new Microsoft.Data.SqlClient.SqlParameter("@Value", Value),
            new Microsoft.Data.SqlClient.SqlParameter("@Created", Created),
            new Microsoft.Data.SqlClient.SqlParameter("@Updated", Updated)
        };
        DbInfo dbInfo = new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_InsertEventCallbackLocationType", new Microsoft.Data.SqlClient.SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
        ID = EntityHelper.DoEntityDALInsert<byte>(dbInfo);
    }

    internal void Update()
    {
        Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[4]
        {
            new Microsoft.Data.SqlClient.SqlParameter("@ID", ID),
            new Microsoft.Data.SqlClient.SqlParameter("@Value", Value),
            new Microsoft.Data.SqlClient.SqlParameter("@Created", Created),
            new Microsoft.Data.SqlClient.SqlParameter("@Updated", Updated)
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
        Microsoft.Data.SqlClient.SqlParameter[] queryParameters = new Microsoft.Data.SqlClient.SqlParameter[1]
        {
            new Microsoft.Data.SqlClient.SqlParameter("@Value", value)
        };
        return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "EventCallbackLocationTypes_GetEventCallbackLocationTypeByValue", queryParameters), BuildDAL);
    }
}


}
