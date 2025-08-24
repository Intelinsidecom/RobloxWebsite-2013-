using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityTicketsV2DAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountSecurity;

	internal long ID { get; set; }

	internal Guid Value { get; set; }

	internal long AccountID { get; set; }

	internal bool IsValid { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountSecurityTicketsV2DAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountSecurityTicketsV2DAL
		{
			ID = (long)record["ID"],
			Value = (Guid)record["Value"],
			AccountID = (long)record["AccountID"],
			IsValid = (bool)record["IsValid"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountSecurity.Delete("AccountSecurityTicketsV2_DeleteAccountSecurityTicketV2ByID", ID);
	}

	internal static AccountSecurityTicketsV2DAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountSecurity.Get("AccountSecurityTicketsV2_GetAccountSecurityTicketV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@IsValid", IsValid),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountSecurity.Insert<long>("AccountSecurityTicketsV2_InsertAccountSecurityTicketV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@IsValid", IsValid),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountSecurity.Update("AccountSecurityTicketsV2_UpdateAccountSecurityTicketV2ByID", queryParameters);
	}

	internal static ICollection<AccountSecurityTicketsV2DAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountSecurity.MultiGet("AccountSecurityTicketsV2_GetAccountSecurityTicketsV2ByIDs", ids, BuildDAL);
	}

	internal static AccountSecurityTicketsV2DAL GetAccountSecurityTicketsV2ByValue(Guid value)
	{
		if (value == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountSecurity.Lookup("AccountSecurityTicketsV2_GetAccountSecurityTicketV2ByValue", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetAccountSecurityTicketsV2IDsByAccountIDAndIsValid(long accountID, bool isValid, long count, long exclusiveStartAccountSecurityTicketsV2Id)
	{
		if (accountID == 0L)
		{
			throw new ArgumentException("Parameter 'accountID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountSecurityTicketsV2Id < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountSecurityTicketsV2ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@AccountID", accountID),
			new SqlParameter("@IsValid", isValid),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartAccountSecurityTicketV2ID", exclusiveStartAccountSecurityTicketsV2Id)
		};
		return RobloxDatabase.RobloxAccountSecurity.GetIDCollection<long>("AccountSecurityTicketsV2_GetAccountSecurityTicketsV2IDsByAccountIDAndIsValid", queryParameters);
	}

	internal static long GetTotalNumberOfAccountSecurityTicketsV2ByAccountIDAndIsValid(long accountId, bool isValid)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountID' cannot be null, empty or the default value.");
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@IsValid", isValid)
		};
		return RobloxDatabase.RobloxAccountSecurity.GetCount<int>("AccountSecurityTicketsV2_GetTotalNumberOfAccountSecurityTicketsV2ByAccountIDAndIsValid", queryParameters);
	}
}
