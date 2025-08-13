using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Roblox.Common;
using Roblox.Common.Properties;
using Roblox.Data;

namespace Roblox.Billing;

public class TransactionLogDAL
{
	private long _ID;

	public int SaleID;

	public long PaymentID;

	public byte PaymentStatusTypeID;

	public long? UserAccountID;

	public string TransactionID;

	public string TransactionType;

	public string AuthCode;

	public string AvsCode;

	public string Number;

	public decimal? Amount;

	public int? Year;

	public int? Month;

	public string Address;

	public string Address2;

	public string City;

	public string Country;

	public string Email;

	public string FirstName;

	public string LastName;

	public string Phone;

	public string StateProvince;

	public string ZipPostal;

	public string ClientIP;

	public DateTime? TransactionDate;

	public string ErrorMessage;

	public string Description;

	public string Code;

	public string AccountID;

	public DateTime Created;

	public DateTime Updated;

	public int? PayPalBillingAgreementID;

	public byte? CurrencyTypeID;

	private static readonly string dbConnectionString_TransactionLogDAL = Settings.Default.BillingConnectionString;

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
		EntityHelper.DoEntityDALDelete(new DbInfo(dbConnectionString_TransactionLogDAL, "TransactionLog_DeleteTransactionLogByID", queryParameters));
	}

	public void Insert()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@PaymentID", PaymentID));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@UserAccountID", UserAccountID.HasValue ? ((object)UserAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@TransactionID", (TransactionID != null) ? ((IConvertible)TransactionID) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TransactionType", (TransactionType != null) ? ((IConvertible)TransactionType) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@AuthCode", (AuthCode != null) ? ((IConvertible)AuthCode) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@AvsCode", (AvsCode != null) ? ((IConvertible)AvsCode) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Number", (Number != null) ? ((IConvertible)Number) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Amount", Amount.HasValue ? ((object)Amount) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Year", Year.HasValue ? ((object)Year) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Month", Month.HasValue ? ((object)Month) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Address", (Address != null) ? ((IConvertible)Address) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Address2", (Address2 != null) ? ((IConvertible)Address2) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@City", (City != null) ? ((IConvertible)City) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Country", (Country != null) ? ((IConvertible)Country) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Email", (Email != null) ? ((IConvertible)Email) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@FirstName", (FirstName != null) ? ((IConvertible)FirstName) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@LastName", (LastName != null) ? ((IConvertible)LastName) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Phone", (Phone != null) ? ((IConvertible)Phone) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@StateProvince", (StateProvince != null) ? ((IConvertible)StateProvince) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@ZipPostal", (ZipPostal != null) ? ((IConvertible)ZipPostal) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@ClientIP", (ClientIP != null) ? ((IConvertible)ClientIP) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TransactionDate", TransactionDate.HasValue ? ((object)TransactionDate) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ErrorMessage", (ErrorMessage != null) ? ((IConvertible)ErrorMessage) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Description", (Description != null) ? ((IConvertible)Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Code", (Code != null) ? ((IConvertible)Code) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@AccountID", (AccountID != null) ? ((IConvertible)AccountID) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@PayPalBillingAgreementID", PayPalBillingAgreementID.HasValue ? ((object)PayPalBillingAgreementID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		ID = EntityHelper.DoEntityDALInsert<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "TransactionLog_InsertTransactionLog", new SqlParameter("@ID", SqlDbType.BigInt), queryParameters));
	}

	public void Update()
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", _ID));
		queryParameters.Add(new SqlParameter("@SaleID", SaleID));
		queryParameters.Add(new SqlParameter("@PaymentID", PaymentID));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", PaymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@UserAccountID", UserAccountID.HasValue ? ((object)UserAccountID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@TransactionID", (TransactionID != null) ? ((IConvertible)TransactionID) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TransactionType", (TransactionType != null) ? ((IConvertible)TransactionType) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@AuthCode", (AuthCode != null) ? ((IConvertible)AuthCode) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@AvsCode", (AvsCode != null) ? ((IConvertible)AvsCode) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Number", (Number != null) ? ((IConvertible)Number) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Amount", Amount.HasValue ? ((object)Amount) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Year", Year.HasValue ? ((object)Year) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Month", Month.HasValue ? ((object)Month) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@Address", (Address != null) ? ((IConvertible)Address) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Address2", (Address2 != null) ? ((IConvertible)Address2) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@City", (City != null) ? ((IConvertible)City) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Country", (Country != null) ? ((IConvertible)Country) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Email", (Email != null) ? ((IConvertible)Email) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@FirstName", (FirstName != null) ? ((IConvertible)FirstName) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@LastName", (LastName != null) ? ((IConvertible)LastName) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Phone", (Phone != null) ? ((IConvertible)Phone) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@StateProvince", (StateProvince != null) ? ((IConvertible)StateProvince) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@ZipPostal", (ZipPostal != null) ? ((IConvertible)ZipPostal) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@ClientIP", (ClientIP != null) ? ((IConvertible)ClientIP) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@TransactionDate", TransactionDate.HasValue ? ((object)TransactionDate) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@ErrorMessage", (ErrorMessage != null) ? ((IConvertible)ErrorMessage) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Description", (Description != null) ? ((IConvertible)Description) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Code", (Code != null) ? ((IConvertible)Code) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@AccountID", (AccountID != null) ? ((IConvertible)AccountID) : ((IConvertible)DBNull.Value)));
		queryParameters.Add(new SqlParameter("@Created", Created));
		queryParameters.Add(new SqlParameter("@Updated", Updated));
		queryParameters.Add(new SqlParameter("@PayPalBillingAgreementID", PayPalBillingAgreementID.HasValue ? ((object)PayPalBillingAgreementID) : DBNull.Value));
		queryParameters.Add(new SqlParameter("@CurrencyTypeID", CurrencyTypeID.HasValue ? ((object)CurrencyTypeID) : DBNull.Value));
		EntityHelper.DoEntityDALUpdate(new DbInfo(dbConnectionString_TransactionLogDAL, "TransactionLog_UpdateTransactionLogByID", queryParameters));
	}

	private static TransactionLogDAL BuildDAL(SqlDataReader reader)
	{
		TransactionLogDAL dal = new TransactionLogDAL();
		while (reader.Read())
		{
			dal.ID = (long)reader["ID"];
			dal.SaleID = (int)reader["SaleID"];
			dal.PaymentID = (long)reader["PaymentID"];
			dal.PaymentStatusTypeID = (byte)reader["PaymentStatusTypeID"];
			dal.UserAccountID = (reader["UserAccountID"].Equals(DBNull.Value) ? null : new long?(Convert.ToInt64(reader["UserAccountID"])));
			dal.TransactionID = (reader["TransactionID"].Equals(DBNull.Value) ? null : ((string)reader["TransactionID"]));
			dal.TransactionType = (reader["TransactionType"].Equals(DBNull.Value) ? null : ((string)reader["TransactionType"]));
			dal.AuthCode = (reader["AuthCode"].Equals(DBNull.Value) ? null : ((string)reader["AuthCode"]));
			dal.AvsCode = (reader["AvsCode"].Equals(DBNull.Value) ? null : ((string)reader["AvsCode"]));
			dal.Number = (reader["Number"].Equals(DBNull.Value) ? null : ((string)reader["Number"]));
			dal.Amount = (reader["Amount"].Equals(DBNull.Value) ? null : ((decimal?)reader["Amount"]));
			dal.Year = (reader["Year"].Equals(DBNull.Value) ? null : ((int?)reader["Year"]));
			dal.Month = (reader["Month"].Equals(DBNull.Value) ? null : ((int?)reader["Month"]));
			dal.Address = (reader["Address"].Equals(DBNull.Value) ? null : ((string)reader["Address"]));
			dal.Address2 = (reader["Address2"].Equals(DBNull.Value) ? null : ((string)reader["Address2"]));
			dal.City = (reader["City"].Equals(DBNull.Value) ? null : ((string)reader["City"]));
			dal.Country = (reader["Country"].Equals(DBNull.Value) ? null : ((string)reader["Country"]));
			dal.Email = (reader["Email"].Equals(DBNull.Value) ? null : ((string)reader["Email"]));
			dal.FirstName = (reader["FirstName"].Equals(DBNull.Value) ? null : ((string)reader["FirstName"]));
			dal.LastName = (reader["LastName"].Equals(DBNull.Value) ? null : ((string)reader["LastName"]));
			dal.Phone = (reader["Phone"].Equals(DBNull.Value) ? null : ((string)reader["Phone"]));
			dal.StateProvince = (reader["StateProvince"].Equals(DBNull.Value) ? null : ((string)reader["StateProvince"]));
			dal.ZipPostal = (reader["ZipPostal"].Equals(DBNull.Value) ? null : ((string)reader["ZipPostal"]));
			dal.ClientIP = (reader["ClientIP"].Equals(DBNull.Value) ? null : ((string)reader["ClientIP"]));
			dal.TransactionDate = (reader["TransactionDate"].Equals(DBNull.Value) ? null : ((DateTime?)reader["TransactionDate"]));
			dal.ErrorMessage = (reader["ErrorMessage"].Equals(DBNull.Value) ? null : ((string)reader["ErrorMessage"]));
			dal.Description = (reader["Description"].Equals(DBNull.Value) ? null : ((string)reader["Description"]));
			dal.Code = (reader["Code"].Equals(DBNull.Value) ? null : ((string)reader["Code"]));
			dal.AccountID = (reader["AccountID"].Equals(DBNull.Value) ? null : ((string)reader["AccountID"]));
			dal.Created = (DateTime)reader["Created"];
			dal.Updated = (DateTime)reader["Updated"];
			dal.PayPalBillingAgreementID = (reader["PayPalBillingAgreementID"].Equals(DBNull.Value) ? null : ((int?)reader["PayPalBillingAgreementID"]));
			dal.CurrencyTypeID = (reader["CurrencyTypeID"].Equals(DBNull.Value) ? null : ((byte?)reader["CurrencyTypeID"]));
		}
		if (dal.ID == 0L)
		{
			return null;
		}
		return dal;
	}

	public static TransactionLogDAL Get(long id)
	{
		if (id == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@ID", id));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_TransactionLogDAL, "TransactionLog_GetTransactionLogByID", queryParameters), BuildDAL);
	}

	public static TransactionLogDAL GetByPaymentID(long paymentId)
	{
		if (paymentId == 0L)
		{
			return null;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@PaymentID", paymentId));
		return EntityHelper.GetEntityDAL(new DbInfo(dbConnectionString_TransactionLogDAL, "TransactionLog_GetTransactionLogByPaymentID", queryParameters), BuildDAL);
	}

	public static ICollection<long> GetIDsByUserAccountID(long userAccountId, DateTime startDate)
	{
		if (startDate == DateTime.MinValue)
		{
			startDate = (DateTime)SqlDateTime.MinValue;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserAccountID", userAccountId));
		queryParameters.Add(new SqlParameter("@StartDate", startDate));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByUserAccountID]", queryParameters));
	}

	public static ICollection<long> GetIDsByEmail(string email, DateTime startDate)
	{
		if (startDate == DateTime.MinValue)
		{
			startDate = (DateTime)SqlDateTime.MinValue;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Email", email));
		queryParameters.Add(new SqlParameter("@StartDate", startDate));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByEmail]", queryParameters));
	}

	public static ICollection<long> GetIDsByMaskedCreditCardNumber(string number, DateTime startDate)
	{
		if (startDate == DateTime.MinValue)
		{
			startDate = (DateTime)SqlDateTime.MinValue;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Number", number));
		queryParameters.Add(new SqlParameter("@StartDate", startDate));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByMaskedCreditCardNumber]", queryParameters));
	}

	public static ICollection<long> FindIDsByMaskedCreditCardNumber(string number, DateTime startDate)
	{
		if (startDate == DateTime.MinValue)
		{
			startDate = (DateTime)SqlDateTime.MinValue;
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Number", number));
		queryParameters.Add(new SqlParameter("@StartDate", startDate));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_FindTransactionLogIDsByMaskedCreditCardNumber]", queryParameters));
	}

	public static ICollection<long> GetIDsByFirstName(string firstName)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@FirstName", firstName));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByFirstName]", queryParameters));
	}

	public static ICollection<long> GetIDsByLastName(string lastName)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@LastName", lastName));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByLastName]", queryParameters));
	}

	public static ICollection<long> GetIDsByFirstNameAndLastName(string firstName, string lastName)
	{
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@FirstName", firstName));
		queryParameters.Add(new SqlParameter("@LastName", lastName));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByFirstNameAndLastName]", queryParameters));
	}

	internal static ICollection<long> GetIDsByEmailAndPaymentStatusTypeID(string email, byte paymentStatusTypeID, int startRowIndex, int maxRows)
	{
		if (string.IsNullOrEmpty(email))
		{
			throw new ApplicationException("Required value not specified: email.");
		}
		if (paymentStatusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: paymentStatusTypeID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Email", email));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", paymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByEmailAndPaymentStatusTypeID_Paged]", queryParameters));
	}

	internal static ICollection<long> GetIDsByAddressCityZipPostalCountryAndPaymentStatusTypeID(string address, string city, string zipPostal, string country, byte paymentStatusTypeID, int startRowIndex, int maxRows)
	{
		if (string.IsNullOrEmpty(address))
		{
			throw new ApplicationException("Required value not specified: address.");
		}
		if (string.IsNullOrEmpty(city))
		{
			throw new ApplicationException("Required value not specified: city.");
		}
		if (string.IsNullOrEmpty(country))
		{
			throw new ApplicationException("Required value not specified: country.");
		}
		if (paymentStatusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: paymentStatusTypeID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Address", address));
		queryParameters.Add(new SqlParameter("@City", city));
		queryParameters.Add(new SqlParameter("@ZipPostal", zipPostal));
		queryParameters.Add(new SqlParameter("@Country", country));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", paymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByAddressCityZipPostalCountryAndPaymentStatusTypeID_Paged]", queryParameters));
	}

	internal static ICollection<long> GetIDsByNumberPaymentStatusTypeIDUserAccountIDAndCreatedBeforeDate(string maskedCreditCardNumber, byte paymentStatusTypeID, long userAccountID, DateTime created, int startRowIndex, int maxRows)
	{
		if (string.IsNullOrEmpty(maskedCreditCardNumber))
		{
			throw new ApplicationException("Required value not specified: maskedCreditCardNumber.");
		}
		if (paymentStatusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: paymentStatusTypeID.");
		}
		if (userAccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: userAccountID.");
		}
		if (created == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: created.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Number", maskedCreditCardNumber));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", paymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@UserAccountID", userAccountID));
		queryParameters.Add(new SqlParameter("@CreatedBefore", created));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByNumberPaymentStatusTypeIDUserAccountIDAndCreatedBeforeDate_Paged]", queryParameters));
	}

	internal static ICollection<long> GetIDsByUserAccountIDAndCreatedAfterDate(long userAccountID, DateTime created, int startRowIndex, int maxRows)
	{
		if (userAccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: userAccountID.");
		}
		if (created == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: created.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserAccountID", userAccountID));
		queryParameters.Add(new SqlParameter("@CreatedAfter", created));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByUserAccountIDAndCreatedAfterDate_Paged]", queryParameters));
	}

	internal static ICollection<long> GetIDsByEmailAndCreatedAfterDate(string email, DateTime created, int startRowIndex, int maxRows)
	{
		if (string.IsNullOrEmpty(email))
		{
			throw new ApplicationException("Required value not specified: email.");
		}
		if (created == default(DateTime))
		{
			throw new ApplicationException("Required value not specified: created.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@Email", email));
		queryParameters.Add(new SqlParameter("@CreatedAfter", created));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByEmailAndCreatedAfterDate_Paged]", queryParameters));
	}

	internal static ICollection<long> GetIDsByUserAccountIDAndPaymentStatusTypeID(long userAccountID, byte paymentStatusTypeID, int startRowIndex, int maxRows)
	{
		if (userAccountID == 0L)
		{
			throw new ApplicationException("Required value not specified: userAccountID.");
		}
		if (paymentStatusTypeID == 0)
		{
			throw new ApplicationException("Required value not specified: paymentStatusTypeID.");
		}
		if (maxRows == 0)
		{
			throw new ApplicationException("Required value not specified: maxRows.");
		}
		List<SqlParameter> queryParameters = new List<SqlParameter>();
		queryParameters.Add(new SqlParameter("@UserAccountID", userAccountID));
		queryParameters.Add(new SqlParameter("@PaymentStatusTypeID", paymentStatusTypeID));
		queryParameters.Add(new SqlParameter("@StartRowIndex", startRowIndex + 1));
		queryParameters.Add(new SqlParameter("@MaximumRows", maxRows));
		return EntityHelper.GetDataEntityIDCollection<long>(new DbInfo(dbConnectionString_TransactionLogDAL, "[dbo].[TransactionLog_GetTransactionLogIDsByUserAccountIDAndPaymentStatusTypeID_Paged]", queryParameters));
	}
}
