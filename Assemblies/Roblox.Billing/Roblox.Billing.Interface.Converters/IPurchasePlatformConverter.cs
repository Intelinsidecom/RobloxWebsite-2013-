namespace Roblox.Billing.Interface.Converters;

public interface IPurchasePlatformConverter
{
	/// <summary>
	/// Gets the string value of a <see cref="T:Roblox.Billing.PaymentProviderType" /> for the <see cref="!:payment" />
	/// </summary>
	string GetPurchasePlatformTypeFromPaymentProviderTypeId(Payment payment);
}
