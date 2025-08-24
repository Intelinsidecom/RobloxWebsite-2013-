using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Marketing.Core.Entities;

internal class Win10AppSignupDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal long ID { get; set; }

	internal long UserID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static Win10AppSignupDAL BuildDAL(IDictionary<string, object> record)
	{
		return new Win10AppSignupDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			UserID = Convert.ToInt64(record["UserID"]),
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("Win10AppSignups_DeleteWin10AppSignupByID", ID);
	}

	internal static Win10AppSignupDAL Get(long id)
	{
		return RobloxDatabase.RobloxMarketing.Get("Win10AppSignups_GetWin10AppSignupByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<long>("Win10AppSignups_InsertWin10AppSignup", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@UserID", UserID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxMarketing.Update("Win10AppSignups_UpdateWin10AppSignupByID", queryParameters);
	}

	internal static ICollection<Win10AppSignupDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("Win10AppSignups_GetWin10AppSignupsByIDs", ids, BuildDAL);
	}
}
