using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Moderation.Properties;

namespace Roblox.Moderation;

public class SellBanDAL
{
	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal DateTime? Expiration { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.dbConnectionString_RobloxModeration;

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "SellBansV2_DeleteSellBanV2ByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "SellBansV2_InsertSellBanV2", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "SellBansV2_UpdateSellBanV2ByID", queryParameters));
	}

	private static SellBanDAL BuildDAL(SqlDataReader reader)
	{
		SellBanDAL dal = new SellBanDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.Expiration = (reader["Expiration"].Equals(DBNull.Value) ? null : ((DateTime?)reader["Expiration"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	internal static SellBanDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "SellBansV2_GetSellBanV2ByID", queryParameters), BuildDAL);
	}

	public static SellBanDAL GetByUserID(long userId)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@UserID", userId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "[dbo].[SellBansV2_GetSellBanV2ByUserID]", queryParameters), BuildDAL);
	}
}
