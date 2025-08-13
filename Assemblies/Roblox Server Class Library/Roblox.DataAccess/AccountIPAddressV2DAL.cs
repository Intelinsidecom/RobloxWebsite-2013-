using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

public class AccountIPAddressV2DAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxIPAddresses;

	internal long ID { get; set; }

	internal long AccountID { get; set; }

	internal long IPAddressID { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime? LastSeen { get; set; }

	internal void Delete()
	{
		RobloxDatabase.RobloxIPAddresses.Delete("AccountIPAddressesV3_DeleteAccountIPAddressV3ByID", ID);
	}

	internal void Insert()
	{
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (IPAddressID == 0L)
		{
			throw new ApplicationException("Required value not specified: IPAddressID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@LastSeenUtc", LastSeen.HasValue ? ((object)LastSeen.Value.ToUniversalTime()) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxIPAddresses.Insert<int>("AccountIPAddressesV3_InsertAccountIPAddressV3", queryParameters);
	}

	internal void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (IPAddressID == 0L)
		{
			throw new ApplicationException("Required value not specified: IPAddressID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		SqlParameter[] queryParameters = new SqlParameter[5]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@IPAddressID", IPAddressID),
			new SqlParameter("@Created", Created),
			new SqlParameter("@LastSeenUtc", LastSeen.HasValue ? ((object)LastSeen.Value.ToUniversalTime()) : DBNull.Value)
		};
		RobloxDatabase.RobloxIPAddresses.Update("AccountIPAddressesV3_UpdateAccountIPAddressV3ByID", queryParameters);
	}

	private static DateTime? SpecifyKindUtcGivenNullable(DateTime? nullableDateTime)
	{
		if (nullableDateTime.HasValue)
		{
			return DateTime.SpecifyKind(nullableDateTime.Value, DateTimeKind.Utc);
		}
		return null;
	}

	private static AccountIPAddressV2DAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountIPAddressV2DAL
		{
			ID = (long)record["ID"],
			AccountID = (long)record["AccountID"],
			IPAddressID = (long)record["IPAddressID"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			LastSeen = SpecifyKindUtcGivenNullable((DateTime?)record["LastSeenUtc"])
		};
	}

	internal static AccountIPAddressV2DAL Get(long id)
	{
		return RobloxDatabase.RobloxIPAddresses.Get("AccountIPAddressesV3_GetAccountIPAddressV3ByID", id, BuildDAL);
	}

	internal static AccountIPAddressV2DAL Get(long accountId, long ipAddressId)
	{
		if (accountId == 0L || ipAddressId == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[2]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@IPAddressID", ipAddressId)
		};
		return RobloxDatabase.RobloxIPAddresses.Lookup("AccountIPAddressesV3_GetAccountIPAddressV3ByAccountIDAndIPAddressID", BuildDAL, queryParameters);
	}

	internal static ICollection<AccountIPAddressV2DAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxIPAddresses.MultiGet("AccountIPAddressesV3_GetAccountIPAddressesV3ByIDs", ids, BuildDAL);
	}

	internal static ICollection<long> GetAccountIPAddressV2IDsByAccountPaged(long accountId, int startRowIndex, long maximumRows)
	{
		if (accountId == 0L)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxIPAddresses.GetIDCollection<long>("AccountIPAddressesV3_GetAccountIPAddressV3IDsByAccountID_Paged", queryParameters);
	}

	internal static ICollection<long> GetAccountIPAddressV2IDsByAddressPaged(long ipAddressId, int startRowIndex, long maximumRows)
	{
		if (ipAddressId == 0L)
		{
			return new List<long>();
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@IPAddressID", ipAddressId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return RobloxDatabase.RobloxIPAddresses.GetIDCollection<long>("AccountIPAddressesV3_GetAccountIPAddressV3IDsByIPAddressID_Paged", queryParameters);
	}

	internal static long GetTotalNumberOfAccountIPAddressesV2ByAccount(long accountId)
	{
		if (accountId == 0L)
		{
			return 0L;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@AccountID", accountId)
		};
		return RobloxDatabase.RobloxIPAddresses.GetCount<long>("AccountIPAddressesV3_GetTotalNumberOfAccountIPAddressesV3ByAccountID", queryParameters);
	}

	internal static long GetTotalNumberOfAccountIPAddressesV2ByAddress(long ipAddressId)
	{
		if (ipAddressId == 0L)
		{
			return 0L;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@IPAddressID", ipAddressId)
		};
		return RobloxDatabase.RobloxIPAddresses.GetCount<long>("AccountIPAddressesV3_GetTotalNumberOfAccountIPAddressesV3ByIPAddressID", queryParameters);
	}

	internal static EntityHelper.GetOrCreateDALWrapper<AccountIPAddressV2DAL> GetOrCreate(long accountId, long ipAddressId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException(string.Format("Required value not specified: {0}", "accountId"));
		}
		if (ipAddressId == 0L)
		{
			throw new ArgumentException(string.Format("Required value not specified: {0}", "ipAddressId"));
		}
		SqlParameter[] queryParameters = new SqlParameter[3]
		{
			new SqlParameter("@CreatedNewEntity", SqlDbType.Bit)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@IPAddressID", ipAddressId)
		};
		return RobloxDatabase.RobloxIPAddresses.GetOrCreate("AccountIPAddressesV3_GetOrCreateAccountIPAddressV3", BuildDAL, queryParameters);
	}

	internal static ICollection<long> GetAccountIPAddressV2IDsByAccountID(long accountId, int count, DateTime? exclusiveStartLastSeen, long? exclusiveStartID)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartID.HasValue && exclusiveStartID.Value <= 0)
		{
			throw new ApplicationException("Argument must be positive: ExclusiveStartID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@Count", count),
			new SqlParameter("@ExclusiveStartLastSeenUtc", exclusiveStartLastSeen.HasValue ? ((object)exclusiveStartLastSeen.Value.ToUniversalTime()) : DBNull.Value),
			new SqlParameter("@ExclusiveStartID", exclusiveStartID.HasValue ? ((object)exclusiveStartID.Value) : DBNull.Value)
		};
		return RobloxDatabase.RobloxIPAddresses.GetIDCollection<long>("AccountIPAddressesV3_GetAccountIPAddressV3IDsByAccountID", queryParameters);
	}
}
