using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class GroupRoleSetDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupRoleSets;

	internal long ID { get; set; }

	internal long GroupID { get; set; }

	internal string Name { get; set; } = string.Empty;


	internal string Description { get; set; } = string.Empty;


	internal byte Rank { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxGroupRoleSets.Delete("GroupRoleSets_DeleteGroupRoleSetByID", ID);
	}

	internal void Insert()
	{
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (string.IsNullOrEmpty(Name))
		{
			throw new ApplicationException("Required value not specified: Name");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? string.Empty : Description),
			new SqlParameter("@Rank", Rank),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupRoleSets.Insert<long>("GroupRoleSets_InsertGroupRoleSet", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (GroupID == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		if (string.IsNullOrEmpty(Name))
		{
			throw new ApplicationException("Required value not specified: Name");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@GroupID", GroupID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)),
			new SqlParameter("@Rank", Rank),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupRoleSets.Update("GroupRoleSets_UpdateGroupRoleSetByID", queryParameters);
	}

	private static GroupRoleSetDAL BuildDAL(IDictionary<string, object> record)
	{
		if (Convert.ToInt64(record["ID"]) == 0L)
		{
			return null;
		}
		return new GroupRoleSetDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			GroupID = Convert.ToInt64(record["GroupID"]),
			Name = (string)record["Name"],
			Description = ((record["Description"] == null || record["Description"].Equals(DBNull.Value)) ? string.Empty : ((string)record["Description"])),
			Rank = (byte)record["Rank"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal static GroupRoleSetDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return RobloxDatabase.RobloxGroupRoleSets.Get("GroupRoleSets_GetGroupRoleSetByID", id, BuildDAL);
	}

	internal static GroupRoleSetDAL Get(long groupId, string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxGroupRoleSets.Lookup("GroupRoleSets_GetGroupRoleSetByGroupIDAndName", BuildDAL, queryParameters);
	}

	internal static ICollection<GroupRoleSetDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxGroupRoleSets.MultiGet("GroupRoleSets_GetGroupRoleSetsByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GroupRoleSetDAL> GetOrCreate(long groupId, string name, string description, byte rank)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID.");
		}
		if (string.IsNullOrEmpty(name))
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@Name", name),
			new SqlParameter("@Description", description),
			new SqlParameter("@Rank", rank)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetOrCreate("GroupRoleSets_GetOrCreateGroupRoleSetByGroupIDAndNameAndDescriptionAndRank", BuildDAL, queryParameters);
	}

	internal static GroupRoleSetDAL GetOwnerGroupRoleSetByGroupID(long groupId)
	{
		if (groupId == 0L)
		{
			throw new ApplicationException("Required value not specified: GroupID");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.Lookup("GroupRoleSets_GetOwnerGroupRoleSetByGroupID", BuildDAL, queryParameters);
	}

	internal static int GetTotalNumberOfGroupRoleSetsByGroupID(long groupId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetCount<int>("GroupRoleSets_GetTotalNumberOfGroupRoleSetsByGroupID", queryParameters);
	}

	internal static ICollection<long> GetGroupRoleSetIDsByGroupID(long groupId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@GroupID", groupId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("GroupRoleSets_GetGroupRoleSetIDsByGroupID", queryParameters);
	}

	internal static ICollection<long> GetGroupRoleSetIDsByGroupIDAndMaxRank(long groupId, byte maxRank)
	{
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@GroupID", groupId),
			new SqlParameter("@MaxRank", maxRank)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("GroupRoleSets_GetGroupRoleSetIDsByGroupIDAndMaxRank", queryParameters);
	}
}
