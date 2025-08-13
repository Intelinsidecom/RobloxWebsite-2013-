namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevExHomeResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevExHomeResources_ja_jp : DevExHomeResources_en_us, IDevExHomeResources, ITranslationResources
{
	/// <summary>
	/// Key: "GetActionCancel"
	/// English String: "Cancel"
	/// </summary>
	public override string GetActionCancel => "キャンセル";

	/// <summary>
	/// Key: "GetActionCashOut"
	/// English String: "Cash Out"
	/// </summary>
	public override string GetActionCashOut => "キャッシュアウト";

	/// <summary>
	/// Key: "GetActionGetObc"
	/// English String: "Get OBC Now"
	/// </summary>
	public override string GetActionGetObc => "今すぐOBCをゲット";

	/// <summary>
	/// Key: "GetActionUpgradeMembership"
	/// English String: "Upgrade Membership"
	/// </summary>
	public override string GetActionUpgradeMembership => "メンバーシップをアップグレード";

	/// <summary>
	/// Key: "GetActionVerify"
	/// English String: "Verify"
	/// </summary>
	public override string GetActionVerify => "認証";

	/// <summary>
	/// Key: "GetActionVerifyEmail"
	/// English String: "Verify Email"
	/// </summary>
	public override string GetActionVerifyEmail => "メールアドレスを認証";

	/// <summary>
	/// Key: "GetActionVerifyNow"
	/// English String: "Verify Now"
	/// </summary>
	public override string GetActionVerifyNow => "今すぐ認証";

	/// <summary>
	/// Key: "GetActionVisitDevEx"
	/// English String: "Visit DevEx"
	/// </summary>
	public override string GetActionVisitDevEx => "DevExにアクセス";

	/// <summary>
	/// Key: "GetLabelAlmostReady"
	/// English String: "You're almost ready!"
	/// </summary>
	public override string GetLabelAlmostReady => "あと少しです！";

	/// <summary>
	/// Key: "GetLabelBuilderClubForCash"
	/// English String: "You'll need Outrageous Builder's Club to exchange Robux for cash."
	/// </summary>
	public override string GetLabelBuilderClubForCash => "Robuxを現金に交換するには、Outrageous Builders Clubが必要です。";

	/// <summary>
	/// Key: "GetLabelBuildersCludForCashout"
	/// English String: "You need Outrageous Builders Club to Cash Out."
	/// </summary>
	public override string GetLabelBuildersCludForCashout => "キャッシュアウトには、Outrageous Builders Clubが必要です。";

	/// <summary>
	/// Key: "GetLabelCurrentExchangeRate"
	/// English String: "Current Exchange Rates"
	/// </summary>
	public override string GetLabelCurrentExchangeRate => "現在の交換レート";

	/// <summary>
	/// Key: "GetLabelNeedVerifiedEmail"
	/// English String: "You need a verified email address to use DevEx."
	/// </summary>
	public override string GetLabelNeedVerifiedEmail => "DevExを使うには認証済みのメールアドレスが必要です。";

	/// <summary>
	/// Key: "GetLabelNotEligible"
	/// English String: "You are not eligible currently."
	/// </summary>
	public override string GetLabelNotEligible => "現在、権限がありません。";

	/// <summary>
	/// Key: "GetLabelNotEnoughRobuxForCashout"
	/// English String: "You don't have enough Robux to Cash Out."
	/// </summary>
	public override string GetLabelNotEnoughRobuxForCashout => "Robuxが不足しているためキャッシュアウトできません。";

	/// <summary>
	/// Key: "GetLabelRobux"
	/// English String: "Robux"
	/// </summary>
	public override string GetLabelRobux => "Robux";

	/// <summary>
	/// Key: "GetLabelTradingRobux"
	/// English String: "You're on your way to trading Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobux => "もうすぐRobuxを現金と交換できるようになります！";

	/// <summary>
	/// Key: "GetLabelTradingRobuxCash"
	/// English String: "You're almost there! You almost qualify to trade your Robux for cash!"
	/// </summary>
	public override string GetLabelTradingRobuxCash => "もう少しです！あと少しでRobuxを現金と交換できるようになります！";

	/// <summary>
	/// Key: "GetLabelVerifiedEmailForCashout"
	/// English String: "You must verify your email before you can cash out."
	/// </summary>
	public override string GetLabelVerifiedEmailForCashout => "キャッシュアウトする前に、メールアドレスの認証が必要です。";

	public DevExHomeResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForGetActionCancel()
	{
		return "キャンセル";
	}

	protected override string _GetTemplateForGetActionCashOut()
	{
		return "キャッシュアウト";
	}

	protected override string _GetTemplateForGetActionGetObc()
	{
		return "今すぐOBCをゲット";
	}

	protected override string _GetTemplateForGetActionUpgradeMembership()
	{
		return "メンバーシップをアップグレード";
	}

	protected override string _GetTemplateForGetActionVerify()
	{
		return "認証";
	}

	protected override string _GetTemplateForGetActionVerifyEmail()
	{
		return "メールアドレスを認証";
	}

	protected override string _GetTemplateForGetActionVerifyNow()
	{
		return "今すぐ認証";
	}

	protected override string _GetTemplateForGetActionVisitDevEx()
	{
		return "DevExにアクセス";
	}

	protected override string _GetTemplateForGetLabelAlmostReady()
	{
		return "あと少しです！";
	}

	protected override string _GetTemplateForGetLabelBuilderClubForCash()
	{
		return "Robuxを現金に交換するには、Outrageous Builders Clubが必要です。";
	}

	protected override string _GetTemplateForGetLabelBuildersCludForCashout()
	{
		return "キャッシュアウトには、Outrageous Builders Clubが必要です。";
	}

	protected override string _GetTemplateForGetLabelCurrentExchangeRate()
	{
		return "現在の交換レート";
	}

	protected override string _GetTemplateForGetLabelNeedVerifiedEmail()
	{
		return "DevExを使うには認証済みのメールアドレスが必要です。";
	}

	protected override string _GetTemplateForGetLabelNotEligible()
	{
		return "現在、権限がありません。";
	}

	protected override string _GetTemplateForGetLabelNotEnoughRobuxForCashout()
	{
		return "Robuxが不足しているためキャッシュアウトできません。";
	}

	protected override string _GetTemplateForGetLabelRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForGetLabelTradingRobux()
	{
		return "もうすぐRobuxを現金と交換できるようになります！";
	}

	protected override string _GetTemplateForGetLabelTradingRobuxCash()
	{
		return "もう少しです！あと少しでRobuxを現金と交換できるようになります！";
	}

	protected override string _GetTemplateForGetLabelVerifiedEmailForCashout()
	{
		return "キャッシュアウトする前に、メールアドレスの認証が必要です。";
	}
}
