using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Moderation.Entities;

[ExcludeFromCodeCoverage]
internal class ModerationLocaleDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxModerationNew;

	internal int ID { get; set; }

	internal int SupportedLocaleID { get; set; }

	internal bool IsActive { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ModerationLocaleDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ModerationLocaleDAL
		{
			ID = (int)record["ID"],
			SupportedLocaleID = (int)record["SupportedLocaleID"],
			IsActive = (bool)record["IsActive"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxModerationNew.Delete("ModerationLocales_DeleteModerationLocaleByID", ID);
	}

	internal static ModerationLocaleDAL Get(int id)
	{
		return RobloxDatabase.RobloxModerationNew.Get("ModerationLocales_GetModerationLocaleByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SupportedLocaleID", SupportedLocaleID),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxModerationNew.Insert<int>("ModerationLocales_InsertModerationLocale", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@SupportedLocaleID", SupportedLocaleID),
			new SqlParameter("@IsActive", IsActive),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxModerationNew.Update("ModerationLocales_UpdateModerationLocaleByID", queryParameters);
	}

	internal static ICollection<ModerationLocaleDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxModerationNew.MultiGet("ModerationLocales_GetModerationLocalesByIDs", ids, BuildDAL);
	}

	internal static ModerationLocaleDAL GetModerationLocaleBySupportedLocaleID(int supportedLocaleId)
	{
		if (supportedLocaleId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@SupportedLocaleID", supportedLocaleId)
		};
		return RobloxDatabase.RobloxModerationNew.Lookup("ModerationLocales_GetModerationLocaleBySupportedLocaleID", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetModerationLocaleIDsByIsActive(bool isActive, int count, int exclusiveStartId)
	{
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@IsActive", isActive),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartID", exclusiveStartId)
		};
		return RobloxDatabase.RobloxModerationNew.GetIDCollection<int>("ModerationLocales_GetModerationLocaleIDsByIsActive", queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ModerationLocaleDAL> GetOrCreateModerationLocale(int supportedLocaleId)
	{
		if (supportedLocaleId == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@SupportedLocaleID", supportedLocaleId)
		};
		return RobloxDatabase.RobloxModerationNew.GetOrCreate("ModerationLocales_GetOrCreateModerationLocale", BuildDAL, queryParameters);
	}
}
