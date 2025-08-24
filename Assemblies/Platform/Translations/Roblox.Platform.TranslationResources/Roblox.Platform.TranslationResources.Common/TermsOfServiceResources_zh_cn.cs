namespace Roblox.TranslationResources.Common;

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
	public override string HeadingTosAgreementTitle => "使用条款协议";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "使用条款已更改";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "我同意";

	public TermsOfServiceResources_zh_cn(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "使用条款协议";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "使用条款已更改";
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
		return $"点按“我同意”，即表示你同意{tosLinkStart}使用条款{tosLinkEnd}和{privacyLinkStart}隐私政策{privacyLinkEnd}。如需了解更多关于更改的内容，请查看{legalChangesLinkStart}此处{legalChangesLinkEnd}。";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "点按“我同意”，即表示你同意{tosLinkStart}使用条款{tosLinkEnd}和{privacyLinkStart}隐私政策{privacyLinkEnd}。如需了解更多关于更改的内容，请查看{legalChangesLinkStart}此处{legalChangesLinkEnd}。";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"点按“我同意”，即表示你同意{tosLinkStart}使用条款{tosLinkEnd}，你将授权 Roblox 在线上、线下及实体商品上使用你在 Roblox 过去以及将来创作的内容。如需了解更多相关更改的内容，请查看{legalChangesLinkStart}此处{legalChangesLinkEnd}。";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "点按“我同意”，即表示你同意{tosLinkStart}使用条款{tosLinkEnd}，你将授权 Roblox 在线上、线下及实体商品上使用你在 Roblox 过去以及将来创作的内容。如需了解更多相关更改的内容，请查看{legalChangesLinkStart}此处{legalChangesLinkEnd}。";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"点按“我同意”，即表示你同意 {tosLinkStart}Roblox 使用条款{tosLinkEnd}。你将授权 Roblox 在线上、线下及实体商品上使用你在 Roblox 过去以及将来创作的内容。如需了解更多相关更改的内容，请查看{legalChangesLinkStart}此处{legalChangesLinkEnd}。";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "点按“我同意”，即表示你同意 {tosLinkStart}Roblox 使用条款{tosLinkEnd}。你将授权 Roblox 在线上、线下及实体商品上使用你在 Roblox 过去以及将来创作的内容。如需了解更多相关更改的内容，请查看{legalChangesLinkStart}此处{legalChangesLinkEnd}。";
	}
}
