using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

public class AlertDAL
{
	private int _ID;

	public long UserID;

	public string Text;

	public DateTime Created;

	public DateTime Updated;

	public int VisibilityTypeID;

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

	private static string ConnectionString => RobloxDatabase.Roblox.GetConnectionString();

	private static AlertDAL BuildDAL(SqlDataReader reader)
	{
		AlertDAL dal = new AlertDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Text = (string)reader["Text"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.VisibilityTypeID = (int)reader["VisibilityTypeID"];
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
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@Text", Text));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@VisibilityTypeID", VisibilityTypeID));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "Alerts_InsertAlert", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@UserID", UserID));
		queryParameters.Add(new SqlParameter("@Text", Text));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@VisibilityTypeID", VisibilityTypeID));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "Alerts_UpdateAlertByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "Alerts_DeleteAlertByID", queryParameters));
	}

	public static AlertDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "Alerts_GetAlertByID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetMostRecentIDsPaged(int startRowIndex, int maximumRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex));
		queryParameters.Add(new SqlParameter("@MaximumRows", maximumRows));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(ConnectionString, "[dbo].[Alerts_GetMostRecentIDs_Paged]", queryParameters));
	}
}
