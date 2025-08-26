namespace Roblox.Platform.TranslationResources.Feature {
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
	public override string CashOutFormCashOutSubmit => "í˜„ê¸ˆ ì¸ì¶œ";

	/// <summary>
	/// Key: "CashOutForm.EmailAddressLabel"
	/// English String: "Email Address"
	/// </summary>
	public override string CashOutFormEmailAddressLabel => "ì´ë©”ì¼ ì£¼ì†Œ";

	/// <summary>
	/// Key: "CashOutForm.ExchangeRateLabel"
	/// English String: "Exchange Rate"
	/// </summary>
	public override string CashOutFormExchangeRateLabel => "í™˜ìœ¨";

	/// <summary>
	/// Key: "CashOutForm.FirstNameLabel"
	/// English String: "First Name"
	/// </summary>
	public override string CashOutFormFirstNameLabel => "ì´ë¦„";

	/// <summary>
	/// Key: "CashOutForm.LastNameLabel"
	/// English String: "Last Name"
	/// </summary>
	public override string CashOutFormLastNameLabel => "ì„±";

	/// <summary>
	/// Key: "CashOutForm.Robux"
	/// English String: "Robux"
	/// </summary>
	public override string CashOutFormRobux => "Robux";

	/// <summary>
	/// Key: "CashOutForm.RobuxAmountLabel"
	/// English String: "Robux Amount"
	/// </summary>
	public override string CashOutFormRobuxAmountLabel => "Robux ê¸ˆì•¡";

	/// <summary>
	/// Key: "CashOutForm.YouGetLabel"
	/// English String: "You get up to:"
	/// </summary>
	public override string CashOutFormYouGetLabel => "ë°›ì„ ê¸ˆì•¡:";

	/// <summary>
	/// Key: "Label.PasswordLabel"
	/// English String: "Password"
	/// </summary>
	public override string LabelPasswordLabel => "ë¹„ë°€ë²ˆí˜¸";

	/// <summary>
	/// Key: "Label.PasswordPlaceholder"
	/// English String: "Verify Account Password"
	/// </summary>
	public override string LabelPasswordPlaceholder => "ê³„ì • ë¹„ë°€ë²ˆí˜¸ í™•ì¸";

	/// <summary>
	/// Key: "PageHeader.Description"
	/// English String: "Create games, earn money."
	/// </summary>
	public override string PageHeaderDescription => "ê²Œìž„ ê°œë°œì„ í†µí•´ ìˆ˜ìµ ì°½ì¶œê¹Œì§€.";

	/// <summary>
	/// Key: "PageHeader.Title"
	/// English String: "Developer Exchange"
	/// </summary>
	public override string PageHeaderTitle => "ê°œë°œìž í™˜ì „";

	/// <summary>
	/// Key: "Response.CannotLoadExchangeRate"
	/// English String: "Sorry, we were unable to load the current exchange rate. Please try again."
	/// </summary>
	public override string ResponseCannotLoadExchangeRate => "ì£„ì†¡í•©ë‹ˆë‹¤. í˜„ìž¬ í™˜ìœ¨ì„ ë¶ˆëŸ¬ì˜¤ì§€ ëª»í–ˆìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.CurrencyOperationUnavailable"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseCurrencyOperationUnavailable => "ì£„ì†¡í•©ë‹ˆë‹¤. ë¬¸ì œê°€ ë°œìƒí–ˆë„¤ìš”.\u00a0ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.FirstNameRequiredErrorMessage"
	/// English String: "Please enter your first name."
	/// </summary>
	public override string ResponseFirstNameRequiredErrorMessage => "ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.IncorrectCredentials"
	/// English String: "Invalid password."
	/// </summary>
	public override string ResponseIncorrectCredentials => "ìœ íš¨í•˜ì§€ ì•Šì€ ë¹„ë°€ë²ˆí˜¸.";

	/// <summary>
	/// Key: "Response.InsufficientFunds"
	/// English String: "You do not have enough Robux to complete this transaction."
	/// </summary>
	public override string ResponseInsufficientFunds => "Robuxê°€ ë¶€ì¡±í•´ì„œ ì´ ê±°ëž˜ë¥¼ ì™„ë£Œí•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.InvalidEmailErrorMessage"
	/// English String: "Please enter a valid email address."
	/// </summary>
	public override string ResponseInvalidEmailErrorMessage => "ìœ íš¨í•œ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.LastNameRequiredErrorMessage"
	/// English String: "Please enter your last name."
	/// </summary>
	public override string ResponseLastNameRequiredErrorMessage => "ì„±ì„ ìž…ë ¥í•˜ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.RobuxAmountIsBelowMinimumCashoutThreshold"
	/// English String: "Robux amount below minimum cash out threshold."
	/// </summary>
	public override string ResponseRobuxAmountIsBelowMinimumCashoutThreshold => "Robux ê¸ˆì•¡ì´ í˜„ê¸ˆ ì¸ì¶œ ê°€ëŠ¥í•œ ìµœì†Œ ê¸ˆì•¡ë³´ë‹¤ ì ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Sorry, something went wrong. Please try again."
	/// </summary>
	public override string ResponseUnknownError => "ì£„ì†¡í•©ë‹ˆë‹¤. ë¬¸ì œê°€ ë°œìƒí–ˆë„¤ìš”.\u00a0ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";

	/// <summary>
	/// Key: "Response.UserBalanceDoesNotHaveMoreRobuxThanMinimumCashout"
	/// English String: "You cannot cash out for less than the minimum amount."
	/// </summary>
	public override string ResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout => "ìµœì†Œ ê¸ˆì•¡ë³´ë‹¤ ì ì€ ê¸ˆì•¡ì„ ì¸ì¶œí•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UserCannotCashout"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserCannotCashout => "ì£„ì†¡í•˜ì§€ë§Œ, íšŒì›ë‹˜ì€ í˜„ìž¬ í˜„ê¸ˆì„ ì¸ì¶œí•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UserDoesNotHavePremium"
	/// English String: "You need a Roblox Premium subscription to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHavePremium => "í˜„ê¸ˆ ì¸ì¶œì„ í•˜ë ¤ë©´ Roblox Premium íšŒì›ì´ì–´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UserDoesNotHaveVerifiedEmail"
	/// English String: "You need a verified email address to cash out."
	/// </summary>
	public override string ResponseUserDoesNotHaveVerifiedEmail => "í˜„ê¸ˆ ì¸ì¶œì„ í•˜ë ¤ë©´ ì´ë©”ì¼ ì£¼ì†Œë¶€í„° ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UserMustProvideFirstAndLastName"
	/// English String: "You need to provide your first and last name."
	/// </summary>
	public override string ResponseUserMustProvideFirstAndLastName => "ì„±ê³¼ ì´ë¦„ì„ ëª¨ë‘ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.";

	/// <summary>
	/// Key: "Response.UserNotEligibleError"
	/// English String: "Sorry, you are not eligible to cash out at this time."
	/// </summary>
	public override string ResponseUserNotEligibleError => "ì£„ì†¡í•˜ì§€ë§Œ, íšŒì›ë‹˜ì€ í˜„ìž¬ í˜„ê¸ˆì„ ì¸ì¶œí•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";

	public DevexCashOutResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForCashOutFormCashOutSubmit()
	{
		return "í˜„ê¸ˆ ì¸ì¶œ";
	}

	/// <summary>
	/// Key: "CashOutForm.Description"
	/// English String: "Please complete this form to begin processing your payment. The email address you provide must match the email address on your Roblox DevEx Portal account. If you need assistance with this form, {linkStart}please visit the Help Center.{linkEnd}"
	/// </summary>
	public override string CashOutFormDescription(string linkStart, string linkEnd)
	{
		return $"ê²°ì œë¥¼ ì²˜ë¦¬í•˜ë ¤ë©´ ì´ ì–‘ì‹ì„ ìž‘ì„±í•´ ì£¼ì„¸ìš”. ì´ë•Œ ì£¼ì†ŒëŠ” ë°˜ë“œì‹œ Roblox DevEx í¬í„¸ ê³„ì •ì— ë“±ë¡ëœ ê²ƒê³¼ ì¼ì¹˜í•´ì•¼ í•©ë‹ˆë‹¤. ì–‘ì‹ ìž‘ì„±ì— ë„ì›€ì´ í•„ìš”í•˜ë‹¤ë©´ {linkStart}ë„ì›€ë§ íŽ˜ì´ì§€ë¥¼ ë°©ë¬¸í•˜ì„¸ìš”.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormDescription()
	{
		return "ê²°ì œë¥¼ ì²˜ë¦¬í•˜ë ¤ë©´ ì´ ì–‘ì‹ì„ ìž‘ì„±í•´ ì£¼ì„¸ìš”. ì´ë•Œ ì£¼ì†ŒëŠ” ë°˜ë“œì‹œ Roblox DevEx í¬í„¸ ê³„ì •ì— ë“±ë¡ëœ ê²ƒê³¼ ì¼ì¹˜í•´ì•¼ í•©ë‹ˆë‹¤. ì–‘ì‹ ìž‘ì„±ì— ë„ì›€ì´ í•„ìš”í•˜ë‹¤ë©´ {linkStart}ë„ì›€ë§ íŽ˜ì´ì§€ë¥¼ ë°©ë¬¸í•˜ì„¸ìš”.{linkEnd}";
	}

	protected override string _GetTemplateForCashOutFormEmailAddressLabel()
	{
		return "ì´ë©”ì¼ ì£¼ì†Œ";
	}

	protected override string _GetTemplateForCashOutFormExchangeRateLabel()
	{
		return "í™˜ìœ¨";
	}

	protected override string _GetTemplateForCashOutFormFirstNameLabel()
	{
		return "ì´ë¦„";
	}

	protected override string _GetTemplateForCashOutFormLastNameLabel()
	{
		return "ì„±";
	}

	protected override string _GetTemplateForCashOutFormRobux()
	{
		return "Robux";
	}

	protected override string _GetTemplateForCashOutFormRobuxAmountLabel()
	{
		return "Robux ê¸ˆì•¡";
	}

	/// <summary>
	/// Key: "CashOutForm.TermsOfService"
	/// English String: "I have read and agree to the {linkStart}Terms of Use{linkEnd}"
	/// </summary>
	public override string CashOutFormTermsOfService(string linkStart, string linkEnd)
	{
		return $"{linkStart}ì´ìš© ì•½ê´€{linkEnd}ì„ ì½ì—ˆìœ¼ë©° ì´ì— ë™ì˜í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForCashOutFormTermsOfService()
	{
		return "{linkStart}ì´ìš© ì•½ê´€{linkEnd}ì„ ì½ì—ˆìœ¼ë©° ì´ì— ë™ì˜í•©ë‹ˆë‹¤";
	}

	protected override string _GetTemplateForCashOutFormYouGetLabel()
	{
		return "ë°›ì„ ê¸ˆì•¡:";
	}

	protected override string _GetTemplateForLabelPasswordLabel()
	{
		return "ë¹„ë°€ë²ˆí˜¸";
	}

	protected override string _GetTemplateForLabelPasswordPlaceholder()
	{
		return "ê³„ì • ë¹„ë°€ë²ˆí˜¸ í™•ì¸";
	}

	protected override string _GetTemplateForPageHeaderDescription()
	{
		return "ê²Œìž„ ê°œë°œì„ í†µí•´ ìˆ˜ìµ ì°½ì¶œê¹Œì§€.";
	}

	protected override string _GetTemplateForPageHeaderTitle()
	{
		return "ê°œë°œìž í™˜ì „";
	}

	protected override string _GetTemplateForResponseCannotLoadExchangeRate()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. í˜„ìž¬ í™˜ìœ¨ì„ ë¶ˆëŸ¬ì˜¤ì§€ ëª»í–ˆìŠµë‹ˆë‹¤. ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseCurrencyOperationUnavailable()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë¬¸ì œê°€ ë°œìƒí–ˆë„¤ìš”.\u00a0ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseFirstNameRequiredErrorMessage()
	{
		return "ì´ë¦„ì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseIncorrectCredentials()
	{
		return "ìœ íš¨í•˜ì§€ ì•Šì€ ë¹„ë°€ë²ˆí˜¸.";
	}

	protected override string _GetTemplateForResponseInsufficientFunds()
	{
		return "Robuxê°€ ë¶€ì¡±í•´ì„œ ì´ ê±°ëž˜ë¥¼ ì™„ë£Œí•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseInvalidEmailErrorMessage()
	{
		return "ìœ íš¨í•œ ì´ë©”ì¼ ì£¼ì†Œë¥¼ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseLastNameRequiredErrorMessage()
	{
		return "ì„±ì„ ìž…ë ¥í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseRobuxAmountIsBelowMinimumCashoutThreshold()
	{
		return "Robux ê¸ˆì•¡ì´ í˜„ê¸ˆ ì¸ì¶œ ê°€ëŠ¥í•œ ìµœì†Œ ê¸ˆì•¡ë³´ë‹¤ ì ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUnknownError()
	{
		return "ì£„ì†¡í•©ë‹ˆë‹¤. ë¬¸ì œê°€ ë°œìƒí–ˆë„¤ìš”.\u00a0ë‹¤ì‹œ ì‹œë„í•´ ì£¼ì„¸ìš”.";
	}

	protected override string _GetTemplateForResponseUserBalanceDoesNotHaveMoreRobuxThanMinimumCashout()
	{
		return "ìµœì†Œ ê¸ˆì•¡ë³´ë‹¤ ì ì€ ê¸ˆì•¡ì„ ì¸ì¶œí•  ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUserCannotCashout()
	{
		return "ì£„ì†¡í•˜ì§€ë§Œ, íšŒì›ë‹˜ì€ í˜„ìž¬ í˜„ê¸ˆì„ ì¸ì¶œí•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHavePremium()
	{
		return "í˜„ê¸ˆ ì¸ì¶œì„ í•˜ë ¤ë©´ Roblox Premium íšŒì›ì´ì–´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUserDoesNotHaveVerifiedEmail()
	{
		return "í˜„ê¸ˆ ì¸ì¶œì„ í•˜ë ¤ë©´ ì´ë©”ì¼ ì£¼ì†Œë¶€í„° ì¸ì¦í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUserMustProvideFirstAndLastName()
	{
		return "ì„±ê³¼ ì´ë¦„ì„ ëª¨ë‘ ìž…ë ¥í•´ì•¼ í•©ë‹ˆë‹¤.";
	}

	protected override string _GetTemplateForResponseUserNotEligibleError()
	{
		return "ì£„ì†¡í•˜ì§€ë§Œ, íšŒì›ë‹˜ì€ í˜„ìž¬ í˜„ê¸ˆì„ ì¸ì¶œí•˜ì‹¤ ìˆ˜ ì—†ìŠµë‹ˆë‹¤.";
	}
}


}
