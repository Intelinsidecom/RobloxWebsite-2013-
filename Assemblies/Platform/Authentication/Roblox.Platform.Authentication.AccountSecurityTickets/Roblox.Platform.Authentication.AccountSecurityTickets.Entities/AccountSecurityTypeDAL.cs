using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Platform.Authentication.AccountSecurityTickets.Entities;

internal class AccountSecurityTypeDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccountSecurity;

	internal short ID { get; set; }

	internal string Value { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static AccountSecurityTypeDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountSecurityTypeDAL
		{
			ID = (short)record["ID"],
			Value = (string)record["Value"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxAccountSecurity.Delete("AccountSecurityTypes_DeleteAccountSecurityTypeByID", ID);
	}

	internal static AccountSecurityTypeDAL Get(short id)
	{
		return RobloxDatabase.RobloxAccountSecurity.Get("AccountSecurityTypes_GetAccountSecurityTypeByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxAccountSecurity.Insert<short>("AccountSecurityTypes_InsertAccountSecurityType", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[4]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@Value", Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxAccountSecurity.Update("AccountSecurityTypes_UpdateAccountSecurityTypeByID", queryParameters);
	}

	internal static ICollection<AccountSecurityTypeDAL> MultiGet(ICollection<short> ids)
	{
		return RobloxDatabase.RobloxAccountSecurity.MultiGet("AccountSecurityTypes_GetAccountSecurityTypesByIDs", ids, BuildDAL);
	}

	internal static AccountSecurityTypeDAL GetAccountSecurityTypeByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Value", value)
		};
		return RobloxDatabase.RobloxAccountSecurity.Lookup("AccountSecurityTypes_GetAccountSecurityTypeByValue", BuildDAL, queryParameters);
	}
}
