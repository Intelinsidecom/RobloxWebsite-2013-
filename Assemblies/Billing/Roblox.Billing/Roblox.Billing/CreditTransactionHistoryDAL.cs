using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class CreditTransactionHistoryDAL
{
	private long _ID;

	public long AccountID;

	public int TransactionTypeID;

	public decimal Amount;

	public DateTime Created;

	public DateTime Updated;

	public string TransactionID;

	public int? TransactionOriginTypeID;

	public long ID
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

	private static string dbConnectionString_CreditTransactionHistoryDAL => Settings.Default.BillingConnectionString;

	private static CreditTransactionHistoryDAL BuildDAL(SqlDataReader reader)
	{
		CreditTransactionHistoryDAL dal = new CreditTransactionHistoryDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.TransactionTypeID = (int)reader["TransactionTypeID"];
			dal.Amount = (decimal)reader["Amount"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.TransactionID = (reader["TransactionID"].Equals(DBNull.Value) ? null : ((string)reader["TransactionID"]));
			dal.TransactionOriginTypeID = (reader["TransactionOriginTypeID"].Equals(DBNull.Value) ? null : ((int?)reader["TransactionOriginTypeID"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@TransactionTypeID", TransactionTypeID));
		queryParameters.Add(new SqlParameter("@Amount", Amount));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@TransactionID", (TransactionID != null) ? ((IConvertible)TransactionID) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginTypeID.HasValue ? ((object)TransactionOriginTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_CreditTransactionHistoryDAL, "CreditTransactionHistory_InsertCreditTransactionHistory", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@TransactionTypeID", TransactionTypeID));
		queryParameters.Add(new SqlParameter("@Amount", Amount));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@TransactionID", (TransactionID != null) ? ((IConvertible)TransactionID) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TransactionOriginTypeID", TransactionOriginTypeID.HasValue ? ((object)TransactionOriginTypeID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CreditTransactionHistoryDAL, "CreditTransactionHistory_UpdateCreditTransactionHistoryByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CreditTransactionHistoryDAL, "CreditTransactionHistory_DeleteCreditTransactionHistoryByID", queryParameters));
	}

	public static CreditTransactionHistoryDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CreditTransactionHistoryDAL, "CreditTransactionHistory_GetCreditTransactionHistoryByID", queryParameters), BuildDAL);
	}
}
