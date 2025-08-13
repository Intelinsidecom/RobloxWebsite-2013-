using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class BadgeDAL
{
	private int _ID;

	private int _BadgeTypeID;

	private long _UserID;

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

	public int BadgeTypeID
	{
		get
		{
			return _BadgeTypeID;
		}
		set
		{
			_BadgeTypeID = value;
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

	private static string DbConnectionString => RobloxDatabase.RobloxBadges.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[BadgesV2_DeleteBadgeByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (_BadgeTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: BadgeTypeID.");
		}
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@BadgeTypeID", _BadgeTypeID);
		dbHelper.SQLParameters.AddWithValue("@UserID", _UserID);
		dbHelper.SQLParameters.AddWithValue("@CreatedUtc", _Created.ToUniversalTime());
		dbHelper.SQLParameters.AddWithValue("@UpdatedUtc", _Updated.ToUniversalTime());
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.Int);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[BadgesV2_InsertBadge]", CommandType.StoredProcedure);
		_ID = Convert.ToInt32(id.Value);
	}

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (_BadgeTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: BadgeTypeID.");
		}
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (_Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (_Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@BadgeTypeID", _BadgeTypeID);
		dbHelper.SQLParameters.AddWithValue("@UserID", _UserID);
		dbHelper.SQLParameters.AddWithValue("@CreatedUtc", _Created.ToUniversalTime());
		dbHelper.SQLParameters.AddWithValue("@UpdatedUtc", _Updated.ToUniversalTime());
		dbHelper.ExecuteSQLScalar("[dbo].[BadgesV2_UpdateBadgeByID]", CommandType.StoredProcedure);
	}

	private static BadgeDAL BuildDAL(SqlDataReader reader)
	{
		BadgeDAL dal = new BadgeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.BadgeTypeID = (int)reader["BadgeTypeID"];
			dal.UserID = (long)reader["UserID"];
			dal.Created = DateTime.SpecifyKind((DateTime)reader["CreatedUtc"], DateTimeKind.Utc);
			dal.Updated = DateTime.SpecifyKind((DateTime)reader["UpdatedUtc"], DateTimeKind.Utc);
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static BadgeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[BadgesV2_GetBadgeByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<int> GetUserBadgeIDsByUserID(long userId)
	{
		if (userId == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		using DbHelper dbHelper = new DbHelper(DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", userId);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[BadgesV2_GetBadgeIDsByUserID]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<int>(reader);
	}
}
