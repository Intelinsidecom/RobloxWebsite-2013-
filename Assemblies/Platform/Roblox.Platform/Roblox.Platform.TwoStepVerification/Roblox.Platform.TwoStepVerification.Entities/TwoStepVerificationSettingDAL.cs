using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSettingDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAuthentication;

	internal long ID { get; set; }

	internal bool IsEnabled { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal byte? TwoStepVerificationMediaTypeID { get; set; }

	private static TwoStepVerificationSettingDAL BuildDAL(IDictionary<string, object> record)
	{
		return new TwoStepVerificationSettingDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			IsEnabled = (bool)record["IsEnabled"],
			UserID = Convert.ToInt64(record["UserID"]),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			TwoStepVerificationMediaTypeID = (byte?)record["TwoStepVerificationMediaTypeID"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAuthentication.Delete("TwoStepVerificationSettingsV2_DeleteTwoStepVerificationSettingV2ByID", ID);
	}

	internal static TwoStepVerificationSettingDAL Get(long id)
	{
		return RobloxDatabase.RobloxAuthentication.Get("TwoStepVerificationSettingsV2_GetTwoStepVerificationSettingV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@TwoStepVerificationMediaTypeID", TwoStepVerificationMediaTypeID.HasValue ? ((object)TwoStepVerificationMediaTypeID) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxAuthentication.Insert<int>("TwoStepVerificationSettingsV2_InsertTwoStepVerificationSettingV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@IsEnabled", IsEnabled),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@TwoStepVerificationMediaTypeID", TwoStepVerificationMediaTypeID.HasValue ? ((object)TwoStepVerificationMediaTypeID) : DBNull.Value)
		};
		RobloxDatabase.RobloxAuthentication.Update("TwoStepVerificationSettingsV2_UpdateTwoStepVerificationSettingV2ByID", queryParameters);
	}

	internal static ICollection<TwoStepVerificationSettingDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAuthentication.MultiGet("TwoStepVerificationSettingsV2_GetTwoStepVerificationSettingsV2ByIDs", ids, BuildDAL);
	}

	internal static TwoStepVerificationSettingDAL GetTwoStepVerificationSettingByUserID(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxAuthentication.Lookup("TwoStepVerificationSettingsV2_GetTwoStepVerificationSettingV2ByUserID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<TwoStepVerificationSettingDAL> GetOrCreateTwoStepVerificationSetting(long userId)
	{
		if (userId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxAuthentication.GetOrCreate("TwoStepVerificationSettingsV2_GetOrCreateTwoStepVerificationSettingV2", BuildDAL, queryParameters);
	}
}
