using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerDAL
{
	internal long ID { get; set; }

	internal long UniverseID { get; set; }

	internal string Name { get; set; }

	internal long OwnerUserID { get; set; }

	internal byte PrivateServerStatusTypeID { get; set; }

	internal Guid AccessCode { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal DateTime ExpirationDate { get; set; }

	internal string LinkCode { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static PrivateServerDAL GetDALFromReader(SqlDataReader reader)
	{
		PrivateServerDAL dal = new PrivateServerDAL
		{
			ID = (long)reader["ID"],
			UniverseID = (long)reader["UniverseID"],
			Name = (string)reader["Name"],
			OwnerUserID = (long)reader["OwnerUserID"],
			PrivateServerStatusTypeID = (byte)reader["PrivateServerStatusTypeID"],
			AccessCode = (Guid)reader["AccessCode"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"],
			ExpirationDate = (DateTime)reader["ExpirationDate"],
			LinkCode = ((reader["LinkCode"] == DBNull.Value) ? null : ((string)reader["LinkCode"]))
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PrivateServerDAL BuildDAL(SqlDataReader reader)
	{
		PrivateServerDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PrivateServerDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PrivateServerDAL> dals = new List<PrivateServerDAL>();
		while (reader.Read())
		{
			PrivateServerDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PrivateServersV2_DeletePrivateServerByID", queryParameters));
	}

	internal static PrivateServerDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@OwnerUserID", OwnerUserID),
			new SqlParameter("@PrivateServerStatusTypeID", PrivateServerStatusTypeID),
			new SqlParameter("@AccessCode", AccessCode),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@ExpirationDate", ExpirationDate),
			new SqlParameter("@LinkCode", LinkCode)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PrivateServersV2_InsertPrivateServer", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UniverseID", UniverseID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@OwnerUserID", OwnerUserID),
			new SqlParameter("@PrivateServerStatusTypeID", PrivateServerStatusTypeID),
			new SqlParameter("@AccessCode", AccessCode),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@ExpirationDate", ExpirationDate),
			new SqlParameter("@LinkCode", LinkCode)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PrivateServersV2_UpdatePrivateServerByID", queryParameters));
	}

	internal static ICollection<PrivateServerDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServersByIDs"), ids, BuildDALCollection);
	}

	internal static PrivateServerDAL GetPrivateServerByAccessCode(Guid accessCode)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccessCode", accessCode)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerByAccessCode", queryParameters), BuildDAL);
	}

	internal static ICollection<long> GetPrivateServerIDsByOwnerUserIDPaged(long ownerUserId, int startRowIndex, int maximumRows)
	{
		if (ownerUserId == 0L)
		{
			throw new ApplicationException("Required value not specified: OwnerUserID.");
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
			new SqlParameter("@OwnerUserID", ownerUserId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerIDsByOwnerUserID_Paged", queryParameters));
	}

	internal static ICollection<long> GetPrivateServerIDsByOwnerUserIDAndUniverseIDPaged(long ownerUserId, long universeId, int startRowIndex, int maximumRows)
	{
		if (ownerUserId == 0L)
		{
			throw new ApplicationException("Required value not specified: OwnerUserID.");
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
			new SqlParameter("@OwnerUserID", ownerUserId),
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerIDsByOwnerUserIDAndUniverseID_Paged", queryParameters));
	}

	internal static ICollection<long> GetPrivateServerIDsByUniverseIDAndPrivateServerStatusTypeIDPaged(long universeId, byte privateServerStatusTypeId, int startRowIndex, int maximumRows)
	{
		if (universeId == 0L)
		{
			throw new ApplicationException("Required value not specified: UniverseID.");
		}
		if (privateServerStatusTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: PrivateServerStatusTypeID.");
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
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@PrivateServerStatusTypeID", privateServerStatusTypeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerIDsByUniverseIDAndPrivateServerStatusTypeID_Paged", queryParameters));
	}

	internal static ICollection<long> GetPrivateServerIDsByUniverseIDPaged(long universeId, int startRowIndex, int maximumRows)
	{
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
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerIDsByUniverseID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServersByOwnerUserID(long ownerUserId)
	{
		if (ownerUserId == 0L)
		{
			throw new ApplicationException("Required value not specified: OwnerUserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@OwnerUserID", ownerUserId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetTotalNumberOfPrivateServersByOwnerUserID", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServersByOwnerUserIDAndUniverseID(long ownerUserId, long universeId)
	{
		if (ownerUserId == 0L)
		{
			throw new ApplicationException("Required value not specified: OwnerUserID.");
		}
		if (universeId == 0L)
		{
			throw new ApplicationException("Required value not specified: UniverseID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@OwnerUserID", ownerUserId),
			new SqlParameter("@UniverseID", universeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetTotalNumberOfPrivateServersByOwnerUserIDAndUniverseID", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServersByUniverseIDAndPrivateServerStatusTypeID(long universeId, byte privateServerStatusTypeId)
	{
		if (universeId == 0L)
		{
			throw new ApplicationException("Required value not specified: UniverseID.");
		}
		if (privateServerStatusTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: PrivateServerStatusTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UniverseID", universeId),
			new SqlParameter("@PrivateServerStatusTypeID", privateServerStatusTypeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetTotalNumberOfPrivateServersByUniverseIDAndPrivateServerStatusTypeID", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServersByUniverseID(long universeId)
	{
		if (universeId == 0L)
		{
			throw new ApplicationException("Required value not specified: UniverseID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UniverseID", universeId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetTotalNumberOfPrivateServersByUniverseID", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServersByLinkCode(string linkCode)
	{
		if (string.IsNullOrEmpty(linkCode))
		{
			throw new ArgumentException("Parameter 'linkCode' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@LinkCode", string.IsNullOrEmpty(linkCode) ? ((IConvertible)DBNull.Value) : ((IConvertible)linkCode))
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetTotalNumberOfPrivateServersByLinkCode", queryParameters));
	}

	internal static ICollection<long> GetPrivateServerIDsByLinkCodePaged(string linkCode, int startRowIndex, int maximumRows)
	{
		if (string.IsNullOrEmpty(linkCode))
		{
			throw new ArgumentException("Parameter 'linkCode' cannot be null, empty or the default value.");
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
			new SqlParameter("@LinkCode", string.IsNullOrEmpty(linkCode) ? ((IConvertible)DBNull.Value) : ((IConvertible)linkCode)),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServersV2_GetPrivateServerIDsByLinkCode_Paged", queryParameters));
	}
}
