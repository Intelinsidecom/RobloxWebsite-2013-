using System;
using Roblox.Billing.Entities;
using Roblox.Billing.Metrics;
using Roblox.Billing.Properties;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

internal class AppleAppStorePaymentProvider : AppStorePaymentProviderBase, IAppleAppStorePaymentProvider
{
	protected override PaymentProviderType _PaymentProviderType => PaymentProviderType.AppleAppStore;

	private bool IsAppleAppStoreLocalPricingEnabled => Settings.Default.IsAppleAppStoreLocalPricingEnabled;

	private string AppleAppStoreLocalPricingSupportedCurrencies => Settings.Default.AppleAppStoreLocalPricingSupportedCurrencies;

	internal AppleAppStorePaymentProvider()
	{
	}

	private AppleAppStorePayment CreateAppleAppStorePayment(Payment payment, AppleAppStoreProofOfPurchase proofOfPurchase)
	{
		return AppleAppStorePayment.CreateNew(payment.ID, proofOfPurchase);
	}

	private bool TryDebounce(string receiptHash, long? transactionIdBigInt, int appleAppStorePaymentStatusTypeId)
	{
		int totalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus = AppleAppStorePayment.GetTotalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus(receiptHash, appleAppStorePaymentStatusTypeId);
		int totalNumberOfPaymentsWithSameTransactionId = 0;
		if (transactionIdBigInt.HasValue)
		{
			totalNumberOfPaymentsWithSameTransactionId = AppleAppStorePayment.GetTotalNumberOfAppleAppStorePaymentsByTransactionIdBigIntAndStatus(transactionIdBigInt.Value, appleAppStorePaymentStatusTypeId);
		}
		if (totalNumberOfAppleAppStorePaymentsByReceiptHashAndStatus <= 0)
		{
			return totalNumberOfPaymentsWithSameTransactionId > 0;
		}
		return true;
	}

	public void Process(IPurchaser purchaser, string receipt, byte platformTypeId, bool isRetry, CancelExistingActiveMembershipSaleHandler findFirstMembershipSaleAndCancelAction, Action<string, int> checkoutSessionLogger, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IEmailSender emailSender, IUserFactory userFactory, IAppleAppStoreVerificationClient verificationClient = null, IBillingStatisticsTracker billingStatisticsTracker = null, ILogger logger = null)
	{
		AppleAppStoreProofOfPurchase proofOfPurchase = null;
		if (verificationClient == null)
		{
			verificationClient = new AppleAppStoreVerificationClient(emailSender, userFactory);
		}
		Func<IPurchase> verifyAndGetPurchase = delegate
		{
			proofOfPurchase = new AppleAppStoreProofOfPurchase(receipt, purchaser.Id);
			return verificationClient.Verify(proofOfPurchase, checkoutSessionLogger);
		};
		Func<bool> isPurchaseDuplicate = delegate
		{
			string receiptHash = HashFunctions.ComputeHashString(receipt.GetBytes());
			long? transactionIdBigInt = null;
			if (Settings.Default.DebounceApplePurchasesByTransactionId && !string.IsNullOrEmpty(proofOfPurchase?.TransactionId))
			{
				transactionIdBigInt = Convert.ToInt64(proofOfPurchase.TransactionId);
			}
			bool num = TryDebounce(receiptHash, transactionIdBigInt, proofOfPurchase.Status);
			if (num)
			{
				string arg = $"The purchase was marked as a duplicate. Receipt: {receipt} - ProductId: {proofOfPurchase.ProductId}" + $"- PoP AppItemId: {proofOfPurchase.AppItemId} - PoP ItemId: {proofOfPurchase.ItemId} " + $"- Pop PurchaseDate: {proofOfPurchase.PurchaseDate} - AccountId: {proofOfPurchase.AccountId}";
				checkoutSessionLogger(arg, 2);
			}
			return num;
		};
		Action<Payment> logPaymentForPaymentProvider = delegate(Payment payment)
		{
			CreateAppleAppStorePayment(payment, proofOfPurchase);
		};
		Func<IPurchase, CountryCurrency> getCountryCurrency = delegate(IPurchase purchase)
		{
			CountryCurrency countryCurrencyForPurchaser = GetCountryCurrencyForPurchaser(purchaser.Id, IsAppleAppStoreLocalPricingEnabled, AppleAppStoreLocalPricingSupportedCurrencies);
			return (!IsLocalizedPurchase(purchase, _PaymentProviderType, countryCurrencyForPurchaser)) ? null : countryCurrencyForPurchaser;
		};
		Process(purchaser, platformTypeId, isRetry, verifyAndGetPurchase, isPurchaseDuplicate, checkoutSessionLogger, logPaymentForPaymentProvider, findFirstMembershipSaleAndCancelAction, saleLogger, paymentLogger, billingStatisticsTracker, null, logger, getCountryCurrency);
	}
}
