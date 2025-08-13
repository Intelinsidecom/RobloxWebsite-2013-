using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.Entities;

[ExcludeFromCodeCoverage]
internal class SessionTokenDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAuthentication;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal Guid Token { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime? Updated { get; set; }

	internal DateTime? Expiration { get; set; }

	private static SessionTokenDAL BuildDAL(IDictionary<string, object> record)
	{
		return new SessionTokenDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			AccountID = Convert.ToInt64(record["AccountID"]),
			Token = (Guid)record["Token"],
			Created = (DateTime)record["Created"],
			Updated = (record["Updated"].Equals(DBNull.Value) ? null : ((DateTime?)record["Updated"])),
			Expiration = (record["Expiration"].Equals(DBNull.Value) ? null : ((DateTime?)record["Expiration"]))
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAuthentication.Delete("SessionTokensV2_DeleteSessionTokenByID", ID);
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
			new SqlParameter("@Token", Token),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.HasValue ? ((object)Updated.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration.Value.ToLocalTime()) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxAuthentication.Insert<long>("SessionTokensV2_InsertSessionToken", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@Token", Token),
			new SqlParameter("@Created", Created.ToLocalTime()),
			new SqlParameter("@Updated", Updated.HasValue ? ((object)Updated.Value.ToLocalTime()) : DBNull.Value),
			new SqlParameter("@Expiration", Expiration.HasValue ? ((object)Expiration.Value.ToLocalTime()) : DBNull.Value)
		};
		RobloxDatabase.RobloxAuthentication.Update("SessionTokensV2_UpdateSessionTokenByID", queryParameters);
	}

	internal static SessionTokenDAL Get(long id)
	{
		return RobloxDatabase.RobloxAuthentication.Get("SessionTokensV2_GetSessionTokenByID", id, BuildDAL);
	}

	internal static SessionTokenDAL GetByToken(Guid token)
	{
		if (token == default(Guid))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Token", token)
		};
		return RobloxDatabase.RobloxAuthentication.Lookup("SessionTokensV2_GetSessionTokenByToken", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetSessionTokensByAccountID_Paged(long accountId, long startRowIndex, long maximumRows)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountId' cannot be null, empty or the default value.");
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
		return RobloxDatabase.RobloxAuthentication.GetIDCollection<long>("SessionTokensV2_GetSessionTokenIDsByAccountID_Paged", queryParameters);
	}
}
