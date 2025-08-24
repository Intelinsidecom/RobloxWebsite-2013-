namespace Roblox.Platform.Billing;

public interface ICreditCard
{
	string Number { get; set; }

	CreditCardType CardType { get; set; }

	string SecurityCode { get; set; }

	string ExpirationMonth { get; set; }

	string ExpirationYear { get; set; }
}
