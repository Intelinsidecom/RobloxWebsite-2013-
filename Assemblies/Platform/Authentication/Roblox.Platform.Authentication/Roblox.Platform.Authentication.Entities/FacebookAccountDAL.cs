using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.Entities;

internal class FacebookAccountDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxFacebookAccounts;

	internal int ID { get; set; }

	internal long AccountID { get; set; }

	internal ulong FacebookID { get; set; }

	internal bool IsValid { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static FacebookAccountDAL BuildDAL(IDictionary<string, object> record)
	{
		return new FacebookAccountDAL
		{
			ID = (int)record["ID"],
			AccountID = (long)record["AccountID"],
			FacebookID = Convert.ToUInt64(record["FacebookID"]),
			IsValid = (bool)record["IsValid"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxFacebookAccounts.Delete("FacebookAccountsV2_DeleteFacebookAccountV2ByID", ID);
	}

	internal static FacebookAccountDAL Get(int id)
	{
		return RobloxDatabase.RobloxFacebookAccounts.Get("FacebookAccountsV2_GetFacebookAccountV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@FacebookID", (long)FacebookID),
			new SqlParameter("@IsValid", IsValid),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxFacebookAccounts.Insert<int>("FacebookAccountsV2_InsertFacebookAccountV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@FacebookID", (long)FacebookID),
			new SqlParameter("@IsValid", IsValid),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxFacebookAccounts.Update("FacebookAccountsV2_UpdateFacebookAccountV2ByID", queryParameters);
	}

	internal static ICollection<FacebookAccountDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxFacebookAccounts.MultiGet("FacebookAccountsV2_GetFacebookAccountsV2ByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetFacebookAccountIDsByAccountIDAndIsValid(long accountID, bool isValid, int count, int exclusiveStartFacebookAccountId)
	{
		if (accountID == 0L)
		{
			throw new ArgumentException("Parameter 'accountID' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartFacebookAccountId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartFacebookAccountID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@AccountID", accountID),
			new SqlParameter("@IsValid", isValid),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartFacebookAccountID", exclusiveStartFacebookAccountId)
		};
		return RobloxDatabase.RobloxFacebookAccounts.GetIDCollection<int>("FacebookAccountsV2_GetFacebookAccountV2IDsByAccountIDAndIsValid", queryParameters);
	}

	internal static FacebookAccountDAL GetFacebookAccountByFacebookIDAndIsValid(ulong facebookID, bool isValid)
	{
		if (facebookID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@FacebookID", (long)facebookID),
			new SqlParameter("@IsValid", isValid)
		};
		return RobloxDatabase.RobloxFacebookAccounts.Lookup("FacebookAccountsV2_GetFacebookAccountV2ByFacebookIDAndIsValid", BuildDAL, queryParameters);
	}
}
