namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides CreditCardExpiringModalResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class CreditCardExpiringModalResources_pt_br : CreditCardExpiringModalResources_en_us, ICreditCardExpiringModalResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.DontRemindAgain"
	/// link text
	/// English String: "Don't remind me again"
	/// </summary>
	public override string ActionDontRemindAgain => "NÃ£o lembrar novamente";

	/// <summary>
	/// Key: "Action.UpdateNow"
	/// button text
	/// English String: "Update Now"
	/// </summary>
	public override string ActionUpdateNow => "Fazer upgrade agora";

	/// <summary>
	/// Key: "Description.UpdateYourCreditCard"
	/// description text
	/// English String: "Please update your credit card information to make sure your Builders Club membership doesn't expire!"
	/// </summary>
	public override string DescriptionUpdateYourCreditCard => "Atualize as informaÃ§Ãµes do seu cartÃ£o de crÃ©dito para que sua assinatura do Builders Club nÃ£o expire!";

	/// <summary>
	/// Key: "Heading.CreditCardExpiration"
	/// modal heading
	/// English String: "Credit Card Expiration"
	/// </summary>
	public override string HeadingCreditCardExpiration => "Data de vencimento do cartÃ£o de crÃ©dito";

	public CreditCardExpiringModalResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionDontRemindAgain()
	{
		return "NÃ£o lembrar novamente";
	}

	protected override string _GetTemplateForActionUpdateNow()
	{
		return "Fazer upgrade agora";
	}

	/// <summary>
	/// Key: "Description.CreditCardExpiration"
	/// description text
	/// English String: "Your Credit Card will expire on {expirationDate}!"
	/// </summary>
	public override string DescriptionCreditCardExpiration(string expirationDate)
	{
		return $"Seu cartÃ£o de crÃ©dito vence em {expirationDate}!";
	}

	protected override string _GetTemplateForDescriptionCreditCardExpiration()
	{
		return "Seu cartÃ£o de crÃ©dito vence em {expirationDate}!";
	}

	protected override string _GetTemplateForDescriptionUpdateYourCreditCard()
	{
		return "Atualize as informaÃ§Ãµes do seu cartÃ£o de crÃ©dito para que sua assinatura do Builders Club nÃ£o expire!";
	}

	protected override string _GetTemplateForHeadingCreditCardExpiration()
	{
		return "Data de vencimento do cartÃ£o de crÃ©dito";
	}
}


}
