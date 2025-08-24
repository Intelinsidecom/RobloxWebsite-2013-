using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Marketing.Core.Entities;

internal class ContentItemTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static ContentItemTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new ContentItemTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("ContentItemTypes_DeleteContentItemTypeByID", ID);
	}

	internal static ContentItemTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxMarketing.Get("ContentItemTypes_GetContentItemTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxMarketing.Insert<byte>("ContentItemTypes_InsertContentItemType", queryParameters);
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
		RobloxDatabase.RobloxMarketing.Update("ContentItemTypes_UpdateContentItemTypeByID", queryParameters);
	}

	internal static ICollection<ContentItemTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("ContentItemTypes_GetContentItemTypesByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<ContentItemTypeDAL> GetOrCreateContentItemType(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxMarketing.GetOrCreate("ContentItemTypes_GetOrCreateContentItemType", BuildDAL, queryParameters);
	}
}
