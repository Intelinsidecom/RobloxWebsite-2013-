using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

public class AccountSecurityTicketItemDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountSecurity;

	internal long ID { get; set; }

	internal long AccountSecurityTicketID { get; set; }

	internal short AccountSecurityTypeID { get; set; }

	internal long AccountSecurityTargetID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountSecurityTicketItemDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountSecurityTicketItemDAL
		{
			ID = (long)record["ID"],
			AccountSecurityTicketID = (long)record["AccountSecurityTicketID"],
			AccountSecurityTypeID = (short)record["AccountSecurityTypeID"],
			AccountSecurityTargetID = (long)record["AccountSecurityTargetID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountSecurity.Delete("AccountSecurityTicketItems_DeleteAccountSecurityTicketItemByID", ID);
	}

	internal static AccountSecurityTicketItemDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountSecurity.Get("AccountSecurityTicketItems_GetAccountSecurityTicketItemByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountSecurityTicketID", AccountSecurityTicketID),
			new SqlParameter("@AccountSecurityTypeID", AccountSecurityTypeID),
			new SqlParameter("@AccountSecurityTargetID", AccountSecurityTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountSecurity.Insert<long>("AccountSecurityTicketItems_InsertAccountSecurityTicketItem", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountSecurityTicketID", AccountSecurityTicketID),
			new SqlParameter("@AccountSecurityTypeID", AccountSecurityTypeID),
			new SqlParameter("@AccountSecurityTargetID", AccountSecurityTargetID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountSecurity.Update("AccountSecurityTicketItems_UpdateAccountSecurityTicketItemByID", queryParameters);
	}

	internal static ICollection<AccountSecurityTicketItemDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountSecurity.MultiGet("AccountSecurityTicketItems_GetAccountSecurityTicketItemsByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountSecurityTicketItemIDsByAccountSecurityTicketID(long accountSecurityTicketID, int count, long exclusiveStartAccountSecurityTicketItemId)
	{
		if (accountSecurityTicketID == 0L)
		{
			throw new ArgumentException("Parameter 'accountSecurityTicketID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountSecurityTicketItemId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountSecurityTicketItemID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@AccountSecurityTicketID", accountSecurityTicketID),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartAccountSecurityTicketItemID", exclusiveStartAccountSecurityTicketItemId)
		};
		return RobloxDatabase.RobloxAccountSecurity.GetIDCollection<long>("AccountSecurityTicketItems_GetAccountSecurityTicketItemIDsByAccountSecurityTicketID", queryParameters);
	}

	internal static int GetTotalNumberOfAccountSecurityTicketItemsByAccountSecurityTicketID(long accountSecurityTicketID)
	{
		if (accountSecurityTicketID == 0L)
		{
			throw new ArgumentException("Parameter 'accountSecurityTicketID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountSecurityTicketID", accountSecurityTicketID)
		};
		return RobloxDatabase.RobloxAccountSecurity.GetCount<int>("AccountSecurityTicketItems_GetTotalNumberOfAccountSecurityTicketItemsByAccountSecurityTicketID", queryParameters);
	}
}
