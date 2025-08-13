using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class ShowcaseDAL
{
	private long _ID;

	private long _UserID;

	private long _AssetID;

	private byte _SortOrder;

	private DateTime _Created = DateTime.MinValue;

	private DateTime _Updated = DateTime.MinValue;

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

	public long AssetID
	{
		get
		{
			return _AssetID;
		}
		set
		{
			_AssetID = value;
		}
	}

	public byte SortOrder
	{
		get
		{
			return _SortOrder;
		}
		set
		{
			_SortOrder = value;
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

	private static string _DbConnectionString => RobloxDatabase.RobloxPlaceShowcases.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.ExecuteSQLScalar("[dbo].[ShowcasesV2_DeleteShowcaseByID]", CommandType.StoredProcedure);
	}

	public void Insert()
	{
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID.");
		}
		if (_AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", _UserID);
		dbHelper.SQLParameters.AddWithValue("@AssetID", _AssetID);
		dbHelper.SQLParameters.AddWithValue("@SortOrder", _SortOrder);
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		SqlParameter id = dbHelper.SQLParameters.Add("@ID", SqlDbType.BigInt);
		id.Direction = ParameterDirection.Output;
		dbHelper.ExecuteSQLScalar("[dbo].[ShowcasesV2_InsertShowcase]", CommandType.StoredProcedure);
		_ID = Convert.ToInt64(id.Value);
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
		if (_AssetID == 0L)
		{
			throw new ApplicationException("Required value not specified: AssetID.");
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", _ID);
		dbHelper.SQLParameters.AddWithValue("@UserID", _UserID);
		dbHelper.SQLParameters.AddWithValue("@AssetID", _AssetID);
		dbHelper.SQLParameters.AddWithValue("@SortOrder", _SortOrder);
		dbHelper.SQLParameters.AddWithValue("@Created", _Created);
		dbHelper.SQLParameters.AddWithValue("@Updated", _Updated);
		dbHelper.ExecuteSQLScalar("[dbo].[ShowcasesV2_UpdateShowcaseByID]", CommandType.StoredProcedure);
	}

	private static ShowcaseDAL BuildDAL(SqlDataReader reader)
	{
		ShowcaseDAL dal = new ShowcaseDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.UserID = (long)reader["UserID"];
			dal.AssetID = (long)reader["AssetID"];
			dal.SortOrder = (byte)reader["SortOrder"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static ShowcaseDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@ID", id);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ShowcasesV2_GetShowcaseByID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ShowcaseDAL Get(long userId, long assetId)
	{
		if (userId == 0L || assetId == 0L)
		{
			return null;
		}
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", userId);
		dbHelper.SQLParameters.AddWithValue("@AssetID", assetId);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ShowcasesV2_GetShowcaseByUserIDAndAssetID]", CommandType.StoredProcedure);
		return BuildDAL(reader);
	}

	public static ICollection<long> GetShowcaseIDs(long userId, string sortExpression, int startRowIndex, int maximumRows)
	{
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", userId);
		dbHelper.SQLParameters.AddWithValue("@SortExpression", sortExpression);
		dbHelper.SQLParameters.AddWithValue("@StartRowIndex", startRowIndex);
		dbHelper.SQLParameters.AddWithValue("@MaximumRows", maximumRows);
		using SqlDataReader reader = dbHelper.ExecuteSQLReader("[dbo].[ShowcasesV2_GetShowcaseIDsBySearchCriteria_PagedAndSorted]", CommandType.StoredProcedure);
		return DbHelper.BuildIDCollection<long>(reader);
	}

	public static int GetTotalNumberOfShowcases(long userId)
	{
		using DbHelper dbHelper = new DbHelper(_DbConnectionString);
		dbHelper.SQLParameters.AddWithValue("@UserID", userId);
		return Convert.ToInt32(dbHelper.ExecuteSQLScalar("[dbo].[ShowcasesV2_GetTotalNumberOfShowcases]", CommandType.StoredProcedure));
	}
}
