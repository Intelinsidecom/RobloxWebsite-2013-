using Roblox.Billing;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public class CreditCardProviderFactory
{
	private readonly AuditLogDelegates.CheckoutSessionAuditLogFunc _CheckoutSessionAuditLogFunc;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Billing.CreditCardProviderFactory" /> class.
	/// </summary>
	/// <param name="checkoutSessionAuditLogFunc">The checkout session audit log function.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	///     <paramref name="checkoutSessionAuditLogFunc" />
	/// </exception>
	public CreditCardProviderFactory(AuditLogDelegates.CheckoutSessionAuditLogFunc checkoutSessionAuditLogFunc)
	{
		if (checkoutSessionAuditLogFunc == null)
		{
			throw new PlatformArgumentNullException("checkoutSessionAuditLogFunc");
		}
		_CheckoutSessionAuditLogFunc = checkoutSessionAuditLogFunc;
	}

	internal ICreditCardProvider GetCreditCardProvider(BillingDomainFactories domainFactories, IUser user)
	{
		return new AuthenticatedWebsitePaymentsProCreditCardProvider(domainFactories, user, _CheckoutSessionAuditLogFunc);
	}

	internal ICreditCardProvider GetCreditCardProvider(BillingDomainFactories domainFactories, long browserTrackerId)
	{
		return new AnonymousWebsitePaymentsProCreditCardProvider(domainFactories, browserTrackerId, _CheckoutSessionAuditLogFunc);
	}
}
