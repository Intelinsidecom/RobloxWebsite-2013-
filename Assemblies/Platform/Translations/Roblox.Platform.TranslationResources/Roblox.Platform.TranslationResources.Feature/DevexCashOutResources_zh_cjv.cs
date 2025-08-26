namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string CashOutFormCashOutSubmit => "å–çŽ°";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "ç”µå­é‚®ä»¶åœ°å€";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "æ±‡çŽ‡";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "åå­—";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "å§“æ°";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux æ•°é¢";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "ä½ èŽ·å¾—";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "å¯†ç ";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "éªŒè¯å¸æˆ·å¯†ç ";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "åˆ¶ä½œæ¸¸æˆï¼Œèµšå–é‡‘é’±ã€‚";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "Developer Exchange";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "æŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•åŠ è½½å½“å‰æ±‡çŽ‡ã€‚è¯·å†è¯•ä¸€æ¬¡ã€‚";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "æŠ±æ­‰ï¼Œæœ‰åœ°æ–¹å‡ºé”™äº†ï¼Œè¯·å†è¯•ä¸€æ¬¡ã€‚";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "è¯·è¾“å…¥æ‚¨çš„åå­—ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "å¯†ç æ— æ•ˆã€‚";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "æ‚¨çš„ Robux ä¸è¶³ï¼Œæ— æ³•å®Œæˆæ­¤äº¤æ˜“ã€‚";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "è¯·è¾“å…¥æœ‰æ•ˆçš„ç”µå­é‚®ä»¶åœ°å€ã€‚";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "è¯·è¾“å…¥æ‚¨çš„å§“æ°ã€‚";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux æ•°é¢å°äºŽæœ€ä½Žå–çŽ°é—¨æ§›ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "æŠ±æ­‰ï¼Œæœ‰åœ°æ–¹å‡ºé”™äº†ï¼Œè¯·å†è¯•ä¸€æ¬¡ã€‚";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "æ‚¨å–çŽ°çš„é‡‘é¢ä¸å¯ä½ŽäºŽæœ€ä½Žé¢åº¦ã€‚";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "æŠ±æ­‰ï¼Œæ‚¨å½“å‰ä¸ç¬¦åˆå–çŽ°èµ„æ ¼ã€‚";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "æ‚¨éœ€è¦å…·å¤‡ Roblox Premium è®¢é˜…èµ„æ ¼æ‰èƒ½å–çŽ°ã€‚";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "æ‚¨éœ€è¦å…·å¤‡ç»éªŒè¯çš„ç”µå­é‚®ä»¶åœ°å€æ‰èƒ½å–çŽ°ã€‚";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "æ‚¨éœ€è¦æä¾›æ‚¨çš„å§“æ°å’Œåå­—ã€‚";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "æŠ±æ­‰ï¼Œæ‚¨å½“å‰ä¸ç¬¦åˆå–çŽ°èµ„æ ¼ã€‚";

	public DevexCashOutResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "å–çŽ°";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"åœ¨ä»˜æ¬¾å‰ï¼Œè¯·å…ˆå¡«å†™è¿™ä»½è¡¨æ ¼ã€‚ä¸‹æ–¹æä¾›çš„åœ°å€å¿…é¡»ä¸Ž Roblox DevEx é—¨æˆ·ç½‘ç«™å¸æˆ·ä¸­çš„åœ°å€ç›¸ç¬¦ã€‚å¡«å†™æ­¤è¡¨å¦‚éœ€å–å¾—è¿›ä¸€æ­¥ååŠ©ï¼Œ{linkStart}è¯·å‚è§æˆ‘ä»¬çš„å¸®åŠ©é¡µé¢ã€‚{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "åœ¨ä»˜æ¬¾å‰ï¼Œè¯·å…ˆå¡«å†™è¿™ä»½è¡¨æ ¼ã€‚ä¸‹æ–¹æä¾›çš„åœ°å€å¿…é¡»ä¸Ž Roblox DevEx é—¨æˆ·ç½‘ç«™å¸æˆ·ä¸­çš„åœ°å€ç›¸ç¬¦ã€‚å¡«å†™æ­¤è¡¨å¦‚éœ€å–å¾—è¿›ä¸€æ­¥ååŠ©ï¼Œ{linkStart}è¯·å‚è§æˆ‘ä»¬çš„å¸®åŠ©é¡µé¢ã€‚{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "ç”µå­é‚®ä»¶åœ°å€";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "æ±‡çŽ‡";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "åå­—";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "å§“æ°";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux æ•°é¢";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"æˆ‘å·²é˜…è¯»å¹¶åŒæ„{linkStart}ä½¿ç”¨æ¡æ¬¾{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "æˆ‘å·²é˜…è¯»å¹¶åŒæ„{linkStart}ä½¿ç”¨æ¡æ¬¾{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "ä½ èŽ·å¾—";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "å¯†ç ";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "éªŒè¯å¸æˆ·å¯†ç ";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "åˆ¶ä½œæ¸¸æˆï¼Œèµšå–é‡‘é’±ã€‚";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "Developer Exchange";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "æŠ±æ­‰ï¼Œæˆ‘ä»¬æ— æ³•åŠ è½½å½“å‰æ±‡çŽ‡ã€‚è¯·å†è¯•ä¸€æ¬¡ã€‚";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "æŠ±æ­‰ï¼Œæœ‰åœ°æ–¹å‡ºé”™äº†ï¼Œè¯·å†è¯•ä¸€æ¬¡ã€‚";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "è¯·è¾“å…¥æ‚¨çš„åå­—ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "å¯†ç æ— æ•ˆã€‚";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "æ‚¨çš„ Robux ä¸è¶³ï¼Œæ— æ³•å®Œæˆæ­¤äº¤æ˜“ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "è¯·è¾“å…¥æœ‰æ•ˆçš„ç”µå­é‚®ä»¶åœ°å€ã€‚";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "è¯·è¾“å…¥æ‚¨çš„å§“æ°ã€‚";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux æ•°é¢å°äºŽæœ€ä½Žå–çŽ°é—¨æ§›ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "æŠ±æ­‰ï¼Œæœ‰åœ°æ–¹å‡ºé”™äº†ï¼Œè¯·å†è¯•ä¸€æ¬¡ã€‚";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "æ‚¨å–çŽ°çš„é‡‘é¢ä¸å¯ä½ŽäºŽæœ€ä½Žé¢åº¦ã€‚";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "æŠ±æ­‰ï¼Œæ‚¨å½“å‰ä¸ç¬¦åˆå–çŽ°èµ„æ ¼ã€‚";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "æ‚¨éœ€è¦å…·å¤‡ Roblox Premium è®¢é˜…èµ„æ ¼æ‰èƒ½å–çŽ°ã€‚";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "æ‚¨éœ€è¦å…·å¤‡ç»éªŒè¯çš„ç”µå­é‚®ä»¶åœ°å€æ‰èƒ½å–çŽ°ã€‚";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "æ‚¨éœ€è¦æä¾›æ‚¨çš„å§“æ°å’Œåå­—ã€‚";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "æŠ±æ­‰ï¼Œæ‚¨å½“å‰ä¸ç¬¦åˆå–çŽ°èµ„æ ¼ã€‚";
	}
}


}
