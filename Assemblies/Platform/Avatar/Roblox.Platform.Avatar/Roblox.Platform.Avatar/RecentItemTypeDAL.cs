using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Avatar;

internal class RecentItemTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static RecentItemTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new RecentItemTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("RecentItemTypes_DeleteRecentItemTypeByID", ID);
	}

	internal static RecentItemTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAvatars.Get("RecentItemTypes_GetRecentItemTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAvatars.Insert<byte>("RecentItemTypes_InsertRecentItemType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAvatars.Update("RecentItemTypes_UpdateRecentItemTypeByID", queryParameters);
	}

	internal static ICollection<RecentItemTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("RecentItemTypes_GetRecentItemTypesByIDs", ids, BuildDAL);
	}

	internal static RecentItemTypeDAL GetRecentItemTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("RecentItemTypes_GetRecentItemTypeByValue", BuildDAL, queryParameters);
	}
}
