namespace Roblox.TranslationResources.Common;

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
	public override string HeadingTosAgreementTitle => "利用規約の同意";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "利用規約が変更されました";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "同意する";

	public TermsOfServiceResources_ja_jp(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "利用規約の同意";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "利用規約が変更されました";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "同意する";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"「同意する」をクリックすることで、{tosLinkStart}利用規約{tosLinkEnd} と {privacyLinkStart}プライバシーポリシー{legalChangesLinkEnd} に同意したものとみなされます。変更内容の詳細は、 {privacyLinkEnd}こちら{legalChangesLinkStart} で確認してください。";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "「同意する」をクリックすることで、{tosLinkStart}利用規約{tosLinkEnd} と {privacyLinkStart}プライバシーポリシー{legalChangesLinkEnd} に同意したものとみなされます。変更内容の詳細は、 {privacyLinkEnd}こちら{legalChangesLinkStart} で確認してください。";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"「同意する」をクリックすることで、 {tosLinkStart}利用規約{tosLinkEnd} に同意したものとみなされます。これには、オンライン、オフライン（有形アイテムなど）で使用するためにサービスに対してあなたが提供するRobloxの過去および将来のコンテンツのライセンスを含みます。変更内容の詳細は、 {legalChangesLinkStart}こちら{legalChangesLinkEnd} で確認してください。";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "「同意する」をクリックすることで、 {tosLinkStart}利用規約{tosLinkEnd} に同意したものとみなされます。これには、オンライン、オフライン（有形アイテムなど）で使用するためにサービスに対してあなたが提供するRobloxの過去および将来のコンテンツのライセンスを含みます。変更内容の詳細は、 {legalChangesLinkStart}こちら{legalChangesLinkEnd} で確認してください。";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"「同意する」をクリックすることで、 {tosLinkStart}Robloxの利用規約{tosLinkEnd} に同意したものとみなされます。これには、当社のオンライン、オフライン、有形アイテムのサービスに対してあなたが提供するRobloxの過去および将来のコンテンツのライセンスを含みます。変更内容の詳細は、 {legalChangesLinkStart}こちら{legalChangesLinkEnd} で確認してください。";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "「同意する」をクリックすることで、 {tosLinkStart}Robloxの利用規約{tosLinkEnd} に同意したものとみなされます。これには、当社のオンライン、オフライン、有形アイテムのサービスに対してあなたが提供するRobloxの過去および将来のコンテンツのライセンスを含みます。変更内容の詳細は、 {legalChangesLinkStart}こちら{legalChangesLinkEnd} で確認してください。";
	}
}
