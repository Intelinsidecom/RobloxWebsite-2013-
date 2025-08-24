using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.Moderation;

[Serializable]
public class AccountMACAddressDAL
{
	private static string ConnectionString => RobloxDatabase.RobloxMacAddresses.GetConnectionString();

	public long ID { get; set; }

	public long AccountID { get; set; }

	public long MACAddressID { get; set; }

	public DateTime Created { get; set; } = DateTime.MinValue;


	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_DeleteAccountMACAddressByID]", queryParameters));
	}

	public void Insert()
	{
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (MACAddressID == 0L)
		{
			throw new ApplicationException("Required value not specified: MACAddressID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@MACAddressID", MACAddressID),
			new SqlParameter("@Created", Created)
		};
		DbInfo dbInfo = new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_InsertAccountMACAddress]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	public void Update()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		if (AccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		if (MACAddressID == 0L)
		{
			throw new ApplicationException("Required value not specified: MACAddressID.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@AccountID", AccountID),
			new SqlParameter("@MACAddressID", MACAddressID),
			new SqlParameter("@Created", Created)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_UpdateAccountMACAddressByID]", queryParameters));
	}

	private static AccountMACAddressDAL BuildDAL(SqlDataReader reader)
	{
		AccountMACAddressDAL dal = new AccountMACAddressDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.MACAddressID = (long)reader["MACAddressID"];
			dal.Created = (DateTime)reader["Created"];
		}
		if (dal.Created == DateTime.MinValue)
		{
			return null;
		}
		return dal;
	}

	public static AccountMACAddressDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_GetAccountMACAddressByID]", queryParameters), BuildDAL);
	}

	public static AccountMACAddressDAL GetAccountMACAddressByAccountIDAndMACAddressID(long accountId, long macAddressId)
	{
		if (accountId == 0L || macAddressId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@MACAddressID", macAddressId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_GetAccountMACAddressByAccountIDAndMACAddressID]", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetAccountMACAddressIDsByAccountPaged(long accountId, long startRowIndex, long maximumRows)
	{
		if (accountId == 0L)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountID", accountId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_GetAccountMACAddressIDsByAccountID_Paged]", queryParameters));
	}

	public static ICollection<long> GetAccountMACAddressIDsByAddressPaged(long macAddressId, long startRowIndex, long maximumRows)
	{
		if (macAddressId == 0L)
		{
			return new List<long>();
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@MACAddressID", macAddressId),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maximumRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_GetAccountMACAddressIDsByMACAddressID_Paged]", queryParameters));
	}

	public static long GetTotalNumberOfAccountMACAddressesByAccount(long accountId)
	{
		if (accountId == 0L)
		{
			return 0L;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountID", accountId)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_GetTotalNumberOfAccountMACAddressesByAccountID]", queryParameters));
	}

	public static long GetTotalNumberOfAccountMACAddressesByAddress(long macAddressId)
	{
		if (macAddressId == 0L)
		{
			return 0L;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@MACAddressID", macAddressId)
		};
		return EntityHelper.GetDataCount<long>(new DbInfo(ConnectionString, "[dbo].[AccountMACAddresses_GetTotalNumberOfAccountMACAddressesByMACAddressID]", queryParameters));
	}
}
