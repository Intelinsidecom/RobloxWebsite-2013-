using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.DataAccess;

[Serializable]
public class AccountDAL
{
	private string _Name = string.Empty;

	private string _Description = string.Empty;

	private const RobloxDatabase _Database = RobloxDatabase.RobloxAccounts;

	public long ID { get; set; }

	public string Name
	{
		get
		{
			return _Name;
		}
		set
		{
			_Name = value.Substring(0, (value.Length < 50) ? value.Length : 50);
		}
	}

	public string Description
	{
		get
		{
			return _Description;
		}
		set
		{
			if (value.Length < 1000)
			{
				_Description = value;
			}
			else
			{
				_Description = value.Substring(0, char.IsHighSurrogate(value[999]) ? 999 : 1000);
			}
		}
	}

	public byte AccountStatusID { get; set; }

	public DateTime Created { get; set; } = DateTime.MinValue;


	public DateTime Updated { get; set; } = DateTime.MinValue;


	private static AccountDAL BuildDAL(IDictionary<string, object> record)
	{
		return new AccountDAL
		{
			ID = Convert.ToInt64(record["ID"]),
			Name = (string)record["Name"],
			AccountStatusID = (byte)record["AccountStatusID"],
			Created = DateTime.SpecifyKind((DateTime)record["Created"], DateTimeKind.Local),
			Updated = DateTime.SpecifyKind((DateTime)record["Updated"], DateTimeKind.Local),
			Description = (((string)record["Description"]) ?? string.Empty)
		};
	}

	public static AccountDAL Get(long id)
	{
		return RobloxDatabase.RobloxAccounts.Get("AccountsV2_GetAccountV2ByID", id, BuildDAL);
	}

	public static ICollection<AccountDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxAccounts.MultiGet("AccountsV2_GetAccountsV2ByIDs", ids, BuildDAL);
	}

	public static AccountDAL GetByName(string name)
	{
		if (string.IsNullOrEmpty(name))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@Name", name)
		};
		return RobloxDatabase.RobloxAccounts.Lookup("AccountsV2_GetAccountV2ByName", BuildDAL, queryParameters);
	}
}
