namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_de_de : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "Wir können deine Zahlung leider nicht verarbeiten. Bitte überprüfe, ob die eingegebenen Rechnungsdaten mit der Karte übereinstimmen, und versuche es dann erneut. Probiere bitte eine andere Karte oder Zahlungsart aus, falls der Vorgang erneut fehlschlägt.\t";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "Stell sicher, dass du die Erlaubnis deiner Eltern hast, bevor du deren Kreditkarten verwendest. Karteninhaber können zur Bestätigung kontaktiert werden. Wenn du eine Karte ohne Erlaubnis verwendest, wird dein Konto gelöscht.";

	public PaymentResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "Wir können deine Zahlung leider nicht verarbeiten. Bitte überprüfe, ob die eingegebenen Rechnungsdaten mit der Karte übereinstimmen, und versuche es dann erneut. Probiere bitte eine andere Karte oder Zahlungsart aus, falls der Vorgang erneut fehlschlägt.\t";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"Deine Transaktion wurde wegen verdächtiger Aktivitäten gesperrt. Falls du glaubst, dass es sich dabei um einen Irrtum handelt, kontaktiere uns bitte über {linkStart}roblox.com/support{linkEnd}.";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "Deine Transaktion wurde wegen verdächtiger Aktivitäten gesperrt. Falls du glaubst, dass es sich dabei um einen Irrtum handelt, kontaktiere uns bitte über {linkStart}roblox.com/support{linkEnd}.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"Stell sicher, dass du die Erlaubnis deiner Eltern hast, bevor du deren Kreditkarten verwendest. Karteninhaber können zur Bestätigung kontaktiert werden. {lineStart}Wenn du eine Karte ohne Erlaubnis verwendest, wird dein Konto gelöscht.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "Stell sicher, dass du die Erlaubnis deiner Eltern hast, bevor du deren Kreditkarten verwendest. Karteninhaber können zur Bestätigung kontaktiert werden. {lineStart}Wenn du eine Karte ohne Erlaubnis verwendest, wird dein Konto gelöscht.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "Stell sicher, dass du die Erlaubnis deiner Eltern hast, bevor du deren Kreditkarten verwendest. Karteninhaber können zur Bestätigung kontaktiert werden. Wenn du eine Karte ohne Erlaubnis verwendest, wird dein Konto gelöscht.";
	}
}
