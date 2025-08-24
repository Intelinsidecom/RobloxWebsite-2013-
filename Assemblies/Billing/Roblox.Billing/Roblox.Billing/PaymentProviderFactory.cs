namespace Roblox.Billing;

public class PaymentProviderFactory
{
	private readonly IAppleAppStorePaymentProvider _AppleAppStorePaymentProvider = new AppleAppStorePaymentProvider();

	private readonly IGooglePlayStorePaymentProvider _GooglePlayStorePaymentProvider = new GooglePlayStorePaymentProvider();

	private readonly IAmazonStorePaymentProvider _AmazonStorePaymentProvider = new AmazonStorePaymentProvider();

	private readonly IXboxStorePaymentProvider _XboxStorePaymentProvider = new XboxStorePaymentProvider();

	private readonly IWindowsStorePaymentProvider _WindowsStorePaymentProvider = new WindowsStorePaymentProvider();

	public static readonly PaymentProviderFactory Singleton = new PaymentProviderFactory();

	private PaymentProviderFactory()
	{
	}

	public IAppleAppStorePaymentProvider GetAppleAppStorePaymentProvider()
	{
		return _AppleAppStorePaymentProvider;
	}

	public IGooglePlayStorePaymentProvider GetGooglePlayStorePaymentProvider()
	{
		return _GooglePlayStorePaymentProvider;
	}

	public IAmazonStorePaymentProvider GetAmazonStorePaymentProvider()
	{
		return _AmazonStorePaymentProvider;
	}

	public IXboxStorePaymentProvider GetXboxStorePaymentProvider()
	{
		return _XboxStorePaymentProvider;
	}

	public IWindowsStorePaymentProvider GetWindowsStorePaymentProvider()
	{
		return _WindowsStorePaymentProvider;
	}
}
