using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class FeedDAL
{
	private long _ID;

	private long _UserID;

	private long _ItemID;

	private int _ItemType;

	private int _ActionType;

	private string _Description = string.Empty;

	private DateTime _ActionDate = DateTime.MinValue;

	private DateTime _HarvestDate = DateTime.MinValue;

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

	public long ItemID
	{
		get
		{
			return _ItemID;
		}
		set
		{
			_ItemID = value;
		}
	}

	public int ItemType
	{
		get
		{
			return _ItemType;
		}
		set
		{
			_ItemType = value;
		}
	}

	public int ActionType
	{
		get
		{
			return _ActionType;
		}
		set
		{
			_ActionType = value;
		}
	}

	public string Description
	{
		get
		{
			return _Description;
		}
		set
		{
			_Description = value;
		}
	}

	public DateTime ActionDate
	{
		get
		{
			return _ActionDate;
		}
		set
		{
			_ActionDate = value;
		}
	}

	public DateTime HarvestDate
	{
		get
		{
			return _HarvestDate;
		}
		set
		{
			_HarvestDate = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxFeeds.GetConnectionString();

	public void Delete()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[Feeds_DeleteFeedByID]", queryParameters));
	}

	public static void Delete(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[Feeds_DeleteFeedByID]", queryParameters));
	}

	public void Insert()
	{
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (_ActionType == 0)
		{
			throw new ApplicationException("Required value not specified: ActionType");
		}
		if (_Description.Length == 0)
		{
			throw new ApplicationException("Required value not specified: Description.");
		}
		if (_ActionDate.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", _UserID));
		queryParameters.Add(new SqlParameter("@ItemID", _ItemID));
		queryParameters.Add(new SqlParameter("@ItemType", _ItemType));
		queryParameters.Add(new SqlParameter("@ActionType", _ActionType));
		queryParameters.Add(new SqlParameter("@Description", _Description));
		queryParameters.Add(new SqlParameter("@ActionDate", _ActionDate));
		queryParameters.Add(new SqlParameter("@HarvestDate", _HarvestDate));
		_ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[Feeds_InsertFeed]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		if (_ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		if (_UserID == 0L)
		{
			throw new ApplicationException("Required value not specified: UserID");
		}
		if (_ActionType == 0)
		{
			throw new ApplicationException("Required value not specified: ActionType");
		}
		if (_Description.Trim().Length == 0)
		{
			throw new ApplicationException("Required value not specified: Description.");
		}
		if (_ActionDate.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@UserID", _UserID));
		queryParameters.Add(new SqlParameter("@ItemID", _ItemID));
		queryParameters.Add(new SqlParameter("@ItemType", _ItemType));
		queryParameters.Add(new SqlParameter("@ActionType", _ActionType));
		queryParameters.Add(new SqlParameter("@Description", _Description));
		queryParameters.Add(new SqlParameter("@ActionDate", _ActionDate));
		queryParameters.Add(new SqlParameter("@HarvestDate", _HarvestDate));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[Feeds_UpdateFeedByID]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	private static FeedDAL BuildDAL(SqlDataReader reader)
	{
		FeedDAL dal = new FeedDAL();
		while (reader.Read())
		{
			dal.ID = Convert.ToInt64(reader["ID"]);
			dal.UserID = Convert.ToInt64(reader["UserID"]);
			dal.ItemID = Convert.ToInt64(reader["ItemID"]);
			dal.ItemType = (int)reader["ItemType"];
			dal.ActionType = (int)reader["ActionType"];
			dal.Description = (string)reader["Description"];
			dal.ActionDate = (DateTime)reader["ActionDate"];
			dal.HarvestDate = (DateTime)reader["HarvestDate"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static FeedDAL Get(long id)
	{
		if (id == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[Feeds_GetFeedByID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetFeedIDsByUserIDAndActionType(long userID, int actionType, int limit)
	{
		if (userID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (actionType == 0)
		{
			throw new ApplicationException("Required value not specified: ActionType.");
		}
		if (limit == 0)
		{
			throw new ApplicationException("Required value not specified: limit.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserID", userID));
		queryParameters.Add(new SqlParameter("@ActionType", actionType));
		queryParameters.Add(new SqlParameter("@Limit", limit));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[Feeds_GetFeedIDsByUserIDAndActionType]", queryParameters));
	}

	public static ICollection<long> GetFeedIDsByItemIDAndActionType(long itemID, int actionType, int limit)
	{
		if (itemID == 0L)
		{
			throw new ApplicationException("Required value not specified: itemID.");
		}
		if (actionType == 0)
		{
			throw new ApplicationException("Required value not specified: ActionType.");
		}
		if (limit == 0)
		{
			throw new ApplicationException("Required value not specified: limit.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ItemID", itemID));
		queryParameters.Add(new SqlParameter("@ActionType", actionType));
		queryParameters.Add(new SqlParameter("@Limit", limit));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[Feeds_GetFeedIDsByItemIDAndActionType]", queryParameters));
	}
}
