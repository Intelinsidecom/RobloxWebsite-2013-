namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_de_de : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "Nicht mehr erinnern";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "Jetzt aktualisieren";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Bitte aktualisiere deine Kreditkarteninformationen, damit deine „Builders Club“-Mitgliedschaft nicht abläuft!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "Abgelaufene Kreditkarte";

	public CreditCardExpiringModalResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "Nicht mehr erinnern";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "Jetzt aktualisieren";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"Deine Kreditkarte läuft am {expirationDate} ab!";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "Deine Kreditkarte läuft am {expirationDate} ab!";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Bitte aktualisiere deine Kreditkarteninformationen, damit deine „Builders Club“-Mitgliedschaft nicht abläuft!";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "Abgelaufene Kreditkarte";
	}
}
