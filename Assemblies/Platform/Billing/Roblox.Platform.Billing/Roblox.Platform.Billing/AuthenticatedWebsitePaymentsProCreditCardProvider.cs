using System.Collections.Generic;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Platform.Membership;
using Roblox.Users;

namespace Roblox.Platform.Billing;

internal class AuthenticatedWebsitePaymentsProCreditCardProvider : WebsitePaymentsProCreditCardProvider
{
	private readonly IUser _AuthenticatedUser;

	internal AuthenticatedWebsitePaymentsProCreditCardProvider(BillingDomainFactories domainFactories, IUser authenticatedUser, AuditLogDelegates.CheckoutSessionAuditLogFunc checkoutSessionAuditLogFunc)
		: base(domainFactories, checkoutSessionAuditLogFunc)
	{
		_AuthenticatedUser = authenticatedUser;
	}

	protected override ShoppingCart BuildShoppingCart(ICollection<LineItem> lineItems, long? checkoutSessionId)
	{
		return lineItems.ToShoppingCart(_AuthenticatedUser);
	}

	protected override ITransactionResult DoProcess(ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, ShoppingCart shoppingCart, CreditCardPaymentProvider creditCardPaymentProvider, LineItem renewableLineItem, Roblox.Billing.Business_Logic_Layer.CurrencyType currencyType, long? checkoutSessionId, byte platformTypeId)
	{
		byte countryId = Country.Get(creditCardTransactionInfo.CountryId)?.ID ?? Country.GetUSACountry().ID;
		if (renewableLineItem != null)
		{
			creditCardPaymentProvider.CheckOut(shoppingCart, renewableLineItem.RenewalStartDate.Value, _AuthenticatedUser.Name, countryId, currencyType.ID, platformTypeId);
		}
		else
		{
			creditCardPaymentProvider.CheckOut(shoppingCart, _AuthenticatedUser.Name, adminOverride: false, countryId, currencyType.ID, platformTypeId);
		}
		ISale sale = base.DomainFactories.SaleFactory.Get(creditCardPaymentProvider.Sale.ID);
		return new CreditCardTransactionResult(creditCardPaymentProvider.NetSuccessOrFailure, sale);
	}
}
