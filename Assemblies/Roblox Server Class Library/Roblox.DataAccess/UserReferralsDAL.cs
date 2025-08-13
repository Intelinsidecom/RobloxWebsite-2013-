using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class UserReferralsDAL
{
	private int _ID;

	private long _UserID;

	private long _ReferrerID;

	private string _Type;

	private DateTime _Time = DateTime.MinValue;

	private bool _Awarded;

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

	public long ReferrerID
	{
		get
		{
			return _ReferrerID;
		}
		set
		{
			_ReferrerID = value;
		}
	}

	public string Type
	{
		get
		{
			return _Type;
		}
		set
		{
			_Type = value;
		}
	}

	public DateTime Time
	{
		get
		{
			return _Time;
		}
		set
		{
			_Time = value;
		}
	}

	public bool Awarded
	{
		get
		{
			return _Awarded;
		}
		set
		{
			_Awarded = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxUsers.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[UserReferrals_DeleteUserReferralByID]", queryParameters));
	}

	public void Insert()
	{
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (_ReferrerID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReferrerID.");
		}
		if (_Type == null)
		{
			throw new ApplicationException("Required value not specified: Type");
		}
		if (_Time == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Time");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", _UserID));
		queryParameters.Add(new SqlParameter("@ReferrerID", _ReferrerID));
		queryParameters.Add(new SqlParameter("@Type", _Type));
		queryParameters.Add(new SqlParameter("@Time", _Time));
		queryParameters.Add(new SqlParameter("@Awarded", _Awarded));
		_ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(ConnectionString, "[dbo].[UserReferrals_InsertUserReferrals]", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (_ReferrerID == 0L)
		{
			throw new ApplicationException("Required value not specified: ReferrerID");
		}
		if (_Type == null)
		{
			throw new ApplicationException("Required value not specified: Type");
		}
		if (_Time == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Time");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@UserID", _UserID));
		queryParameters.Add(new SqlParameter("@ReferrerID", _ReferrerID));
		queryParameters.Add(new SqlParameter("@Type", _Type));
		queryParameters.Add(new SqlParameter("@Time", _Time));
		queryParameters.Add(new SqlParameter("@Awarded", _Awarded));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[UserReferrals_UpdateUserReferralsByID]", queryParameters));
	}

	private static UserReferralsDAL BuildDAL(SqlDataReader reader)
	{
		UserReferralsDAL dal = new UserReferralsDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.ReferrerID = Convert.ToInt64(reader["ReferrerID"]);
			dal.Type = (string)reader["Type"];
			dal.Time = (DateTime)reader["Time"];
			dal.Awarded = (bool)reader["Awarded"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static UserReferralsDAL GetByUserIDAndType(long userId, string type)
	{
		if (userId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		queryParameters.Add(new SqlParameter("@Type", type));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[UserReferrals_GetUserReferralsByUserIDAndType]", queryParameters), BuildDAL);
	}
}
