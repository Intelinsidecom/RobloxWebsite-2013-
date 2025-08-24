namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_es_es : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "No me lo vuelvas a recordar";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "Actualizar ahora";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "¡Actualiza la información de tu tarjeta de crédito para que tu suscripción al Builders Club no caduque!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "Fecha de vencimiento de la tarjeta de crédito";

	public CreditCardExpiringModalResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "No me lo vuelvas a recordar";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "Actualizar ahora";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"¡Tu tarjeta de crédito se vencerá el {expirationDate}!";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "¡Tu tarjeta de crédito se vencerá el {expirationDate}!";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "¡Actualiza la información de tu tarjeta de crédito para que tu suscripción al Builders Club no caduque!";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "Fecha de vencimiento de la tarjeta de crédito";
	}
}
