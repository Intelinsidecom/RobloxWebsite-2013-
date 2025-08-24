namespace Roblox.Platform.Billing;

internal enum PaymentProviderType
{
	[EntityTypeValue("Apple App Store")]
	AppleAppStore,
	[EntityTypeValue("Boku")]
	Boku,
	[EntityTypeValue("PayPal Express Checkout eCheck")]
	Check,
	[EntityTypeValue("Credit")]
	Credit,
	[EntityTypeValue("Website Payments Pro Payflow Edition")]
	CreditCard,
	[EntityTypeValue("Google Play Store")]
	GooglePlayStore,
	[EntityTypeValue("InComm")]
	InComm,
	[EntityTypeValue("Pay by Mail Direct")]
	Mail,
	[EntityTypeValue("PayPal Express Checkout")]
	Paypal,
	[EntityTypeValue("Rixty")]
	Rixty,
	[EntityTypeValue("RixtyPin")]
	RixtyPin,
	[EntityTypeValue("LiveGamer")]
	LiveGamer,
	[EntityTypeValue("ROBLOX Giveaway")]
	ROBLOXGiveaway,
	[EntityTypeValue("Amazon Store")]
	AmazonStore,
	[EntityTypeValue("Xbox Store")]
	XboxStore,
	[EntityTypeValue("Windows Store")]
	WindowsStore,
	[EntityTypeValue("Midas WeChat")]
	MidasWeChat
}
