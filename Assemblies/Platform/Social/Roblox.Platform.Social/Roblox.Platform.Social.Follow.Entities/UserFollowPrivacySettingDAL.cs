using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Social.Follow.Entities;

[ExcludeFromCodeCoverage]
internal class UserFollowPrivacySettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUserPrivacy;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal byte FollowPrivacyTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UserFollowPrivacySettingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UserFollowPrivacySettingDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			FollowPrivacyTypeID = (byte)record["FollowPrivacyTypeID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxUserPrivacy.Delete("UserFollowPrivacySettings_DeleteUserFollowPrivacySettingByID", ID);
	}

	internal static UserFollowPrivacySettingDAL Get(long id)
	{
		return RobloxDatabase.RobloxUserPrivacy.Get("UserFollowPrivacySettings_GetUserFollowPrivacySettingByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@FollowPrivacyTypeID", FollowPrivacyTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxUserPrivacy.Insert<long>("UserFollowPrivacySettings_InsertUserFollowPrivacySetting", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@FollowPrivacyTypeID", FollowPrivacyTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxUserPrivacy.Update("UserFollowPrivacySettings_UpdateUserFollowPrivacySettingByID", queryParameters);
	}

	internal static ICollection<UserFollowPrivacySettingDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxUserPrivacy.MultiGet("UserFollowPrivacySettings_GetUserFollowPrivacySettingsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<UserFollowPrivacySettingDAL> GetOrCreateUserFollowPrivacySetting(long userID, byte defaultPrivacyTypeID)
	{
		if (userID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", userID),
			new SqlParameter("@FollowPrivacyTypeID", defaultPrivacyTypeID)
		};
		return RobloxDatabase.RobloxUserPrivacy.GetOrCreate("UserFollowPrivacySettings_GetOrCreateUserFollowPrivacySettingByUserIDAndFollowPrivacyTypeID", BuildDAL, queryParameters);
	}
}
