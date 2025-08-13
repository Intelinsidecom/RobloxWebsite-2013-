using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.Caching;
using Roblox.Caching.Interfaces;
using Roblox.Common;
using Roblox.Data.Interfaces;

namespace Roblox.Billing;

public class TransactionLog : IRobloxEntity<long, TransactionLogDAL>, ICacheableObject<long>, ICacheableObject, ITransactionLog
{
	private TransactionLogDAL _EntityDAL;

	public static CacheInfo EntityCacheInfo = new CacheInfo(new CacheabilitySettings(collectionsAreCacheable: true, countsAreCacheable: true, entityIsCacheable: true, idLookupsAreCacheable: true), "Roblox.Billing.TransactionLog", isNullCacheable: true);

	public long ID => _EntityDAL.ID;

	public int SaleID
	{
		get
		{
			return _EntityDAL.SaleID;
		}
		set
		{
			_EntityDAL.SaleID = value;
		}
	}

	public long PaymentID
	{
		get
		{
			return _EntityDAL.PaymentID;
		}
		set
		{
			_EntityDAL.PaymentID = value;
		}
	}

	public byte PaymentStatusTypeID
	{
		get
		{
			return _EntityDAL.PaymentStatusTypeID;
		}
		set
		{
			_EntityDAL.PaymentStatusTypeID = value;
		}
	}

	public long? UserAccountID
	{
		get
		{
			return _EntityDAL.UserAccountID;
		}
		set
		{
			_EntityDAL.UserAccountID = value;
		}
	}

	public string TransactionID
	{
		get
		{
			return _EntityDAL.TransactionID;
		}
		set
		{
			_EntityDAL.TransactionID = value;
		}
	}

	public string TransactionType
	{
		get
		{
			return _EntityDAL.TransactionType;
		}
		set
		{
			_EntityDAL.TransactionType = value;
		}
	}

	public string AuthCode
	{
		get
		{
			return _EntityDAL.AuthCode;
		}
		set
		{
			_EntityDAL.AuthCode = value;
		}
	}

	public string AvsCode
	{
		get
		{
			return _EntityDAL.AvsCode;
		}
		set
		{
			_EntityDAL.AvsCode = value;
		}
	}

	public string Number
	{
		get
		{
			return _EntityDAL.Number;
		}
		set
		{
			_EntityDAL.Number = value;
		}
	}

	public decimal? Amount
	{
		get
		{
			return _EntityDAL.Amount;
		}
		set
		{
			_EntityDAL.Amount = value;
		}
	}

	public int? Year
	{
		get
		{
			return _EntityDAL.Year;
		}
		set
		{
			_EntityDAL.Year = value;
		}
	}

	public int? Month
	{
		get
		{
			return _EntityDAL.Month;
		}
		set
		{
			_EntityDAL.Month = value;
		}
	}

	public string Address
	{
		get
		{
			return _EntityDAL.Address;
		}
		set
		{
			_EntityDAL.Address = value;
		}
	}

	public string Address2
	{
		get
		{
			return _EntityDAL.Address2;
		}
		set
		{
			_EntityDAL.Address2 = value;
		}
	}

	public string City
	{
		get
		{
			return _EntityDAL.City;
		}
		set
		{
			_EntityDAL.City = value;
		}
	}

	public string Country
	{
		get
		{
			return _EntityDAL.Country;
		}
		set
		{
			_EntityDAL.Country = value;
		}
	}

	public string Email
	{
		get
		{
			return _EntityDAL.Email;
		}
		set
		{
			_EntityDAL.Email = value;
		}
	}

	public string FirstName
	{
		get
		{
			return _EntityDAL.FirstName;
		}
		set
		{
			_EntityDAL.FirstName = value;
		}
	}

	public string LastName
	{
		get
		{
			return _EntityDAL.LastName;
		}
		set
		{
			_EntityDAL.LastName = value;
		}
	}

	public string Phone
	{
		get
		{
			return _EntityDAL.Phone;
		}
		set
		{
			_EntityDAL.Phone = value;
		}
	}

	public string StateProvince
	{
		get
		{
			return _EntityDAL.StateProvince;
		}
		set
		{
			_EntityDAL.StateProvince = value;
		}
	}

	public string ZipPostal
	{
		get
		{
			return _EntityDAL.ZipPostal;
		}
		set
		{
			_EntityDAL.ZipPostal = value;
		}
	}

	public string ClientIP
	{
		get
		{
			return _EntityDAL.ClientIP;
		}
		set
		{
			_EntityDAL.ClientIP = value;
		}
	}

	public DateTime? TransactionDate
	{
		get
		{
			return _EntityDAL.TransactionDate;
		}
		set
		{
			_EntityDAL.TransactionDate = value;
		}
	}

	public string ErrorMessage
	{
		get
		{
			return _EntityDAL.ErrorMessage;
		}
		set
		{
			_EntityDAL.ErrorMessage = value;
		}
	}

	public string Description
	{
		get
		{
			return _EntityDAL.Description;
		}
		set
		{
			_EntityDAL.Description = value;
		}
	}

	public string Code
	{
		get
		{
			return _EntityDAL.Code;
		}
		set
		{
			_EntityDAL.Code = value;
		}
	}

	public string AccountID
	{
		get
		{
			return _EntityDAL.AccountID;
		}
		set
		{
			_EntityDAL.AccountID = value;
		}
	}

	public DateTime Created
	{
		get
		{
			return _EntityDAL.Created;
		}
		set
		{
			_EntityDAL.Created = value;
		}
	}

	public DateTime Updated
	{
		get
		{
			return _EntityDAL.Updated;
		}
		set
		{
			_EntityDAL.Updated = value;
		}
	}

	public int? PayPalBillingAgreementID
	{
		get
		{
			return _EntityDAL.PayPalBillingAgreementID;
		}
		set
		{
			_EntityDAL.PayPalBillingAgreementID = value;
		}
	}

	public byte? CurrencyTypeID
	{
		get
		{
			return _EntityDAL.CurrencyTypeID;
		}
		set
		{
			_EntityDAL.CurrencyTypeID = value;
		}
	}

	public CacheInfo CacheInfo => EntityCacheInfo;

	public TransactionLog()
	{
		_EntityDAL = new TransactionLogDAL();
	}

	public void Save()
	{
		EntityHelper.SaveEntity(this, delegate
		{
			_EntityDAL.Created = DateTime.Now;
			_EntityDAL.Updated = Created;
			_EntityDAL.Insert();
		}, delegate
		{
			_EntityDAL.Updated = DateTime.Now;
			_EntityDAL.Update();
		});
	}

	public void Delete()
	{
		EntityHelper.DeleteEntity(this, _EntityDAL.Delete);
	}

	public static TransactionLog CreateNew(long paymentid, long? userAccountID, string transactionid, string transactiontype, string authcode, string avscode, int saleId, string number, decimal? amount, int? year, int? month, string address, string address2, string city, string country, string email, string firstname, string lastname, string phone, string stateprovince, string zippostal, string clientip, DateTime? transactiondate, byte paymentstatustypeid, string errormessage, string description, string code, string accountid, int? paypalbillingagreementid, byte? currencyTypeID = null)
	{
		if (!currencyTypeID.HasValue)
		{
			currencyTypeID = CurrencyType.GetUSDCurrencyTypeID;
		}
		TransactionLog transactionLog = new TransactionLog();
		transactionLog.PaymentID = paymentid;
		transactionLog.UserAccountID = userAccountID;
		transactionLog.TransactionID = transactionid;
		transactionLog.TransactionType = transactiontype;
		transactionLog.AuthCode = authcode;
		transactionLog.AvsCode = avscode;
		transactionLog.SaleID = saleId;
		transactionLog.Number = number;
		transactionLog.Amount = amount;
		transactionLog.Year = year;
		transactionLog.Month = month;
		transactionLog.Address = address;
		transactionLog.Address2 = address2;
		transactionLog.City = city;
		transactionLog.Country = country;
		transactionLog.Email = email;
		transactionLog.FirstName = firstname;
		transactionLog.LastName = lastname;
		transactionLog.Phone = phone;
		transactionLog.StateProvince = stateprovince;
		transactionLog.ZipPostal = zippostal;
		transactionLog.ClientIP = clientip;
		transactionLog.TransactionDate = transactiondate;
		transactionLog.PaymentStatusTypeID = paymentstatustypeid;
		transactionLog.ErrorMessage = errormessage;
		transactionLog.Description = description;
		transactionLog.Code = code;
		transactionLog.AccountID = accountid;
		transactionLog.PayPalBillingAgreementID = paypalbillingagreementid;
		transactionLog.CurrencyTypeID = currencyTypeID;
		transactionLog.Save();
		return transactionLog;
	}

	public static TransactionLog Get(long id)
	{
		return EntityHelper.GetEntity<long, TransactionLogDAL, TransactionLog>(EntityCacheInfo, id, () => TransactionLogDAL.Get(id));
	}

	public static TransactionLog GetByPaymentID(long paymentId)
	{
		return EntityHelper.GetEntityByLookup<long, TransactionLogDAL, TransactionLog>(EntityCacheInfo, $"PaymentID:{paymentId}", () => TransactionLogDAL.GetByPaymentID(paymentId));
	}

	public static ICollection<TransactionLog> GetTransactionLogsByUserAccountID(long userAccountId, DateTime startDate)
	{
		return TransactionLogDAL.GetIDsByUserAccountID(userAccountId, startDate).Select(Get).ToList();
	}

	public static ICollection<TransactionLog> GetTransactionLogsByUserAccountID(long userAccountId)
	{
		string collectionId = $"GetTrasactionLogsByUserAccountID_AccountID:{userAccountId}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserAccountID:{userAccountId}"), collectionId, () => TransactionLogDAL.GetIDsByUserAccountID(userAccountId, DateTime.MinValue), Get);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByMaskedCreditCardNumber(string number, DateTime startDate)
	{
		return TransactionLogDAL.GetIDsByMaskedCreditCardNumber(number, startDate).Select(Get).ToList();
	}

	public static ICollection<TransactionLog> GetTransactionLogsByMaskedCreditCardNumber(string number)
	{
		string collectionId = $"GetTransactionLogsByMaskedCreditCardNumber_Number:{number}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"MaskedCreditCardNumber:{number}"), collectionId, () => TransactionLogDAL.GetIDsByMaskedCreditCardNumber(number, DateTime.MinValue), Get);
	}

	public static ICollection<TransactionLog> FindTransactionLogsByWildcardCreditCardNumber(string number)
	{
		if (string.IsNullOrEmpty(number) || number.Length != 4)
		{
			throw new ApplicationException("Masked CC Number must be 4 digits in length!");
		}
		string collectionId = $"FindTransactionLogsByMaskedCreditCardNumber_Number:{number}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"WildcardSearchCreditCardNumber:{number}"), collectionId, () => TransactionLogDAL.FindIDsByMaskedCreditCardNumber(number, DateTime.MinValue), Get);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByEmail(string email, DateTime startDate)
	{
		return TransactionLogDAL.GetIDsByEmail(email, startDate).Select(Get).ToList();
	}

	public static ICollection<TransactionLog> GetTransactionLogsByEmail(string email)
	{
		string collectionId = $"GetTransactionLogsByEmail_Email:{email}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"Email:{email}"), collectionId, () => TransactionLogDAL.GetIDsByEmail(email, DateTime.MinValue), Get);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByFirstName(string firstName)
	{
		if (!Settings.Default.TransactionLogCachingEnabled)
		{
			return TransactionLogDAL.GetIDsByFirstName(firstName).Select(Get).ToList();
		}
		string collectionId = $"GetTransactionLogsByFirstName_FirstName:{firstName}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"FirstName:{firstName}"), collectionId, () => TransactionLogDAL.GetIDsByFirstName(firstName), Get);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByLastName(string lastName)
	{
		if (!Settings.Default.TransactionLogCachingEnabled)
		{
			return TransactionLogDAL.GetIDsByLastName(lastName).Select(Get).ToList();
		}
		string collectionId = $"GetTransactionLogsByLastName_LastName:{lastName}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"LastName:{lastName}"), collectionId, () => TransactionLogDAL.GetIDsByLastName(lastName), Get);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByFirstNameAndLastName(string firstName, string lastName)
	{
		string collectionId = $"GetTransactionLogsByFirstNameAndLastName_FirstName:{firstName}_LastName:{lastName}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"FirstName:{firstName}LastName:{lastName}"), collectionId, () => TransactionLogDAL.GetIDsByFirstNameAndLastName(firstName, lastName), Get);
	}

	public static int GetCountByEmailAndPaymentStatusTypeID(string email, byte paymentStatusTypeID)
	{
		int startRowIndex = 0;
		int maxRows = 2147483646;
		string countID = $"GetCountByEmailAndPaymentStatusTypeID_Email:{email}_PaymentStatusTypeID:{paymentStatusTypeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"Email:{email}_PaymentStatusTypeID:{paymentStatusTypeID}"), countID, () => TransactionLogDAL.GetIDsByEmailAndPaymentStatusTypeID(email, paymentStatusTypeID, startRowIndex, maxRows).Count);
	}

	public static int GetCountByAddressCityZipPostalCountryAndPaymentStatusTypeID(string address, string city, string zipPostal, string country, byte paymentStatusTypeID)
	{
		int startRowIndex = 0;
		int maxRows = 2147483646;
		string countID = $"GetCountByAddressCityZipPostalCountryAndPaymentStatusTypeID_Address:{address}_City:{city}_ZipPostal:{zipPostal}_Country:{country}_PaymentStatusTypeID:{paymentStatusTypeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"Address:{address}_City:{city}_ZipPostal:{zipPostal}_Country:{country}_PaymentStatusTypeID:{paymentStatusTypeID}"), countID, () => TransactionLogDAL.GetIDsByAddressCityZipPostalCountryAndPaymentStatusTypeID(address, city, zipPostal, country, paymentStatusTypeID, startRowIndex, maxRows).Count);
	}

	public static int GetCountByNumberPaymentStatusTypeIDUserAccountIDAndCreatedBeforeDate(string maskedCreditCardNumber, byte paymentStatusTypeID, long userAccountID, DateTime createdBefore)
	{
		int startRowIndex = 0;
		int maxRows = 2147483646;
		string countID = $"GetCountByNumberPaymentStatusTypeIDUserAccountIDAndCreatedBeforeDate_Number:{maskedCreditCardNumber}_PaymentStatusTypeID:{paymentStatusTypeID}_UserAccountID:{userAccountID}_CreatedBefore:{createdBefore}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"Number:{maskedCreditCardNumber}_PaymentStatusTypeID:{paymentStatusTypeID}_UserAccountID:{userAccountID}_CreatedBefore:{createdBefore}"), countID, () => TransactionLogDAL.GetIDsByNumberPaymentStatusTypeIDUserAccountIDAndCreatedBeforeDate(maskedCreditCardNumber, paymentStatusTypeID, userAccountID, createdBefore, startRowIndex, maxRows).Count);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByUserAccountIDAndCreatedAfterDate(long userAccountID, DateTime createdAfter)
	{
		int startRowIndex = 0;
		int maxRows = 2147483646;
		string collectionID = $"GetTransactionlogsByUserAccountIDAndCreatedAfterDate_UserAccountID:{userAccountID}_CreatedAfter:{createdAfter}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserAccountID:{userAccountID}_CreatedAfter:{createdAfter}"), collectionID, () => TransactionLogDAL.GetIDsByUserAccountIDAndCreatedAfterDate(userAccountID, createdAfter, startRowIndex, maxRows), Get);
	}

	public static ICollection<TransactionLog> GetTransactionLogsByEmailAndCreatedAfterDate(string email, DateTime createdAfter)
	{
		int startRowIndex = 0;
		int maxRows = 2147483646;
		string collectionID = $"GetTransactionLogsByEmailAndCreatedAfterDate_Email:{email}_CreatedAfter:{createdAfter}";
		return EntityHelper.GetEntityCollection(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"Email:{email}_CreatedAfter:{createdAfter}"), collectionID, () => TransactionLogDAL.GetIDsByEmailAndCreatedAfterDate(email, createdAfter, startRowIndex, maxRows), Get);
	}

	public static int GetCountByUserAccountIDAndPaymentStatusTypeID(long userAccountID, byte paymentStatusTypeID)
	{
		int startRowIndex = 0;
		int maxRows = 2147483646;
		string countID = $"GetCountByUserAccountIDAndPaymentStatusTypeID_UserAccountID:{userAccountID}_PaymentStatusTypeID:{paymentStatusTypeID}";
		return EntityHelper.GetEntityCount(EntityCacheInfo, new CacheManager.CachePolicy(CacheManager.CacheScopeFilter.Qualified, $"UserAccountID:{userAccountID}_PaymentStatusTypeID:{paymentStatusTypeID}"), countID, () => TransactionLogDAL.GetIDsByUserAccountIDAndPaymentStatusTypeID(userAccountID, paymentStatusTypeID, startRowIndex, maxRows).Count);
	}

	public void Construct(TransactionLogDAL dal)
	{
		_EntityDAL = dal;
	}

	public IEnumerable<string> BuildEntityIDLookups()
	{
		if (_EntityDAL != null && PaymentID != 0L)
		{
			yield return $"PaymentID:{PaymentID}";
		}
	}

	public IEnumerable<StateToken> BuildStateTokenCollection()
	{
		if (Settings.Default.TransactionLogCachingEnabled)
		{
			yield return new StateToken($"UserAccountID:{UserAccountID}");
			yield return new StateToken($"MaskedCreditCardNumber:{Number}");
			if (!string.IsNullOrEmpty(Number) && Number.Length >= 4)
			{
				yield return new StateToken($"WildcardSearchCreditCardNumber:{Number.Substring(Number.Length - 4)}");
			}
			yield return new StateToken($"Email:{Email}");
			yield return new StateToken($"FirstName:{FirstName}");
			yield return new StateToken($"LastName:{LastName}");
			yield return new StateToken($"FirstName:{FirstName}LastName:{LastName}");
		}
	}
}
