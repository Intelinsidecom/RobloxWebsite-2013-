using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

/// <summary>
/// Represents the data access layer for an Amazon store payment.
/// </summary>
public class AmazonStorePaymentDAL
{
	/// <summary>
	/// Gets the payment's ID.
	/// </summary>
	public long ID { get; internal set; }

	/// <summary>
	/// Gets or sets the ID of the corresponding payment record.
	/// </summary>
	public long PaymentID { get; set; }

	/// <summary>
	/// Gets or sets the receipt ID supplied by Amazon.
	/// </summary>
	public string AmazonReceiptID { get; set; }

	/// <summary>
	/// Gets or sets the hash of <see cref="P:Roblox.Billing.AmazonStorePaymentDAL.AmazonReceiptID" />.
	/// </summary>
	public string AmazonReceiptIDHash { get; set; }

	/// <summary>
	/// Gets or sets the ID of the Amazon user.
	/// </summary>
	public string AmazonUserID { get; set; }

	/// <summary>
	/// Gets or sets the ID of the Amazon product.
	/// </summary>
	public string AmazonProductID { get; set; }

	/// <summary>
	/// Gets or sets the date that a product subscription was canceled.
	/// If a substriction is ongoing then <see cref="P:Roblox.Billing.AmazonStorePaymentDAL.CancelDate" /> will be null.
	/// </summary>
	public string CancelDate { get; set; }

	/// <summary>
	/// Gets or sets the type of the product that was paid for.
	/// </summary>
	public string ProductType { get; set; }

	/// <summary>
	/// Gets or sets the date that the purchase was made.
	/// </summary>
	public long? PurchaseDate { get; set; }

	/// <summary>
	/// The <see cref="T:System.DateTime" /> at which the record was created.
	/// </summary>
	public DateTime Created { get; set; }

	/// <summary>
	/// The <see cref="T:System.DateTime" /> at which the record was last updated.
	/// </summary>
	public DateTime Updated { get; set; }

	/// <summary>
	/// Gets the connection string of the AmazonStorePayments database.
	/// </summary>
	private static string _DbConnectionString => Settings.Default.BillingConnectionString;

	/// <summary>
	/// Inserts a record of the <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> into the database.
	/// </summary>
	public void Insert()
	{
		List<SqlParameter> obj = new List<SqlParameter>
		{
			new SqlParameter("@PaymentId", PaymentID),
			new SqlParameter("@AmazonReceiptID", AmazonReceiptID),
			new SqlParameter("@AmazonReceiptIDHash", AmazonReceiptIDHash),
			new SqlParameter("@AmazonUserID", AmazonUserID),
			new SqlParameter("@AmazonProductID", ((object)AmazonProductID) ?? ((object)DBNull.Value)),
			new SqlParameter("@CancelDate", ((object)CancelDate) ?? ((object)DBNull.Value)),
			new SqlParameter("@ProductType", ((object)ProductType) ?? ((object)DBNull.Value))
		};
		long? purchaseDate = PurchaseDate;
		obj.Add(new SqlParameter("@PurchaseDate", purchaseDate.HasValue ? ((object)purchaseDate.GetValueOrDefault()) : DBNull.Value));
		obj.Add(new SqlParameter("@Created", Created));
		obj.Add(new SqlParameter("@Updated", Updated));
		List<SqlParameter> queryParameters = obj;
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "AmazonStorePayments_InsertAmazonStorePayment", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<long>(dbInfo);
	}

	/// <summary>
	/// Updates an existing record of the <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> in the database.
	/// </summary>
	public void Update()
	{
		List<SqlParameter> obj = new List<SqlParameter>
		{
			new SqlParameter("@PaymentId", PaymentID),
			new SqlParameter("@AmazonReceiptID", AmazonReceiptID),
			new SqlParameter("@AmazonReceiptIDHash", AmazonReceiptIDHash),
			new SqlParameter("@AmazonUserID", AmazonUserID),
			new SqlParameter("@AmazonProductID", ((object)AmazonProductID) ?? ((object)DBNull.Value)),
			new SqlParameter("@CancelDate", ((object)CancelDate) ?? ((object)DBNull.Value)),
			new SqlParameter("@ProductType", ((object)ProductType) ?? ((object)DBNull.Value))
		};
		long? purchaseDate = PurchaseDate;
		obj.Add(new SqlParameter("@PurchaseDate", purchaseDate.HasValue ? ((object)purchaseDate.GetValueOrDefault()) : DBNull.Value));
		obj.Add(new SqlParameter("@Created", Created));
		obj.Add(new SqlParameter("@Updated", Updated));
		List<SqlParameter> queryParameters = obj;
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "AmazonStorePayments_UpdateAmazonStorePaymentByID", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	/// <summary>
	/// Deletes the <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> from the database.
	/// </summary>
	public void Delete()
	{
		if (ID == 0L)
		{
			throw new ApplicationException("Required value not specified: Id.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "AmazonStorePayments_DeleteAmazonStorePaymentByID", queryParameters));
	}

	/// <summary>
	/// Gets an <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> by its ID..
	/// </summary>
	/// <param name="id">The ID of the <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> to get.</param>
	/// <returns>The <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> with the given ID, or null of none exists.</returns>
	public static AmazonStorePaymentDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "AmazonStorePayments_GetAmazonStorePaymentByID", queryParameters), GetDALFromReader);
	}

	/// <summary>
	/// Builds an <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> from the given <see cref="T:System.Data.SqlClient.SqlDataReader" />.
	/// </summary>
	/// <param name="reader">The <see cref="T:System.Data.SqlClient.SqlDataReader" /> to build the <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> from.</param>
	/// <returns>A <see cref="T:Roblox.Billing.AmazonStorePaymentDAL" /> built from the given <see cref="T:System.Data.SqlClient.SqlDataReader" />.</returns>
	private static AmazonStorePaymentDAL GetDALFromReader(SqlDataReader reader)
	{
		AmazonStorePaymentDAL dal = new AmazonStorePaymentDAL
		{
			ID = (long)reader["ID"],
			PaymentID = (long)reader["PaymentID"],
			AmazonReceiptID = (string)reader["AmazonReceiptID"],
			AmazonReceiptIDHash = (string)reader["AmazonReceiptIDHash"],
			AmazonUserID = (string)reader["AmazonUserID"],
			AmazonProductID = (reader["AmazonProductID"].Equals(DBNull.Value) ? null : ((string)reader["AmazonProductID"])),
			CancelDate = (reader["CancelDate"].Equals(DBNull.Value) ? null : ((string)reader["CancelDate"])),
			ProductType = (reader["ProductType"].Equals(DBNull.Value) ? null : ((string)reader["ProductType"])),
			PurchaseDate = (reader["PurchaseDate"].Equals(DBNull.Value) ? null : ((long?)reader["PurchaseDate"])),
			Created = (DateTime)reader["Created"],
			Updated = (DateTime)reader["Updated"]
		};
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	private static List<AmazonStorePaymentDAL> BuildDALCollection(SqlDataReader reader)
	{
		List<AmazonStorePaymentDAL> dals = new List<AmazonStorePaymentDAL>();
		while (reader.Read())
		{
			AmazonStorePaymentDAL dal = GetDALFromReader(reader);
			dals.Add(dal);
		}
		return dals;
	}

	internal static ICollection<AmazonStorePaymentDAL> MultiGet(ICollection<long> ids)
	{
		return EntityHelper.GetEntityDALCollection(new DbInfo(_DbConnectionString, "AmazonStorePayments_GetAmazonStorePaymentsByIDs"), ids, BuildDALCollection);
	}

	/// <summary>
	/// Gets the total number of AmazonStorePayments containing the given receipt hash.
	/// </summary>
	/// <param name="amazonReceiptIdHash">The receipt hash.</param>
	/// <returns>The total number of AmazonStorePayments containing the given receipt hash.</returns>
	public static int GetTotalNumberOfAppleAppStorePaymentsByAmazonReceiptIdHash(string amazonReceiptIdHash)
	{
		if (string.IsNullOrWhiteSpace(amazonReceiptIdHash))
		{
			throw new ApplicationException("Required value not specified: ReceiptHash.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AmazonReceiptIDHash", amazonReceiptIdHash)
		};
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "[dbo].[AmazonStorePayments_GetTotalNumberOfAmazonStorePaymentsByAmazonReceiptIDHash]", queryParameters));
	}

	/// <summary>
	/// Gets the IDs of all AmazonStorePayments containing the given receipt hash.
	/// </summary>
	/// <param name="amazonReceiptIdHash">The receipt hash.</param>
	/// <param name="startRowIndex">StartRowIndex</param>
	/// <param name="maxRows">MaxRows</param>
	/// <returns>The IDs of all AmazonStorePayments containing the given receipt hash.</returns>
	public static ICollection<long> GetAmazonStorePaymentIDsByAmazonReceiptIdHash_Paged(string amazonReceiptIdHash, int startRowIndex, int maxRows)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@AmazonReceiptIDHash", amazonReceiptIdHash),
			new SqlParameter("@StartRowIndex", startRowIndex),
			new SqlParameter("@MaximumRows", maxRows)
		};
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(_DbConnectionString, "[dbo].[AmazonStorePayments_GetAmazonStorePaymentIDsByAmazonReceiptIDHash_Paged]", queryParameters));
	}
}
