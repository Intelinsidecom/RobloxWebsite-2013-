using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class GroupJoinRequestDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupMembershipRequests;

	public long ID { get; set; }

	public long GroupID { get; set; }

	public long UserID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		(new SqlParameter[1])[0] = new SqlParameter("@ID", ID);
		RobloxDatabase.RobloxGroupMembershipRequests.Delete("GroupJoinRequestsV2_DeleteGroupJoinRequestV2ByID", ID);
	}

	public void Insert()
	{
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupMembershipRequests.Insert<long>("GroupJoinRequestsV2_InsertGroupJoinRequestV2", queryParameters);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupMembershipRequests.Update("GroupJoinRequestsV2_UpdateGroupJoinRequestV2ByID", queryParameters);
	}

	private static GroupJoinRequestDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GroupJoinRequestDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public static GroupJoinRequestDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		(new SqlParameter[1])[0] = new SqlParameter("@ID", id);
		return RobloxDatabase.RobloxGroupMembershipRequests.Get("GroupJoinRequestsV2_GetGroupJoinRequestV2ByID", id, BuildDAL);
	}

	public static GroupJoinRequestDAL Get(long groupId, long userId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxGroupMembershipRequests.Lookup("GroupJoinRequestsV2_GetGroupJoinRequestV2ByGroupIDAndUserID", BuildDAL, queryParameters);
	}

	public static ICollection<long> GetGroupJoinRequestIDsByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupMembershipRequests.GetIDCollection<long>("GroupJoinRequestsV2_GetGroupJoinRequestV2IDsByGroupID", queryParameters);
	}

	public static ICollection<long> GetGroupJoinRequestsIDsByGroupIDEnumerative(long groupId, long? exclusiveStartId, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException(string.Format("Required value not specified: {0}.", "groupId"));
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			null,
			null
		};
		long? num = exclusiveStartId;
		obj[1] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		obj[2] = new SqlParameter("@Count", maximumRows);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxGroupMembershipRequests.GetIDCollection<long>("GroupJoinRequestsV2_GetGroupJoinRequestsV2IDsByGroupIDEnumerative", queryParameters);
	}

	public static ICollection<long> GetGroupJoinRequestIDsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
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
		return RobloxDatabase.RobloxGroupMembershipRequests.GetIDCollection<long>("GroupJoinRequestsV2_GetGroupJoinRequestV2IDsByGroupID_Paged", queryParameters);
	}

	public static ICollection<long> GetGroupJoinRequestIDsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxGroupMembershipRequests.GetIDCollection<long>("GroupJoinRequestsV2_GetGroupJoinRequestV2IDsByUserID", queryParameters);
	}

	public static int GetTotalNumberOfGroupJoinRequestsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@UserID", userId)
		};
		return RobloxDatabase.RobloxGroupMembershipRequests.GetCount<int>("GroupJoinRequestsV2_GetTotalNumberOfGroupJoinRequestsV2ByUserID", queryParameters);
	}

	public static int GetTotalNumberOfGroupJoinRequestsByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupMembershipRequests.GetCount<int>("GroupJoinRequestsV2_GetTotalNumberOfGroupJoinRequestsV2ByGroupID", queryParameters);
	}
}
