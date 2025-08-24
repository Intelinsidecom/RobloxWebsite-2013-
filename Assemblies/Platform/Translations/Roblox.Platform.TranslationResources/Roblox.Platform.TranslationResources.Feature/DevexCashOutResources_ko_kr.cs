namespace Roblox.TranslationResources.Feature;

/// <summary>
/// This class overrides DevexCashOutResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class DevexCashOutResources_ko_kr : DevexCashOutResources_en_us, IDevexCashOutResources, ITranslationResources
{
	/// <summary>
	/// Key: "CashOutForm.CashOutSubmit"
	/// English String: "Cash Out"
	/// </summary>
	public override string CashOutFormCashOutSubmit => "현금 인출";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "이메일 주소";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "환율";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "이름";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "성";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux 금액";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "받을 금액:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "비밀번호";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "계정 비밀번호 확인";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "게임 개발을 통해 수익 창출까지.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "개발자 환전";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "죄송합니다. 현재 환율을 불러오지 못했습니다. 다시 시도해 주세요.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "죄송합니다. 문제가 발생했네요.\u00a0다시 시도해 주세요.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "이름을 입력하세요.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "유효하지 않은 비밀번호.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "Robux가 부족해서 이 거래를 완료할 수 없습니다.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "유효한 이메일 주소를 입력하세요.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "성을 입력하세요.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux 금액이 현금 인출 가능한 최소 금액보다 적습니다.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "죄송합니다. 문제가 발생했네요.\u00a0다시 시도해 주세요.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "최소 금액보다 적은 금액을 인출할 수 없습니다.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "죄송하지만, 회원님은 현재 현금을 인출하실 수 없습니다.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "현금 인출을 하려면 Roblox Premium 회원이어야 합니다.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "현금 인출을 하려면 이메일 주소부터 인증해야 합니다.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "성과 이름을 모두 입력해야 합니다.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "죄송하지만, 회원님은 현재 현금을 인출하실 수 없습니다.";

	public DevexCashOutResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "현금 인출";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"결제를 처리하려면 이 양식을 작성해 주세요. 이때 주소는 반드시 Roblox DevEx 포털 계정에 등록된 것과 일치해야 합니다. 양식 작성에 도움이 필요하다면 {linkStart}도움말 페이지를 방문하세요.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "결제를 처리하려면 이 양식을 작성해 주세요. 이때 주소는 반드시 Roblox DevEx 포털 계정에 등록된 것과 일치해야 합니다. 양식 작성에 도움이 필요하다면 {linkStart}도움말 페이지를 방문하세요.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "이메일 주소";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "환율";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "이름";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "성";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux 금액";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"{linkStart}이용 약관{linkEnd}을 읽었으며 이에 동의합니다";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "{linkStart}이용 약관{linkEnd}을 읽었으며 이에 동의합니다";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "받을 금액:";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "비밀번호";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "계정 비밀번호 확인";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "게임 개발을 통해 수익 창출까지.";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "개발자 환전";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "죄송합니다. 현재 환율을 불러오지 못했습니다. 다시 시도해 주세요.";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "죄송합니다. 문제가 발생했네요.\u00a0다시 시도해 주세요.";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "이름을 입력하세요.";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "유효하지 않은 비밀번호.";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "Robux가 부족해서 이 거래를 완료할 수 없습니다.";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "유효한 이메일 주소를 입력하세요.";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "성을 입력하세요.";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux 금액이 현금 인출 가능한 최소 금액보다 적습니다.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "죄송합니다. 문제가 발생했네요.\u00a0다시 시도해 주세요.";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "최소 금액보다 적은 금액을 인출할 수 없습니다.";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "죄송하지만, 회원님은 현재 현금을 인출하실 수 없습니다.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "현금 인출을 하려면 Roblox Premium 회원이어야 합니다.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "현금 인출을 하려면 이메일 주소부터 인증해야 합니다.";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "성과 이름을 모두 입력해야 합니다.";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "죄송하지만, 회원님은 현재 현금을 인출하실 수 없습니다.";
	}
}
