namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_fr_fr : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "Annuler";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "Encaisser";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "Obtenir OBC maintenant";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "Mettre à jour l'abonnement";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "Vérifier";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "Vérifier l'adresse e-mail";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "Vérifier maintenant";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "Visiter DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "Vous êtes presque prêt(e)\u00a0!";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Vous avez besoin d'Outrageous Builders Club afin d'échanger des Robux contre de l'argent.";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "Vous avez besoin d'Outrageous Builders Club afin de pouvoir effectuer un encaissement.";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "Taux de change actuels";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "Vous devez avoir une adresse e-mail vérifiée afin d'utiliser DevEx.";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "Vous n'êtes pas admissible pour le moment.";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "Vous n'avez pas assez de Robux pour effectuer un encaissement.";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "Vous serez bientôt en mesure d'échanger des Robux contre de l'argent\u00a0!";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "Vous y êtes presque\u00a0! Vous serez bientôt admissible pour échanger des Robux contre de l'argent\u00a0!";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "Tu dois vérifier ton adresse e-mail avant de pouvoir effectuer un encaissement.";

	public DevExHomeResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "Annuler";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "Encaisser";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "Obtenir OBC maintenant";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "Mettre à jour l'abonnement";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "Vérifier";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "Vérifier l'adresse e-mail";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "Vérifier maintenant";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "Visiter DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "Vous êtes presque prêt(e)\u00a0!";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Vous avez besoin d'Outrageous Builders Club afin d'échanger des Robux contre de l'argent.";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "Vous avez besoin d'Outrageous Builders Club afin de pouvoir effectuer un encaissement.";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "Taux de change actuels";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "Vous devez avoir une adresse e-mail vérifiée afin d'utiliser DevEx.";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "Vous n'êtes pas admissible pour le moment.";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "Vous n'avez pas assez de Robux pour effectuer un encaissement.";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "Vous serez bientôt en mesure d'échanger des Robux contre de l'argent\u00a0!";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "Vous y êtes presque\u00a0! Vous serez bientôt admissible pour échanger des Robux contre de l'argent\u00a0!";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "Tu dois vérifier ton adresse e-mail avant de pouvoir effectuer un encaissement.";
	}
}
