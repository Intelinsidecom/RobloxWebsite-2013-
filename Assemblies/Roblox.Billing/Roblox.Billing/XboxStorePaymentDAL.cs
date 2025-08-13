using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Billing;

public class XboxStorePaymentDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxBilling;

	internal int ID { get; set; }

	internal long PaymentID { get; set; }

	internal string XboxStoreProductID { get; set; }

	internal string XboxStoreTransactionID { get; set; }

	internal string XboxStoreTitleID { get; set; }

	internal string XboxStoreSandboxID { get; set; }

	internal DateTime PurchaseTime { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static XboxStorePaymentDAL BuildDAL(IDictionary<string, object> record)
	{
		return new XboxStorePaymentDAL
		{
			ID = (int)record["ID"],
			PaymentID = (long)record["PaymentID"],
			XboxStoreProductID = (string)record["XboxStoreProductID"],
			XboxStoreTransactionID = (string)record["XboxStoreTransactionID"],
			XboxStoreTitleID = (string)record["XboxStoreTitleID"],
			XboxStoreSandboxID = (string)record["XboxStoreSandboxID"],
			PurchaseTime = (DateTime)record["PurchaseTime"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxBilling.Delete("XboxStorePayments_DeleteXboxStorePaymentByID", ID);
	}

	internal static XboxStorePaymentDAL Get(int id)
	{
		return RobloxDatabase.RobloxBilling.Get("XboxStorePayments_GetXboxStorePaymentByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", SqlDbType.Int)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@XboxStoreProductID", XboxStoreProductID),
			new SqlParameter("@XboxStoreTransactionID", XboxStoreTransactionID),
			new SqlParameter("@XboxStoreTitleID", string.IsNullOrEmpty(XboxStoreTitleID) ? ((IConvertible)DBNull.Value) : ((IConvertible)XboxStoreTitleID)),
			new SqlParameter("@XboxStoreSandboxID", string.IsNullOrEmpty(XboxStoreSandboxID) ? ((IConvertible)DBNull.Value) : ((IConvertible)XboxStoreSandboxID)),
			new SqlParameter("@PurchaseTime", PurchaseTime),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxBilling.Insert<int>("XboxStorePayments_InsertXboxStorePayment", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[9]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@XboxStoreProductID", XboxStoreProductID),
			new SqlParameter("@XboxStoreTransactionID", XboxStoreTransactionID),
			new SqlParameter("@XboxStoreTitleID", string.IsNullOrEmpty(XboxStoreTitleID) ? ((IConvertible)DBNull.Value) : ((IConvertible)XboxStoreTitleID)),
			new SqlParameter("@XboxStoreSandboxID", string.IsNullOrEmpty(XboxStoreSandboxID) ? ((IConvertible)DBNull.Value) : ((IConvertible)XboxStoreSandboxID)),
			new SqlParameter("@PurchaseTime", PurchaseTime),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxBilling.Update("XboxStorePayments_UpdateXboxStorePaymentByID", queryParameters);
	}

	internal static ICollection<XboxStorePaymentDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxBilling.MultiGet("XboxStorePayments_GetXboxStorePaymentsByIDs", ids, BuildDAL);
	}

	internal static XboxStorePaymentDAL GetXboxStorePaymentByPaymentID(long paymentID)
	{
		if (paymentID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return RobloxDatabase.RobloxBilling.Lookup("XboxStorePayments_GetXboxStorePaymentByPaymentID", BuildDAL, queryParameters);
	}

	internal static XboxStorePaymentDAL GetXboxStorePaymentByXboxStoreTransactionID(string xboxStoreTransactionID)
	{
		if (string.IsNullOrEmpty(xboxStoreTransactionID))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@XboxStoreTransactionID", xboxStoreTransactionID)
		};
		return RobloxDatabase.RobloxBilling.Lookup("XboxStorePayments_GetXboxStorePaymentByXboxStoreTransactionID", BuildDAL, queryParameters);
	}
}
