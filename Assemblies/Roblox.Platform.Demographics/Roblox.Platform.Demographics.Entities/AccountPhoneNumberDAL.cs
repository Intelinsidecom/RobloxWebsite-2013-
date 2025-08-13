using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Demographics.Entities;

[ExcludeFromCodeCoverage]
internal class AccountPhoneNumberDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxUsers;

	internal int ID { get; set; }

	internal long AccountID { get; set; }

	internal string Phone { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal int? PhoneNumberID { get; set; }

	internal bool? IsVerified { get; set; }

	internal bool? IsActive { get; set; }

	private static AccountPhoneNumberDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountPhoneNumberDAL
		{
			ID = (int)record["ID"],
			AccountID = (long)record["AccountID"],
			Phone = (string)record["Phone"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			PhoneNumberID = (int?)record["PhoneNumberID"],
			IsVerified = (bool?)record["IsVerified"],
			IsActive = (bool?)record["IsActive"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxUsers.Delete("AccountPhoneNumbersV2_DeleteAccountPhoneNumberV2ByID", ID);
	}

	internal static AccountPhoneNumberDAL Get(int id)
	{
		return RobloxDatabase.RobloxUsers.Get("AccountPhoneNumbersV2_GetAccountPhoneNumberV2ByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@Phone", Phone),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@PhoneNumberID", PhoneNumberID.HasValue ? ((object)PhoneNumberID) : DBNull.Value),
			new SqlParameter("@IsVerified", IsVerified.HasValue ? ((object)IsVerified) : DBNull.Value),
			new SqlParameter("@IsActive", IsActive.HasValue ? ((object)IsActive) : DBNull.Value)
		};
		ID = RobloxDatabase.RobloxUsers.Insert<int>("AccountPhoneNumbersV2_InsertAccountPhoneNumberV2", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[8]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@Phone", Phone),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@PhoneNumberID", PhoneNumberID.HasValue ? ((object)PhoneNumberID) : DBNull.Value),
			new SqlParameter("@IsVerified", IsVerified.HasValue ? ((object)IsVerified) : DBNull.Value),
			new SqlParameter("@IsActive", IsActive.HasValue ? ((object)IsActive) : DBNull.Value)
		};
		RobloxDatabase.RobloxUsers.Update("AccountPhoneNumbersV2_UpdateAccountPhoneNumberV2ByID", queryParameters);
	}

	internal static ICollection<AccountPhoneNumberDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxUsers.MultiGet("AccountPhoneNumbersV2_GetAccountPhoneNumbersV2ByIDs", ids, BuildDAL);
	}

	internal static ICollection<int> GetAccountPhoneNumberIDsByPhoneNumberIDIsVerifiedAndIsActive(int phoneNumberId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		if (phoneNumberId == 0)
		{
			throw new ArgumentException("Parameter 'phoneNumberId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountPhoneNumberId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountPhoneNumberID.");
		}
		SqlParameter[] obj = new SqlParameter[5]
		{
			new SqlParameter("@PhoneNumberID", phoneNumberId),
			new SqlParameter("@IsVerified", isVerified.HasValue ? ((object)isVerified) : DBNull.Value),
			new SqlParameter("@IsActive", isActive.HasValue ? ((object)isActive) : DBNull.Value),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartAccountPhoneNumberId;
		obj[4] = new SqlParameter("@ExclusiveStartAccountPhoneNumberID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxUsers.GetIDCollection<int>("AccountPhoneNumbersV2_GetAccountPhoneNumberV2IDsByPhoneNumberIDIsVerifiedAndIsActive", queryParameters);
	}

	internal static ICollection<int> GetAccountPhoneNumberIDsByAccountIDAndIsVerified(long accountId, bool? isVerified, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountPhoneNumberId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountPhoneNumberID.");
		}
		SqlParameter[] obj = new SqlParameter[4]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@IsVerified", isVerified.HasValue ? ((object)isVerified) : DBNull.Value),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartAccountPhoneNumberId;
		obj[3] = new SqlParameter("@ExclusiveStartAccountPhoneNumberID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxUsers.GetIDCollection<int>("AccountPhoneNumbersV2_GetAccountPhoneNumberV2IDsByAccountIDAndIsVerified", queryParameters);
	}

	internal static ICollection<int> GetAccountPhoneNumberIDsByAccountIDIsVerifiedAndIsActive(long accountId, bool? isVerified, bool? isActive, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountPhoneNumberId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountPhoneNumberID.");
		}
		SqlParameter[] obj = new SqlParameter[5]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@IsVerified", isVerified.HasValue ? ((object)isVerified) : DBNull.Value),
			new SqlParameter("@IsActive", isActive.HasValue ? ((object)isActive) : DBNull.Value),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartAccountPhoneNumberId;
		obj[4] = new SqlParameter("@ExclusiveStartAccountPhoneNumberID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxUsers.GetIDCollection<int>("AccountPhoneNumbersV2_GetAccountPhoneNumberV2IDsByAccountIDIsVerifiedAndIsActive", queryParameters);
	}

	internal static ICollection<int> GetAccountPhoneNumberIDsByAccountID(long accountId, int count, int? exclusiveStartAccountPhoneNumberId)
	{
		if (accountId == 0L)
		{
			throw new ArgumentException("Parameter 'accountId' cannot be null, empty or the default value.");
		}
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartAccountPhoneNumberId < 0)
		{
			throw new ApplicationException("Required value not specified: ExclusiveStartAccountPhoneNumberID.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartAccountPhoneNumberId;
		obj[2] = new SqlParameter("@ExclusiveStartAccountPhoneNumberID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxUsers.GetIDCollection<int>("AccountPhoneNumbersV2_GetAccountPhoneNumberV2IDsByAccountID", queryParameters);
	}
}
