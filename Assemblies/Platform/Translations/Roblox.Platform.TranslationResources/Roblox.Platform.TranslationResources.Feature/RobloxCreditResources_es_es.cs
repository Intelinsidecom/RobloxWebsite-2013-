namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_es_es : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "Convertir a Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Canjear";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Obtener Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Crédito de Roblox";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "Hubo un problema al procesar tus créditos de Roblox. Inténtalo de nuevo más tarde.";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Hemos abonado tus créditos de Roblox, pero hubo un problema al procesar los Robux. Contacta con Atención al cliente para obtenerlos.";

	public RobloxCreditResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "Convertir a Robux";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Canjear";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"Canjea tu crédito de Roblox de {balance} a {iconRobux}{robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "Canjea tu crédito de Roblox de {balance} a {iconRobux}{robuxAmount}";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Obtener Robux";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Crédito de Roblox";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"Saldo actual: ${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "Saldo actual: ${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "Hubo un problema al procesar tus créditos de Roblox. Inténtalo de nuevo más tarde.";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Hemos abonado tus créditos de Roblox, pero hubo un problema al procesar los Robux. Contacta con Atención al cliente para obtenerlos.";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"Has canjeado correctamente {robuxAmount} Robux.";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "Has canjeado correctamente {robuxAmount} Robux.";
	}
}
