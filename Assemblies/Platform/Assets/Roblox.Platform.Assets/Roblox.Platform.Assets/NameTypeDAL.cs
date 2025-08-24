using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets;

internal class NameTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssetNamespaces;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static NameTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new NameTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAssetNamespaces.Delete("NameTypes_DeleteNameTypeByID", ID);
	}

	internal static NameTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAssetNamespaces.Get("NameTypes_GetNameTypeByID", id, BuildDAL);
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
		ID = RobloxDatabase.RobloxAssetNamespaces.Insert<byte>("NameTypes_InsertNameType", queryParameters);
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
		RobloxDatabase.RobloxAssetNamespaces.Update("NameTypes_UpdateNameTypeByID", queryParameters);
	}

	internal static ICollection<NameTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAssetNamespaces.MultiGet("NameTypes_GetNameTypesByIDs", ids, BuildDAL);
	}

	internal static NameTypeDAL GetNameTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAssetNamespaces.Lookup("NameTypes_GetNameTypeByValue", BuildDAL, queryParameters);
	}
}
