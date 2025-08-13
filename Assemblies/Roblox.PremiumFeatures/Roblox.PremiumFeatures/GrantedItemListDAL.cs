using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemListDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	internal long ID { get; set; }

	internal string Name { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static GrantedItemListDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GrantedItemListDAL
		{
			ID = (long)record["ID"],
			Name = (string)record["Name"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPremiumFeatures.Delete("GrantedItemLists_DeleteGrantedItemListByID", ID);
	}

	internal static GrantedItemListDAL Get(long id)
	{
		return RobloxDatabase.RobloxPremiumFeatures.Get("GrantedItemLists_GetGrantedItemListByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<long>("GrantedItemLists_InsertGrantedItemList", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		RobloxDatabase.RobloxPremiumFeatures.Update("GrantedItemLists_UpdateGrantedItemListByID", queryParameters);
	}

	internal static ICollection<GrantedItemListDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("GrantedItemLists_GetGrantedItemListsByIDs", ids, BuildDAL);
	}
}
