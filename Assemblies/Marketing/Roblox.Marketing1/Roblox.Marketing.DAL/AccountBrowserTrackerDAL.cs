using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Marketing.DAL;

[ExcludeFromCodeCoverage]
internal class AccountBrowserTrackerDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxMarketing;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal long BrowserTrackerID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountBrowserTrackerDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountBrowserTrackerDAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			BrowserTrackerID = (long)record["BrowserTrackerID"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local)
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxMarketing.Delete("AccountBrowserTrackersNewV2_DeleteAccountBrowserTrackerNewV2ByID", ID);
	}

	internal static AccountBrowserTrackerDAL Get(long id)
	{
		return RobloxDatabase.RobloxMarketing.Get("AccountBrowserTrackersNewV2_GetAccountBrowserTrackerNewV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@BrowserTrackerID", BrowserTrackerID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		ID = RobloxDatabase.RobloxMarketing.Insert<long>("AccountBrowserTrackersNewV2_InsertAccountBrowserTrackerNewV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@BrowserTrackerID", BrowserTrackerID),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.ToLocalTime())
		};
		RobloxDatabase.RobloxMarketing.Update("AccountBrowserTrackersNewV2_UpdateAccountBrowserTrackerNewV2ByID", queryParameters);
	}

	internal static ICollection<AccountBrowserTrackerDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxMarketing.MultiGet("AccountBrowserTrackersNewV2_GetAccountBrowserTrackersNewV2ByIDs", ids, BuildDAL);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountBrowserTrackerDAL> GetOrCreate(long accountId, long browserTrackerId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Required value not specified: accountId");
		}
		if (browserTrackerId == 0L)
		{
			throw new ArgumentException("Required value not specified: browserTrackerId");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@BrowserTrackerID", browserTrackerId)
		};
		return RobloxDatabase.RobloxMarketing.GetOrCreate("AccountBrowserTrackersNewV2_GetOrCreateAccountBrowserTrackerNewV2", BuildDAL, queryParameters);
	}

	internal static AccountBrowserTrackerDAL GetByAccountIDAndBrowserTrackerID(long accountId, long browserTrackerId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		if (browserTrackerId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@BrowserTrackerID", browserTrackerId)
		};
		return RobloxDatabase.RobloxMarketing.Lookup("AccountBrowserTrackersNewV2_GetAccountBrowserTrackerNewV2ByAccountIDAndBrowserTrackerID", BuildDAL, queryParameters);
	}
}
