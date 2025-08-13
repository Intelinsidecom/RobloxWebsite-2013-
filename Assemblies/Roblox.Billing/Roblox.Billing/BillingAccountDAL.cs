using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class BillingAccountDAL
{
	private int _ID;

	public long AccountID;

	public DateTime Created;

	public DateTime Updated;

	private static readonly string dbConnectionString_BillingAccountDAL = Settings.Default.BillingConnectionString;

	public int ID
	{
		get
		{
			return _ID;
		}
		set
		{
			_ID = value;
		}
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_BillingAccountDAL, "BillingAccounts_DeleteBillingAccountByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_BillingAccountDAL, "BillingAccounts_InsertBillingAccount", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_BillingAccountDAL, "BillingAccounts_UpdateBillingAccountByID", queryParameters));
	}

	private static BillingAccountDAL BuildDAL(SqlDataReader reader)
	{
		BillingAccountDAL dal = new BillingAccountDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public static BillingAccountDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_BillingAccountDAL, "BillingAccounts_GetBillingAccountByID", queryParameters), BuildDAL);
	}

	public static BillingAccountDAL GetByAccountID(long accountId)
	{
		if (accountId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_BillingAccountDAL, "BillingAccounts_GetBillingAccountByAccountID", queryParameters), BuildDAL);
	}
}
