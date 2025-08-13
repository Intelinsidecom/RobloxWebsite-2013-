using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Localization.Accounts;

[ExcludeFromCodeCoverage]
internal class AccountCountryDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountLocalization;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal int? CountryID { get; set; }

	internal bool IsVerified { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountCountryDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountCountryDAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			CountryID = (int?)record["CountryID"],
			IsVerified = (bool)record["IsVerified"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountLocalization.Delete("AccountCountries_DeleteAccountCountryByID", ID);
	}

	internal static AccountCountryDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountLocalization.Get("AccountCountries_GetAccountCountryByID", id, BuildDAL);
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
			new SqlParameter("@CountryID", CountryID.HasValue ? ((object)CountryID) : DBNull.Value),
			new SqlParameter("@IsVerified", IsVerified),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountLocalization.Insert<long>("AccountCountries_InsertAccountCountry", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@CountryID", CountryID.HasValue ? ((object)CountryID) : DBNull.Value),
			new SqlParameter("@IsVerified", IsVerified),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountLocalization.Update("AccountCountries_UpdateAccountCountryByID", queryParameters);
	}

	internal static ICollection<AccountCountryDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountLocalization.MultiGet("AccountCountries_GetAccountCountriesByIDs", ids, BuildDAL);
	}

	internal static AccountCountryDAL GetAccountCountryByAccountID(long accountId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxAccountLocalization.Lookup("AccountCountries_GetAccountCountryByAccountID", BuildDAL, queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountCountryDAL> GetOrCreateAccountCountry(long accountId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxAccountLocalization.GetOrCreate("AccountCountries_GetOrCreateAccountCountry", BuildDAL, queryParameters);
	}
}
