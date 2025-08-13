using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.XboxLive.Entities;

internal class CrossPlaySettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxXbox;

	internal long ID { get; set; }

	internal long UserId { get; set; }

	internal bool IsEnabled { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static CrossPlaySettingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new CrossPlaySettingDAL
		{
			ID = (long)record["ID"],
			UserId = (long)record["UserID"],
			IsEnabled = (bool)record["IsEnabled"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxXbox.Delete("CrossPlaySettings_DeleteCrossPlaySettingByID", ID);
	}

	internal static CrossPlaySettingDAL Get(long id)
	{
		return RobloxDatabase.RobloxXbox.Get("CrossPlaySettings_GetCrossPlaySettingByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserId),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxXbox.Insert<long>("CrossPlaySettings_InsertCrossPlaySetting", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserId),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxXbox.Update("CrossPlaySettings_UpdateCrossPlaySettingByID", queryParameters);
	}

	internal static ICollection<CrossPlaySettingDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxXbox.MultiGet("CrossPlaySettings_GetCrossPlaySettingsByIDs", ids, BuildDAL);
	}

	internal static CrossPlaySettingDAL GetCrossPlaySettingByUserId(long userId)
	{
		if (userId <= 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxXbox.Lookup("CrossPlaySettings_GetCrossPlaySettingByUserID", BuildDAL, queryParameters);
	}
}
