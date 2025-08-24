using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Avatar;

internal class RecentItemListDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAvatars;

	internal long ID { get; set; }

	internal byte RecentItemListTypeID { get; set; }

	internal long UserID { get; set; }

	internal byte[] RecentItemTypeIDs { get; set; }

	internal long[] TargetIDs { get; set; }

	internal DateTime[] Dates { get; set; }

	internal int Revision { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static RecentItemListDAL BuildDAL(IDictionary<string, object> record)
	{
		byte[] recentItemTypeIds = (byte[])record["RecentItemTypeIDs"];
		long[] targetIds = ((byte[])record["TargetIDs"]).ToListLong().ToArray();
		DateTime[] dates = ((byte[])record["Dates"]).ToListDateTime().ToArray();
		return new RecentItemListDAL
		{
			ID = (long)record["ID"],
			RecentItemListTypeID = (byte)record["RecentItemListTypeID"],
			UserID = (long)record["UserID"],
			RecentItemTypeIDs = recentItemTypeIds,
			TargetIDs = targetIds,
			Dates = dates,
			Revision = (int)record["Revision"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAvatars.Delete("RecentItemLists_DeleteRecentItemListByID", ID);
	}

	internal static RecentItemListDAL Get(long id)
	{
		return RobloxDatabase.RobloxAvatars.Get("RecentItemLists_GetRecentItemListByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@RecentItemListTypeID", RecentItemListTypeID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RecentItemTypeIDs", RecentItemTypeIDs),
			new SqlParameter("@TargetIDs", TargetIDs.ToBinary()),
			new SqlParameter("@Dates", Dates.ToBinary()),
			new SqlParameter("@Revision", Revision),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAvatars.Insert<long>("RecentItemLists_InsertRecentItemList", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@RecentItemListTypeID", RecentItemListTypeID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RecentItemTypeIDs", RecentItemTypeIDs),
			new SqlParameter("@TargetIDs", TargetIDs.ToBinary()),
			new SqlParameter("@Dates", Dates.ToBinary()),
			new SqlParameter("@Revision", Revision),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAvatars.Update("RecentItemLists_UpdateRecentItemListByID", queryParameters);
	}

	internal bool UpdateByRevision()
	{
		SqlParameter updatedEntityOutputParameter = new SqlParameter("@UpdatedEntity", SqlDbType.Bit)
		{
			Direction = ParameterDirection.Output
		};
		SqlParameter[] queryParameters = new SqlParameter[10]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@RecentItemListTypeID", RecentItemListTypeID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@RecentItemTypeIDs", RecentItemTypeIDs),
			new SqlParameter("@TargetIDs", TargetIDs.ToBinary()),
			new SqlParameter("@Dates", Dates.ToBinary()),
			new SqlParameter("@Revision", Revision),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			updatedEntityOutputParameter
		};
		RobloxDatabase.RobloxAvatars.ExecuteScalar("RecentItemLists_UpdateRecentItemListByIDAndRevision", queryParameters);
		return (bool)updatedEntityOutputParameter.Value;
	}

	internal static ICollection<RecentItemListDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAvatars.MultiGet("RecentItemLists_GetRecentItemListsByIDs", ids, BuildDAL);
	}

	internal static RecentItemListDAL GetRecentItemListByUserIDAndRecentItemListTypeID(long userID, byte recentItemListTypeID)
	{
		if (userID == 0L)
		{
			return null;
		}
		if (recentItemListTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@UserID", userID),
			new SqlParameter("@RecentItemListTypeID", recentItemListTypeID)
		};
		return RobloxDatabase.RobloxAvatars.Lookup("RecentItemLists_GetRecentItemListByUserIDAndRecentItemListTypeID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<RecentItemListDAL> GetOrCreateRecentItemList(long userID, byte recentItemListTypeID)
	{
		if (userID == 0L)
		{
			return null;
		}
		if (recentItemListTypeID == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@RecentItemListTypeID", recentItemListTypeID),
			new SqlParameter("@UserID", userID)
		};
		return RobloxDatabase.RobloxAvatars.GetOrCreate("RecentItemLists_GetOrCreateRecentItemList", BuildDAL, queryParameters);
	}
}
