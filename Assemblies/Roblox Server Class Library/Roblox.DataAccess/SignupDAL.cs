using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class SignupDAL
{
	public enum SelectFilter
	{
		ID,
		UserID
	}

	public long ID;

	public DateTime Created = DateTime.MinValue;

	public DateTime Updated = DateTime.MinValue;

	public int ThemeTypeID;

	public long? UserID { get; set; }

	public bool? AgeGroup { get; set; }

	public int? SignupPath { get; set; }

	public bool? DOBPageViewed { get; set; }

	public bool? UsernamePageViewed { get; set; }

	public bool? EmailPageViewed { get; set; }

	public bool? EmailValidated { get; set; }

	private static string ConnectionString => RobloxDatabase.RobloxUsers.GetConnectionString();

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", UserID.HasValue ? ((object)UserID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AgeGroup", AgeGroup.HasValue ? ((object)AgeGroup) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SignupPath", SignupPath.HasValue ? ((object)SignupPath) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@DOBPageViewed", DOBPageViewed.HasValue ? ((object)DOBPageViewed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@UsernamePageViewed", UsernamePageViewed.HasValue ? ((object)UsernamePageViewed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EmailPageViewed", EmailPageViewed.HasValue ? ((object)EmailPageViewed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EmailValidated", EmailValidated.HasValue ? ((object)EmailValidated) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@ThemeTypeID", ThemeTypeID));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[Signups_InsertSignup]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", ID));
		queryParameters.Add(new SqlParameter("@UserID", UserID.HasValue ? ((object)UserID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@AgeGroup", AgeGroup.HasValue ? ((object)AgeGroup) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@SignupPath", SignupPath.HasValue ? ((object)SignupPath) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@DOBPageViewed", DOBPageViewed.HasValue ? ((object)DOBPageViewed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@UsernamePageViewed", UsernamePageViewed.HasValue ? ((object)UsernamePageViewed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EmailPageViewed", EmailPageViewed.HasValue ? ((object)EmailPageViewed) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@EmailValidated", EmailValidated.HasValue ? ((object)EmailValidated) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@ThemeTypeID", ThemeTypeID));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[Signups_UpdateSignupByID]", queryParameters));
	}

	private static SignupDAL BuildDAL(SqlDataReader reader)
	{
		SignupDAL dal = new SignupDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.UserID = (reader["UserID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["UserID"])));
			dal.AgeGroup = (reader["AgeGroup"].Equals(DBNull.Value) ? null : ((bool?)reader["AgeGroup"]));
			dal.SignupPath = (reader["SignupPath"].Equals(DBNull.Value) ? null : ((int?)reader["SignupPath"]));
			dal.DOBPageViewed = (reader["DOBPageViewed"].Equals(DBNull.Value) ? null : ((bool?)reader["DOBPageViewed"]));
			dal.EmailPageViewed = (reader["EmailPageViewed"].Equals(DBNull.Value) ? null : ((bool?)reader["EmailPageViewed"]));
			dal.EmailValidated = (reader["EmailValidated"].Equals(DBNull.Value) ? null : ((bool?)reader["EmailValidated"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.ThemeTypeID = (int)reader["ThemeTypeID"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static SignupDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[Signups_GetSignupByID]", queryParameters), BuildDAL);
	}

	public static SignupDAL Get(SelectFilter filter, long id)
	{
		if (id == 0L)
		{
			return null;
		}
		if (filter == SelectFilter.ID)
		{
			return Get(id);
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[Signups_GetSignupByUserID]", queryParameters), BuildDAL);
	}
}
