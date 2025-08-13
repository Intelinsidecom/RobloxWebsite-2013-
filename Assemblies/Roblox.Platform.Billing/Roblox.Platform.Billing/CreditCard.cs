namespace Roblox.Platform.Billing;

public class CreditCard : ICreditCard
{
	public string Number { get; set; }

	public CreditCardType CardType { get; set; }

	public string SecurityCode { get; set; }

	public string ExpirationMonth { get; set; }

	public string ExpirationYear { get; set; }
}
