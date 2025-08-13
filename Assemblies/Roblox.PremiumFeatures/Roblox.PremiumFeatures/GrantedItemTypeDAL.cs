using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	internal byte ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static GrantedItemTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GrantedItemTypeDAL
		{
			ID = (byte)record["ID"],
			Value = (string)record["Value"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPremiumFeatures.Delete("GrantedItemTypes_DeleteGrantedItemTypeByID", ID);
	}

	internal static GrantedItemTypeDAL Get(byte id)
	{
		return RobloxDatabase.RobloxPremiumFeatures.Get("GrantedItemTypes_GetGrantedItemTypeByID", id, BuildDAL);
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
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<byte>("GrantedItemTypes_InsertGrantedItemType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		RobloxDatabase.RobloxPremiumFeatures.Update("GrantedItemTypes_UpdateGrantedItemTypeByID", queryParameters);
	}

	internal static ICollection<GrantedItemTypeDAL> MultiGet(ICollection<byte> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("GrantedItemTypes_GetGrantedItemTypesByIDs", ids, BuildDAL);
	}

	internal static GrantedItemTypeDAL GetGrantedItemTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxPremiumFeatures.Lookup("GrantedItemTypes_GetGrantedItemTypeByValue", BuildDAL, queryParameters);
	}
}
