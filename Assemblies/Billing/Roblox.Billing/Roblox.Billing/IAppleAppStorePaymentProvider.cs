using System;
using Roblox.Billing.Metrics;
using Roblox.EventLog;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

/// <summary>
/// An interface for Apple App Store Payment provider.
/// </summary>
public interface IAppleAppStorePaymentProvider
{
	/// <summary>
	/// Processes the specified transaction.
	/// </summary>
	/// <param name="purchaser">The <see cref="T:Roblox.Billing.IPurchaser" />.</param>
	/// <param name="receipt">The receipt.</param>
	/// <param name="platformTypeId">The platform type identifier.</param>
	/// <param name="isRetry">if set to <c>true</c> [is retry].</param>
	/// <param name="findFirstMembershipSaleAndCancelAction">The <see cref="T:Roblox.Billing.CancelExistingActiveMembershipSaleHandler" />.</param>
	/// <param name="checkoutSessionLogger">The checkout session logger.</param>
	/// <param name="saleLogger">The sale logger.</param>
	/// <param name="paymentLogger">The payment logger.</param>
	/// <param name="emailSender">The <see cref="!:IEmailClient" />.</param>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="verificationClient">The <see cref="T:Roblox.Billing.IAppleAppStoreVerificationClient" />.</param>
	/// <param name="billingStatisticsTracker">The <see cref="T:Roblox.Billing.Metrics.IBillingStatisticsTracker" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	void Process(IPurchaser purchaser, string receipt, byte platformTypeId, bool isRetry, CancelExistingActiveMembershipSaleHandler findFirstMembershipSaleAndCancelAction, Action<string, int> checkoutSessionLogger, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IEmailSender emailSender, IUserFactory userFactory, IAppleAppStoreVerificationClient verificationClient = null, IBillingStatisticsTracker billingStatisticsTracker = null, ILogger logger = null);
}
