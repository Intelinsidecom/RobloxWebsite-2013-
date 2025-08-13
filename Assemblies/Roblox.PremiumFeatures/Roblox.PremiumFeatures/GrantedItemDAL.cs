using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

[ExcludeFromCodeCoverage]
internal class GrantedItemDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxPremiumFeatures;

	internal long ID { get; set; }

	internal long GrantedItemListID { get; set; }

	internal long GrantedItemTargetID { get; set; }

	internal byte GrantedItemTypeID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static GrantedItemDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GrantedItemDAL
		{
			ID = (long)record["ID"],
			GrantedItemListID = (long)record["GrantedItemListID"],
			GrantedItemTargetID = (long)record["GrantedItemTargetID"],
			GrantedItemTypeID = (byte)record["GrantedItemTypeID"],
			Created = DateTime.SpecifyKind((DateTime)record["CreatedUtc"], DateTimeKind.Utc),
			Updated = DateTime.SpecifyKind((DateTime)record["UpdatedUtc"], DateTimeKind.Utc)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxPremiumFeatures.Delete("GrantedItems_DeleteGrantedItemByID", ID);
	}

	internal static GrantedItemDAL Get(long id)
	{
		return RobloxDatabase.RobloxPremiumFeatures.Get("GrantedItems_GetGrantedItemByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GrantedItemListID", GrantedItemListID),
			new SqlParameter("@GrantedItemTargetID", GrantedItemTargetID),
			new SqlParameter("@GrantedItemTypeID", GrantedItemTypeID),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		ID = RobloxDatabase.RobloxPremiumFeatures.Insert<long>("GrantedItems_InsertGrantedItem", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GrantedItemListID", GrantedItemListID),
			new SqlParameter("@GrantedItemTargetID", GrantedItemTargetID),
			new SqlParameter("@GrantedItemTypeID", GrantedItemTypeID),
			new SqlParameter("@CreatedUtc", Created.ToUniversalTime()),
			new SqlParameter("@UpdatedUtc", Updated.ToUniversalTime())
		};
		RobloxDatabase.RobloxPremiumFeatures.Update("GrantedItems_UpdateGrantedItemByID", queryParameters);
	}

	internal static ICollection<GrantedItemDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxPremiumFeatures.MultiGet("GrantedItems_GetGrantedItemsByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetGrantedItemIDsByGrantedItemListID(long grantedItemListId, int count, long? exclusiveStartId)
	{
		if (grantedItemListId == 0L)
		{
			throw new ArgumentException("Parameter 'grantedItemListId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@GrantedItemListID", grantedItemListId),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[2] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxPremiumFeatures.GetIDCollection<long>("GrantedItems_GetGrantedItemIDsByGrantedItemListID", queryParameters);
	}
}
