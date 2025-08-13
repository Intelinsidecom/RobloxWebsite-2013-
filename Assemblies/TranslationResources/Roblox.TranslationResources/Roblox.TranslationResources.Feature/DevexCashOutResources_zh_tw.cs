namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_zh_tw : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "兌現";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "電子郵件地址";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "匯率";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "名";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "姓";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux 數量";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "您最多可獲得：";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "密碼";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "驗證帳號密碼";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "創作遊戲，賺取金錢！";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "對不起，無法載入目前匯率。請重新嘗試。";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "對不起，發生錯誤。請重新嘗試。";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "請輸入您的名。";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "密碼無效。";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "您的 Robux 不足，無法完成交易。";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "請輸入有效的電子郵件地址。";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "請輸入您的姓。";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux 金額小於最低兌現金額。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "對不起，發生錯誤。請重新嘗試。";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "兌現金額無法小於最低金額。";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "對不起，您目前尚無兌現資格。";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "您需要 Roblox Premium 才能兌現。";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "您需要已驗證的電子郵件地址才能兌現。";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "請輸入您的名。";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "對不起，您目前尚無兌現資格。";

	public DevexCashOutResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "兌現";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"請完成此表格開始付款程序。您提供電子郵件的地址必須與您的 Roblox DevEx 平台帳號的電子郵件地址符合。若需更多協助，{linkStart}請前往協助中心。{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "請完成此表格開始付款程序。您提供電子郵件的地址必須與您的 Roblox DevEx 平台帳號的電子郵件地址符合。若需更多協助，{linkStart}請前往協助中心。{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "電子郵件地址";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "匯率";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "名";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "姓";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux 數量";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"我已閱讀並同意{linkStart}使用條款{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "我已閱讀並同意{linkStart}使用條款{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "您最多可獲得：";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "密碼";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "驗證帳號密碼";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "創作遊戲，賺取金錢！";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "對不起，無法載入目前匯率。請重新嘗試。";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "對不起，發生錯誤。請重新嘗試。";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "請輸入您的名。";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "密碼無效。";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "您的 Robux 不足，無法完成交易。";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "請輸入有效的電子郵件地址。";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "請輸入您的姓。";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux 金額小於最低兌現金額。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "對不起，發生錯誤。請重新嘗試。";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "兌現金額無法小於最低金額。";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "對不起，您目前尚無兌現資格。";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "您需要 Roblox Premium 才能兌現。";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "您需要已驗證的電子郵件地址才能兌現。";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "請輸入您的名。";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "對不起，您目前尚無兌現資格。";
	}
}
