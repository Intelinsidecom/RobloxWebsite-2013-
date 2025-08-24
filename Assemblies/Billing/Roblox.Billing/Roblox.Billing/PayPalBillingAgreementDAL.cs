using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PayPalBillingAgreementDAL
{
	private int _ID;

	public long AccountID;

	public string BillingAgreementID;

	public bool IsActive;

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

	private static string dbConnectionString_PayPalBillingAgreementDAL => Settings.Default.BillingConnectionString;

	private static PayPalBillingAgreementDAL BuildDAL(SqlDataReader reader)
	{
		PayPalBillingAgreementDAL dal = new PayPalBillingAgreementDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.BillingAgreementID = (string)reader["BillingAgreementID"];
			dal.IsActive = (bool)reader["IsActive"];
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
		queryParameters.Add(new SqlParameter("@BillingAgreementID", BillingAgreementID));
		queryParameters.Add(new SqlParameter("@IsActive", IsActive));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_PayPalBillingAgreementDAL, "PayPalBillingAgreements_InsertPayPalBillingAgreement", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@BillingAgreementID", BillingAgreementID));
		queryParameters.Add(new SqlParameter("@IsActive", IsActive));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_PayPalBillingAgreementDAL, "PayPalBillingAgreements_UpdatePayPalBillingAgreementByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_PayPalBillingAgreementDAL, "PayPalBillingAgreements_DeletePayPalBillingAgreementByID", queryParameters));
	}

	public static PayPalBillingAgreementDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_PayPalBillingAgreementDAL, "PayPalBillingAgreements_GetPayPalBillingAgreementByID", queryParameters), BuildDAL);
	}
}
