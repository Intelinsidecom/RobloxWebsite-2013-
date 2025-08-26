namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_fr_fr : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "Ne me le rappelez pas";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "Mettre Ã  jour maintenant";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Veuillez mettre Ã  jour vos informations de carte de crÃ©dit afin de vous assurer que votre abonnement au Builders Club n'expire pas\u00a0!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "Expiration de la carte de crÃ©dit";

	public CreditCardExpiringModalResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "Ne me le rappelez pas";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "Mettre Ã  jour maintenant";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"Votre carte de crÃ©dit expirera le {expirationDate}\u00a0!";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "Votre carte de crÃ©dit expirera le {expirationDate}\u00a0!";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Veuillez mettre Ã  jour vos informations de carte de crÃ©dit afin de vous assurer que votre abonnement au Builders Club n'expire pas\u00a0!";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "Expiration de la carte de crÃ©dit";
	}
}


}
