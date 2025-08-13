using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class LiveGamerPaymentDAL
{
	private long _ID;

	public DateTime Created;

	public DateTime Updated;

	public long PaymentID;

	public byte LiveGamerPaymentStatusTypeID;

	public int? ExternalOrderId;

	public string PaymentType;

	public string CallbackXmlContent;

	public string Signature;

	public string TaxModel;

	public decimal? Tax;

	private static readonly string dbConnectionString_LiveGamerPaymentDAL = Settings.Default.BillingConnectionString;

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

	public void Delete()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_LiveGamerPaymentDAL, "LiveGamerPayments_DeleteLiveGamerPaymentByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentID", PaymentID));
		queryParameters.Add(new SqlParameter("@LiveGamerPaymentStatusTypeID", LiveGamerPaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@ExternalOrderId", ExternalOrderId.HasValue ? ((object)ExternalOrderId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@PaymentType", ((object)PaymentType) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TaxModel", ((object)TaxModel) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Tax", Tax.HasValue ? ((object)Tax) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CallbackXmlContent", ((object)CallbackXmlContent) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Signature", ((object)Signature) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_LiveGamerPaymentDAL, "LiveGamerPayments_InsertLiveGamerPayment", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@PaymentID", PaymentID));
		queryParameters.Add(new SqlParameter("@LiveGamerPaymentStatusTypeID", LiveGamerPaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@ExternalOrderId", ExternalOrderId.HasValue ? ((object)ExternalOrderId) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@PaymentType", ((object)PaymentType) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TaxModel", ((object)TaxModel) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Tax", Tax.HasValue ? ((object)Tax) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CallbackXmlContent", ((object)CallbackXmlContent) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Signature", ((object)Signature) ?? ((object)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_LiveGamerPaymentDAL, "LiveGamerPayments_UpdateLiveGamerPaymentByID", queryParameters));
	}

	private static LiveGamerPaymentDAL BuildDAL(SqlDataReader reader)
	{
		LiveGamerPaymentDAL dal = new LiveGamerPaymentDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.LiveGamerPaymentStatusTypeID = (byte)reader["LiveGamerPaymentStatusTypeID"];
			dal.PaymentID = (long)reader["PaymentID"];
			dal.ExternalOrderId = (reader["ExternalOrderId"].Equals(DBNull.Value) ? null : ((int?)reader["ExternalOrderId"]));
			dal.PaymentType = (reader["PaymentType"].Equals(DBNull.Value) ? null : ((string)reader["PaymentType"]));
			dal.TaxModel = (reader["TaxModel"].Equals(DBNull.Value) ? null : ((string)reader["TaxModel"]));
			dal.Tax = (reader["Tax"].Equals(DBNull.Value) ? null : ((decimal?)reader["Tax"]));
			dal.CallbackXmlContent = (reader["CallbackXmlContent"].Equals(DBNull.Value) ? null : ((string)reader["CallbackXmlContent"]));
			dal.Signature = (reader["Signature"].Equals(DBNull.Value) ? null : ((string)reader["Signature"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static LiveGamerPaymentDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_LiveGamerPaymentDAL, "LiveGamerPayments_GetLiveGamerPaymentByID", queryParameters), BuildDAL);
	}

	public static LiveGamerPaymentDAL GetByPaymentId(long paymentId)
	{
		if (paymentId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentID", paymentId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_LiveGamerPaymentDAL, "LiveGamerPayments_GetLiveGamerPaymentByPaymentID", queryParameters), BuildDAL);
	}
}
