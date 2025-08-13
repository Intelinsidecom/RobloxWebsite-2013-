using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class ImbursementBlacklistUserDAL
{
	internal int ID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal ImbursementBlacklistUserDAL()
	{
	}

	private static ImbursementBlacklistUserDAL GetDALFromReader(SqlDataReader reader)
	{
		ImbursementBlacklistUserDAL dal = new ImbursementBlacklistUserDAL
		{
			ID = (int)reader["ID"],
			UserID = Convert.ToInt64(reader["UserID"]),
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static ImbursementBlacklistUserDAL BuildDAL(SqlDataReader reader)
	{
		ImbursementBlacklistUserDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<ImbursementBlacklistUserDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<ImbursementBlacklistUserDAL> dals = new List<ImbursementBlacklistUserDAL>();
		while (reader.Read())
		{
			ImbursementBlacklistUserDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "ImbursementBlacklistUsers_DeleteImbursementBlacklistUserByID", queryParameters));
	}

	internal static ImbursementBlacklistUserDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementBlacklistUsers_GetImbursementBlacklistUserByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "ImbursementBlacklistUsers_InsertImbursementBlacklistUser", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
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
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "ImbursementBlacklistUsers_UpdateImbursementBlacklistUserByID", queryParameters));
	}

	internal static ICollection<ImbursementBlacklistUserDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "ImbursementBlacklistUsers_GetImbursementBlacklistUsersByIDs"), ids, BuildDALCollection);
	}

	internal static ImbursementBlacklistUserDAL GetImbursementBlacklistUserByUserID(long userID)
	{
		if (userID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "ImbursementBlacklistUsers_GetImbursementBlacklistUserByUserID", queryParameters), BuildDAL);
	}
}
