using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class UserFeedDAL
{
	private static RobloxDatabase Database => RobloxDatabase.RobloxUserFeeds;

	internal long ID { get; set; }

	internal long FeedID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	private static UserFeedDAL BuildDAL(IDictionary<string, object> record)
	{
		return new UserFeedDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			FeedID = Convert.ToInt64(record["FeedID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			Created = (DateTime)record["Created"]
		};
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		Database.Delete("UserFeedsV2_DeleteUserFeedV2ByID", ID);
	}

	internal void Insert()
	{
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (FeedID == 0L)
		{
			throw new ApplicationException("Required value not specified: FeedID");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@FeedID", FeedID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		ID = Database.Insert<long>("UserFeedsV2_InsertUserFeedV2", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (FeedID == 0L)
		{
			throw new ApplicationException("Required value not specified: FeedID");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@FeedID", FeedID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created)
		};
		Database.Update("UserFeedsV2_UpdateUserFeedV2ByID", queryParameters);
	}

	internal static ICollection<UserFeedDAL> MultiGet(ICollection<long> ids)
	{
		return Database.MultiGet("UserFeedsV2_GetUserFeedsV2ByIDs", ids, BuildDAL);
	}

	internal static void Delete(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		Database.Delete("UserFeedsV2_DeleteUserFeedV2ByID", id);
	}

	internal static UserFeedDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return Database.Get("UserFeedsV2_GetUserFeedV2ByID", id, BuildDAL);
	}

	internal static UserFeedDAL GetUserFeedByFeedIDAndUserID(long feedID, long userID)
	{
		if (feedID == 0L)
		{
			return null;
		}
		if (userID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@FeedID", feedID),
			new SqlParameter("@UserID", userID)
		};
		return Database.Lookup("UserFeedsV2_GetUserFeedV2ByFeedIDAndUserID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetUserFeedIDsByUserIDPaged(long userId, int startRowIndex, int maximumRows)
	{
		if (userId == 0L)
		{
			throw new ArgumentException("Parameter 'userID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@UserID", userId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return Database.GetIDCollection<long>("UserFeedsV2_GetUserFeedV2IDsByUserID_Paged", queryParameters);
	}
}
