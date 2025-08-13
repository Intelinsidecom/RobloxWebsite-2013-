using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Web.ElevatedActions.DAL;

public class ElevatedActionDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxRoles.GetConnectionString();

	public int ID { get; set; }

	public string Name { get; set; }

	public string Description { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static ElevatedActionDAL BuildDAL(SqlDataReader reader)
	{
		ElevatedActionDAL dal = new ElevatedActionDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Name = (string)reader["Name"];
			dal.Description = (string)reader["Description"];
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
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "ElevatedActions_InsertElevatedAction", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Name", Name),
			new SqlParameter("@Description", Description),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "ElevatedActions_UpdateElevatedActionByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "ElevatedActions_DeleteElevatedActionByID", queryParameters));
	}

	public static ElevatedActionDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ElevatedActions_GetElevatedActionByID", queryParameters), BuildDAL);
	}

	public static ElevatedActionDAL Get(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@Name", name)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "ElevatedActions_GetElevatedActionByName", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetAllElevatedActionIDs()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[ElevatedActions_GetAllElevatedActionIDs]", queryParameters));
	}
}
