using System;
using Roblox.Billing.Entities;
using Roblox.Billing.Metrics;
using Roblox.Billing.Properties;
using Roblox.EventLog;
using Roblox.GoogleAPI.Interfaces;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

internal class GooglePlayStorePaymentProvider : AppStorePaymentProviderBase, IGooglePlayStorePaymentProvider
{
	protected override PaymentProviderType _PaymentProviderType => PaymentProviderType.GooglePlayStore;

	private bool IsGooglePlayStoreLocalPricingEnabled => Settings.Default.IsGooglePlayStoreLocalPricingEnabled;

	private string GooglePlayStoreLocalPricingSupportedCurrencies => Settings.Default.GooglePlayStoreLocalPricingSupportedCurrencies;

	public static bool IsDuplicatePurchase(GooglePlayStoreProofOfPurchase proofOfPurchase)
	{
		string tokenHash = GooglePlayStorePayment.GetTokenHash(proofOfPurchase.Token);
		string packageName = proofOfPurchase.PackageName;
		string appProductId = proofOfPurchase.PlayStoreProductId;
		int? purchaseState = null;
		if (proofOfPurchase.Response != null)
		{
			purchaseState = proofOfPurchase.Response.PurchaseState;
		}
		return GooglePlayStorePayment.GetTotalNumberOfGooglePlayStorePayments(packageName, appProductId, tokenHash, purchaseState) >= 1;
	}

	public void CreateGooglePlayStorePayment(Payment payment, GooglePlayStoreProofOfPurchase proofOfPurchase, string orderId)
	{
		GooglePlayStorePayment gpsp = new GooglePlayStorePayment
		{
			OrderID = orderId,
			PaymentID = payment.ID,
			PackageName = proofOfPurchase.PackageName,
			AppProductID = proofOfPurchase.PlayStoreProductId,
			TokenHash = GooglePlayStorePayment.GetTokenHash(proofOfPurchase.Token),
			Token = proofOfPurchase.Token
		};
		if (proofOfPurchase.Response != null)
		{
			gpsp.ConsumptionState = proofOfPurchase.Response.ConsumptionState;
			gpsp.DeveloperPayload = proofOfPurchase.Response.DeveloperPayload;
			gpsp.PurchaseState = proofOfPurchase.Response.PurchaseState;
			gpsp.PurchaseTime = proofOfPurchase.Response.PurchaseTime;
		}
		gpsp.Save();
	}

	public void Process(IPurchaser purchaser, string packageName, string orderId, string productId, string token, byte platformTypeId, bool isRetry, IAndroidPublisher googleClient, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSaleAction, Action<string, int> checkoutSessionLogger, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IUserFactory userFactory, IGooglePlayStoreVerificationClient verificationClient = null, IBillingStatisticsTracker billingStatisticsTracker = null, ILogger logger = null)
	{
		GooglePlayStoreProofOfPurchase proofOfPurchase = null;
		if (verificationClient == null)
		{
			verificationClient = new GooglePlayStoreVerificationClient(googleClient, userFactory);
		}
		Func<IPurchase> verifyAndGetPurchase = delegate
		{
			proofOfPurchase = new GooglePlayStoreProofOfPurchase(packageName, productId, token);
			return verificationClient.Verify(proofOfPurchase, checkoutSessionLogger, purchaser);
		};
		Func<bool> isPurchaseDuplicate = delegate
		{
			bool num = IsDuplicatePurchase(proofOfPurchase);
			if (num)
			{
				string arg = $"The purchase was marked as a duplicate. OrderId: {orderId} - ProductId: {productId} " + $"- PoP Token: {proofOfPurchase.Token} - PoP AppProductId: {proofOfPurchase.PlayStoreProductId} " + $"- PoP ConsumptionState: {proofOfPurchase.Response?.ConsumptionState} - PoP DeveloperPayload: {proofOfPurchase.Response?.DeveloperPayload} " + $"- PoP PurchaseState: {proofOfPurchase.Response?.PurchaseState} - PoP PurchaseTime: {proofOfPurchase.Response?.PurchaseTime}";
				checkoutSessionLogger(arg, 2);
			}
			return num;
		};
		Action<Payment> logPaymentForPaymentProvider = delegate(Payment payment)
		{
			CreateGooglePlayStorePayment(payment, proofOfPurchase, orderId);
		};
		Func<IPurchase, CountryCurrency> getCountryCurrency = delegate(IPurchase purchase)
		{
			CountryCurrency countryCurrencyForPurchaser = GetCountryCurrencyForPurchaser(purchaser.Id, IsGooglePlayStoreLocalPricingEnabled, GooglePlayStoreLocalPricingSupportedCurrencies);
			return (!IsLocalizedPurchase(purchase, _PaymentProviderType, countryCurrencyForPurchaser)) ? null : countryCurrencyForPurchaser;
		};
		string leaseLockKey = $"Google_PlayStore_Process_{token}";
		double leaseLockDurationInMillisecond = Settings.Default.GooglePlayStorePaymentProviderLeaseLockTimeSpan.TotalMilliseconds;
		ProcessInLeasedLock(purchaser, platformTypeId, isRetry, verifyAndGetPurchase, isPurchaseDuplicate, logPaymentForPaymentProvider, cancelExistingActiveMembershipSaleAction, saleLogger, paymentLogger, checkoutSessionLogger, leaseLockKey, (int)leaseLockDurationInMillisecond, billingStatisticsTracker, userFactory, logger, getCountryCurrency);
	}
}
