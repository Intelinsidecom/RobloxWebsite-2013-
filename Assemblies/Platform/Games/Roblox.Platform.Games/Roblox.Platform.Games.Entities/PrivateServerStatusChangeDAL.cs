using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Games.Entities;

internal class PrivateServerStatusChangeDAL
{
	internal long ID { get; set; }

	internal long PrivateServerID { get; set; }

	internal byte OldPrivateServerStatusTypeID { get; set; }

	internal byte NewPrivateServerStatusTypeID { get; set; }

	internal byte PrivateServerStatusChangeReasonTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => RobloxDatabase.RobloxGames.GetConnectionString();

	private static PrivateServerStatusChangeDAL GetDALFromReader(SqlDataReader reader)
	{
		PrivateServerStatusChangeDAL dal = new PrivateServerStatusChangeDAL
		{
			ID = (long)reader["ID"],
			PrivateServerID = (long)reader["PrivateServerID"],
			OldPrivateServerStatusTypeID = (byte)reader["OldPrivateServerStatusTypeID"],
			NewPrivateServerStatusTypeID = (byte)reader["NewPrivateServerStatusTypeID"],
			PrivateServerStatusChangeReasonTypeID = (byte)reader["PrivateServerStatusChangeReasonTypeID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static PrivateServerStatusChangeDAL BuildDAL(SqlDataReader reader)
	{
		PrivateServerStatusChangeDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<PrivateServerStatusChangeDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<PrivateServerStatusChangeDAL> dals = new List<PrivateServerStatusChangeDAL>();
		while (reader.Read())
		{
			PrivateServerStatusChangeDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_DeletePrivateServerStatusChangeByID", queryParameters));
	}

	internal static PrivateServerStatusChangeDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_GetPrivateServerStatusChangeByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@OldPrivateServerStatusTypeID", OldPrivateServerStatusTypeID),
			new SqlParameter("@NewPrivateServerStatusTypeID", NewPrivateServerStatusTypeID),
			new SqlParameter("@PrivateServerStatusChangeReasonTypeID", PrivateServerStatusChangeReasonTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_InsertPrivateServerStatusChange", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PrivateServerID", PrivateServerID),
			new SqlParameter("@OldPrivateServerStatusTypeID", OldPrivateServerStatusTypeID),
			new SqlParameter("@NewPrivateServerStatusTypeID", NewPrivateServerStatusTypeID),
			new SqlParameter("@PrivateServerStatusChangeReasonTypeID", PrivateServerStatusChangeReasonTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_UpdatePrivateServerStatusChangeByID", queryParameters));
	}

	internal static ICollection<PrivateServerStatusChangeDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_GetPrivateServerStatusChangesByIDs"), ids, BuildDALCollection);
	}

	internal static ICollection<long> GetPrivateServerStatusChangeIDsByPrivateServerIDPaged(long privateServerId, long startRowIndex, long maximumRows)
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
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_GetPrivateServerStatusChangeIDsByPrivateServerID_Paged", queryParameters));
	}

	internal static long GetTotalNumberOfPrivateServerStatusChangesByPrivateServerID(long privateServerId)
	{
		if (privateServerId == 0L)
		{
			throw new ApplicationException("Required value not specified: PrivateServerID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PrivateServerID", privateServerId)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "PrivateServerStatusChanges_GetTotalNumberOfPrivateServerStatusChangesByPrivateServerID", queryParameters));
	}
}
