using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class CreditBalanceDAL
{
	private int _ID;

	public long AccountID;

	public decimal Balance;

	public DateTime Created;

	public DateTime Updated;

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

	private static string dbConnectionString_CreditBalanceDAL => Settings.Default.BillingConnectionString;

	private static CreditBalanceDAL BuildDAL(SqlDataReader reader)
	{
		CreditBalanceDAL dal = new CreditBalanceDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.Balance = (decimal)reader["Balance"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@Balance", Balance));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_CreditBalanceDAL, "CreditBalances_InsertCreditBalance", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@Balance", Balance));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CreditBalanceDAL, "CreditBalances_UpdateCreditBalanceByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CreditBalanceDAL, "CreditBalances_DeleteCreditBalanceByID", queryParameters));
	}

	public static CreditBalanceDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CreditBalanceDAL, "CreditBalances_GetCreditBalanceByID", queryParameters), BuildDAL);
	}

	public static CreditBalanceDAL GetByAccountID(long accountId)
	{
		if (accountId == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CreditBalanceDAL, "[dbo].[CreditBalances_GetCreditBalanceByAccountID]", queryParameters), BuildDAL);
	}

	public static EntityHelper.GetOrCreateDALWrapper<CreditBalanceDAL> GetOrCreate(long accountid)
	{
		if (accountid == 0L)
		{
			throw new ApplicationException("Required value not specified: AccountID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", accountid));
		return EntityHelper.GetOrCreateEntityDAL(new DbInfo(dbConnectionString_CreditBalanceDAL, "[dbo].[CreditBalances_GetOrCreateCreditBalance]", queryParameters), BuildDAL);
	}

	public void Credit(decimal amount)
	{
		if (amount == 0m)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter output_Balance = new SqlParameter("@Balance", SqlDbType.SmallMoney);
		output_Balance.Direction = ParameterDirection.Output;
		SqlParameter output_Updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_Updated.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(output_Balance);
		queryParameters.Add(output_Updated);
		EntityHelper.DoEntityDALAction(new DbInfo(dbConnectionString_CreditBalanceDAL, "[dbo].[CreditBalances_CreditByID]", queryParameters));
		Balance = (decimal)output_Balance.Value;
		Updated = (DateTime)output_Updated.Value;
	}

	public bool TryDebit(decimal amount)
	{
		if (amount == 0m)
		{
			throw new ApplicationException("Required value not specified: Amount.");
		}
		SqlParameter output_Balance = new SqlParameter("@Balance", SqlDbType.SmallMoney);
		output_Balance.Direction = ParameterDirection.Output;
		SqlParameter output_Updated = new SqlParameter("@Updated", SqlDbType.DateTime);
		output_Updated.Direction = ParameterDirection.Output;
		SqlParameter output_IsSuccess = new SqlParameter("@IsSuccess", SqlDbType.Bit);
		output_IsSuccess.Direction = ParameterDirection.Output;
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Amount", amount));
		queryParameters.Add(output_Balance);
		queryParameters.Add(output_Updated);
		queryParameters.Add(output_IsSuccess);
		EntityHelper.DoEntityDALAction(new DbInfo(dbConnectionString_CreditBalanceDAL, "[dbo].[CreditBalances_TryDebitByID]", queryParameters));
		Balance = (decimal)output_Balance.Value;
		Updated = (DateTime)output_Updated.Value;
		return (bool)output_IsSuccess.Value;
	}
}
