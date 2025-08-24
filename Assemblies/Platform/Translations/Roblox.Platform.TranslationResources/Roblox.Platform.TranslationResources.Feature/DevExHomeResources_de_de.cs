namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_de_de : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "Abbrechen";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "Auszahlen";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "Jetzt OBC holen";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "Mitgliedschaft aufwerten";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "Verifizieren";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "E-Mail-Adresse verifizieren";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "Jetzt verifizieren";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "DevEx besuchen";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "Du bist fast bereit!";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Du musst „Outrageous Builders Club“-Mitglied sein, um Robux gegen echtes Geld eintauschen zu können.";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "Du musst „Outrageous Builders Club“-Mitglied sein, um Auszahlungen erhalten zu können.";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "Aktuelle Wechselkurse";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "Für die Nutzung von DevEx benötigst du eine verifizierte E-Mail-Adresse.";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "Du bist derzeit nicht dazu berechtigt.";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "Du hast nicht genügend Robux für eine Auszahlung.";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "Bald kannst du Robux gegen echtes Geld eintauschen!";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "Du hast es fast geschafft! Du kannst schon bald Robux gegen echtes Geld eintauschen!";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "Bevor du Auszahlungen erhalten kannst, musst du deine E-Mail-Adresse verifizieren.";

	public DevExHomeResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "Abbrechen";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "Auszahlen";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "Jetzt OBC holen";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "Mitgliedschaft aufwerten";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "Verifizieren";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "E-Mail-Adresse verifizieren";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "Jetzt verifizieren";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "DevEx besuchen";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "Du bist fast bereit!";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Du musst „Outrageous Builders Club“-Mitglied sein, um Robux gegen echtes Geld eintauschen zu können.";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "Du musst „Outrageous Builders Club“-Mitglied sein, um Auszahlungen erhalten zu können.";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "Aktuelle Wechselkurse";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "Für die Nutzung von DevEx benötigst du eine verifizierte E-Mail-Adresse.";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "Du bist derzeit nicht dazu berechtigt.";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "Du hast nicht genügend Robux für eine Auszahlung.";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "Bald kannst du Robux gegen echtes Geld eintauschen!";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "Du hast es fast geschafft! Du kannst schon bald Robux gegen echtes Geld eintauschen!";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "Bevor du Auszahlungen erhalten kannst, musst du deine E-Mail-Adresse verifizieren.";
	}
}
