using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Platform.Moderation.Properties;

namespace Roblox.Platform.Moderation;

internal class InGameAdvertisingBanDAL
{
	internal int ID { get; set; }

	internal long UserID { get; set; }

	internal DateTime? Expiration { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.ModerationNewConnectionString;

	internal InGameAdvertisingBanDAL()
	{
	}

	private static InGameAdvertisingBanDAL BuildDAL(SqlDataReader reader)
	{
		InGameAdvertisingBanDAL dal = new InGameAdvertisingBanDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Expiration = (reader["Expiration"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Expiration"]));
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
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "InGameAdvertisingBans_DeleteInGameAdvertisingBanByID", queryParameters));
	}

	internal static InGameAdvertisingBanDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "InGameAdvertisingBans_GetInGameAdvertisingBanByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "InGameAdvertisingBans_InsertInGameAdvertisingBan", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "InGameAdvertisingBans_UpdateInGameAdvertisingBanByID", queryParameters));
	}

	internal static InGameAdvertisingBanDAL GetByUserID(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "InGameAdvertisingBans_GetInGameAdvertisingBanByUserID", queryParameters), BuildDAL);
	}
}
