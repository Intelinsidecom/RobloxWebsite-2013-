using System;
using Roblox.Billing.Metrics;
using Roblox.EventLog;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;

namespace Roblox.Billing;

/// <summary>
/// Provides a common interface for an Amazon store payment provider.
/// </summary>
public interface IAmazonStorePaymentProvider
{
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
	void Process(IPurchaser purchaser, string receiptId, string amazonUserId, byte platformTypeId, bool isRetry, CancelExistingActiveMembershipSaleHandler findFirstMembershipSaleAndCancelAction, Action<string, int> checkoutSessionLogger, AuditLogDelegates.SaleAuditLogFunc saleLogger, AuditLogDelegates.PaymentAuditLogFunc paymentLogger, IEmailSender emailSender, IUserFactory userFactory, IAmazonStoreVerificationClient verificationClient = null, IBillingStatisticsTracker billingStatisticsTracker = null, ILogger logger = null);
}
