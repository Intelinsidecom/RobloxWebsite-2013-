using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerStatusTypeDAL
{
	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static PrivateServerStatusTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		PrivateServerStatusTypeDAL dal = new PrivateServerStatusTypeDAL
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

	private static PrivateServerStatusTypeDAL BuildDAL(SqlDataReader reader)
	{
		PrivateServerStatusTypeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PrivateServerStatusTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PrivateServerStatusTypeDAL> dals = new List<PrivateServerStatusTypeDAL>();
		while (reader.Read())
		{
			PrivateServerStatusTypeDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PrivateServerStatusTypes_DeletePrivateServerStatusTypeByID", queryParameters));
	}

	internal static PrivateServerStatusTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerStatusTypes_GetPrivateServerStatusTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PrivateServerStatusTypes_InsertPrivateServerStatusType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
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
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PrivateServerStatusTypes_UpdatePrivateServerStatusTypeByID", queryParameters));
	}

	internal static ICollection<PrivateServerStatusTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PrivateServerStatusTypes_GetPrivateServerStatusTypesByIDs"), ids, BuildDALCollection);
	}

	internal static PrivateServerStatusTypeDAL GetPrivateServerStatusTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerStatusTypes_GetPrivateServerStatusTypeByValue", queryParameters), BuildDAL);
	}
}
