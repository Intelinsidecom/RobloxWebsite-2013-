using System;
using Roblox.Billing.Metrics;
using Roblox.EventLog;
using Roblox.GoogleAPI.Interfaces;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

public interface IGooglePlayStorePaymentProvider
{
	/// <summary>
	/// Process a Google Play Store Transaction.
	/// </summary>
	/// <param name="purchaser">The <see cref="T:Roblox.Billing.IPurchaser" />.</param>
	/// <param name="packageName">The package name.</param>
	/// <param name="orderId">The order Id.</param>
	/// <param name="appProductId">The product Id of the app.</param>
	/// <param name="playStoreToken">The Google Play Store token.</param>
	/// <param name="platformTypeId">The platform type Id.</param>
	/// <param name="isRetry">Is this a retry of a previous attempt.</param>
	/// <param name="googleClient">The <see cref="T:Roblox.GoogleAPI.Interfaces.IAndroidPublisher" />.</param>
	/// <param name="cancelExistingActiveMembershipSaleAction"></param>
	/// <param name="checkoutSessionLogger">The checkout session logger.</param>
	/// <param name="saleLogger">The sale logger.</param>
	/// <param name="paymentLogger">The payment logger.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="verificationClient">The <see cref="T:Roblox.Billing.IGooglePlayStoreVerificationClient" />. Will create a new one if passed in as null.</param>
	/// <param name="billingStatisticsTracker">The <see cref="T:Roblox.Billing.Metrics.IBillingStatisticsTracker" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	void Process(IPurchaser purchaser, string packageName, string orderId, string appProductId, string playStoreToken, byte platformTypeId, bool isRetry, IAndroidPublisher googleClient, CancelExistingActiveMembershipSaleHandler cancelExistingActiveMembershipSaleAction, Action<string, int> checkoutSessionLogger, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IUserFactory userFactory, IGooglePlayStoreVerificationClient verificationClient = null, IBillingStatisticsTracker billingStatisticsTracker = null, ILogger logger = null);
}
