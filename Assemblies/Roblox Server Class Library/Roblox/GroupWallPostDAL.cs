using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.DataV2.Core;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class GroupWallPostDAL
{
	private static RobloxDatabase Database => RobloxDatabase.RobloxGroupPosts;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal long GroupID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		Database.Delete("WallPostsV2_DeleteWallPostV2ByID", ID);
	}

	internal void Insert()
	{
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@Value", string.IsNullOrEmpty(Value) ? ((IConvertible)DBNull.Value) : ((IConvertible)Value)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = Database.Insert<long>("WallPostsV2_InsertWallPostV2", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@Value", string.IsNullOrEmpty(Value) ? ((IConvertible)DBNull.Value) : ((IConvertible)Value)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		Database.Update("WallPostsV2_UpdateWallPostV2ByID", queryParameters);
	}

	private static GroupWallPostDAL BuildDAL(IDictionary<string, object> record)
	{
		if (Convert.ToInt64(record["ID"]) == 0L)
		{
			return null;
		}
		return new GroupWallPostDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			Value = ((record["Value"] == null || record["Value"].Equals(DBNull.Value)) ? string.Empty : ((string)record["Value"])),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal static GroupWallPostDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return Database.Get("WallPostsV2_GetWallPostV2ByID", id, BuildDAL);
	}

	internal static ICollection<long> GetGroupWallPostIDsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return Database.GetIDCollection<long>("WallPostsV2_GetWallPostV2IDsByGroupID_Paged", queryParameters);
	}

	internal static ICollection<long> GetTopGroupWallPostIDsByUserIDAndGroupID(long userId, long groupId, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return Database.GetIDCollection<long>("WallPostsV2_GetTopWallPostV2IDsByUserIDAndGroupID", queryParameters);
	}

	internal static int GetTotalNumberOfGroupWallPostsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return Database.GetCount<int>("WallPostsV2_GetTotalNumberOfWallPostsV2ByUserID", queryParameters);
	}

	internal static int GetTotalNumberOfGroupWallPostsByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return Database.GetCount<int>("WallPostsV2_GetTotalNumberOfWallPostsV2ByGroupID", queryParameters);
	}

	internal static ICollection<long> GetGroupWallPostIDsByGroupID(long groupId, int count, long? exclusiveStartId, Roblox.DataV2.Core.SortOrder sortOrder)
	{
		if (groupId <= 0 || count <= 0)
		{
			return new long[0];
		}
		if (!exclusiveStartId.HasValue && sortOrder.Equals(Roblox.DataV2.Core.SortOrder.Asc))
		{
			exclusiveStartId = 0L;
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@Count", count),
			new SqlParameter("@IsAscendingOrder", sortOrder == Roblox.DataV2.Core.SortOrder.Asc),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return Database.GetIDCollection<long>("WallPostsV2_GetWallPostV2IDsByGroupID", queryParameters);
	}
}
