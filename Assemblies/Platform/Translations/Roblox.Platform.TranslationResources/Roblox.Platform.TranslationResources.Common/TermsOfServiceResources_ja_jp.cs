namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_ja_jp : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "åˆ©ç”¨è¦ç´„ã®åŒæ„";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "åˆ©ç”¨è¦ç´„ãŒå¤‰æ›´ã•ã‚Œã¾ã—ãŸ";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "åŒæ„ã™ã‚‹";

	public TermsOfServiceResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "åˆ©ç”¨è¦ç´„ã®åŒæ„";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "åˆ©ç”¨è¦ç´„ãŒå¤‰æ›´ã•ã‚Œã¾ã—ãŸ";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "åŒæ„ã™ã‚‹";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"ã€ŒåŒæ„ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã“ã¨ã§ã€{tosLinkStart}åˆ©ç”¨è¦ç´„{tosLinkEnd} ã¨ {privacyLinkStart}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼{legalChangesLinkEnd} ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚å¤‰æ›´å†…å®¹ã®è©³ç´°ã¯ã€ {privacyLinkEnd}ã“ã¡ã‚‰{legalChangesLinkStart} ã§ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "ã€ŒåŒæ„ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã“ã¨ã§ã€{tosLinkStart}åˆ©ç”¨è¦ç´„{tosLinkEnd} ã¨ {privacyLinkStart}ãƒ—ãƒ©ã‚¤ãƒã‚·ãƒ¼ãƒãƒªã‚·ãƒ¼{legalChangesLinkEnd} ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚å¤‰æ›´å†…å®¹ã®è©³ç´°ã¯ã€ {privacyLinkEnd}ã“ã¡ã‚‰{legalChangesLinkStart} ã§ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"ã€ŒåŒæ„ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã“ã¨ã§ã€ {tosLinkStart}åˆ©ç”¨è¦ç´„{tosLinkEnd} ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚ã“ã‚Œã«ã¯ã€ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã€ã‚ªãƒ•ãƒ©ã‚¤ãƒ³ï¼ˆæœ‰å½¢ã‚¢ã‚¤ãƒ†ãƒ ãªã©ï¼‰ã§ä½¿ç”¨ã™ã‚‹ãŸã‚ã«ã‚µãƒ¼ãƒ“ã‚¹ã«å¯¾ã—ã¦ã‚ãªãŸãŒæä¾›ã™ã‚‹Robloxã®éŽåŽ»ãŠã‚ˆã³å°†æ¥ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ãƒ©ã‚¤ã‚»ãƒ³ã‚¹ã‚’å«ã¿ã¾ã™ã€‚å¤‰æ›´å†…å®¹ã®è©³ç´°ã¯ã€ {legalChangesLinkStart}ã“ã¡ã‚‰{legalChangesLinkEnd} ã§ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "ã€ŒåŒæ„ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã“ã¨ã§ã€ {tosLinkStart}åˆ©ç”¨è¦ç´„{tosLinkEnd} ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚ã“ã‚Œã«ã¯ã€ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã€ã‚ªãƒ•ãƒ©ã‚¤ãƒ³ï¼ˆæœ‰å½¢ã‚¢ã‚¤ãƒ†ãƒ ãªã©ï¼‰ã§ä½¿ç”¨ã™ã‚‹ãŸã‚ã«ã‚µãƒ¼ãƒ“ã‚¹ã«å¯¾ã—ã¦ã‚ãªãŸãŒæä¾›ã™ã‚‹Robloxã®éŽåŽ»ãŠã‚ˆã³å°†æ¥ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ãƒ©ã‚¤ã‚»ãƒ³ã‚¹ã‚’å«ã¿ã¾ã™ã€‚å¤‰æ›´å†…å®¹ã®è©³ç´°ã¯ã€ {legalChangesLinkStart}ã“ã¡ã‚‰{legalChangesLinkEnd} ã§ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"ã€ŒåŒæ„ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã“ã¨ã§ã€ {tosLinkStart}Robloxã®åˆ©ç”¨è¦ç´„{tosLinkEnd} ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚ã“ã‚Œã«ã¯ã€å½“ç¤¾ã®ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã€ã‚ªãƒ•ãƒ©ã‚¤ãƒ³ã€æœ‰å½¢ã‚¢ã‚¤ãƒ†ãƒ ã®ã‚µãƒ¼ãƒ“ã‚¹ã«å¯¾ã—ã¦ã‚ãªãŸãŒæä¾›ã™ã‚‹Robloxã®éŽåŽ»ãŠã‚ˆã³å°†æ¥ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ãƒ©ã‚¤ã‚»ãƒ³ã‚¹ã‚’å«ã¿ã¾ã™ã€‚å¤‰æ›´å†…å®¹ã®è©³ç´°ã¯ã€ {legalChangesLinkStart}ã“ã¡ã‚‰{legalChangesLinkEnd} ã§ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "ã€ŒåŒæ„ã™ã‚‹ã€ã‚’ã‚¯ãƒªãƒƒã‚¯ã™ã‚‹ã“ã¨ã§ã€ {tosLinkStart}Robloxã®åˆ©ç”¨è¦ç´„{tosLinkEnd} ã«åŒæ„ã—ãŸã‚‚ã®ã¨ã¿ãªã•ã‚Œã¾ã™ã€‚ã“ã‚Œã«ã¯ã€å½“ç¤¾ã®ã‚ªãƒ³ãƒ©ã‚¤ãƒ³ã€ã‚ªãƒ•ãƒ©ã‚¤ãƒ³ã€æœ‰å½¢ã‚¢ã‚¤ãƒ†ãƒ ã®ã‚µãƒ¼ãƒ“ã‚¹ã«å¯¾ã—ã¦ã‚ãªãŸãŒæä¾›ã™ã‚‹Robloxã®éŽåŽ»ãŠã‚ˆã³å°†æ¥ã®ã‚³ãƒ³ãƒ†ãƒ³ãƒ„ã®ãƒ©ã‚¤ã‚»ãƒ³ã‚¹ã‚’å«ã¿ã¾ã™ã€‚å¤‰æ›´å†…å®¹ã®è©³ç´°ã¯ã€ {legalChangesLinkStart}ã“ã¡ã‚‰{legalChangesLinkEnd} ã§ç¢ºèªã—ã¦ãã ã•ã„ã€‚";
	}
}


}
