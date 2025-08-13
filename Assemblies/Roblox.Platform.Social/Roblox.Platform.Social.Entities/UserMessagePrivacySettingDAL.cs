using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Social.Entities;

[Serializable]
internal class UserMessagePrivacySettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUserPrivacy;

	public long ID { get; set; }

	public long UserID { get; set; }

	public byte MessagePrivacyTypeID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static UserMessagePrivacySettingDAL BuildDAL(IDictionary<string, object> record)
	{
		UserMessagePrivacySettingDAL dal = new UserMessagePrivacySettingDAL
		{
			ID = (long)record["ID"],
			UserID = (long)record["UserID"],
			MessagePrivacyTypeID = (byte)record["MessagePrivacyTypeID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@MessagePrivacyTypeID", MessagePrivacyTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxUserPrivacy.Insert<long>("UserMessagePrivacySettingsV2_InsertUserMessagePrivacySettingV2", queryParameters);
	}

	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@MessagePrivacyTypeID", MessagePrivacyTypeID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxUserPrivacy.Update("UserMessagePrivacySettingsV2_UpdateUserMessagePrivacySettingV2ByID", queryParameters);
	}

	public void Delete()
	{
		RobloxDatabase.RobloxUserPrivacy.Delete("UserMessagePrivacySettingsV2_DeleteUserMessagePrivacySettingV2ByID", ID);
	}

	public static UserMessagePrivacySettingDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxUserPrivacy.Get("UserMessagePrivacySettingsV2_GetUserMessagePrivacySettingV2ByID", id, BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<UserMessagePrivacySettingDAL> GetOrCreate(long userId, byte messagePrivacyTypeId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", userId),
			new SqlParameter("@MessagePrivacyTypeID", messagePrivacyTypeId)
		};
		return RobloxDatabase.RobloxUserPrivacy.GetOrCreate("UserMessagePrivacySettingsV2_GetOrCreateUserMessagePrivacySettingV2ByUserIDAndMessagePrivacyTypeID", BuildDAL, queryParameters);
	}
}
