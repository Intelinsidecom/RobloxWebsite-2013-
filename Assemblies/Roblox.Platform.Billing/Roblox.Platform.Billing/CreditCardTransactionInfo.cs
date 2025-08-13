using Roblox.Billing;

namespace Roblox.Platform.Billing;

public class CreditCardTransactionInfo
{
	public CreditCardPaymentInfo CreditCardPaymentInfo { get; set; }

	public bool DoublePurchaseConfirmed { get; set; }

	public byte CountryId { get; set; }

	public CurrencyType CurrencyType { get; set; }

	public long BrowserTrackerId { get; set; }

	public byte PlatformTypeId { get; set; }

	public string BaseUrlHttps { get; set; }

	public CreditCardType CreditCardType { get; set; }
}
