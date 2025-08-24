using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.TwoStepVerification.Entities;

[ExcludeFromCodeCoverage]
internal class TwoStepVerificationSessionTokenDAL
{
	private const RobloxDatabase Database = RobloxDatabase.RobloxAuthentication;

	internal long Id { get; set; }

	internal long AccountId { get; set; }

	internal Guid Token { get; set; }

	internal DateTime Expiration { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static TwoStepVerificationSessionTokenDAL BuildDAL(IDictionary<string, object> record)
	{
		return new TwoStepVerificationSessionTokenDAL
		{
			Id = (long)record["ID"],
			AccountId = Convert.ToInt64(record["AccountID"]),
			Token = (Guid)record["Token"],
			Expiration = (DateTime)record["Expiration"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAuthentication.Delete("TwoStepVerificationSessionTokens_DeleteTwoStepVerificationSessionTokenByID", Id);
	}

	internal static TwoStepVerificationSessionTokenDAL Get(long id)
	{
		return RobloxDatabase.RobloxAuthentication.Get("TwoStepVerificationSessionTokens_GetTwoStepVerificationSessionTokenByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountId),
			new SqlParameter("@Token", Token),
			new SqlParameter("@Expiration", Expiration),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		Id = RobloxDatabase.RobloxAuthentication.Insert<long>("TwoStepVerificationSessionTokens_InsertTwoStepVerificationSessionToken", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", Id),
			new SqlParameter("@AccountID", AccountId),
			new SqlParameter("@Token", Token),
			new SqlParameter("@Expiration", Expiration),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAuthentication.Update("TwoStepVerificationSessionTokens_UpdateTwoStepVerificationSessionTokenByID", queryParameters);
	}

	internal static ICollection<TwoStepVerificationSessionTokenDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAuthentication.MultiGet("TwoStepVerificationSessionTokens_GetTwoStepVerificationSessionTokensByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetTwoStepVerificationSessionTokenIDsByAccountIdPaged(long accountId, long startRowIndex, long maximumRows)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountID' cannot be null, empty or the default value.");
		}
		if (startRowIndex < 1)
		{
			throw new ApplicationException("Required value not specified: StartRowIndex.");
		}
		if (maximumRows < 1)
		{
			throw new ApplicationException("Required value not specified: MaximumRows.");
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxAuthentication.GetIDCollection<long>("TwoStepVerificationSessionTokens_GetTwoStepVerificationSessionTokenIDsByAccountID_Paged", queryParameters);
	}

	internal static TwoStepVerificationSessionTokenDAL GetTwoStepVerificationSessionTokenByToken(Guid token)
	{
		if (token == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Token", token)
		};
		return RobloxDatabase.RobloxAuthentication.Lookup("TwoStepVerificationSessionTokens_GetTwoStepVerificationSessionTokenByToken", BuildDAL, queryParameters);
	}
}
