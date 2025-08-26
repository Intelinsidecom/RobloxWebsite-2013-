namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_zh_cn : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "ä½¿ç”¨æ¡æ¬¾åè®®";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "ä½¿ç”¨æ¡æ¬¾å·²æ›´æ”¹";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "æˆ‘åŒæ„";

	public TermsOfServiceResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "ä½¿ç”¨æ¡æ¬¾åè®®";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "ä½¿ç”¨æ¡æ¬¾å·²æ›´æ”¹";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "æˆ‘åŒæ„";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"ç‚¹æŒ‰â€œæˆ‘åŒæ„â€ï¼Œå³è¡¨ç¤ºä½ åŒæ„{tosLinkStart}ä½¿ç”¨æ¡æ¬¾{tosLinkEnd}å’Œ{privacyLinkStart}éšç§æ”¿ç­–{privacyLinkEnd}ã€‚å¦‚éœ€äº†è§£æ›´å¤šå…³äºŽæ›´æ”¹çš„å†…å®¹ï¼Œè¯·æŸ¥çœ‹{legalChangesLinkStart}æ­¤å¤„{legalChangesLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "ç‚¹æŒ‰â€œæˆ‘åŒæ„â€ï¼Œå³è¡¨ç¤ºä½ åŒæ„{tosLinkStart}ä½¿ç”¨æ¡æ¬¾{tosLinkEnd}å’Œ{privacyLinkStart}éšç§æ”¿ç­–{privacyLinkEnd}ã€‚å¦‚éœ€äº†è§£æ›´å¤šå…³äºŽæ›´æ”¹çš„å†…å®¹ï¼Œè¯·æŸ¥çœ‹{legalChangesLinkStart}æ­¤å¤„{legalChangesLinkEnd}ã€‚";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"ç‚¹æŒ‰â€œæˆ‘åŒæ„â€ï¼Œå³è¡¨ç¤ºä½ åŒæ„{tosLinkStart}ä½¿ç”¨æ¡æ¬¾{tosLinkEnd}ï¼Œä½ å°†æŽˆæƒ Roblox åœ¨çº¿ä¸Šã€çº¿ä¸‹åŠå®žä½“å•†å“ä¸Šä½¿ç”¨ä½ åœ¨ Roblox è¿‡åŽ»ä»¥åŠå°†æ¥åˆ›ä½œçš„å†…å®¹ã€‚å¦‚éœ€äº†è§£æ›´å¤šç›¸å…³æ›´æ”¹çš„å†…å®¹ï¼Œè¯·æŸ¥çœ‹{legalChangesLinkStart}æ­¤å¤„{legalChangesLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "ç‚¹æŒ‰â€œæˆ‘åŒæ„â€ï¼Œå³è¡¨ç¤ºä½ åŒæ„{tosLinkStart}ä½¿ç”¨æ¡æ¬¾{tosLinkEnd}ï¼Œä½ å°†æŽˆæƒ Roblox åœ¨çº¿ä¸Šã€çº¿ä¸‹åŠå®žä½“å•†å“ä¸Šä½¿ç”¨ä½ åœ¨ Roblox è¿‡åŽ»ä»¥åŠå°†æ¥åˆ›ä½œçš„å†…å®¹ã€‚å¦‚éœ€äº†è§£æ›´å¤šç›¸å…³æ›´æ”¹çš„å†…å®¹ï¼Œè¯·æŸ¥çœ‹{legalChangesLinkStart}æ­¤å¤„{legalChangesLinkEnd}ã€‚";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"ç‚¹æŒ‰â€œæˆ‘åŒæ„â€ï¼Œå³è¡¨ç¤ºä½ åŒæ„ {tosLinkStart}Roblox ä½¿ç”¨æ¡æ¬¾{tosLinkEnd}ã€‚ä½ å°†æŽˆæƒ Roblox åœ¨çº¿ä¸Šã€çº¿ä¸‹åŠå®žä½“å•†å“ä¸Šä½¿ç”¨ä½ åœ¨ Roblox è¿‡åŽ»ä»¥åŠå°†æ¥åˆ›ä½œçš„å†…å®¹ã€‚å¦‚éœ€äº†è§£æ›´å¤šç›¸å…³æ›´æ”¹çš„å†…å®¹ï¼Œè¯·æŸ¥çœ‹{legalChangesLinkStart}æ­¤å¤„{legalChangesLinkEnd}ã€‚";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "ç‚¹æŒ‰â€œæˆ‘åŒæ„â€ï¼Œå³è¡¨ç¤ºä½ åŒæ„ {tosLinkStart}Roblox ä½¿ç”¨æ¡æ¬¾{tosLinkEnd}ã€‚ä½ å°†æŽˆæƒ Roblox åœ¨çº¿ä¸Šã€çº¿ä¸‹åŠå®žä½“å•†å“ä¸Šä½¿ç”¨ä½ åœ¨ Roblox è¿‡åŽ»ä»¥åŠå°†æ¥åˆ›ä½œçš„å†…å®¹ã€‚å¦‚éœ€äº†è§£æ›´å¤šç›¸å…³æ›´æ”¹çš„å†…å®¹ï¼Œè¯·æŸ¥çœ‹{legalChangesLinkStart}æ­¤å¤„{legalChangesLinkEnd}ã€‚";
	}
}


}
