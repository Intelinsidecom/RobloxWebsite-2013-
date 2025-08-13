using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class GroupRoleSetPermissionDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupRoleSets;

	internal long ID { get; set; }

	internal long RoleSetID { get; set; }

	internal int RoleSetPermissionTypeID { get; set; }

	internal byte RoleSetPermissionTypeCategoryID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxGroupRoleSets.Delete("RoleSetPermissions_DeleteRoleSetPermissionByID", ID);
	}

	internal void Insert()
	{
		if (RoleSetID == 0L)
		{
			throw new ApplicationException("Required value not specified: RoleSetID");
		}
		if (RoleSetPermissionTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetPermissionTypeID");
		}
		if (RoleSetPermissionTypeCategoryID == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetPermissionTypeCategoryID");
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
			new SqlParameter("@RoleSetID", RoleSetID),
			new SqlParameter("@RoleSetPermissionTypeID", RoleSetPermissionTypeID),
			new SqlParameter("@RoleSetPermissionTypeCategoryID", RoleSetPermissionTypeCategoryID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupRoleSets.Insert<long>("RoleSetPermissions_InsertRoleSetPermission", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (RoleSetID == 0L)
		{
			throw new ApplicationException("Required value not specified: RoleSetID");
		}
		if (RoleSetPermissionTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetPermissionTypeID");
		}
		if (RoleSetPermissionTypeCategoryID == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetPermissionTypeCategoryID");
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
			new SqlParameter("@RoleSetID", RoleSetID),
			new SqlParameter("@RoleSetPermissionTypeID", RoleSetPermissionTypeID),
			new SqlParameter("@RoleSetPermissionTypeCategoryID", RoleSetPermissionTypeCategoryID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupRoleSets.Update("RoleSetPermissions_UpdateRoleSetPermissionByID", queryParameters);
	}

	private static GroupRoleSetPermissionDAL BuildDAL(IDictionary<string, object> record)
	{
		if (Convert.ToInt64(record["ID"]) == 0L)
		{
			return null;
		}
		return new GroupRoleSetPermissionDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			RoleSetID = Convert.ToInt64(record["RoleSetID"]),
			RoleSetPermissionTypeID = (int)record["RoleSetPermissionTypeID"],
			RoleSetPermissionTypeCategoryID = (byte)record["RoleSetPermissionTypeCategoryID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal static GroupRoleSetPermissionDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return RobloxDatabase.RobloxGroupRoleSets.Get("RoleSetPermissions_GetRoleSetPermissionByID", id, BuildDAL);
	}

	internal static GroupRoleSetPermissionDAL GetByRoleSetIDAndTypeID(long roleSetId, int typeId)
	{
		if (roleSetId == 0L)
		{
			throw new ApplicationException("Required value not specified: RoleSetID.");
		}
		if (typeId == 0)
		{
			throw new ApplicationException("Required value not specified: TypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@RoleSetID", roleSetId),
			new SqlParameter("@RoleSetPermissionTypeID", typeId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.Lookup("RoleSetPermissions_GetRoleSetPermissionByRoleSetIDAndRoleSetPermissionTypeID", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetRoleSetPermissionIDsByRoleSetID(long roleSetId)
	{
		if (roleSetId == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@RoleSetID", roleSetId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<long>("RoleSetPermissions_GetRoleSetPermissionIDsByRoleSetID", queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<GroupRoleSetPermissionDAL> GetOrCreate(long roleSetId, int roleSetPermissionTypeId, byte roleSetPermissionTypeCategoryId)
	{
		if (roleSetId == 0L)
		{
			throw new ApplicationException("Required value not specified: RoleSetID.");
		}
		if (roleSetPermissionTypeId == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetPermissionTypeID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@RoleSetID", roleSetId),
			new SqlParameter("@RoleSetPermissionTypeID", roleSetPermissionTypeId),
			new SqlParameter("@RoleSetPermissionTypeCategoryID", roleSetPermissionTypeCategoryId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetOrCreate("RoleSetPermissions_GetOrCreateRoleSetPermissionByRoleSetIDAndRoleSetPermissionTypeID", BuildDAL, queryParameters);
	}

	internal static int GetTotalNumberOfRoleSetPermissionsByRoleSetID(long roleSetId)
	{
		if (roleSetId == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@RoleSetID", roleSetId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetCount<int>("RoleSetPermissions_GetTotalNumberOfRoleSetPermissionsByRoleSetID", queryParameters);
	}
}
