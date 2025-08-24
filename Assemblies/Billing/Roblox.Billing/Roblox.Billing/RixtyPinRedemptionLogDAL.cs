using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class RixtyPinRedemptionLogDAL
{
	private int _ID;

	public long AccountID;

	public byte PaymentStatusTypeID;

	public string TransactionID;

	public decimal CardValue;

	public long CardPIN;

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

	private static string dbConnectionString_RixtyPinRedemptionLogDAL => Settings.Default.BillingConnectionString;

	private static RixtyPinRedemptionLogDAL BuildDAL(SqlDataReader reader)
	{
		RixtyPinRedemptionLogDAL dal = new RixtyPinRedemptionLogDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.AccountID = Convert.ToInt64(reader["AccountID"]);
			dal.PaymentStatusTypeID = (byte)reader["PaymentStatusTypeID"];
			dal.TransactionID = (string)reader["TransactionID"];
			dal.CardValue = (decimal)reader["CardValue"];
			dal.CardPIN = (long)reader["CardPIN"];
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
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@TransactionID", TransactionID));
		queryParameters.Add(new SqlParameter("@CardValue", CardValue));
		queryParameters.Add(new SqlParameter("@CardPIN", CardPIN));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<int>(new DbInfo(dbConnectionString_RixtyPinRedemptionLogDAL, "RixtyPinRedemptionLog_InsertRixtyPinRedemptionLog", new SqlParameter("@ID", SqlDbType.Int), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@AccountID", AccountID));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@TransactionID", TransactionID));
		queryParameters.Add(new SqlParameter("@CardValue", CardValue));
		queryParameters.Add(new SqlParameter("@CardPIN", CardPIN));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_RixtyPinRedemptionLogDAL, "RixtyPinRedemptionLog_UpdateRixtyPinRedemptionLogByID", queryParameters));
	}

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_RixtyPinRedemptionLogDAL, "RixtyPinRedemptionLog_DeleteRixtyPinRedemptionLogByID", queryParameters));
	}

	public static RixtyPinRedemptionLogDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_RixtyPinRedemptionLogDAL, "RixtyPinRedemptionLog_GetRixtyPinRedemptionLogByID", queryParameters), BuildDAL);
	}

	public static RixtyPinRedemptionLogDAL GetByCardPIN(long cardPin)
	{
		if (cardPin == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@cardPIN", cardPin));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_RixtyPinRedemptionLogDAL, "RixtyPinRedemptionLog_GetRixtyPinRedemptionLogByCardPIN", queryParameters), BuildDAL);
	}
}
