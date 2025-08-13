using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.MssqlDatabases;

namespace Roblox.PremiumFeatures;

public class AccountAddOnExpirationEmailTaskDAL
{
	private long _id;

	public int AccountAddOnID;

	public DateTime? EmailSent;

	public DateTime Created;

	public DateTime Updated;

	public DateTime LastExpiration;

	public long ID
	{
		get
		{
			return _id;
		}
		set
		{
			_id = value;
		}
	}

	private static string ConnectionString => RobloxDatabase.RobloxPremiumFeatures.GetConnectionString();

	private static AccountAddOnExpirationEmailTaskDAL BuildDAL(SqlDataReader reader)
	{
		AccountAddOnExpirationEmailTaskDAL dal = new AccountAddOnExpirationEmailTaskDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccountAddOnID = (int)reader["AccountAddOnID"];
			dal.EmailSent = (reader["EmailSent"].Equals(DBNull.Value) ? null : ((DateTime?)reader["EmailSent"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.LastExpiration = (DateTime)reader["LastExpiration"];
		}
		if (dal.ID != 0L)
		{
			return dal;
		}
		return null;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountAddOnID", AccountAddOnID),
			new SqlParameter("@EmailSent", EmailSent.HasValue ? ((object)EmailSent) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@LastExpiration", LastExpiration)
		};
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(ConnectionString, "[dbo].[AccountAddOnExpirationEmailTasks_InsertAccountAddOnExpirationEmailTask]", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _id),
			new SqlParameter("@AccountAddOnID", AccountAddOnID),
			new SqlParameter("@EmailSent", EmailSent.HasValue ? ((object)EmailSent) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@LastExpiration", LastExpiration)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(ConnectionString, "[dbo].[AccountAddOnExpirationEmailTasks_UpdateAccountAddOnExpirationEmailTaskByID]", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", _id)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(ConnectionString, "[dbo].[AccountAddOnExpirationEmailTasks_DeleteAccountAddOnExpirationEmailTaskByID]", queryParameters));
	}

	public static AccountAddOnExpirationEmailTaskDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountAddOnExpirationEmailTasks_GetAccountAddOnExpirationEmailTaskByID]", queryParameters), BuildDAL);
	}

	internal static AccountAddOnExpirationEmailTaskDAL GetAccountAddOnExpirationEmailTaskByAccountAddOnID(int accountAddOnId)
	{
		if (accountAddOnId == 0)
		{
			throw new ApplicationException("Required value not specified: AccountAddOnID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AccountAddOnID", accountAddOnId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(ConnectionString, "[dbo].[AccountAddOnExpirationEmailTasks_GetAccountAddOnExpirationEmailTaskByAccountAddOnID]", queryParameters), BuildDAL);
	}
}
