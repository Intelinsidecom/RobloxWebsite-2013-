using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class CreditTransactionOriginTypeDAL
{
	private int _ID;

	public string Value;

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

	private static string dbConnectionString_CreditTransactionOriginTypeDAL => Settings.Default.BillingConnectionString;

	private static CreditTransactionOriginTypeDAL BuildDAL(SqlDataReader reader)
	{
		CreditTransactionOriginTypeDAL dal = new CreditTransactionOriginTypeDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.Value = (string)reader["Value"];
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
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_CreditTransactionOriginTypeDAL, "CreditTransactionOriginTypes_InsertCreditTransactionOriginType", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@Value", Value));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_CreditTransactionOriginTypeDAL, "CreditTransactionOriginTypes_UpdateCreditTransactionOriginTypeByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_CreditTransactionOriginTypeDAL, "CreditTransactionOriginTypes_DeleteCreditTransactionOriginTypeByID", queryParameters));
	}

	public static CreditTransactionOriginTypeDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CreditTransactionOriginTypeDAL, "CreditTransactionOriginTypes_GetCreditTransactionOriginTypeByID", queryParameters), BuildDAL);
	}

	public static CreditTransactionOriginTypeDAL GetByValue(string value)
	{
		if (string.IsNullOrEmpty(value))
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Value", value));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_CreditTransactionOriginTypeDAL, "[dbo].[CreditTransactionOriginTypes_GetCreditTransactionOriginTypeByValue]", queryParameters), BuildDAL);
	}
}
