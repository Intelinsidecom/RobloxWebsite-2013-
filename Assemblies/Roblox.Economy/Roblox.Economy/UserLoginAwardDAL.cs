using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Economy.Common;

namespace Roblox.Economy;

[Serializable]
public class UserLoginAwardDAL
{
	private int _ID;

	private long _UserID;

	private DateTime? _LastAwarded;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

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

	public long UserID
	{
		get
		{
			return _UserID;
		}
		set
		{
			_UserID = value;
		}
	}

	public DateTime? LastAwarded
	{
		get
		{
			return _LastAwarded;
		}
		set
		{
			_LastAwarded = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _Created;
		}
		set
		{
			_Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _Updated;
		}
		set
		{
			_Updated = value;
		}
	}

	public static UserLoginAwardDAL Get(int id)
	{
		if (id == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(Helper.DBConnectionString, "UserLoginAwards_GetUserLoginAwardByID", queryParameters), BuildDAL);
	}

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(Helper.DBConnectionString, "[dbo].[UserLoginAwards_DeleteUserLoginAwardByID]", queryParameters));
	}

	public bool TrySetDailyAward()
	{
		SqlParameter output_LastAwarded = new SqlParameter("@LastAwarded", SqlDbType.DateTime);
		output_LastAwarded.Direction = ParameterDirection.Output;
		SqlParameter output_Updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_Updated.Direction = ParameterDirection.Output;
		SqlParameter output_IsSuccess = new SqlParameter("@IsSuccess", SqlDbType.Bit);
		output_IsSuccess.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(output_LastAwarded);
		queryParameters.Add(output_Updated);
		queryParameters.Add(output_IsSuccess);
		EntityHelper.DoEntityDALAction(new DbInfo(Helper.DBConnectionString, "[dbo].[UserLoginAwards_TrySetDailyAward]", queryParameters));
		_LastAwarded = (DateTime)output_LastAwarded.Value;
		_Updated = (DateTime)output_Updated.Value;
		return (bool)output_IsSuccess.Value;
	}

	private static UserLoginAwardDAL BuildDAL(SqlDataReader reader)
	{
		UserLoginAwardDAL dal = new UserLoginAwardDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.LastAwarded = (reader["LastAwarded"].Equals(DBNull.Value) ? null : ((DateTime?)reader["LastAwarded"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static EntityHelper.GetOrCreateDALWrapper<UserLoginAwardDAL> GetOrCreate(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(Helper.DBConnectionString, "[dbo].[UserLoginAwards_GetOrCreateUserLoginAward]", queryParameters), BuildDAL);
	}
}
