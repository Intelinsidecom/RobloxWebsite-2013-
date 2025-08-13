namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_zh_cjv : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "取现";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "电子邮件地址";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "汇率";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "名字";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "姓氏";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux 数额";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "你获得";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "密码";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "验证帐户密码";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "制作游戏，赚取金钱。";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "抱歉，我们无法加载当前汇率。请再试一次。";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "抱歉，有地方出错了，请再试一次。";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "请输入您的名字。";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "密码无效。";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "您的 Robux 不足，无法完成此交易。";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "请输入有效的电子邮件地址。";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "请输入您的姓氏。";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux 数额小于最低取现门槛。";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "抱歉，有地方出错了，请再试一次。";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "您取现的金额不可低于最低额度。";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "抱歉，您当前不符合取现资格。";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "您需要具备 Roblox Premium 订阅资格才能取现。";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "您需要具备经验证的电子邮件地址才能取现。";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "您需要提供您的姓氏和名字。";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "抱歉，您当前不符合取现资格。";

	public DevexCashOutResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "取现";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"在付款前，请先填写这份表格。下方提供的地址必须与 Roblox DevEx 门户网站帐户中的地址相符。填写此表如需取得进一步协助，{linkStart}请参见我们的帮助页面。{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "在付款前，请先填写这份表格。下方提供的地址必须与 Roblox DevEx 门户网站帐户中的地址相符。填写此表如需取得进一步协助，{linkStart}请参见我们的帮助页面。{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "电子邮件地址";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "汇率";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "名字";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "姓氏";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux 数额";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"我已阅读并同意{linkStart}使用条款{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "我已阅读并同意{linkStart}使用条款{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "你获得";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "密码";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "验证帐户密码";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "制作游戏，赚取金钱。";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "抱歉，我们无法加载当前汇率。请再试一次。";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "抱歉，有地方出错了，请再试一次。";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "请输入您的名字。";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "密码无效。";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "您的 Robux 不足，无法完成此交易。";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "请输入有效的电子邮件地址。";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "请输入您的姓氏。";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux 数额小于最低取现门槛。";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "抱歉，有地方出错了，请再试一次。";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "您取现的金额不可低于最低额度。";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "抱歉，您当前不符合取现资格。";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "您需要具备 Roblox Premium 订阅资格才能取现。";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "您需要具备经验证的电子邮件地址才能取现。";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "您需要提供您的姓氏和名字。";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "抱歉，您当前不符合取现资格。";
	}
}
