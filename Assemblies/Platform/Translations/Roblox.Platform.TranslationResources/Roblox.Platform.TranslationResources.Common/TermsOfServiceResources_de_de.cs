namespace Roblox.Platform.TranslationResources.Common {
    /// <summary>

/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_de_de : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "AKZEPTIERUNG DER NUTZUNGSBEDINGUNGEN";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "NUTZUNGSBEDINGUNGEN WURDEN GEÃ„NDERT";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "ICH AKZEPTIERE";

	public TermsOfServiceResources_de_de(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "AKZEPTIERUNG DER NUTZUNGSBEDINGUNGEN";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "NUTZUNGSBEDINGUNGEN WURDEN GEÃ„NDERT";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "ICH AKZEPTIERE";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Indem du auf â€žIch akzeptiereâ€œ klickst, stimmst du den {tosLinkStart}Nutzungsbedingungen{tosLinkEnd} und {privacyLinkStart}Datenschutzrichtlinien{privacyLinkEnd} zu. Mehr Details zu den Ã„nderungen findest du {legalChangesLinkStart}hier{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "Indem du auf â€žIch akzeptiereâ€œ klickst, stimmst du den {tosLinkStart}Nutzungsbedingungen{tosLinkEnd} und {privacyLinkStart}Datenschutzrichtlinien{privacyLinkEnd} zu. Mehr Details zu den Ã„nderungen findest du {legalChangesLinkStart}hier{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Indem du auf â€žIch akzeptiereâ€œ klickst, stimmst du den {tosLinkStart}Nutzungsbedingungen{tosLinkEnd} zu. Dazu gehÃ¶rt auch die Erlaubniserteilung an uns, bisherige und kÃ¼nftige Inhalte, die du dem Dienst zu VerfÃ¼gung stellst, online und offline (etwa fÃ¼r materielle Artikel) nutzen zu dÃ¼rfen. Mehr Details zu den Ã„nderungen findest du {legalChangesLinkStart}hier{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "Indem du auf â€žIch akzeptiereâ€œ klickst, stimmst du den {tosLinkStart}Nutzungsbedingungen{tosLinkEnd} zu. Dazu gehÃ¶rt auch die Erlaubniserteilung an uns, bisherige und kÃ¼nftige Inhalte, die du dem Dienst zu VerfÃ¼gung stellst, online und offline (etwa fÃ¼r materielle Artikel) nutzen zu dÃ¼rfen. Mehr Details zu den Ã„nderungen findest du {legalChangesLinkStart}hier{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Indem du auf â€žIch akzeptiereâ€œ klickst, stimmst du den {tosLinkStart}Nutzungsbedingungen von Roblox{tosLinkEnd} zu. Dazu gehÃ¶rt auch die Erlaubniserteilung an Roblox, bisherige und kÃ¼nftige Inhalte, die du dem Dienst zu VerfÃ¼gung stellst, online, offline und fÃ¼r materielle Artikel nutzen zu dÃ¼rfen. Mehr Details zu den Ã„nderungen findest du {legalChangesLinkStart}hier{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "Indem du auf â€žIch akzeptiereâ€œ klickst, stimmst du den {tosLinkStart}Nutzungsbedingungen von Roblox{tosLinkEnd} zu. Dazu gehÃ¶rt auch die Erlaubniserteilung an Roblox, bisherige und kÃ¼nftige Inhalte, die du dem Dienst zu VerfÃ¼gung stellst, online, offline und fÃ¼r materielle Artikel nutzen zu dÃ¼rfen. Mehr Details zu den Ã„nderungen findest du {legalChangesLinkStart}hier{legalChangesLinkEnd}.";
	}
}


}
