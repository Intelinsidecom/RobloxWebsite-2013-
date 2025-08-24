using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Roblox.Common;
using Roblox.Data;
using Roblox.Entities.Mssql;
using Roblox.MssqlDatabases;

namespace Roblox.Billing.Entities;

public class GooglePlayStorePaymentDAL
{
	private const RobloxDatabase _Database = RobloxDatabase.RobloxBilling;

	private static string _DbConnectionString = RobloxDatabase.RobloxBilling.GetConnectionString();

	public int ID { get; set; }

	public long PaymentID { get; set; }

	public string PackageName { get; set; }

	public string OrderID { get; set; }

	public string AppProductID { get; set; }

	public string TokenHash { get; set; }

	public string Token { get; set; }

	public string DeveloperPayload { get; set; }

	public int? PurchaseState { get; set; }

	public long? PurchaseTime { get; set; }

	public int? ConsumptionState { get; set; }

	public DateTime Created { get; set; }

	public DateTime Updated { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="!:GooglePlayStorePatmentDAL" /> class.
	/// </summary>
	public GooglePlayStorePaymentDAL()
	{
	}

	private static GooglePlayStorePaymentDAL BuildDAL(IDictionary<string, object> record)
	{
		return new GooglePlayStorePaymentDAL
		{
			ID = (int)record["ID"],
			PaymentID = (long)record["PaymentID"],
			PackageName = (string)record["PackageName"],
			AppProductID = (string)record["AppProductID"],
			TokenHash = (string)record["TokenHash"],
			Token = (string)record["Token"],
			DeveloperPayload = (string)record["DeveloperPayload"],
			PurchaseState = (int?)record["PurchaseState"],
			PurchaseTime = (long?)record["PurchaseTime"],
			ConsumptionState = (int?)record["ConsumptionState"],
			Created = (DateTime)record["Created"],
			Updated = (DateTime)record["Updated"],
			OrderID = (string)record["OrderID"]
		};
	}

	private static GooglePlayStorePaymentDAL BuildDAL(SqlDataReader reader)
	{
		GooglePlayStorePaymentDAL dal = new GooglePlayStorePaymentDAL();
		while (reader.Read())
		{
			dal.ID = (int)reader["ID"];
			dal.PaymentID = (long)reader["PaymentID"];
			dal.PackageName = (string)reader["PackageName"];
			dal.OrderID = (reader["OrderID"].Equals(DBNull.Value) ? null : ((string)reader["OrderID"]));
			dal.AppProductID = (string)reader["AppProductID"];
			dal.TokenHash = (string)reader["TokenHash"];
			dal.Token = (string)reader["Token"];
			dal.DeveloperPayload = (reader["DeveloperPayload"].Equals(DBNull.Value) ? null : ((string)reader["DeveloperPayload"]));
			dal.PurchaseState = (reader["PurchaseState"].Equals(DBNull.Value) ? null : ((int?)reader["PurchaseState"]));
			dal.PurchaseTime = (reader["PurchaseTime"].Equals(DBNull.Value) ? null : ((long?)reader["PurchaseTime"]));
			dal.ConsumptionState = (reader["ConsumptionState"].Equals(DBNull.Value) ? null : ((int?)reader["ConsumptionState"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
		}
		if (dal.ID == 0)
		{
			return null;
		}
		return dal;
	}

	/// <summary>
	/// Deletes the GooglePlayStorePayment record.
	/// </summary>
	public void Delete()
	{
		if (ID == 0)
		{
			throw new ApplicationException("Required value not specified: ID.");
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", ID)
		};
		EntityHelper.DoEntityDALDelete(new DbInfo(_DbConnectionString, "GooglePlayStorePaymentsV2_DeleteGooglePlayStorePaymentByID", queryParameters));
	}

	/// <summary>
	/// Gets a GooglePlayStorePayment record by its ID.
	/// </summary>
	/// <param name="id">The ID of the GooglePlayStorePayment to get.</param>
	/// <returns>The GooglePlayStorePayment record with the given ID, or null if non exists.</returns>
	public static GooglePlayStorePaymentDAL Get(int id)
	{
		if (id == 0)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@ID", id)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "GooglePlayStorePaymentsV2_GetGooglePlayStorePaymentByID", queryParameters), BuildDAL);
	}

	/// <summary>
	/// Inserts a new GooglePlatStorePayment record.
	/// </summary>
	public void Insert()
	{
		SqlParameter[] queryParameters = new SqlParameter[12]
		{
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@PackageName", PackageName),
			new SqlParameter("@OrderID", ((object)OrderID) ?? ((object)DBNull.Value)),
			new SqlParameter("@AppProductID", AppProductID),
			new SqlParameter("@TokenHash", TokenHash),
			new SqlParameter("@Token", Token),
			new SqlParameter("@DeveloperPayload", (DeveloperPayload != null) ? ((IConvertible)DeveloperPayload) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@PurchaseState", PurchaseState.HasValue ? ((object)PurchaseState) : DBNull.Value),
			new SqlParameter("@PurchaseTime", PurchaseTime.HasValue ? ((object)PurchaseTime) : DBNull.Value),
			new SqlParameter("@ConsumptionState", ConsumptionState.HasValue ? ((object)ConsumptionState) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		DbInfo dbInfo = new DbInfo(_DbConnectionString, "GooglePlayStorePaymentsV2_InsertGooglePlayStorePayment", new SqlParameter("@ID", SqlDbType.Int), queryParameters);
		ID = EntityHelper.DoEntityDALInsert<int>(dbInfo);
	}

	/// <summary>
	/// Updates an existing GooglePlayStorePayment record.
	/// </summary>
	public void Update()
	{
		SqlParameter[] queryParameters = new SqlParameter[13]
		{
			new SqlParameter("@ID", ID),
			new SqlParameter("@PaymentID", PaymentID),
			new SqlParameter("@PackageName", PackageName),
			new SqlParameter("@OrderID", ((object)OrderID) ?? ((object)DBNull.Value)),
			new SqlParameter("@AppProductID", AppProductID),
			new SqlParameter("@TokenHash", TokenHash),
			new SqlParameter("@Token", Token),
			new SqlParameter("@DeveloperPayload", (DeveloperPayload != null) ? ((IConvertible)DeveloperPayload) : ((IConvertible)DBNull.Value)),
			new SqlParameter("@PurchaseState", PurchaseState.HasValue ? ((object)PurchaseState) : DBNull.Value),
			new SqlParameter("@PurchaseTime", PurchaseTime.HasValue ? ((object)PurchaseTime) : DBNull.Value),
			new SqlParameter("@ConsumptionState", ConsumptionState.HasValue ? ((object)ConsumptionState) : DBNull.Value),
			new SqlParameter("@Created", Created),
			new SqlParameter("@Updated", Updated)
		};
		EntityHelper.DoEntityDALUpdate(new DbInfo(_DbConnectionString, "GooglePlayStorePaymentsV2_UpdateGooglePlayStorePaymentByID", queryParameters));
	}

	public static ICollection<GooglePlayStorePaymentDAL> MultiGet(ICollection<int> ids)
	{
		return RobloxDatabase.RobloxBilling.MultiGet("GooglePlayStorePaymentsV2_GetGooglePlayStorePaymentsByIDs", ids, BuildDAL);
	}

	/// <summary>
	/// Gets a GooglePlayStorePayment record by its payment ID.
	/// </summary>
	/// <param name="paymentID">The payment ID of the GooglePlayStorePayment record to get.</param>
	/// <returns>The GooglePlayStorePayment with the given payment ID, or null of none exists.</returns>
	public static GooglePlayStorePaymentDAL GetGooglePlayStorePaymentByPaymentID(long paymentID)
	{
		if (paymentID == 0L)
		{
			return null;
		}
		SqlParameter[] queryParameters = new SqlParameter[1]
		{
			new SqlParameter("@PaymentID", paymentID)
		};
		return EntityHelper.GetEntityDAL(new DbInfo(_DbConnectionString, "GooglePlayStorePaymentsV2_GetGooglePlayStorePaymentByPaymentID", queryParameters), BuildDAL);
	}

	public static ICollection<int> GetGooglePlayStorePaymentIDsByOrderID(string orderId, int count, int? exclusiveStartId)
	{
		if (count < 1)
		{
			throw new ApplicationException("Required value not specified: Count.");
		}
		if (exclusiveStartId < 0)
		{
			throw new ApplicationException("Parameter 'ExclusiveStartID' cannot be negative.");
		}
		SqlParameter[] obj = new SqlParameter[3]
		{
			new SqlParameter("@OrderID", string.IsNullOrEmpty(orderId) ? ((IConvertible)DBNull.Value) : ((IConvertible)orderId)),
			new SqlParameter("@Count", count),
			null
		};
		int? num = exclusiveStartId;
		obj[2] = new SqlParameter("@ExclusiveStartID", num.HasValue ? ((object)num.GetValueOrDefault()) : DBNull.Value);
		SqlParameter[] queryParameters = obj;
		return RobloxDatabase.RobloxBilling.GetIDCollection<int>("GooglePlayStorePaymentsV2_GetGooglePlayStorePaymentIDsByOrderID", queryParameters);
	}

	public static int GetTotalNumberOfGooglePlayStorePayments(string packageName, string appProductID, string tokenHash, int? purchaseState)
	{
		if (string.IsNullOrEmpty(packageName))
		{
			throw new ApplicationException("Required value not specified: packageName.");
		}
		if (string.IsNullOrEmpty(appProductID))
		{
			throw new ApplicationException("Required value not specified: appProductID.");
		}
		if (string.IsNullOrEmpty(tokenHash))
		{
			throw new ApplicationException("Required value not specified: tokenHash.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>
		{
			new SqlParameter("@PackageName", packageName),
			new SqlParameter("@AppProductID", appProductID),
			new SqlParameter("@TokenHash", tokenHash)
		};
		if (purchaseState.HasValue)
		{
			queryParameters.Add(new SqlParameter("@PurchaseState", purchaseState));
		}
		else
		{
			queryParameters.Add(new SqlParameter("@PurchaseState", DBNull.Value));
		}
		return EntityHelper.GetDataCount<int>(new DbInfo(_DbConnectionString, "GooglePlayStorePaymentsV2_GetTotalNumberOfGooglePlayStorePaymentsByPackageNameAppProductIDTokenHashAndPurchaseState", queryParameters));
	}
}
