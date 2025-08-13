using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox;

public class GroupActionTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxGroupRoleSets;

	internal int ID { get; set; }

	internal int PermissionTypeID { get; set; }

	internal string Name { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static GroupActionTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		if ((int)record["ID"] == 0)
		{
			return null;
		}
		return new GroupActionTypeDAL
		{
			ID = (int)record["ID"],
			PermissionTypeID = (int)record["PermissionTypeID"],
			Name = (string)record["Name"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PermissionTypeID", PermissionTypeID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxGroupRoleSets.Insert<int>("GroupActionTypes_InsertGroupActionType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PermissionTypeID", PermissionTypeID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxGroupRoleSets.Update("GroupActionTypes_UpdateGroupActionTypeByID", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxGroupRoleSets.Delete("GroupActionTypes_DeleteGroupActionTypeByID", ID);
	}

	internal static GroupActionTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		return RobloxDatabase.RobloxGroupRoleSets.Get("GroupActionTypes_GetGroupActionTypeByID", id, BuildDAL);
	}

	internal static GroupActionTypeDAL GetByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxGroupRoleSets.Lookup("GroupActionTypes_GetGroupActionTypeByName", BuildDAL, queryParameters);
	}
}
