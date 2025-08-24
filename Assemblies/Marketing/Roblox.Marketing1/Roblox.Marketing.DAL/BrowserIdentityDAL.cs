using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Marketing.Properties;

namespace Roblox.Marketing.DAL;

public class BrowserIdentityDAL
{
	private int _ID;

	public int? UserID;

	public int? BrowserID;

	public DateTime Created;

	public DateTime Updated;

	public int ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	private static string dbConnectionString_BrowserIdentityDAL => Settings.Default.RobloxMarketing;

	private static BrowserIdentityDAL BuildDAL(SqlDataReader reader)
	{
		BrowserIdentityDAL dal = new BrowserIdentityDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = (reader["UserID"].Equals(DBNull.Value) ? null : ((int?)reader["UserID"]));
			dal.BrowserID = (reader["BrowserID"].Equals(DBNull.Value) ? null : ((int?)reader["BrowserID"]));
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
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		SqlParameter output_BrowserID = new SqlParameter("@BrowserID", SqlDbType.Int);
		output_BrowserID.Value = BrowserID;
		output_BrowserID.Direction = ParameterDirection.InputOutput;
		queryParameters.Add(new SqlParameter("@UserID", UserID.HasValue ? ((object)UserID) : DBNull.Value));
		queryParameters.Add(output_BrowserID);
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_BrowserIdentityDAL, "BrowserIdentities_InsertBrowserIdentity", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
		BrowserID = (int)output_BrowserID.Value;
	}

	public static BrowserIdentityDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_BrowserIdentityDAL, "BrowserIdentities_GetBrowserIdentityByID", queryParameters), BuildDAL);
	}
}
