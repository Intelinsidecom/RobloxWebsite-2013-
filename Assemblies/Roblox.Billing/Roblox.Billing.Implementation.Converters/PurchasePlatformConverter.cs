using Roblox.Billing.Interface.Converters;
using Roblox.Common;

namespace Roblox.Billing.Implementation.Converters;

public class PurchasePlatformConverter : IPurchasePlatformConverter
{
	public string GetPurchasePlatformTypeFromPaymentProviderTypeId(Payment payment)
	{
		if (payment == null)
		{
			return null;
		}
		string purchasePlatformType = "";
		byte paymentProviderTypeId = PaymentProviderType.Get(payment.PaymentProviderTypeID).ID;
		if (paymentProviderTypeId == PaymentProviderType.AppleAppStore.ID)
		{
			return PurchasePlatformType.IsIosApp.ToDescription();
		}
		if (paymentProviderTypeId == PaymentProviderType.GooglePlayStore.ID)
		{
			return PurchasePlatformType.IsAndroidApp.ToDescription();
		}
		if (paymentProviderTypeId == PaymentProviderType.AmazonStore.ID)
		{
			return PurchasePlatformType.IsAmazonApp.ToDescription();
		}
		if (paymentProviderTypeId == PaymentProviderType.XboxStore.ID)
		{
			return PurchasePlatformType.IsXboxApp.ToDescription();
		}
		if (paymentProviderTypeId == PaymentProviderType.WindowsStore.ID)
		{
			return PurchasePlatformType.IsUwpApp.ToDescription();
		}
		return PurchasePlatformType.IsDesktop.ToDescription();
	}
}
