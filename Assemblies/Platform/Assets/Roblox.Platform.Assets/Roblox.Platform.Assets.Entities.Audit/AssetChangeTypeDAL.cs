using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Assets.Entities.Audit;

[ExcludeFromCodeCoverage]
internal class AssetChangeTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAssetsAudit;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AssetChangeTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AssetChangeTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Description = (string)record["Description"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAssetsAudit.Delete("AssetChangeTypes_DeleteAssetChangeTypeByID", ID);
	}

	internal static AssetChangeTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxAssetsAudit.Get("AssetChangeTypes_GetAssetChangeTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.TinyInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAssetsAudit.Insert<byte>("AssetChangeTypes_InsertAssetChangeType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAssetsAudit.Update("AssetChangeTypes_UpdateAssetChangeTypeByID", queryParameters);
	}

	internal static ICollection<AssetChangeTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxAssetsAudit.MultiGet("AssetChangeTypes_GetAssetChangeTypesByIDs", ids, BuildDAL);
	}

	internal static AssetChangeTypeDAL GetAssetChangeTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAssetsAudit.Lookup("AssetChangeTypes_GetAssetChangeTypeByValue", BuildDAL, queryParameters);
	}
}
