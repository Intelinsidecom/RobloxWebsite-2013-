namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_ko_kr : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "ì´ìš© ì•½ê´€ ë™ì˜";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "ì´ìš© ì•½ê´€ì´ ë³€ê²½ë˜ì—ˆìŠµë‹ˆë‹¤";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "ë™ì˜";

	public TermsOfServiceResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "ì´ìš© ì•½ê´€ ë™ì˜";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "ì´ìš© ì•½ê´€ì´ ë³€ê²½ë˜ì—ˆìŠµë‹ˆë‹¤";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "ë™ì˜";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"'ë™ì˜'ë¥¼ í´ë¦­í•˜ë©´ {tosLinkStart}ì´ìš© ì•½ê´€{tosLinkEnd} ë° {privacyLinkStart}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{privacyLinkEnd}ì— ë™ì˜í•˜ê²Œ ë©ë‹ˆë‹¤. ìžì„¸í•œ ë³€ê²½ ì‚¬í•­ì€ {legalChangesLinkStart}ì—¬ê¸°{legalChangesLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "'ë™ì˜'ë¥¼ í´ë¦­í•˜ë©´ {tosLinkStart}ì´ìš© ì•½ê´€{tosLinkEnd} ë° {privacyLinkStart}ê°œì¸ì •ë³´ ì²˜ë¦¬ë°©ì¹¨{privacyLinkEnd}ì— ë™ì˜í•˜ê²Œ ë©ë‹ˆë‹¤. ìžì„¸í•œ ë³€ê²½ ì‚¬í•­ì€ {legalChangesLinkStart}ì—¬ê¸°{legalChangesLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"'ë™ì˜'ë¥¼ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì´ {tosLinkStart}ì´ìš© ì•½ê´€{tosLinkEnd}ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë˜ë©°, ì´ëŠ” íšŒì›ë‹˜ì´ Robloxì— ê³¼ê±°ì— ì œê³µí–ˆìœ¼ë©° ë¯¸ëž˜ì— ì œê³µí•  ì½˜í…ì¸ ë¥¼ Robloxê°€ ì˜¨ë¼ì¸ ë° ì˜¤í”„ë¼ì¸ì—ì„œ (ìœ í˜• ì•„ì´í…œ ë“±) ì‚¬ìš©í•  ìˆ˜ ìžˆë„ë¡ í—ˆê°€í•˜ëŠ” ë¼ì´ì„ ìŠ¤ë¥¼ í¬í•¨í•©ë‹ˆë‹¤. ìžì„¸í•œ ë³€ê²½ ì‚¬í•­ì€ {legalChangesLinkStart}ì—¬ê¸°{legalChangesLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "'ë™ì˜'ë¥¼ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì´ {tosLinkStart}ì´ìš© ì•½ê´€{tosLinkEnd}ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë˜ë©°, ì´ëŠ” íšŒì›ë‹˜ì´ Robloxì— ê³¼ê±°ì— ì œê³µí–ˆìœ¼ë©° ë¯¸ëž˜ì— ì œê³µí•  ì½˜í…ì¸ ë¥¼ Robloxê°€ ì˜¨ë¼ì¸ ë° ì˜¤í”„ë¼ì¸ì—ì„œ (ìœ í˜• ì•„ì´í…œ ë“±) ì‚¬ìš©í•  ìˆ˜ ìžˆë„ë¡ í—ˆê°€í•˜ëŠ” ë¼ì´ì„ ìŠ¤ë¥¼ í¬í•¨í•©ë‹ˆë‹¤. ìžì„¸í•œ ë³€ê²½ ì‚¬í•­ì€ {legalChangesLinkStart}ì—¬ê¸°{legalChangesLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"'ë™ì˜'ë¥¼ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì´ {tosLinkStart}Roblox ì´ìš© ì•½ê´€{tosLinkEnd}ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤. ë³¸ ì•½ê´€ì€ íšŒì›ë‹˜ì´ Robloxì— ê³¼ê±°ì— ì œê³µí–ˆìœ¼ë©° ë¯¸ëž˜ì— ì œê³µí•  ì½˜í…ì¸ ë¥¼ Robloxê°€ ì˜¨ë¼ì¸, ì˜¤í”„ë¼ì¸ ìš©ë„ ë° ìœ í˜• ì•„ì´í…œì— ì‚¬ìš©í•  ìˆ˜ ìžˆë„ë¡ í—ˆê°€í•˜ëŠ” ë¼ì´ì„ ìŠ¤ë¥¼ í¬í•¨í•©ë‹ˆë‹¤. ìžì„¸í•œ ë³€ê²½ ì‚¬í•­ì€ {legalChangesLinkStart}ì—¬ê¸°{legalChangesLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "'ë™ì˜'ë¥¼ í´ë¦­í•˜ë©´ íšŒì›ë‹˜ì´ {tosLinkStart}Roblox ì´ìš© ì•½ê´€{tosLinkEnd}ì— ë™ì˜í•˜ëŠ” ê²ƒìœ¼ë¡œ ê°„ì£¼ë©ë‹ˆë‹¤. ë³¸ ì•½ê´€ì€ íšŒì›ë‹˜ì´ Robloxì— ê³¼ê±°ì— ì œê³µí–ˆìœ¼ë©° ë¯¸ëž˜ì— ì œê³µí•  ì½˜í…ì¸ ë¥¼ Robloxê°€ ì˜¨ë¼ì¸, ì˜¤í”„ë¼ì¸ ìš©ë„ ë° ìœ í˜• ì•„ì´í…œì— ì‚¬ìš©í•  ìˆ˜ ìžˆë„ë¡ í—ˆê°€í•˜ëŠ” ë¼ì´ì„ ìŠ¤ë¥¼ í¬í•¨í•©ë‹ˆë‹¤. ìžì„¸í•œ ë³€ê²½ ì‚¬í•­ì€ {legalChangesLinkStart}ì—¬ê¸°{legalChangesLinkEnd}ì—ì„œ í™•ì¸í•˜ì„¸ìš”.";
	}
}


}
