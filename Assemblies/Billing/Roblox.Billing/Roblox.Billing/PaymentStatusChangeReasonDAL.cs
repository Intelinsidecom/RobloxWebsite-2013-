using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class PaymentStatusChangeReasonDAL
{
	internal long ID { get; set; }

	internal long PaymentStatusChangeID { get; set; }

	internal long? AccountID { get; set; }

	internal byte PaymentStatusChangeReasonTypeID { get; set; }

	internal string Notes { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal PaymentStatusChangeReasonDAL()
	{
	}

	internal void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "PaymentStatusChangeReasons_DeletePaymentStatusChangeReasonByID", queryParameters));
	}

	internal void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PaymentStatusChangeID", PaymentStatusChangeID),
			new SqlParameter("@AccountID", AccountID.HasValue ? ((object)AccountID) : DBNull.Value),
			new SqlParameter("@PaymentStatusChangeReasonTypeID", PaymentStatusChangeReasonTypeID),
			new SqlParameter("@Notes", string.IsNullOrEmpty(Notes) ? ((IConvertible)DBNull.Value) : ((IConvertible)Notes)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "PaymentStatusChangeReasons_InsertPaymentStatusChangeReason", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	internal void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PaymentStatusChangeID", PaymentStatusChangeID),
			new SqlParameter("@AccountID", AccountID.HasValue ? ((object)AccountID) : DBNull.Value),
			new SqlParameter("@PaymentStatusChangeReasonTypeID", PaymentStatusChangeReasonTypeID),
			new SqlParameter("@Notes", string.IsNullOrEmpty(Notes) ? ((IConvertible)DBNull.Value) : ((IConvertible)Notes)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "PaymentStatusChangeReasons_UpdatePaymentStatusChangeReasonByID", queryParameters));
	}

	private static PaymentStatusChangeReasonDAL BuildDAL(SqlDataReader reader)
	{
		PaymentStatusChangeReasonDAL dal = new PaymentStatusChangeReasonDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.PaymentStatusChangeID = (long)reader["PaymentStatusChangeID"];
			dal.AccountID = (reader["AccountID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["AccountID"])));
			dal.PaymentStatusChangeReasonTypeID = (byte)reader["PaymentStatusChangeReasonTypeID"];
			dal.Notes = (string)reader["Notes"];
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	internal static PaymentStatusChangeReasonDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentStatusChangeReasons_GetPaymentStatusChangeReasonByID", queryParameters), BuildDAL);
	}

	internal static PaymentStatusChangeReasonDAL GetByPaymenstStatusChangeId(long paymentStatusChangeId)
	{
		if (paymentStatusChangeId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PaymentStatusChangeID", paymentStatusChangeId)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "PaymentStatusChangeReasons_GetPaymentStatusChangeReasonByPaymentStatusChangeID", queryParameters), BuildDAL);
	}
}
