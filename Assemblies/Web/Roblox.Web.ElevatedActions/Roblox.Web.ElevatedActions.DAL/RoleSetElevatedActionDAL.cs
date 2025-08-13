using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Web.ElevatedActions.DAL;

public class RoleSetElevatedActionDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxRoles.GetConnectionString();

	public int ID { get; set; }

	public int RoleSetID { get; set; }

	public int ElevatedActionID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static RoleSetElevatedActionDAL BuildDAL(SqlDataReader reader)
	{
		RoleSetElevatedActionDAL dal = new RoleSetElevatedActionDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.RoleSetID = (int)reader["RoleSetID"];
			dal.ElevatedActionID = (int)reader["ElevatedActionID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@RoleSetID", RoleSetID),
			new SqlParameter("@ElevatedActionID", ElevatedActionID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "RoleSetElevatedActions_InsertRoleSetElevatedAction", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@RoleSetID", RoleSetID),
			new SqlParameter("@ElevatedActionID", ElevatedActionID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "RoleSetElevatedActions_UpdateRoleSetElevatedActionByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "RoleSetElevatedActions_DeleteRoleSetElevatedActionByID", queryParameters));
	}

	public static RoleSetElevatedActionDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "RoleSetElevatedActions_GetRoleSetElevatedActionByID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetRoleSetElevatedActionIDsByRoleSetID(int roleSetId)
	{
		if (roleSetId == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@RoleSetID", roleSetId)
		};
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "RoleSetElevatedActions_GetRoleSetElevatedActionIDsByRoleSetID", queryParameters));
	}

	internal static RoleSetElevatedActionDAL Get(int roleSetId, int elevatedActionId)
	{
		if (roleSetId == 0)
		{
			throw new ApplicationException("Required value not specified: RoleSetID.");
		}
		if (elevatedActionId == 0)
		{
			throw new ApplicationException("Required value not specified: ElevatedActionID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@RoleSetID", roleSetId),
			new SqlParameter("@ElevatedActionID", elevatedActionId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "RoleSetElevatedActions_GetRoleSetElevatedActionByRoleSetIDAndElevatedActionID", queryParameters), BuildDAL);
	}
}
