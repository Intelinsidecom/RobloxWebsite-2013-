using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox;

[Serializable]
public class UserStatusDAL
{
	public enum SelectFilter
	{
		ID,
		UserID
	}

	private long _ID;

	private long _UserID;

	private string _Message = string.Empty;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

	private static string ConnectionString => RobloxDatabase.RobloxUserStatuses.GetConnectionString();

	public long ID
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

	public string Message
	{
		get
		{
			return _Message;
		}
		set
		{
			_Message = value;
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

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[UserStatusesV2_DeleteUserStatusV2ByID]", queryParameters));
	}

	public void Insert()
	{
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (_Message == null)
		{
			throw new ApplicationException("Required value not specified: Message");
		}
		if (_Created == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Created");
		}
		if (_Updated == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Updated");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", _UserID));
		queryParameters.Add(new SqlParameter("@Message", _Message));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[UserStatusesV2_InsertUserStatusV2]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (_Message == null)
		{
			throw new ApplicationException("Required value not specified: Message.");
		}
		if (_Created == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated == DateTime.MinValue)
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@UserID", _UserID));
		queryParameters.Add(new SqlParameter("@Message", _Message));
		queryParameters.Add(new SqlParameter("@Created", _Created));
		queryParameters.Add(new SqlParameter("@Updated", _Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[UserStatusesV2_UpdateUserStatusV2ByID]", queryParameters));
	}

	private static UserStatusDAL BuildDAL(SqlDataReader reader)
	{
		UserStatusDAL dal = new UserStatusDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.Message = (string)reader["Message"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static UserStatusDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[UserStatusesV2_GetUserStatusV2ByID]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<UserStatusDAL> GetOrCreate(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userId));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(ConnectionString, "[dbo].[UserStatusesV2_GetOrCreateUserStatusV2]", queryParameters), BuildDAL);
	}
}
