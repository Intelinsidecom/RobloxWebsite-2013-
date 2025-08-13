using System;
using Roblox.Billing;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Billing;

public interface IMobileAppPurchaseValidator
{
	MobileAppProductValidationResult ValidateMobilePurchase(IUser user, GetAppSpecificProductFromProductId productGetter, string productId, Roblox.Billing.PaymentProviderType paymentProviderType, string ipAddress, Action<Exception> exceptionHandler, string currencyCode = null);
}
