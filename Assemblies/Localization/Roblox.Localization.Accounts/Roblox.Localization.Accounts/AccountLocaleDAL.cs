using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountLocaleDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalization;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal int ObservedLocaleID { get; set; }

	internal int? SupportedLocaleID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountLocaleDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountLocaleDAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			ObservedLocaleID = (int)record["ObservedLocaleID"],
			SupportedLocaleID = (int?)record["SupportedLocaleID"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountLocalization.Delete("AccountLocales_DeleteAccountLocaleByID", ID);
	}

	internal static AccountLocaleDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountLocalization.Get("AccountLocales_GetAccountLocaleByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@ObservedLocaleID", ObservedLocaleID),
			new SqlParameter("@SupportedLocaleID", SupportedLocaleID.HasValue ? ((object)SupportedLocaleID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountLocalization.Insert<long>("AccountLocales_InsertAccountLocale", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@ObservedLocaleID", ObservedLocaleID),
			new SqlParameter("@SupportedLocaleID", SupportedLocaleID.HasValue ? ((object)SupportedLocaleID) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountLocalization.Update("AccountLocales_UpdateAccountLocaleByID", queryParameters);
	}

	internal static ICollection<AccountLocaleDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountLocalization.MultiGet("AccountLocales_GetAccountLocalesByIDs", ids, BuildDAL);
	}

	internal static AccountLocaleDAL GetAccountLocaleByAccountID(long accountId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxAccountLocalization.Lookup("AccountLocales_GetAccountLocaleByAccountID", BuildDAL, queryParameters);
	}
}
