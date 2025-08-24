using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Billing.Properties;
using Roblox.EventLog;
using Roblox.Users;

namespace Roblox.Billing;

internal class WindowsStorePaymentProvider : AppStorePaymentProviderBase, IWindowsStorePaymentProvider
{
	private readonly IWindowsStorePaymentDataAccessor _WindowsStorePaymentDataAccessor;

	protected override PaymentProviderType _PaymentProviderType => PaymentProviderType.WindowsStore;

	public WindowsStorePaymentProvider()
		: this(new WindowsStorePaymentDataAccessor())
	{
	}

	internal WindowsStorePaymentProvider(IWindowsStorePaymentDataAccessor dataAccessor)
	{
		_WindowsStorePaymentDataAccessor = dataAccessor;
	}

	public void SubmitTransaction(IPurchaser purchaser, IEnumerable<Guid> transactionIds, string receipt, byte platformTypeId, bool isRetry, CancelExistingActiveMembershipSaleHandler findFirstMembershipSaleAndCancelAction, IWindowsStoreVerificationClient receiptVerifier, ILogger logger = null)
	{
		if (purchaser == null)
		{
			throw new ArgumentNullException("purchaser");
		}
		if (receiptVerifier == null)
		{
			throw new ArgumentNullException("receiptVerifier");
		}
		List<Guid> transactionIdsList = transactionIds.ToList();
		if (transactionIdsList.Count > Settings.Default.WindowsStoreNumberOfTransactionIdsToProcessLimit)
		{
			throw new ArgumentException("Too many transaction IDs. Slow down!");
		}
		foreach (WindowsStorePayment windowsStorePayment in receiptVerifier.VerifyReceiptAuthenticity(purchaser, receipt, transactionIdsList))
		{
			Func<IPurchase> verifyAndRetrievePurchase = delegate
			{
				IProduct product = WindowsStoreProductFactory.Singleton.GetProduct(windowsStorePayment.ProductId);
				CountryCurrency byCountryTypeIDAndCurrencyTypeID = CountryCurrency.GetByCountryTypeIDAndCurrencyTypeID(Country.GetUSACountry().ID, CurrencyType.GetUSDCurrencyTypeID);
				return PurchaseFactory.Singleton.GetPurchase(product, _PaymentProviderType, byCountryTypeIDAndCurrencyTypeID);
			};
			Func<bool> isDuplicatePurchase = () => _WindowsStorePaymentDataAccessor.GetByTransactionId(windowsStorePayment.TransactionId) != null;
			Action<Payment> createPaymentForPaymentProvider = delegate(Payment payment)
			{
				windowsStorePayment.PaymentId = payment.ID;
				_WindowsStorePaymentDataAccessor.CreateNew(windowsStorePayment.PaymentId, windowsStorePayment.TransactionId, windowsStorePayment.PurchaseDate, windowsStorePayment.Receipt);
			};
			Action<string, int> checkoutLoggerNoOperation = delegate
			{
			};
			AuditLogDelegates.SaleAuditLogFunc saleLoggerNoOperation = delegate
			{
			};
			AuditLogDelegates.PaymentAuditLogFunc paymentLoggerNoOperation = delegate
			{
			};
			Process(purchaser, platformTypeId, isRetry: false, verifyAndRetrievePurchase, isDuplicatePurchase, checkoutLoggerNoOperation, createPaymentForPaymentProvider, findFirstMembershipSaleAndCancelAction, saleLoggerNoOperation, paymentLoggerNoOperation, null, null, logger);
		}
	}
}
