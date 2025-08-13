namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_fr_fr : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "Convertir en Robux";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Activer";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Obtenir des Robux";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Crédit Roblox";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "Une erreur s'est produite lors du traitement de votre crédit Roblox. Veuillez réessayer plus tard.";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Nous vous avons crédité vos crédits Roblox, mais une erreur s'est produite lors de l'attribution des Robux. Veuillez contacter le service à la clientèle pour obtenir vos Robux.";

	public RobloxCreditResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "Convertir en Robux";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Activer";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"Activez votre crédit Roblox de {balance} en {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "Activez votre crédit Roblox de {balance} en {robuxAmount}";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"Activez votre crédit Roblox de {balance} en {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "Activez votre crédit Roblox de {balance} en {iconRobux} {robuxAmount}";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Obtenir des Robux";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Crédit Roblox";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"Solde actuel\u00a0: {balance}\u00a0$";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "Solde actuel\u00a0: {balance}\u00a0$";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "Une erreur s'est produite lors du traitement de votre crédit Roblox. Veuillez réessayer plus tard.";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Nous vous avons crédité vos crédits Roblox, mais une erreur s'est produite lors de l'attribution des Robux. Veuillez contacter le service à la clientèle pour obtenir vos Robux.";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"Vous avez activé vos {robuxAmount} Robux\u00a0!";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "Vous avez activé vos {robuxAmount} Robux\u00a0!";
	}
}
