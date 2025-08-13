using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class UserMobileAdIdentifierDAL
{
	internal int ID { get; set; }

	internal long UserID { get; set; }

	internal int MobileAdIdentifierID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxMarketing.GetConnectionString();

	internal UserMobileAdIdentifierDAL()
	{
	}

	private static UserMobileAdIdentifierDAL GetDALFromReader(SqlDataReader reader)
	{
		UserMobileAdIdentifierDAL dal = new UserMobileAdIdentifierDAL
		{
			ID = (int)reader["ID"],
			UserID = Convert.ToInt64(reader["UserID"]),
			MobileAdIdentifierID = (int)reader["MobileAdIdentifierID"],
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	private static UserMobileAdIdentifierDAL BuildDAL(SqlDataReader reader)
	{
		UserMobileAdIdentifierDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<UserMobileAdIdentifierDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<UserMobileAdIdentifierDAL> dals = new List<UserMobileAdIdentifierDAL>();
		while (reader.Read())
		{
			UserMobileAdIdentifierDAL dal = GetDALFromReader(reader);
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
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "UserMobileAdIdentifiers_DeleteUserMobileAdIdentifierByID", queryParameters));
	}

	internal static UserMobileAdIdentifierDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserMobileAdIdentifiers_GetUserMobileAdIdentifierByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@MobileAdIdentifierID", MobileAdIdentifierID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "UserMobileAdIdentifiers_InsertUserMobileAdIdentifier", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@MobileAdIdentifierID", MobileAdIdentifierID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "UserMobileAdIdentifiers_UpdateUserMobileAdIdentifierByID", queryParameters));
	}

	internal static ICollection<UserMobileAdIdentifierDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(ConnectionString, "UserMobileAdIdentifiers_GetUserMobileAdIdentifiersByIDs"), ids, BuildDALCollection);
	}

	internal static UserMobileAdIdentifierDAL GetUserMobileAdIdentifierByUserIDMobileAdIdentifierID(long userId, int mobileAdIdentifierId)
	{
		if (userId == 0L)
		{
			return null;
		}
		if (mobileAdIdentifierId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@MobileAdIdentifierID", mobileAdIdentifierId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserMobileAdIdentifiers_GetUserMobileAdIdentifierByUserIDAndMobileAdIdentifierID", queryParameters), BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<UserMobileAdIdentifierDAL> GetOrCreateUserMobileAdIdentifier(long userID, int mobileAdIdentifierID)
	{
		if (userID == 0L)
		{
			return null;
		}
		if (mobileAdIdentifierID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UserID", userID),
			new SqlParameter("@MobileAdIdentifierID", mobileAdIdentifierID)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "UserMobileAdIdentifiers_GetOrCreateUserMobileAdIdentifier", queryParameters), BuildDAL);
	}
}
