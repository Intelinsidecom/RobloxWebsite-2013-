using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerUserAccessDAL
{
	internal long ID { get; set; }

	internal long PrivateServerID { get; set; }

	internal long UniverseID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static PrivateServerUserAccessDAL GetDALFromReader(SqlDataReader reader)
	{
		PrivateServerUserAccessDAL dal = new PrivateServerUserAccessDAL
		{
			ID = (long)reader["ID"],
			PrivateServerID = (long)reader["PrivateServerID"],
			UniverseID = (long)reader["UniverseID"],
			UserID = Convert.ToInt64(reader["UserID"]),
			Created = DateTime.SpecifyKind((DateTime)reader["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)reader["UpdatedUtc"], DateTimeKind.Utc)
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PrivateServerUserAccessDAL BuildDAL(SqlDataReader reader)
	{
		PrivateServerUserAccessDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PrivateServerUserAccessDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PrivateServerUserAccessDAL> dals = new List<PrivateServerUserAccessDAL>();
		while (reader.Read())
		{
			PrivateServerUserAccessDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_DeletePrivateServerUserAccessByID", queryParameters));
	}

	internal static PrivateServerUserAccessDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetPrivateServerUserAccessByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_InsertPrivateServerUserAccess", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_UpdatePrivateServerUserAccessByID", queryParameters));
	}

	internal static PrivateServerUserAccessDAL GetPrivateServerUserAccessByPrivateServerIDAndUserID(long privateServerId, long userId)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@PrivateServerID", privateServerId),
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetPrivateServerUserAccessByPrivateServerIDAndUserID", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetPrivateServerUserAccessIDsByPrivateServerIDPaged(long privateServerId, long startRowIndex, long maximumRows)
	{
		if (privateServerId == 0L)
		{
			throw new ApplicationException("Required value not specified: PrivateServerID.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@PrivateServerID", privateServerId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetPrivateServerUserAccessIDsByPrivateServerID_Paged", queryParameters));
	}

	internal static ICollection<long> GetPrivateServerUserAccessIDsByUserIDPaged(long userId, long startRowIndex, long maximumRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetPrivateServerUserAccessIDsByUserID_Paged", queryParameters));
	}

	internal static ICollection<long> GetPrivateServerUserAccessIDsByUserIDAndUniverseIDPaged(long userId, long universeId, long startRowIndex, long maximumRows)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (universeId == 0L)
		{
			throw new ApplicationException("Required value not specified: UniverseID.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetPrivateServerUserAccessIDsByUserIDAndUniverseID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServerUserAccessesByPrivateServerID(long privateServerId)
	{
		if (privateServerId == 0L)
		{
			throw new ApplicationException("Required value not specified: PrivateServerID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PrivateServerID", privateServerId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetTotalNumberOfPrivateServerUserAccessesByPrivateServerID", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServerUserAccessesByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetTotalNumberOfPrivateServerUserAccessesByUserID", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServerUserAccessesByUserIDAndUniverseID(long userId, long universeId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (universeId == 0L)
		{
			throw new ApplicationException("Required value not specified: UniverseID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@UniverseID", universeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetTotalNumberOfPrivateServerUserAccessesByUserIDAndUniverseID", queryParameters));
	}

	internal static ICollection<PrivateServerUserAccessDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PrivateServerUserAccessesV2_GetPrivateServerUserAccessesByIDs"), ids, BuildDALCollection);
	}
}
