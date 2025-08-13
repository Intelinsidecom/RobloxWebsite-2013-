using System;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing;

public class NewBrowserTrackerDmpDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	public int ID { get; set; }

	public long BrowserTrackerID { get; set; }

	public string UserAgent { get; set; }

	public string IPAddress { get; set; }

	public long? UserID { get; set; }

	public string RequestedResource { get; set; }

	public string AdditionalData { get; set; }

	public DateTime Created { get; set; }

	internal void Insert()
	{
		SqlParameter[] obj = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@BrowserTrackerID", BrowserTrackerID),
			new SqlParameter("@UserAgent", UserAgent),
			new SqlParameter("@IPAddress", IPAddress),
			null,
			null,
			null,
			null
		};
		long? userID = UserID;
		obj[4] = new SqlParameter("@UserID", userID.HasValue ? ((object)userID.GetValueOrDefault()) : DBNull.Value);
		obj[5] = new SqlParameter("@RequestedResource", RequestedResource);
		obj[6] = new SqlParameter("@AdditionalData", AdditionalData);
		obj[7] = new SqlParameter("@Created", Created.ToLocalTime());
		SqlParameter[] queryParameters = obj;
		ID = RobloxDatabase.RobloxMarketing.Insert<int>("NewBrowserTrackerDmps_InsertNewBrowserTrackerDmp", queryParameters);
	}
}
