using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.AccountPins.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPinHashDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountSecurity;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal string PinHash { get; set; }

	internal bool IsValid { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountPinHashDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountPinHashDAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			PinHash = (string)record["PinHash"],
			IsValid = (bool)record["IsValid"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountSecurity.Delete("AccountPinHashes_DeleteAccountPinHashByID", ID);
	}

	internal static AccountPinHashDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccountSecurity.Get("AccountPinHashes_GetAccountPinHashByID", id, BuildDAL);
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
			new SqlParameter("@PinHash", PinHash),
			new SqlParameter("@IsValid", IsValid),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountSecurity.Insert<long>("AccountPinHashes_InsertAccountPinHash", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[6]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@PinHash", PinHash),
			new SqlParameter("@IsValid", IsValid),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountSecurity.Update("AccountPinHashes_UpdateAccountPinHashByID", queryParameters);
	}

	internal static ICollection<AccountPinHashDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccountSecurity.MultiGet("AccountPinHashes_GetAccountPinHashesByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountPinHashIDsByAccountIDAndIsValid(long accountId, bool isValid, int count, long? exclusiveStartId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@IsValid", isValid),
			new SqlParameter("@Count", count),
			null
		};
		long? num = exclusiveStartId;
		obj[3] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxAccountSecurity.GetIDCollection<long>("AccountPinHashes_GetAccountPinHashIDsByAccountIDAndIsValid", queryParameters);
	}
}
