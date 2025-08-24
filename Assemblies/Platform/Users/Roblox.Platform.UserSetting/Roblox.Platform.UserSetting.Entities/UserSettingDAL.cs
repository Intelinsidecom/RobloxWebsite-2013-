using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.UserSetting.Entities;

[ExcludeFromCodeCoverage]
internal class UserSettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUserSettings;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal bool CuratedGamesOnlyIsEnabled { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static UserSettingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UserSettingDAL
		{
			ID = (long)record["ID"],
			UserID = (long)record["UserID"],
			CuratedGamesOnlyIsEnabled = (bool)record["CuratedGamesOnlyIsEnabled"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxUserSettings.Delete("UserSettings_DeleteUserSettingByID", ID);
	}

	internal static UserSettingDAL Get(long id)
	{
		return RobloxDatabase.RobloxUserSettings.Get("UserSettings_GetUserSettingByID", id, BuildDAL);
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
			new SqlParameter("@CuratedGamesOnlyIsEnabled", CuratedGamesOnlyIsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxUserSettings.Insert<long>("UserSettings_InsertUserSetting", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@CuratedGamesOnlyIsEnabled", CuratedGamesOnlyIsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxUserSettings.Update("UserSettings_UpdateUserSettingByID", queryParameters);
	}

	internal static ICollection<UserSettingDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxUserSettings.MultiGet("UserSettings_GetUserSettingsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<UserSettingDAL> GetOrCreateUserSetting(long userID)
	{
		if (userID <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", userID)
		};
		return RobloxDatabase.RobloxUserSettings.GetOrCreate("UserSettings_GetOrCreateUserSetting", BuildDAL, queryParameters);
	}
}
