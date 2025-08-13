namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides RobloxCreditResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class RobloxCreditResources_de_de : RobloxCreditResources_en_us, IRobloxCreditResources, ITranslationResources
{
	/// <summary>
	/// Key: "Action.ConvertToRobux"
	/// English String: "Convert To Robux"
	/// </summary>
	public override string ActionConvertToRobux => "In Robux umrechnen";

	/// <summary>
	/// Key: "Action.Redeem"
	/// English String: "Redeem"
	/// </summary>
	public override string ActionRedeem => "Einlösen";

	/// <summary>
	/// Key: "Heading.GetRobux"
	/// English String: "Get Robux"
	/// </summary>
	public override string HeadingGetRobux => "Robux erhalten";

	/// <summary>
	/// Key: "Heading.RobloxCredit"
	/// English String: "Roblox credit"
	/// </summary>
	public override string HeadingRobloxCredit => "Roblox-Guthaben";

	/// <summary>
	/// Key: "Message.FailedDebitRobloxCredit"
	/// English String: "There has been an issue processing your Roblox credit. Please try again later!"
	/// </summary>
	public override string MessageFailedDebitRobloxCredit => "Bei der Verarbeitung deines Roblox-Guthabens ist ein Problem aufgetreten. Bitte versuche es später erneut!";

	/// <summary>
	/// Key: "Message.FailedGrantingRobux"
	/// English String: "We’ve credited your Roblox credits, but there was an issue processing your Robux grant. Please contact customer support to get your Robux."
	/// </summary>
	public override string MessageFailedGrantingRobux => "Wir haben deine Roblox-Credits gutgeschrieben, aber bei der Verarbeitung deines Robux-Zuschusses ist ein Fehler aufgetreten. Wende dich bitte an den Kundendienst, um deine Robux zu erhalten.";

	public RobloxCreditResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForActionConvertToRobux()
	{
		return "In Robux umrechnen";
	}

	protected override string _GetTemplateForActionRedeem()
	{
		return "Einlösen";
	}

	/// <summary>
	/// Key: "Description.ConfirmRedeemCreditForRobux"
	/// "NOT BEING USED" Incorrect message
	/// English String: "Redeem your {balance} Roblox credit to {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRedeemCreditForRobux(string balance, string robuxAmount)
	{
		return $"Löse dein {balance} Roblox-Guthaben in {robuxAmount} ein";
	}

	protected override string _GetTemplateForDescriptionConfirmRedeemCreditForRobux()
	{
		return "Löse dein {balance} Roblox-Guthaben in {robuxAmount} ein";
	}

	/// <summary>
	/// Key: "Description.ConfirmRobloxCreditToRobuxRedemption"
	/// English String: "Redeem your {balance} Roblox credit to {iconRobux} {robuxAmount}"
	/// </summary>
	public override string DescriptionConfirmRobloxCreditToRobuxRedemption(string balance, string iconRobux, string robuxAmount)
	{
		return $"Löse dein {balance} Roblox-Guthaben in {iconRobux} {robuxAmount} ein";
	}

	protected override string _GetTemplateForDescriptionConfirmRobloxCreditToRobuxRedemption()
	{
		return "Löse dein {balance} Roblox-Guthaben in {iconRobux} {robuxAmount} ein";
	}

	protected override string _GetTemplateForHeadingGetRobux()
	{
		return "Robux erhalten";
	}

	protected override string _GetTemplateForHeadingRobloxCredit()
	{
		return "Roblox-Guthaben";
	}

	/// <summary>
	/// Key: "Label.CurrentBalance"
	/// Roblox Credit Balance
	/// English String: "Current Balance: ${balance}"
	/// </summary>
	public override string LabelCurrentBalance(string balance)
	{
		return $"Aktuelles Guthaben: ${balance}";
	}

	protected override string _GetTemplateForLabelCurrentBalance()
	{
		return "Aktuelles Guthaben: ${balance}";
	}

	protected override string _GetTemplateForMessageFailedDebitRobloxCredit()
	{
		return "Bei der Verarbeitung deines Roblox-Guthabens ist ein Problem aufgetreten. Bitte versuche es später erneut!";
	}

	protected override string _GetTemplateForMessageFailedGrantingRobux()
	{
		return "Wir haben deine Roblox-Credits gutgeschrieben, aber bei der Verarbeitung deines Robux-Zuschusses ist ein Fehler aufgetreten. Wende dich bitte an den Kundendienst, um deine Robux zu erhalten.";
	}

	/// <summary>
	/// Key: "Message.RobloxCreditToRobuxRedemptionConfirmation"
	/// English String: "You've successfully redeemed {robuxAmount} Robux!"
	/// </summary>
	public override string MessageRobloxCreditToRobuxRedemptionConfirmation(string robuxAmount)
	{
		return $"Du hast {robuxAmount} Robux erfolgreich eingelöst!";
	}

	protected override string _GetTemplateForMessageRobloxCreditToRobuxRedemptionConfirmation()
	{
		return "Du hast {robuxAmount} Robux erfolgreich eingelöst!";
	}
}
