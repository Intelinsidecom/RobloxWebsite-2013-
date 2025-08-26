namespace Roblox.Platform.TranslationResources.Feature {
    /// <summary>

/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_fr_fr : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "Nous ne parvenons pas Ã  traiter votre paiement. Veuillez vÃ©rifier que les donnÃ©es de facturation saisies correspondent Ã  la carte utilisÃ©e, puis rÃ©essayez. En cas d'Ã©chec, essayez avec une carte ou un moyen de paiement diffÃ©rents.\t";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "Veillez Ã  avoir l'autorisation de vos parents avant d'utiliser leur carte de crÃ©dit. Le dÃ©tenteur de la carte pourra Ãªtre contactÃ© pour confirmation. L'utilisation d'une carte sans permission entraÃ®nera la suppression de votre compte.";

	public PaymentResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "Nous ne parvenons pas Ã  traiter votre paiement. Veuillez vÃ©rifier que les donnÃ©es de facturation saisies correspondent Ã  la carte utilisÃ©e, puis rÃ©essayez. En cas d'Ã©chec, essayez avec une carte ou un moyen de paiement diffÃ©rents.\t";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"Votre prÃ©lÃ¨vement a Ã©tÃ© bloquÃ© en raison d'une activitÃ© suspecte. Si vous pensez qu'il s'agit d'une erreur, veuillez nous contacter Ã  l'adresse\u00a0: {linkStart}roblox.com/support{linkEnd}.";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "Votre prÃ©lÃ¨vement a Ã©tÃ© bloquÃ© en raison d'une activitÃ© suspecte. Si vous pensez qu'il s'agit d'une erreur, veuillez nous contacter Ã  l'adresse\u00a0: {linkStart}roblox.com/support{linkEnd}.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"Veillez Ã  avoir l'autorisation de vos parents avant d'utiliser leur carte de crÃ©dit. Le dÃ©tenteur de la carte pourra Ãªtre contactÃ© pour confirmation.{lineStart}L'utilisation d'une carte sans permission entraÃ®nera la suppression de votre compte.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "Veillez Ã  avoir l'autorisation de vos parents avant d'utiliser leur carte de crÃ©dit. Le dÃ©tenteur de la carte pourra Ãªtre contactÃ© pour confirmation.{lineStart}L'utilisation d'une carte sans permission entraÃ®nera la suppression de votre compte.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "Veillez Ã  avoir l'autorisation de vos parents avant d'utiliser leur carte de crÃ©dit. Le dÃ©tenteur de la carte pourra Ãªtre contactÃ© pour confirmation. L'utilisation d'une carte sans permission entraÃ®nera la suppression de votre compte.";
	}
}


}
