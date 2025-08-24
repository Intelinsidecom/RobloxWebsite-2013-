using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Avatar;

internal class RecentItemListTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static RecentItemListTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new RecentItemListTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("RecentItemListTypes_DeleteRecentItemListTypeByID", ID);
	}

	internal static RecentItemListTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAvatars.Get("RecentItemListTypes_GetRecentItemListTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAvatars.Insert<byte>("RecentItemListTypes_InsertRecentItemListType", queryParameters);
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
		RobloxDatabase.RobloxAvatars.Update("RecentItemListTypes_UpdateRecentItemListTypeByID", queryParameters);
	}

	internal static ICollection<RecentItemListTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("RecentItemListTypes_GetRecentItemListTypesByIDs", ids, BuildDAL);
	}

	internal static RecentItemListTypeDAL GetRecentItemListTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("RecentItemListTypes_GetRecentItemListTypeByValue", BuildDAL, queryParameters);
	}
}
