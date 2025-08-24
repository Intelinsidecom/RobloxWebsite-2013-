using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing.DAL;

public class BrowserTrackerDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxBrowserTrackers;

	public long ID { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	private static BrowserTrackerDAL BuildDAL(IDictionary<string, object> record)
	{
		return new BrowserTrackerDAL
		{
			ID = (long)record["ID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	public static BrowserTrackerDAL Get(long id)
	{
		return RobloxDatabase.RobloxBrowserTrackers.Get("BrowserTrackers_GetBrowserTrackerByID", id, BuildDAL);
	}

	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxBrowserTrackers.Insert<long>("BrowserTrackers_InsertBrowserTracker", queryParameters);
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxBrowserTrackers.Delete("BrowserTrackers_DeleteBrowserTrackerByID", ID);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxBrowserTrackers.Update("BrowserTrackers_UpdateBrowserTrackerByID", queryParameters);
	}
}
