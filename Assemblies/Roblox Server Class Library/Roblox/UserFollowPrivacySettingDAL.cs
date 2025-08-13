using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class UserFollowPrivacySettingDAL
{
	public long ID { get; set; }

	public long UserID { get; set; }

	public byte FollowPrivacyTypeID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxUserPrivacy.GetConnectionString();

	private static UserFollowPrivacySettingDAL BuildDAL(SqlDataReader reader)
	{
		UserFollowPrivacySettingDAL dal = new UserFollowPrivacySettingDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.FollowPrivacyTypeID = (byte)reader["FollowPrivacyTypeID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@FollowPrivacyTypeID", FollowPrivacyTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "UserFollowPrivacySettingsV2_InsertUserFollowPrivacySettingV2", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@FollowPrivacyTypeID", FollowPrivacyTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "UserFollowPrivacySettingsV2_UpdateUserFollowPrivacySettingV2ByID", queryParameters));
	}

	public void Delete()
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "UserFollowPrivacySettingsV2_DeleteUserFollowPrivacySettingV2ByID", queryParameters));
	}

	public static UserFollowPrivacySettingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "UserFollowPrivacySettingsV2_GetUserFollowPrivacySettingV2ByID", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<UserFollowPrivacySettingDAL> GetOrCreate(long userId, byte followPrivacyTypeId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@FollowPrivacyTypeID", followPrivacyTypeId)
		};
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[UserFollowPrivacySettingsV2_GetOrCreateUserFollowPrivacySettingV2ByUserIDAndFollowPrivacyTypeID]", queryParameters), BuildDAL);
	}
}
