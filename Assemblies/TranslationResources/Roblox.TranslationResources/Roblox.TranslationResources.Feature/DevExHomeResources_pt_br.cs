namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_pt_br : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
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
	public override string GetActionCashOut => "Retirada";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "Obter OBC agora";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "Upgrade de assinatura";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "Verificar";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "Verificar e-mail";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "Verificar agora";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "Visite DevEx";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "Quase pronto!";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Você precisa de Outrageous Builder's Club para trocar Robux por dinheiro.";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "Você precisa do Outrageous Builder's Club para fazer uma retirada.";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "Taxas de câmbio atuais";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "Você precisa de um endereço de e-mail verificado para usar DevEx.";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "Você não é elegível no momento.";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "Você não tem Robux suficientes para fazer uma retirada.";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "Você está prestes a trocar Robux por dinheiro!";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "Quase lá! Você está quase qualificado para trocar Robux por dinheiro!";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "Você precisa validar o seu e-mail antes de poder fazer uma retirada.";

	public DevExHomeResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "Cancelar";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "Retirada";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "Obter OBC agora";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "Upgrade de assinatura";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "Verificar";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "Verificar e-mail";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "Verificar agora";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "Visite DevEx";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "Quase pronto!";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Você precisa de Outrageous Builder's Club para trocar Robux por dinheiro.";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "Você precisa do Outrageous Builder's Club para fazer uma retirada.";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "Taxas de câmbio atuais";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "Você precisa de um endereço de e-mail verificado para usar DevEx.";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "Você não é elegível no momento.";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "Você não tem Robux suficientes para fazer uma retirada.";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "Você está prestes a trocar Robux por dinheiro!";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "Quase lá! Você está quase qualificado para trocar Robux por dinheiro!";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "Você precisa validar o seu e-mail antes de poder fazer uma retirada.";
	}
}
