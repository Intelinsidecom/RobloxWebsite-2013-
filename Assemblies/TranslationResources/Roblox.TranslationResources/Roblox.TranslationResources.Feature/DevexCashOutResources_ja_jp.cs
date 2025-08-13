namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_ja_jp : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "キャッシュアウト";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "メールアドレス";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "交換レート";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "下の名前";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "苗字";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux額";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "獲得:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "パスワード";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "アカウントのパスワードの認証";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "ゲームを制作してお金を稼ごう。";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "デベロッパーエクスチェンジ";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "申し訳ありません。現在の交換レートを読み込めませんでした。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "申し訳ありません。問題が発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "下の名前を入力して下さい。";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "無効なパスワード。";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "Robuxが不足しているためこの取引を完了できません。";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "有効なメールアドレスを入力してください。";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "苗字を入力してください。";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux額が最低キャッシュアウト額以下です。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "申し訳ありません。問題が発生しました。もう一度お試しください。";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "最低額以下をキャッシュアウトすることはできません。";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "申し訳ありません。現在、キャッシュアウトする権限がありません。";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "キャッシュアウトするには、Roblox Premiumのサブスクリプション契約が必要です。";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "キャッシュアウトするには認証済みのメールアドレスが必要です。";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "苗字と下の名前の入力が必要です。";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "申し訳ありません。現在、キャッシュアウトする権限がありません。";

	public DevexCashOutResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "キャッシュアウト";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"支払いの手続きを始めるには、このフォームを完了してください。以下のアドレスはRoblox DevExポータルアカウントのアドレスと一致していなければなりません。このフォームに関してヘルプが必要な場合は、{linkStart}ヘルプページを見てください。{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "支払いの手続きを始めるには、このフォームを完了してください。以下のアドレスはRoblox DevExポータルアカウントのアドレスと一致していなければなりません。このフォームに関してヘルプが必要な場合は、{linkStart}ヘルプページを見てください。{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "メールアドレス";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "交換レート";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "下の名前";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "苗字";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux額";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"{linkStart}利用規約{linkEnd}をすでに読み同意します";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "{linkStart}利用規約{linkEnd}をすでに読み同意します";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "獲得:";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "パスワード";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "アカウントのパスワードの認証";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "ゲームを制作してお金を稼ごう。";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "デベロッパーエクスチェンジ";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "申し訳ありません。現在の交換レートを読み込めませんでした。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "申し訳ありません。問題が発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "下の名前を入力して下さい。";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "無効なパスワード。";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "Robuxが不足しているためこの取引を完了できません。";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "有効なメールアドレスを入力してください。";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "苗字を入力してください。";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux額が最低キャッシュアウト額以下です。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "申し訳ありません。問題が発生しました。もう一度お試しください。";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "最低額以下をキャッシュアウトすることはできません。";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "申し訳ありません。現在、キャッシュアウトする権限がありません。";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "キャッシュアウトするには、Roblox Premiumのサブスクリプション契約が必要です。";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "キャッシュアウトするには認証済みのメールアドレスが必要です。";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "苗字と下の名前の入力が必要です。";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "申し訳ありません。現在、キャッシュアウトする権限がありません。";
	}
}
