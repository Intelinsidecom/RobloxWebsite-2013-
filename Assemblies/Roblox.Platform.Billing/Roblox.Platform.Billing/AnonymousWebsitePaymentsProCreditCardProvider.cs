using System.Collections.Generic;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.Users;

namespace Roblox.Platform.Billing;

internal class AnonymousWebsitePaymentsProCreditCardProvider : WebsitePaymentsProCreditCardProvider
{
	private readonly long _BrowserTrackerId;

	internal AnonymousWebsitePaymentsProCreditCardProvider(BillingDomainFactories domainFactories, long browserTrackerId, AuditLogDelegates.CheckoutSessionAuditLogFunc checkoutSessionAuditLogFunc)
		: base(domainFactories, checkoutSessionAuditLogFunc)
	{
		_BrowserTrackerId = browserTrackerId;
	}

	protected override ShoppingCart BuildShoppingCart(ICollection<LineItem> lineItems, long? checkoutSessionId)
	{
		return lineItems.ToShoppingCart(_BrowserTrackerId);
	}

	protected override ITransactionResult DoProcess(ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, ShoppingCart shoppingCart, CreditCardPaymentProvider creditCardPaymentProvider, LineItem renewableLineItem, Roblox.Billing.Business_Logic_Layer.CurrencyType currencyType, long? checkoutSessionId, byte platformTypeId)
	{
		byte countryId = Country.Get(creditCardTransactionInfo.CountryId)?.ID ?? Country.GetUSACountry().ID;
		if (renewableLineItem != null)
		{
			CheckoutSessionAuditLogFunc(checkoutSessionId, 3, "Cannot buy a renewable product while logged out.");
			throw new InvalidProductException("Cannot buy a renewable product while logged out.");
		}
		if (lineItems.IsGiftCardPurchase())
		{
			string creditCardFullName = creditCardTransactionInfo.CreditCardPaymentInfo.FirstName + " " + creditCardTransactionInfo.CreditCardPaymentInfo.LastName;
			CheckoutSessionAuditLogFunc(checkoutSessionId, 1, "Checking out gift card purchase for guest.");
			creditCardPaymentProvider.CheckOut(shoppingCart, creditCardFullName, adminOverride: false, countryId, currencyType.ID, platformTypeId);
			ISale sale = base.DomainFactories.SaleFactory.Get(creditCardPaymentProvider.Sale.ID);
			return new CreditCardTransactionResult(creditCardPaymentProvider.NetSuccessOrFailure, sale);
		}
		CheckoutSessionAuditLogFunc(checkoutSessionId, 3, "Cannot buy a product while logged out. Who would get these products?");
		throw new InvalidProductException("Cannot buy a product while logged out. Who would get these products?");
	}
}
