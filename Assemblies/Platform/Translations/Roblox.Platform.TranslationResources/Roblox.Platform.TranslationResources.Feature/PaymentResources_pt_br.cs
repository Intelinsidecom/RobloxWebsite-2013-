namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_pt_br : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "Infelizmente, não conseguimos processar seu pagamento. Verifique se as informações de cobrança estão de acordo com o cartão fornecido e tente novamente. Se isto não funcionar, tente com um cartão ou método de pagamento diferente.\t";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "Certifique-se de ter a permissão dos seus responsáveis antes de usar seu cartão de crédito. Os donos do cartão podem ser contatados para confirmar a compra. Usar um cartão sem permissão fará com que sua conta seja apagada.";

	public PaymentResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "Infelizmente, não conseguimos processar seu pagamento. Verifique se as informações de cobrança estão de acordo com o cartão fornecido e tente novamente. Se isto não funcionar, tente com um cartão ou método de pagamento diferente.\t";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"Sua cobrança foi bloqueada devido a atividade suspeita. Se você acha que isto é um erro, contate-nos em {linkStart}roblox.com/support{linkEnd}.";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "Sua cobrança foi bloqueada devido a atividade suspeita. Se você acha que isto é um erro, contate-nos em {linkStart}roblox.com/support{linkEnd}.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"Certifique-se de ter a permissão dos seus responsáveis antes de usar seu cartão de crédito. Os donos do cartão podem ser contatados para confirmar a compra.{lineStart}Usar um cartão sem permissão fará com que sua conta seja apagada.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "Certifique-se de ter a permissão dos seus responsáveis antes de usar seu cartão de crédito. Os donos do cartão podem ser contatados para confirmar a compra.{lineStart}Usar um cartão sem permissão fará com que sua conta seja apagada.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "Certifique-se de ter a permissão dos seus responsáveis antes de usar seu cartão de crédito. Os donos do cartão podem ser contatados para confirmar a compra. Usar um cartão sem permissão fará com que sua conta seja apagada.";
	}
}
