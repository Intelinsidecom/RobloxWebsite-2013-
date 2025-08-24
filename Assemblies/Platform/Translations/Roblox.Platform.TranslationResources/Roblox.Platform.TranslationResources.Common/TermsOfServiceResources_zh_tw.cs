namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_zh_tw : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "使用條款合約";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "使用條款已變更";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "我同意";

	public TermsOfServiceResources_zh_tw(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "使用條款合約";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "使用條款已變更";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "我同意";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"按下「我同意」表示您同意{tosLinkStart}使用條款{tosLinkEnd}和{privacyLinkStart}隱私權政策{privacyLinkEnd}。若您想進一步了解所有更動，請前往{legalChangesLinkStart}此處{legalChangesLinkEnd}。";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "按下「我同意」表示您同意{tosLinkStart}使用條款{tosLinkEnd}和{privacyLinkStart}隱私權政策{privacyLinkEnd}。若您想進一步了解所有更動，請前往{legalChangesLinkStart}此處{legalChangesLinkEnd}。";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"按下「我同意」表示您同意{tosLinkStart}使用條款{tosLinkEnd}。您將授權 Roblox 在線上、線下及實體商品上使用您在 Roblox 創作的內容。若您想進一步了解所有更動，請前往{legalChangesLinkStart}此處{legalChangesLinkEnd}。";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "按下「我同意」表示您同意{tosLinkStart}使用條款{tosLinkEnd}。您將授權 Roblox 在線上、線下及實體商品上使用您在 Roblox 創作的內容。若您想進一步了解所有更動，請前往{legalChangesLinkStart}此處{legalChangesLinkEnd}。";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"按下「我同意」表示您同意{tosLinkStart}使用條款{tosLinkEnd}。您將授權 Roblox 在線上、線下及實體商品上使用您在 Roblox 創作的內容。若您想進一步了解所有更動，請前往{legalChangesLinkStart}此處{legalChangesLinkEnd}。";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "按下「我同意」表示您同意{tosLinkStart}使用條款{tosLinkEnd}。您將授權 Roblox 在線上、線下及實體商品上使用您在 Roblox 創作的內容。若您想進一步了解所有更動，請前往{legalChangesLinkStart}此處{legalChangesLinkEnd}。";
	}
}
