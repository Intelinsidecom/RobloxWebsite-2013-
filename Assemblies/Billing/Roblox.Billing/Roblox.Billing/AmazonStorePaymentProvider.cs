using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing.Metrics;
using Roblox.Billing.Properties;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

/// <summary>
/// Represents an Amazon payment provider.
/// </summary>
internal class AmazonStorePaymentProvider : AppStorePaymentProviderBase, IAmazonStorePaymentProvider
{
	/// <summary>
	/// Gets the type of the provider.
	/// </summary>
	protected override PaymentProviderType _PaymentProviderType => PaymentProviderType.AmazonStore;

	private bool IsAmazonStoreLocalPricingEnabled => Settings.Default.IsAmazonStoreLocalPricingEnabled;

	private string AmazonStoreLocalPricingSupportedCurrencies => Settings.Default.AmazonStoreLocalPricingSupportedCurrencies;

	/// <summary>
	/// Processes a payment using the given information.
	/// </summary>
	/// <param name="purchaser">The purchaser that's purchasing the product.</param>
	/// <param name="receiptId">The ID of the Amazon receipt.</param>
	/// <param name="amazonUserId">The ID of the Amazon user performing the purchase.</param>
	/// <param name="platformTypeId">The ID of the platform type that the user is performing the purchase from.</param>
	/// <param name="isRetry">Whether or not the purchase is a retry.</param>
	/// <param name="findFirstMembershipSaleAndCancelAction">Action searches for the first membership RecurringSale, and then cancels the recurring sale.</param>
	/// <param name="checkoutSessionLogger">A delegate that allows logging in AuditLog tables for checkout sessions.</param>
	/// <param name="saleLogger">A delegate that allows logging in AuditLog tables for sales.</param>
	/// <param name="paymentLogger">A delegate that allows logging in AuditLog tables for payments.</param>
	/// <param name="emailSender">The <see cref="T:Roblox.Platform.Email.Delivery.IEmailSender" />.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="verificationClient">client to verify the purchase.</param>
	/// <param name="billingStatisticsTracker">The <see cref="T:Roblox.Billing.Metrics.IBillingStatisticsTracker" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	public void Process(IPurchaser purchaser, string receiptId, string amazonUserId, byte platformTypeId, bool isRetry, CancelExistingActiveMembershipSaleHandler findFirstMembershipSaleAndCancelAction, Action<string, int> checkoutSessionLogger, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IEmailSender emailSender, IUserFactory userFactory, IAmazonStoreVerificationClient verificationClient = null, IBillingStatisticsTracker billingStatisticsTracker = null, ILogger logger = null)
	{
		AmazonStoreProofOfPurchase proofOfPurchase = null;
		bool isPurchaseSuccessful = false;
		if (verificationClient == null)
		{
			verificationClient = new AmazonStoreVerificationClient(emailSender, userFactory);
		}
		Func<IPurchase> verifyAndGetPurchase = delegate
		{
			proofOfPurchase = new AmazonStoreProofOfPurchase(purchaser.Id, receiptId, amazonUserId);
			IPurchase result = verificationClient.Verify(proofOfPurchase);
			isPurchaseSuccessful = true;
			checkoutSessionLogger($"Successfully verified the Amazon receipt {receiptId}.", 1);
			return result;
		};
		Func<bool> isPurchaseDuplicate = delegate
		{
			string receiptHash = HashFunctions.ComputeHashString(receiptId.GetBytes());
			bool flag = TryDebounce(receiptHash, isPurchaseSuccessful);
			checkoutSessionLogger($"The purchase was marked as duplicate {flag} - AccountId: {purchaser.Id} - Receipt: {receiptId} - AmazonUserId: {amazonUserId}", 2);
			return flag;
		};
		Action<Payment> logPaymentForPaymentProvider = delegate(Payment payment)
		{
			CreateAmazonStorePayment(payment, proofOfPurchase);
			checkoutSessionLogger($"Successfully created AmazonStorePayment for receipt {receiptId}", 1);
		};
		Func<IPurchase, CountryCurrency> getCountryCurrency = delegate(IPurchase purchase)
		{
			CountryCurrency countryCurrencyForPurchaser = GetCountryCurrencyForPurchaser(purchaser.Id, IsAmazonStoreLocalPricingEnabled, AmazonStoreLocalPricingSupportedCurrencies);
			return (!IsLocalizedPurchase(purchase, _PaymentProviderType, countryCurrencyForPurchaser)) ? null : countryCurrencyForPurchaser;
		};
		if (Settings.Default.AmazonStorePurchaseProcessWithLeaseLockEnabled)
		{
			string leaseLockKey = $"AmazonStoreReceipt_{receiptId}";
			double leaseDurationInMillisecond = Settings.Default.AmazonStorePurchaseLeaseLockDuration.TotalMilliseconds;
			ProcessInLeasedLock(purchaser, platformTypeId, isRetry, verifyAndGetPurchase, isPurchaseDuplicate, logPaymentForPaymentProvider, findFirstMembershipSaleAndCancelAction, saleLogger, paymentLogger, checkoutSessionLogger, leaseLockKey, (int)leaseDurationInMillisecond, null, userFactory, logger, getCountryCurrency);
		}
		else
		{
			Process(purchaser, platformTypeId, isRetry, verifyAndGetPurchase, isPurchaseDuplicate, checkoutSessionLogger, logPaymentForPaymentProvider, findFirstMembershipSaleAndCancelAction, saleLogger, paymentLogger, billingStatisticsTracker, null, logger, getCountryCurrency);
		}
	}

	/// <summary>
	/// Determines whether the given Amazon receipt hash has already been logged.
	/// </summary>
	/// <param name="receiptHash">The Amazon receipt hash.</param>
	/// <param name="isPurchaseSuccessful">Whether or not the current purchase was successful.</param>
	/// <returns>Whether or not the given Amazon receipt hash has already been logged.</returns>
	private bool TryDebounce(string receiptHash, bool isPurchaseSuccessful)
	{
		int totalNumberOfPayments = AmazonStorePayment.GetTotalNumberOfAmazonStorePaymentsByAmazonReceiptIdHash(receiptHash);
		if (totalNumberOfPayments == 0)
		{
			return false;
		}
		List<AmazonStorePayment> receiptMatches = (from hashMatch in AmazonStorePayment.GetAmazonStorePaymentsByAmazonReceiptIdHash_Paged(receiptHash, 0, totalNumberOfPayments)
			where hashMatch.AmazonReceiptIDHash == receiptHash
			select hashMatch).ToList();
		if (receiptMatches.Count != 0)
		{
			return receiptMatches.Select((AmazonStorePayment receiptMatch) => Payment.Get(receiptMatch.PaymentID)).Any((Payment payment) => HasDuplicateStatusRecord(isPurchaseSuccessful, payment.PaymentStatusTypeID));
		}
		return false;
	}

	/// <summary>
	/// Creates and logs an Amazon store payment.
	/// </summary>
	/// <param name="payment">The payment to log.</param>
	/// <param name="proofOfPurchase">The proof of the Amazon purchase.</param>
	private void CreateAmazonStorePayment(Payment payment, AmazonStoreProofOfPurchase proofOfPurchase)
	{
		AmazonStorePayment amazonStorePayment = new AmazonStorePayment();
		amazonStorePayment.AmazonProductID = proofOfPurchase.AmazonProductId;
		amazonStorePayment.AmazonReceiptID = proofOfPurchase.AmazonReceiptId;
		amazonStorePayment.AmazonReceiptIDHash = HashFunctions.ComputeHashString(proofOfPurchase.AmazonReceiptId.GetBytes());
		amazonStorePayment.AmazonUserID = proofOfPurchase.AmazonUserId;
		amazonStorePayment.CancelDate = proofOfPurchase.CancelDate;
		amazonStorePayment.PaymentID = payment.ID;
		amazonStorePayment.ProductType = proofOfPurchase.ProductType;
		amazonStorePayment.PurchaseDate = proofOfPurchase.PurchaseDate;
		amazonStorePayment.Save();
	}
}
