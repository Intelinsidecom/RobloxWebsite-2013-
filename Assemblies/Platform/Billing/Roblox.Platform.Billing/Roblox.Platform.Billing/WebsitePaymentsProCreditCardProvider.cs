using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Billing;
using Roblox.Billing.Business_Logic_Layer;
using Roblox.EventLog;
using Roblox.Platform.Core;

namespace Roblox.Platform.Billing;

internal abstract class WebsitePaymentsProCreditCardProvider : DomainObjectBase<BillingDomainFactories>, ICreditCardProvider
{
	protected readonly AuditLogDelegates.CheckoutSessionAuditLogFunc CheckoutSessionAuditLogFunc;

	protected abstract ShoppingCart BuildShoppingCart(ICollection<LineItem> lineItems, long? checkoutSessionId);

	protected abstract ITransactionResult DoProcess(ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, ShoppingCart shoppingCart, CreditCardPaymentProvider creditCardPaymentProvider, LineItem renewableLineItem, Roblox.Billing.Business_Logic_Layer.CurrencyType currencyType, long? checkoutSessionId, byte platformTypeId);

	public ITransactionResult Process(ICollection<LineItem> lineItems, CreditCardTransactionInfo creditCardTransactionInfo, Func<FraudDetectionData, IFraudDetectorResult> fraudDetectionAction, ILogger logger, CancelExistingActiveMembershipSaleHandler cancelExistingRecurringMembershipSale, long? checkoutSessionId, byte platformTypeId, string sessionId = null)
	{
		CheckoutSessionAuditLogFunc(checkoutSessionId, 1, "Validating product bundle.");
		lineItems.ValidateProductBundle();
		CheckoutSessionAuditLogFunc(checkoutSessionId, 1, "Successfully validated product bundle.");
		CreditCardPaymentProvider creditCardPaymentProvider = new CreditCardPaymentProvider(logger, creditCardTransactionInfo.CreditCardPaymentInfo, fraudDetectionAction, cancelExistingRecurringMembershipSale, sessionId);
		ShoppingCart shoppingCart = BuildShoppingCart(lineItems, checkoutSessionId);
		LineItem renewableLineItem = lineItems.FirstOrDefault((LineItem i) => i.RenewalStartDate.HasValue);
		Roblox.Billing.Business_Logic_Layer.CurrencyType currencyType = creditCardTransactionInfo.CurrencyType.Translate();
		ITransactionResult result = DoProcess(lineItems, creditCardTransactionInfo, shoppingCart, creditCardPaymentProvider, renewableLineItem, currencyType, checkoutSessionId, platformTypeId);
		if (creditCardPaymentProvider.NetSuccessOrFailure)
		{
			CheckoutSessionAuditLogFunc(checkoutSessionId, 1, "Clearing shopping cart.");
			shoppingCart.RemoveAll();
		}
		return result;
	}

	protected WebsitePaymentsProCreditCardProvider(BillingDomainFactories domainFactories, AuditLogDelegates.CheckoutSessionAuditLogFunc checkoutSessionAuditLogFunc)
		: base(domainFactories)
	{
		if (checkoutSessionAuditLogFunc == null)
		{
			throw new PlatformArgumentNullException("checkoutSessionAuditLogFunc");
		}
		CheckoutSessionAuditLogFunc = checkoutSessionAuditLogFunc;
	}
}
