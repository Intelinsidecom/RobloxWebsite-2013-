using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupRoleSetPermissionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupRoleSets;

	internal int ID { get; set; }

	internal string Name { get; set; }

	internal string Description { get; set; }

	internal byte CategoryID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxGroupRoleSets.Delete("RoleSetPermissionTypes_DeleteRolePermissionTypeByID", ID);
	}

	internal void Insert()
	{
		if (string.IsNullOrEmpty(Name))
		{
			throw new ApplicationException("Required value not specified: Name");
		}
		if (CategoryID == 0)
		{
			throw new ApplicationException("Required value not specified: Cateogry");
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
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", Description),
			new SqlParameter("@CategoryID", CategoryID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupRoleSets.Insert<int>("RoleSetPermissionTypes_InsertRoleSetPermissionType", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (string.IsNullOrEmpty(Name))
		{
			throw new ApplicationException("Required value not specified: Name");
		}
		if (CategoryID == 0)
		{
			throw new ApplicationException("Required value not specified: Cateogry");
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
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", string.IsNullOrEmpty(Description) ? ((IConvertible)DBNull.Value) : ((IConvertible)Description)),
			new SqlParameter("@CategoryID", CategoryID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupRoleSets.Update("RoleSetPermissionTypes_UpdateRoleSetPermissionTypeByID", queryParameters);
	}

	private static GroupRoleSetPermissionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		if ((int)record["ID"] == 0)
		{
			return null;
		}
		return new GroupRoleSetPermissionTypeDAL
		{
			ID = (int)record["ID"],
			Name = (string)record["Name"],
			Description = ((record["Description"] == null || record["Description"].Equals(DBNull.Value)) ? string.Empty : ((string)record["Description"])),
			CategoryID = (byte)record["CategoryID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal static GroupRoleSetPermissionTypeDAL Get(int id)
	{
		if (id == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		return RobloxDatabase.RobloxGroupRoleSets.Get("RoleSetPermissionTypes_GetRoleSetPermissionTypeByID", id, BuildDAL);
	}

	internal static GroupRoleSetPermissionTypeDAL GetByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			throw new ApplicationException("Required value not specified: Name.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxGroupRoleSets.Lookup("RoleSetPermissionTypes_GetRoleSetPermissionTypeByName", BuildDAL, queryParameters);
	}

	internal static ICollection<int> GetGroupRoleSetPermissionTypeIDsByCategoryID(byte categoryId)
	{
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@CategoryID", categoryId)
		};
		return RobloxDatabase.RobloxGroupRoleSets.GetIDCollection<int>("RoleSetPermissionTypes_GetGroupRoleSetPermissionTypeIDsByCategoryID", queryParameters);
	}
}
