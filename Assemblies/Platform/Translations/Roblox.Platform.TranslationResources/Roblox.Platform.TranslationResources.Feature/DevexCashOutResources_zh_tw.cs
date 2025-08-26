namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string CashOutFormCashOutSubmit => "å…Œç¾";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "é›»å­éƒµä»¶åœ°å€";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "åŒ¯çŽ‡";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "å";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "å§“";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux æ•¸é‡";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "æ‚¨æœ€å¤šå¯ç²å¾—ï¼š";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "å¯†ç¢¼";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "é©—è­‰å¸³è™Ÿå¯†ç¢¼";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "å‰µä½œéŠæˆ²ï¼Œè³ºå–é‡‘éŒ¢ï¼";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "å°ä¸èµ·ï¼Œç„¡æ³•è¼‰å…¥ç›®å‰åŒ¯çŽ‡ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "å°ä¸èµ·ï¼Œç™¼ç”ŸéŒ¯èª¤ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "è«‹è¼¸å…¥æ‚¨çš„åã€‚";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "å¯†ç¢¼ç„¡æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "æ‚¨çš„ Robux ä¸è¶³ï¼Œç„¡æ³•å®Œæˆäº¤æ˜“ã€‚";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "è«‹è¼¸å…¥æœ‰æ•ˆçš„é›»å­éƒµä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "è«‹è¼¸å…¥æ‚¨çš„å§“ã€‚";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux é‡‘é¡å°æ–¼æœ€ä½Žå…Œç¾é‡‘é¡ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "å°ä¸èµ·ï¼Œç™¼ç”ŸéŒ¯èª¤ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "å…Œç¾é‡‘é¡ç„¡æ³•å°æ–¼æœ€ä½Žé‡‘é¡ã€‚";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "å°ä¸èµ·ï¼Œæ‚¨ç›®å‰å°šç„¡å…Œç¾è³‡æ ¼ã€‚";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "æ‚¨éœ€è¦ Roblox Premium æ‰èƒ½å…Œç¾ã€‚";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "æ‚¨éœ€è¦å·²é©—è­‰çš„é›»å­éƒµä»¶åœ°å€æ‰èƒ½å…Œç¾ã€‚";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "è«‹è¼¸å…¥æ‚¨çš„åã€‚";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "å°ä¸èµ·ï¼Œæ‚¨ç›®å‰å°šç„¡å…Œç¾è³‡æ ¼ã€‚";

	public DevexCashOutResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "å…Œç¾";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"è«‹å®Œæˆæ­¤è¡¨æ ¼é–‹å§‹ä»˜æ¬¾ç¨‹åºã€‚æ‚¨æä¾›é›»å­éƒµä»¶çš„åœ°å€å¿…é ˆèˆ‡æ‚¨çš„ Roblox DevEx å¹³å°å¸³è™Ÿçš„é›»å­éƒµä»¶åœ°å€ç¬¦åˆã€‚è‹¥éœ€æ›´å¤šå”åŠ©ï¼Œ{linkStart}è«‹å‰å¾€å”åŠ©ä¸­å¿ƒã€‚{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "è«‹å®Œæˆæ­¤è¡¨æ ¼é–‹å§‹ä»˜æ¬¾ç¨‹åºã€‚æ‚¨æä¾›é›»å­éƒµä»¶çš„åœ°å€å¿…é ˆèˆ‡æ‚¨çš„ Roblox DevEx å¹³å°å¸³è™Ÿçš„é›»å­éƒµä»¶åœ°å€ç¬¦åˆã€‚è‹¥éœ€æ›´å¤šå”åŠ©ï¼Œ{linkStart}è«‹å‰å¾€å”åŠ©ä¸­å¿ƒã€‚{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "é›»å­éƒµä»¶åœ°å€";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "åŒ¯çŽ‡";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "å";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "å§“";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux æ•¸é‡";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"æˆ‘å·²é–±è®€ä¸¦åŒæ„{linkStart}ä½¿ç”¨æ¢æ¬¾{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "æˆ‘å·²é–±è®€ä¸¦åŒæ„{linkStart}ä½¿ç”¨æ¢æ¬¾{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "æ‚¨æœ€å¤šå¯ç²å¾—ï¼š";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "å¯†ç¢¼";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "é©—è­‰å¸³è™Ÿå¯†ç¢¼";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "å‰µä½œéŠæˆ²ï¼Œè³ºå–é‡‘éŒ¢ï¼";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "å°ä¸èµ·ï¼Œç„¡æ³•è¼‰å…¥ç›®å‰åŒ¯çŽ‡ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "å°ä¸èµ·ï¼Œç™¼ç”ŸéŒ¯èª¤ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "è«‹è¼¸å…¥æ‚¨çš„åã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "å¯†ç¢¼ç„¡æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "æ‚¨çš„ Robux ä¸è¶³ï¼Œç„¡æ³•å®Œæˆäº¤æ˜“ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "è«‹è¼¸å…¥æœ‰æ•ˆçš„é›»å­éƒµä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "è«‹è¼¸å…¥æ‚¨çš„å§“ã€‚";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux é‡‘é¡å°æ–¼æœ€ä½Žå…Œç¾é‡‘é¡ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "å°ä¸èµ·ï¼Œç™¼ç”ŸéŒ¯èª¤ã€‚è«‹é‡æ–°å˜—è©¦ã€‚";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "å…Œç¾é‡‘é¡ç„¡æ³•å°æ–¼æœ€ä½Žé‡‘é¡ã€‚";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "å°ä¸èµ·ï¼Œæ‚¨ç›®å‰å°šç„¡å…Œç¾è³‡æ ¼ã€‚";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "æ‚¨éœ€è¦ Roblox Premium æ‰èƒ½å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "æ‚¨éœ€è¦å·²é©—è­‰çš„é›»å­éƒµä»¶åœ°å€æ‰èƒ½å…Œç¾ã€‚";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "è«‹è¼¸å…¥æ‚¨çš„åã€‚";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "å°ä¸èµ·ï¼Œæ‚¨ç›®å‰å°šç„¡å…Œç¾è³‡æ ¼ã€‚";
	}
}


}
