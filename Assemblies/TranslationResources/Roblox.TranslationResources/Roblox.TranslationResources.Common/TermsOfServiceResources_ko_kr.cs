namespace Roblox.TranslationResources.Common;

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
	public override string HeadingTosAgreementTitle => "이용 약관 동의";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "이용 약관이 변경되었습니다";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "동의";

	public TermsOfServiceResources_ko_kr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "이용 약관 동의";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "이용 약관이 변경되었습니다";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "동의";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"'동의'를 클릭하면 {tosLinkStart}이용 약관{tosLinkEnd} 및 {privacyLinkStart}개인정보 처리방침{privacyLinkEnd}에 동의하게 됩니다. 자세한 변경 사항은 {legalChangesLinkStart}여기{legalChangesLinkEnd}에서 확인하세요.";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "'동의'를 클릭하면 {tosLinkStart}이용 약관{tosLinkEnd} 및 {privacyLinkStart}개인정보 처리방침{privacyLinkEnd}에 동의하게 됩니다. 자세한 변경 사항은 {legalChangesLinkStart}여기{legalChangesLinkEnd}에서 확인하세요.";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"'동의'를 클릭하면 회원님이 {tosLinkStart}이용 약관{tosLinkEnd}에 동의하는 것으로 간주되며, 이는 회원님이 Roblox에 과거에 제공했으며 미래에 제공할 콘텐츠를 Roblox가 온라인 및 오프라인에서 (유형 아이템 등) 사용할 수 있도록 허가하는 라이선스를 포함합니다. 자세한 변경 사항은 {legalChangesLinkStart}여기{legalChangesLinkEnd}에서 확인하세요.";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "'동의'를 클릭하면 회원님이 {tosLinkStart}이용 약관{tosLinkEnd}에 동의하는 것으로 간주되며, 이는 회원님이 Roblox에 과거에 제공했으며 미래에 제공할 콘텐츠를 Roblox가 온라인 및 오프라인에서 (유형 아이템 등) 사용할 수 있도록 허가하는 라이선스를 포함합니다. 자세한 변경 사항은 {legalChangesLinkStart}여기{legalChangesLinkEnd}에서 확인하세요.";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"'동의'를 클릭하면 회원님이 {tosLinkStart}Roblox 이용 약관{tosLinkEnd}에 동의하는 것으로 간주됩니다. 본 약관은 회원님이 Roblox에 과거에 제공했으며 미래에 제공할 콘텐츠를 Roblox가 온라인, 오프라인 용도 및 유형 아이템에 사용할 수 있도록 허가하는 라이선스를 포함합니다. 자세한 변경 사항은 {legalChangesLinkStart}여기{legalChangesLinkEnd}에서 확인하세요.";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "'동의'를 클릭하면 회원님이 {tosLinkStart}Roblox 이용 약관{tosLinkEnd}에 동의하는 것으로 간주됩니다. 본 약관은 회원님이 Roblox에 과거에 제공했으며 미래에 제공할 콘텐츠를 Roblox가 온라인, 오프라인 용도 및 유형 아이템에 사용할 수 있도록 허가하는 라이선스를 포함합니다. 자세한 변경 사항은 {legalChangesLinkStart}여기{legalChangesLinkEnd}에서 확인하세요.";
	}
}
