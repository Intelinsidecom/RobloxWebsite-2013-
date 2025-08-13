using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Marketing.Properties;

namespace Roblox.Marketing;

public class PersistentLowValueUserDAL
{
	internal int ID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.RobloxMarketing;

	private static PersistentLowValueUserDAL BuildDAL(SqlDataReader reader)
	{
		PersistentLowValueUserDAL dal = new PersistentLowValueUserDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PersistentLowValueUsers_DeletePersistentLowValueUserByID", queryParameters));
	}

	internal static PersistentLowValueUserDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PersistentLowValueUsers_GetPersistentLowValueUserByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PersistentLowValueUsers_InsertPersistentLowValueUser", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PersistentLowValueUsers_UpdatePersistentLowValueUserByID", queryParameters));
	}

	internal static PersistentLowValueUserDAL GetPersistentLowValueUserByUserID(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PersistentLowValueUsers_GetPersistentLowValueUserByUserID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<PersistentLowValueUserDAL> GetOrCreatePersistentLowValueUser(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(_DbConnectionString, "PersistentLowValueUsers_GetOrCreatePersistentLowValueUser", queryParameters), BuildDAL);
	}
}
