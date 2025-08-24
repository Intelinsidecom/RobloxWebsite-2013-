namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_es_es : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "Cancelar";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "Convertir en efectivo";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "Consigue ya la suscripción al OBC";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "Mejorar suscripción";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "Verificar";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "Verificar correo electrónico";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "Verificar ahora";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "Visitar DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "¡Ya casi lo tienes!";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Necesitas ser miembro del Outrageous Builder's Club para cambiar Robux por efectivo.";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "Necesitas ser miembro del Outrageous Builder's Club para convertir en efectivo.";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "Tipos de cambio actuales";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "Necesitas una dirección de correo electrónico verificada para usar DevEx.";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "En estos momentos no eres admisible.";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "No tienes suficientes Robux para convertir en efectivo.";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "¡Estás a punto de poder cambiar Robux por efectivo!";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "¡Ya casi lo tienes! Estás a punto de poder cambiar tus Robux por efectivo.";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "Debes verificar tu correo electrónico antes de convertir en efectivo.";

	public DevExHomeResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "Convertir en efectivo";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "Consigue ya la suscripción al OBC";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "Mejorar suscripción";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "Verificar correo electrónico";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "Verificar ahora";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "Visitar DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "¡Ya casi lo tienes!";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Necesitas ser miembro del Outrageous Builder's Club para cambiar Robux por efectivo.";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "Necesitas ser miembro del Outrageous Builder's Club para convertir en efectivo.";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "Tipos de cambio actuales";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "Necesitas una dirección de correo electrónico verificada para usar DevEx.";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "En estos momentos no eres admisible.";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "No tienes suficientes Robux para convertir en efectivo.";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "¡Estás a punto de poder cambiar Robux por efectivo!";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "¡Ya casi lo tienes! Estás a punto de poder cambiar tus Robux por efectivo.";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "Debes verificar tu correo electrónico antes de convertir en efectivo.";
	}
}
