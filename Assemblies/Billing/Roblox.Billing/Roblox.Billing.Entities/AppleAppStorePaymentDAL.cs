using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing.Entities;

public class AppleAppStorePaymentDAL
{
	internal int ID { get; set; }

	internal long PaymentId { get; set; }

	internal int Status { get; set; }

	internal string Receipt { get; set; }

	internal string ReceiptHash { get; set; }

	internal string AppItemId { get; set; }

	internal string Bid { get; set; }

	internal string BVRS { get; set; }

	internal string ItemId { get; set; }

	internal string OriginalPurchaseDate { get; set; }

	internal string OriginalTransactionId { get; set; }

	internal string ProductId { get; set; }

	internal string PurchaseDate { get; set; }

	internal string Quantity { get; set; }

	internal string TransactionId { get; set; }

	internal string VersionExternalIdentifier { get; set; }

	internal DateTime Created { get; set; }

	internal DateTime Updated { get; set; }

	internal long? TransactionId_BigInt { get; set; }

	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	internal AppleAppStorePaymentDAL()
	{
	}

	private static AppleAppStorePaymentDAL GetDALFromReader(SqlDataReader reader)
	{
		AppleAppStorePaymentDAL dal = new AppleAppStorePaymentDAL
		{
			ID = (int)reader["ID"],
			PaymentId = (long)reader["PaymentID"],
			Status = (int)reader["Status"],
			Receipt = (string)reader["Receipt"],
			ReceiptHash = (string)reader["ReceiptHash"],
			AppItemId = (reader["AppItemID"] as string),
			Bid = (reader["Bid"] as string),
			BVRS = (reader["BVRS"] as string),
			ItemId = (reader["ItemID"] as string),
			OriginalPurchaseDate = (reader["OriginalPurchaseDate"] as string),
			OriginalTransactionId = (reader["OriginalTransactionID"] as string),
			ProductId = (reader["ProductID"] as string),
			PurchaseDate = (reader["PurchaseDate"] as string),
			Quantity = (reader["Quantity"] as string),
			TransactionId = (reader["TransactionID"] as string),
			VersionExternalIdentifier = (reader["VersionExternalIdentifier"] as string),
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"],
			TransactionId_BigInt = (reader["TransactionID_BigInt"].Equals(DBNull.Value) ? null : ((long?)reader["TransactionID_BigInt"]))
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static AppleAppStorePaymentDAL BuildDAL(SqlDataReader reader)
	{
		AppleAppStorePaymentDAL dal = null;
		while (reader.Read())
		{
			dal = GetDALFromReader(reader);
		}
		return dal;
	}

	private static List<AppleAppStorePaymentDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<AppleAppStorePaymentDAL> dals = new List<AppleAppStorePaymentDAL>();
		while (reader.Read())
		{
			AppleAppStorePaymentDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "AppleAppStorePayments_DeleteAppleAppStorePaymentByID", queryParameters));
	}

	internal static AppleAppStorePaymentDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "AppleAppStorePayments_GetAppleAppStorePaymentByID", queryParameters), BuildDAL);
	}

	internal void Insert()
	{
		if (string.IsNullOrWhiteSpace(Receipt))
		{
			throw new ApplicationException("Required value not specified: Receipt.");
		}
		if (string.IsNullOrWhiteSpace(ReceiptHash))
		{
			throw new ApplicationException("Required value not specified: ReceiptHash.");
		}
		if (Created.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Created.");
		}
		if (Updated.Equals(DateTime.MinValue))
		{
			throw new ApplicationException("Required value not specified: Updated.");
		}
		SqlParameter[] queryParameters = new SqlParameter[18]
		{
			new SqlParameter("@PaymentID", PaymentId),
			new SqlParameter("@Status", Status),
			new SqlParameter("@Receipt", Receipt),
			new SqlParameter("@ReceiptHash", ReceiptHash),
			new SqlParameter("@AppItemID", (!string.IsNullOrEmpty(AppItemId)) ? ((IConvertible)AppItemId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@Bid", (!string.IsNullOrEmpty(Bid)) ? ((IConvertible)Bid) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@BVRS", (!string.IsNullOrEmpty(BVRS)) ? ((IConvertible)BVRS) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@ItemID", (!string.IsNullOrEmpty(ItemId)) ? ((IConvertible)ItemId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@OriginalPurchaseDate", (!string.IsNullOrEmpty(OriginalPurchaseDate)) ? ((IConvertible)OriginalPurchaseDate) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@OriginalTransactionID", (!string.IsNullOrEmpty(OriginalTransactionId)) ? ((IConvertible)OriginalTransactionId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@ProductID", (!string.IsNullOrEmpty(ProductId)) ? ((IConvertible)ProductId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@PurchaseDate", (!string.IsNullOrEmpty(PurchaseDate)) ? ((IConvertible)PurchaseDate) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@Quantity", (!string.IsNullOrEmpty(Quantity)) ? ((IConvertible)Quantity) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@TransactionID", (!string.IsNullOrEmpty(TransactionId)) ? ((IConvertible)TransactionId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@VersionExternalIdentifier", (!string.IsNullOrEmpty(VersionExternalIdentifier)) ? ((IConvertible)VersionExternalIdentifier) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@TransactionID_BigInt", TransactionId_BigInt.HasValue ? ((object)TransactionId_BigInt.Value) : DBNull.Value)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "AppleAppStorePayments_InsertAppleAppStorePayment", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	internal void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[19]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PaymentID", PaymentId),
			new SqlParameter("@Status", Status),
			new SqlParameter("@Receipt", Receipt),
			new SqlParameter("@ReceiptHash", ReceiptHash),
			new SqlParameter("@AppItemID", (!string.IsNullOrEmpty(AppItemId)) ? ((IConvertible)AppItemId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@Bid", (!string.IsNullOrEmpty(Bid)) ? ((IConvertible)Bid) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@BVRS", (!string.IsNullOrEmpty(BVRS)) ? ((IConvertible)BVRS) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@ItemID", (!string.IsNullOrEmpty(ItemId)) ? ((IConvertible)ItemId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@OriginalPurchaseDate", (!string.IsNullOrEmpty(OriginalPurchaseDate)) ? ((IConvertible)OriginalPurchaseDate) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@OriginalTransactionID", (!string.IsNullOrEmpty(OriginalTransactionId)) ? ((IConvertible)OriginalTransactionId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@ProductID", (!string.IsNullOrEmpty(ProductId)) ? ((IConvertible)ProductId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@PurchaseDate", (!string.IsNullOrEmpty(PurchaseDate)) ? ((IConvertible)PurchaseDate) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@Quantity", (!string.IsNullOrEmpty(Quantity)) ? ((IConvertible)Quantity) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@TransactionID", (!string.IsNullOrEmpty(TransactionId)) ? ((IConvertible)TransactionId) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@VersionExternalIdentifier", (!string.IsNullOrEmpty(VersionExternalIdentifier)) ? ((IConvertible)VersionExternalIdentifier) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated),
			new SqlParameter("@TransactionID_BigInt", TransactionId_BigInt.HasValue ? ((object)TransactionId_BigInt.Value) : DBNull.Value)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "AppleAppStorePayments_UpdateAppleAppStorePaymentByID", queryParameters));
	}

	internal static ICollection<AppleAppStorePaymentDAL> MultiGet(ICollection<int> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "AppleAppStorePayments_GetAppleAppStorePaymentsByIDs"), ids, BuildDALCollection);
	}

	internal static AppleAppStorePaymentDAL GetAppleAppStorePaymentByPaymentId(long paymentID)
	{
		if (paymentID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "AppleAppStorePayments_GetAppleAppStorePaymentByPaymentID", queryParameters), BuildDAL);
	}

	internal static ICollection<int> GetAppleAppStorePaymentIDsByTransactionIDBigInt(long transactionID_BigInt)
	{
		if (transactionID_BigInt == 0L)
		{
			throw new ApplicationException("Required value not specified: transactionID_BigInt");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@TransactionID_BigInt", transactionID_BigInt));
		queryParameters.Add(new SqlParameter("@Count", Convert.ToInt32(10)));
		queryParameters.Add(new SqlParameter("@ExclusiveStartAppleAppStorePaymentID", Convert.ToInt32(0)));
		return EntityHelper.GetDataEntityIDCollection<int>(new DbInfo(_DbConnectionString, "AppleAppStorePayments_GetAppleAppStorePaymentIDsByTransactionIDBigInt", queryParameters));
	}

	internal static int GetTotalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus(string receiptHash, int status)
	{
		if (string.IsNullOrWhiteSpace(receiptHash))
		{
			throw new ApplicationException("Required value not specified: ReceiptHash.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ReceiptHash", receiptHash));
		queryParameters.Add(new SqlParameter("@Status", status));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[AppleAppStorePayments_GetTotalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus]", queryParameters));
	}

	internal static int GetTotalNumberOfAppleAppStorePaymentsByTransactionIdBigIntAndStatus(long transactionIdBigInt, int status)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@TransactionID_BigInt", transactionIdBigInt));
		queryParameters.Add(new SqlParameter("@Status", status));
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[AppleAppStorePayments_GetTotalNumberOfAppleAppStorePaymentsByTransactionIDBigIntAndStatus]", queryParameters));
	}
}
