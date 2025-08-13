using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing.DAL;

public class InstallSuccessTrackerDAL
{
	private long _ID;

	public int? AccountID;

	public long BrowserTrackerID;

	public DateTime Created;

	public DateTime Updated;

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

	private static string ConnectionString => RobloxDatabase.RobloxMarketing.GetConnectionString();

	private static InstallSuccessTrackerDAL BuildDAL(SqlDataReader reader)
	{
		InstallSuccessTrackerDAL dal = new InstallSuccessTrackerDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccountID = (reader["AccountID"].Equals(DBNull.Value) ? null : ((int?)reader["AccountID"]));
			dal.BrowserTrackerID = (long)reader["BrowserTrackerID"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
	}

	public void Update()
	{
		throw new NotImplementedException();
	}

	public void Delete()
	{
		throw new NotImplementedException();
	}

	public static InstallSuccessTrackerDAL Get(long id)
	{
		throw new NotImplementedException();
	}

	public static ICollection<long> GetInstallSuccessTrackerIDsByBrowserTrackerID(long BrowserTrackerID)
	{
		throw new NotImplementedException();
	}
}
