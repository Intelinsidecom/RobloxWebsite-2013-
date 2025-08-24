using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupActionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupRoleSets;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal long GroupID { get; set; }

	internal int ActionTypeID { get; set; }

	internal string Description { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static GroupActionDAL BuildDAL(IDictionary<string, object> record)
	{
		if (Convert.ToInt64(record["ID"]) == 0L)
		{
			return null;
		}
		return new GroupActionDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			ActionTypeID = (int)record["ActionTypeID"],
			Description = ((record["Description"] == null) ? string.Empty : ((string)record["Description"])),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@ActionTypeID", ActionTypeID),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupRoleSets.Insert<long>("GroupActionsV2_InsertGroupActionV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@ActionTypeID", ActionTypeID),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupRoleSets.Update("GroupActionsV2_UpdateGroupActionV2ByID", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGroupRoleSets.Delete("GroupActionsV2_DeleteGroupActionV2ByID", ID);
	}

	internal static GroupActionDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroupRoleSets.Get("GroupActionsV2_GetGroupActionV2ByID", id, BuildDAL);
	}

	internal static ICollection<long> GetGroupActionIDsByGroupIDPaged(long groupId, int startRowIndex, int maximumRows)
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
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("GroupActionsV2_GetGroupActionV2IDsByGroupID_Paged", queryParameters);
	}

	internal static ICollection<long> GetGroupActionIDsByGroupIDAndUserIDPaged(long groupId, long userId, int startRowIndex, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@UserID", userId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("GroupActionsV2_GetGroupActionV2IDsByGroupIDAndUserID_Paged", queryParameters);
	}

	internal static ICollection<long> GetGroupActionIDsByGroupIDAndActionTypeIDPaged(long groupId, int actionTypeId, int startRowIndex, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (actionTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: ActionTypeId.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@ActionTypeID", actionTypeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("GroupActionsV2_GetGroupActionV2IDsByGroupIDAndActionTypeID_Paged", queryParameters);
	}

	internal static ICollection<long> GetGroupActionIDsByGroupIDUserIDAndActionTypeIDPaged(long groupId, long userId, int actionTypeId, int startRowIndex, int maximumRows)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (actionTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: ActionTypeId.");
		}
		if (startRowIndex == 0)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows == 0)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@UserID", userId),
			new SqlParameter("@ActionTypeID", actionTypeId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("GroupActionsV2_GetGroupActionV2IDsByGroupIDUserIDAndActionTypeID_Paged", queryParameters);
	}

	internal static int GetTotalNumberOfGroupActionsByGroupIDUserIDAndActionTypeID(long groupId, long userId, int actionTypeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (actionTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: ActionTypeId.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@UserID", userId),
			new SqlParameter("@ActionTypeID", actionTypeId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetCount<int>("GroupActionsV2_GetTotalNumberOfGroupActionsV2ByGroupIDUserIDAndActionTypeID", queryParameters);
	}

	internal static int GetTotalNumberOfGroupActionsByGroupIDAndUserID(long groupId, long userId)
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
		return RobloxDatabase.RobloxGroupRoleSets.GetCount<int>("GroupActionsV2_GetTotalNumberOfGroupActionsV2ByGroupIDAndUserID", queryParameters);
	}

	internal static int GetTotalNumberOfGroupActionsByGroupIDAndActionTypeID(long groupId, int actionTypeId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (actionTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: ActionTypeId.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@ActionTypeID", actionTypeId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetCount<int>("GroupActionsV2_GetTotalNumberOfGroupActionsV2ByGroupIDAndActionTypeID", queryParameters);
	}

	internal static int GetTotalNumberOfGroupActionsByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetCount<int>("GroupActionsV2_GetTotalNumberOfGroupActionsV2ByGroupID", queryParameters);
	}
}
