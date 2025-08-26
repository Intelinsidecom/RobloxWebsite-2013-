namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string CashOutFormCashOutSubmit => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆ";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "äº¤æ›ãƒ¬ãƒ¼ãƒˆ";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "ä¸‹ã®åå‰";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "è‹—å­—";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robuxé¡";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "ç²å¾—:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®èªè¨¼";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ãŠé‡‘ã‚’ç¨¼ã”ã†ã€‚";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ã‚¨ã‚¯ã‚¹ãƒã‚§ãƒ³ã‚¸";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ç¾åœ¨ã®äº¤æ›ãƒ¬ãƒ¼ãƒˆã‚’èª­ã¿è¾¼ã‚ã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "ä¸‹ã®åå‰ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "ç„¡åŠ¹ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€‚";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "RobuxãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã“ã®å–å¼•ã‚’å®Œäº†ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "æœ‰åŠ¹ãªãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "è‹—å­—ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robuxé¡ãŒæœ€ä½Žã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆé¡ä»¥ä¸‹ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "æœ€ä½Žé¡ä»¥ä¸‹ã‚’ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ç¾åœ¨ã€ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹ã«ã¯ã€Roblox Premiumã®ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹ã«ã¯èªè¨¼æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "è‹—å­—ã¨ä¸‹ã®åå‰ã®å…¥åŠ›ãŒå¿…è¦ã§ã™ã€‚";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ç¾åœ¨ã€ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";

	public DevexCashOutResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆ";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"æ”¯æ‰•ã„ã®æ‰‹ç¶šãã‚’å§‹ã‚ã‚‹ã«ã¯ã€ã“ã®ãƒ•ã‚©ãƒ¼ãƒ ã‚’å®Œäº†ã—ã¦ãã ã•ã„ã€‚ä»¥ä¸‹ã®ã‚¢ãƒ‰ãƒ¬ã‚¹ã¯Roblox DevExãƒãƒ¼ã‚¿ãƒ«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ã‚¢ãƒ‰ãƒ¬ã‚¹ã¨ä¸€è‡´ã—ã¦ã„ãªã‘ã‚Œã°ãªã‚Šã¾ã›ã‚“ã€‚ã“ã®ãƒ•ã‚©ãƒ¼ãƒ ã«é–¢ã—ã¦ãƒ˜ãƒ«ãƒ—ãŒå¿…è¦ãªå ´åˆã¯ã€{linkStart}ãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸ã‚’è¦‹ã¦ãã ã•ã„ã€‚{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "æ”¯æ‰•ã„ã®æ‰‹ç¶šãã‚’å§‹ã‚ã‚‹ã«ã¯ã€ã“ã®ãƒ•ã‚©ãƒ¼ãƒ ã‚’å®Œäº†ã—ã¦ãã ã•ã„ã€‚ä»¥ä¸‹ã®ã‚¢ãƒ‰ãƒ¬ã‚¹ã¯Roblox DevExãƒãƒ¼ã‚¿ãƒ«ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ã‚¢ãƒ‰ãƒ¬ã‚¹ã¨ä¸€è‡´ã—ã¦ã„ãªã‘ã‚Œã°ãªã‚Šã¾ã›ã‚“ã€‚ã“ã®ãƒ•ã‚©ãƒ¼ãƒ ã«é–¢ã—ã¦ãƒ˜ãƒ«ãƒ—ãŒå¿…è¦ãªå ´åˆã¯ã€{linkStart}ãƒ˜ãƒ«ãƒ—ãƒšãƒ¼ã‚¸ã‚’è¦‹ã¦ãã ã•ã„ã€‚{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "äº¤æ›ãƒ¬ãƒ¼ãƒˆ";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "ä¸‹ã®åå‰";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "è‹—å­—";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robuxé¡";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"{linkStart}åˆ©ç”¨è¦ç´„{linkEnd}ã‚’ã™ã§ã«èª­ã¿åŒæ„ã—ã¾ã™";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "{linkStart}åˆ©ç”¨è¦ç´„{linkEnd}ã‚’ã™ã§ã«èª­ã¿åŒæ„ã—ã¾ã™";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "ç²å¾—:";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "ã‚¢ã‚«ã‚¦ãƒ³ãƒˆã®ãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã®èªè¨¼";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "ã‚²ãƒ¼ãƒ ã‚’åˆ¶ä½œã—ã¦ãŠé‡‘ã‚’ç¨¼ã”ã†ã€‚";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "ãƒ‡ãƒ™ãƒ­ãƒƒãƒ‘ãƒ¼ã‚¨ã‚¯ã‚¹ãƒã‚§ãƒ³ã‚¸";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ç¾åœ¨ã®äº¤æ›ãƒ¬ãƒ¼ãƒˆã‚’èª­ã¿è¾¼ã‚ã¾ã›ã‚“ã§ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "ä¸‹ã®åå‰ã‚’å…¥åŠ›ã—ã¦ä¸‹ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "ç„¡åŠ¹ãªãƒ‘ã‚¹ãƒ¯ãƒ¼ãƒ‰ã€‚";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "RobuxãŒä¸è¶³ã—ã¦ã„ã‚‹ãŸã‚ã“ã®å–å¼•ã‚’å®Œäº†ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "æœ‰åŠ¹ãªãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "è‹—å­—ã‚’å…¥åŠ›ã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robuxé¡ãŒæœ€ä½Žã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆé¡ä»¥ä¸‹ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚å•é¡ŒãŒç™ºç”Ÿã—ã¾ã—ãŸã€‚ã‚‚ã†ä¸€åº¦ãŠè©¦ã—ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "æœ€ä½Žé¡ä»¥ä¸‹ã‚’ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹ã“ã¨ã¯ã§ãã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ç¾åœ¨ã€ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹ã«ã¯ã€Roblox Premiumã®ã‚µãƒ–ã‚¹ã‚¯ãƒªãƒ—ã‚·ãƒ§ãƒ³å¥‘ç´„ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹ã«ã¯èªè¨¼æ¸ˆã¿ã®ãƒ¡ãƒ¼ãƒ«ã‚¢ãƒ‰ãƒ¬ã‚¹ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "è‹—å­—ã¨ä¸‹ã®åå‰ã®å…¥åŠ›ãŒå¿…è¦ã§ã™ã€‚";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "ç”³ã—è¨³ã‚ã‚Šã¾ã›ã‚“ã€‚ç¾åœ¨ã€ã‚­ãƒ£ãƒƒã‚·ãƒ¥ã‚¢ã‚¦ãƒˆã™ã‚‹æ¨©é™ãŒã‚ã‚Šã¾ã›ã‚“ã€‚";
	}
}


}
