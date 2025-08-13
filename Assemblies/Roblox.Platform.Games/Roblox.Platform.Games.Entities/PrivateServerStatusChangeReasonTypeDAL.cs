using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerStatusChangeReasonTypeDAL
{
	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static PrivateServerStatusChangeReasonTypeDAL GetDALFromReader(SqlDataReader reader)
	{
		PrivateServerStatusChangeReasonTypeDAL dal = new PrivateServerStatusChangeReasonTypeDAL
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

	private static PrivateServerStatusChangeReasonTypeDAL BuildDAL(SqlDataReader reader)
	{
		PrivateServerStatusChangeReasonTypeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PrivateServerStatusChangeReasonTypeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PrivateServerStatusChangeReasonTypeDAL> dals = new List<PrivateServerStatusChangeReasonTypeDAL>();
		while (reader.Read())
		{
			PrivateServerStatusChangeReasonTypeDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PrivateServerStatusChangeReasonTypes_DeletePrivateServerStatusChangeReasonTypeByID", queryParameters));
	}

	internal static PrivateServerStatusChangeReasonTypeDAL Get(byte id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerStatusChangeReasonTypes_GetPrivateServerStatusChangeReasonTypeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PrivateServerStatusChangeReasonTypes_InsertPrivateServerStatusChangeReasonType", new SqlParameter("@ID", SqlDbType.SmallInt), queryParameters);
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
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PrivateServerStatusChangeReasonTypes_UpdatePrivateServerStatusChangeReasonTypeByID", queryParameters));
	}

	internal static ICollection<PrivateServerStatusChangeReasonTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PrivateServerStatusChangeReasonTypes_GetPrivateServerStatusChangeReasonTypesByIDs"), ids, BuildDALCollection);
	}

	internal static PrivateServerStatusChangeReasonTypeDAL GetPrivateServerStatusChangeReasonTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerStatusChangeReasonTypes_GetPrivateServerStatusChangeReasonTypeByValue", queryParameters), BuildDAL);
	}
}
