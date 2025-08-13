using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Billing.Entities;

internal class WindowsStorePaymentDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxBilling;

	internal long ID { get; set; }

	internal long PaymentID { get; set; }

	internal DateTime PurchaseDate { get; set; }

	internal string TransactionID { get; set; }

	internal string Receipt { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	private static WindowsStorePaymentDAL BuildDAL(IDictionary<string, object> record)
	{
		return new WindowsStorePaymentDAL
		{
			ID = (long)record["ID"],
			PaymentID = (long)record["PaymentID"],
			PurchaseDate = (DateTime)record["PurchaseDate"],
			TransactionID = (string)record["TransactionID"],
			Receipt = (string)record["Receipt"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"]
		};
	}

	internal void Delete()
	{
		RobloxDatabase.RobloxBilling.Delete("WindowsStorePayments_DeleteWindowsStorePaymentByID", ID);
	}

	internal static WindowsStorePaymentDAL Get(long id)
	{
		return RobloxDatabase.RobloxBilling.Get("WindowsStorePayments_GetWindowsStorePaymentByID", id, BuildDAL);
	}

	internal void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", SqlDbType.BigInt)
			{
				Direction = ParameterDirection.Output
			},
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@PurchaseDate", PurchaseDate),
			new SqlParameter("@TransactionID", TransactionID),
			new SqlParameter("@Receipt", Receipt),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		ID = RobloxDatabase.RobloxBilling.Insert<long>("WindowsStorePayments_InsertWindowsStorePayment", queryParameters);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[7]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@PurchaseDate", PurchaseDate),
			new SqlParameter("@TransactionID", TransactionID),
			new SqlParameter("@Receipt", Receipt),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		RobloxDatabase.RobloxBilling.Update("WindowsStorePayments_UpdateWindowsStorePaymentByID", queryParameters);
	}

	internal static ICollection<WindowsStorePaymentDAL> MultiGet(ICollection<long> ids)
	{
		return RobloxDatabase.RobloxBilling.MultiGet("WindowsStorePayments_GetWindowsStorePaymentsByIDs", ids, BuildDAL);
	}

	internal static WindowsStorePaymentDAL GetWindowsStorePaymentByPaymentID(long paymentID)
	{
		if (paymentID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return RobloxDatabase.RobloxBilling.Lookup("WindowsStorePayments_GetWindowsStorePaymentByPaymentID", BuildDAL, queryParameters);
	}

	internal static WindowsStorePaymentDAL GetWindowsStorePaymentByTransactionID(string transactionID)
	{
		if (string.IsNullOrEmpty(transactionID))
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@TransactionID", transactionID)
		};
		return RobloxDatabase.RobloxBilling.Lookup("WindowsStorePayments_GetWindowsStorePaymentByTransactionID", BuildDAL, queryParameters);
	}
}
