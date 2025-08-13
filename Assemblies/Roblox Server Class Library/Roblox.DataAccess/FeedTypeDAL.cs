using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class FeedTypeDAL
{
	private int _ID;

	private string _FeedType = "";

	private int _Lifetime;

	private bool _Enabled;

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

	public string FeedType
	{
		get
		{
			return _FeedType;
		}
		set
		{
			_FeedType = value;
		}
	}

	public int Lifetime
	{
		get
		{
			return _Lifetime;
		}
		set
		{
			_Lifetime = value;
		}
	}

	public bool Enabled
	{
		get
		{
			return _Enabled;
		}
		set
		{
			_Enabled = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxFeeds.GetConnectionString();

	public void Update()
	{
		if (_ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID");
		}
		if (string.IsNullOrEmpty(_FeedType))
		{
			throw new ApplicationException("Required value not specified: _FeedType");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@FeedType", _FeedType));
		queryParameters.Add(new SqlParameter("@Lifetime", _Lifetime));
		queryParameters.Add(new SqlParameter("@Enabled", _Enabled));
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[FeedTypes_UpdateFeedTypeByID]", queryParameters));
	}

	private static FeedTypeDAL BuildDAL(SqlDataReader reader)
	{
		FeedTypeDAL dal = new FeedTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.FeedType = (string)reader["FeedType"];
			dal.Lifetime = (int)reader["Lifetime"];
			dal.Enabled = (bool)reader["Enabled"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static FeedTypeDAL Get(string feedType)
	{
		if (feedType.Trim().Length == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@FeedType", feedType));
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[FeedTypes_GetFeedTypeByType]", queryParameters), BuildDAL);
	}
}
