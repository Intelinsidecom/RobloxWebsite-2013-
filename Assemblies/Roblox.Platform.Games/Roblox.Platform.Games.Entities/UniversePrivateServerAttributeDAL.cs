using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class UniversePrivateServerAttributeDAL
{
	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal bool AllowPrivateServers { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static UniversePrivateServerAttributeDAL GetDALFromReader(SqlDataReader reader)
	{
		UniversePrivateServerAttributeDAL dal = new UniversePrivateServerAttributeDAL
		{
			ID = (long)reader["ID"],
			UniverseID = (long)reader["UniverseID"],
			AllowPrivateServers = (bool)reader["AllowPrivateServers"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static UniversePrivateServerAttributeDAL BuildDAL(SqlDataReader reader)
	{
		UniversePrivateServerAttributeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<UniversePrivateServerAttributeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<UniversePrivateServerAttributeDAL> dals = new List<UniversePrivateServerAttributeDAL>();
		while (reader.Read())
		{
			UniversePrivateServerAttributeDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "UniversePrivateServerAttributes_DeleteUniversePrivateServerAttributeByID", queryParameters));
	}

	internal static UniversePrivateServerAttributeDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "UniversePrivateServerAttributes_GetUniversePrivateServerAttributeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@AllowPrivateServers", AllowPrivateServers),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "UniversePrivateServerAttributes_InsertUniversePrivateServerAttribute", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@AllowPrivateServers", AllowPrivateServers),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "UniversePrivateServerAttributes_UpdateUniversePrivateServerAttributeByID", queryParameters));
	}

	internal static ICollection<UniversePrivateServerAttributeDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "UniversePrivateServerAttributes_GetUniversePrivateServerAttributesByIDs"), ids, BuildDALCollection);
	}

	internal static UniversePrivateServerAttributeDAL GetUniversePrivateServerAttributeByUniverseID(long universeID)
	{
		if (universeID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "UniversePrivateServerAttributes_GetUniversePrivateServerAttributeByUniverseID", queryParameters), BuildDAL);
	}
}
