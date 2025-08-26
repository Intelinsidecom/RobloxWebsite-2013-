namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_pt_br : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "ACORDO DOS TERMOS DE USO";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "TERMOS DE USO ALTERADOS";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "CONCORDO";

	public TermsOfServiceResources_pt_br(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "ACORDO DOS TERMOS DE USO";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "TERMOS DE USO ALTERADOS";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "CONCORDO";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Clicando em â€œConcordo\", vocÃª estÃ¡ aceitando os {tosLinkStart}Termos de Uso{tosLinkEnd} e {privacyLinkStart}PolÃ­tica de Privacidade{privacyLinkEnd}. VocÃª pode saber mais sobre o que estÃ¡ mudando {legalChangesLinkStart}aqui{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "Clicando em â€œConcordo\", vocÃª estÃ¡ aceitando os {tosLinkStart}Termos de Uso{tosLinkEnd} e {privacyLinkStart}PolÃ­tica de Privacidade{privacyLinkEnd}. VocÃª pode saber mais sobre o que estÃ¡ mudando {legalChangesLinkStart}aqui{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Clicando em â€œConcordo\", vocÃª estÃ¡ aceitando os {tosLinkStart}Termos de Uso{tosLinkEnd}, incluindo a licenÃ§a, concedida a nÃ³s, do conteÃºdo passado e futuro que vocÃª fornecer ao serviÃ§o para nosso uso online e offline (como em itens tangÃ­veis). VocÃª pode saber mais sobre o que estÃ¡ mudando {legalChangesLinkStart}aqui{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "Clicando em â€œConcordo\", vocÃª estÃ¡ aceitando os {tosLinkStart}Termos de Uso{tosLinkEnd}, incluindo a licenÃ§a, concedida a nÃ³s, do conteÃºdo passado e futuro que vocÃª fornecer ao serviÃ§o para nosso uso online e offline (como em itens tangÃ­veis). VocÃª pode saber mais sobre o que estÃ¡ mudando {legalChangesLinkStart}aqui{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Clicando em â€œConcordo\", vocÃª estÃ¡ aceitando os {tosLinkStart}Termos de Uso do Roblox{tosLinkEnd}. Isto inclui a licenÃ§a Roblox do conteÃºdo passado e futuro que vocÃª fornecer ao serviÃ§o para nosso uso online, offline e em itens tangÃ­veis. VocÃª pode saber mais sobre o que estÃ¡ mudando {legalChangesLinkStart}aqui{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "Clicando em â€œConcordo\", vocÃª estÃ¡ aceitando os {tosLinkStart}Termos de Uso do Roblox{tosLinkEnd}. Isto inclui a licenÃ§a Roblox do conteÃºdo passado e futuro que vocÃª fornecer ao serviÃ§o para nosso uso online, offline e em itens tangÃ­veis. VocÃª pode saber mais sobre o que estÃ¡ mudando {legalChangesLinkStart}aqui{legalChangesLinkEnd}.";
	}
}


}
