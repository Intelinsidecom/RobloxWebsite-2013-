namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides PaymentResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class PaymentResources_es_es : PaymentResources_en_us, IPaymentResources, ITranslationResources
{
	/// <summary>
	/// Key: "Message.FraudBlockedPaymentCheckInfoErrorMessage"
	/// English String: "Unfortunately we are unable to process your payment. Please confirm the billing information entered matches the card provided and try again. If this fails, please try another card or different payment method.\t"
	/// </summary>
	public override string MessageFraudBlockedPaymentCheckInfoErrorMessage => "Lamentablemente, no se ha podido procesar tu pago. Asegúrate de que la información de la facturación que acabas de ingresar coincida con aquella de la tarjeta proporcionada e inténtalo de nuevo. Si el error persiste, prueba a usar otra tarjeta u otro método de pago.";

	/// <summary>
	/// Key: "Message.FraudWarningForUnder13WithCreditCard"
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation. Using a card without permission will result in your account being deleted."
	/// </summary>
	public override string MessageFraudWarningForUnder13WithCreditCard => "Asegúrate de tener permiso de tus padres antes de utilizar su tarjeta de crédito. Los dueños de la tarjeta pueden ser contactados para confirmar la compra. El uso no autorizado resultará en la eliminación de la cuenta.";

	public PaymentResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentCheckInfoErrorMessage()
	{
		return "Lamentablemente, no se ha podido procesar tu pago. Asegúrate de que la información de la facturación que acabas de ingresar coincida con aquella de la tarjeta proporcionada e inténtalo de nuevo. Si el error persiste, prueba a usar otra tarjeta u otro método de pago.";
	}

	/// <summary>
	/// Key: "Message.FraudBlockedPaymentErrorMessage"
	/// English String: "Your charge has been blocked due to suspicious activity. If you believe this is in error, please contact us at {linkStart}roblox.com/support{linkEnd}."
	/// </summary>
	public override string MessageFraudBlockedPaymentErrorMessage(string linkStart, string linkEnd)
	{
		return $"Tu cargo ha sido bloqueado debido a actividades sospechosas. Si crees que esto ha ocurrido por error, contáctanos en {linkStart}roblox.com/support{linkEnd}.";
	}

	protected override string _GetTemplateForMessageFraudBlockedPaymentErrorMessage()
	{
		return "Tu cargo ha sido bloqueado debido a actividades sospechosas. Si crees que esto ha ocurrido por error, contáctanos en {linkStart}roblox.com/support{linkEnd}.";
	}

	/// <summary>
	/// Key: "Message.FraudForUnder13UsingCreditCard"
	/// Don't include this string.
	/// English String: "Make sure you have your parents permission before using their credit cards. Card owners may be contacted for confirmation.{lineStart}Using a card without permission will result in your account being deleted.{lineEnd}"
	/// </summary>
	public override string MessageFraudForUnder13UsingCreditCard(string lineStart, string lineEnd)
	{
		return $"Asegúrate de tener permiso de tus padres antes de utilizar su tarjeta de crédito. Los dueños de la tarjeta pueden ser contactados para confirmar la compra.{lineStart}El uso no autorizado resultará en la eliminación de la cuenta.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudForUnder13UsingCreditCard()
	{
		return "Asegúrate de tener permiso de tus padres antes de utilizar su tarjeta de crédito. Los dueños de la tarjeta pueden ser contactados para confirmar la compra.{lineStart}El uso no autorizado resultará en la eliminación de la cuenta.{lineEnd}";
	}

	protected override string _GetTemplateForMessageFraudWarningForUnder13WithCreditCard()
	{
		return "Asegúrate de tener permiso de tus padres antes de utilizar su tarjeta de crédito. Los dueños de la tarjeta pueden ser contactados para confirmar la compra. El uso no autorizado resultará en la eliminación de la cuenta.";
	}
}
