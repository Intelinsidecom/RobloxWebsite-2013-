namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_fr_fr : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "ACCEPTATION DES CONDITIONS D'UTILISATION";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "LES CONDITIONS D'UTILISATION ONT CHANGÉ";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "J'ACCEPTE";

	public TermsOfServiceResources_fr_fr(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "ACCEPTATION DES CONDITIONS D'UTILISATION";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "LES CONDITIONS D'UTILISATION ONT CHANGÉ";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "J'ACCEPTE";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"En cliquant sur «\u00a0J'accepte\u00a0», vous déclarez accepter les {tosLinkStart}Conditions d'utilisation{tosLinkEnd} ainsi que la {privacyLinkStart}Politique de confidentialité{privacyLinkEnd}. Pour en savoir plus sur les changements apportés, reportez-vous à {legalChangesLinkStart}cette adresse{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "En cliquant sur «\u00a0J'accepte\u00a0», vous déclarez accepter les {tosLinkStart}Conditions d'utilisation{tosLinkEnd} ainsi que la {privacyLinkStart}Politique de confidentialité{privacyLinkEnd}. Pour en savoir plus sur les changements apportés, reportez-vous à {legalChangesLinkStart}cette adresse{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"En cliquant sur «\u00a0J'accepte\u00a0», vous déclarez accepter les {tosLinkStart}Conditions d'utilisation{tosLinkEnd}, qui incluent la licence que vous accordez à Roblox pour le contenu passé et à venir fourni au service en vue de son utilisation en ligne et hors ligne (par exemple les objets réels). Pour en savoir plus sur les changements apportés, reportez-vous à {legalChangesLinkStart}cette adresse{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "En cliquant sur «\u00a0J'accepte\u00a0», vous déclarez accepter les {tosLinkStart}Conditions d'utilisation{tosLinkEnd}, qui incluent la licence que vous accordez à Roblox pour le contenu passé et à venir fourni au service en vue de son utilisation en ligne et hors ligne (par exemple les objets réels). Pour en savoir plus sur les changements apportés, reportez-vous à {legalChangesLinkStart}cette adresse{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"En cliquant sur «\u00a0J'accepte\u00a0», vous déclarez accepter les {tosLinkStart}Conditions d'utilisation de Roblox{tosLinkEnd}. Celles-ci incluent la licence que vous accordez à Roblox pour le contenu passé et à venir fourni au service en vue de son utilisation en ligne, hors ligne et sur support physique. Pour en savoir plus sur les changements apportés, reportez-vous à {legalChangesLinkStart}cette adresse{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "En cliquant sur «\u00a0J'accepte\u00a0», vous déclarez accepter les {tosLinkStart}Conditions d'utilisation de Roblox{tosLinkEnd}. Celles-ci incluent la licence que vous accordez à Roblox pour le contenu passé et à venir fourni au service en vue de son utilisation en ligne, hors ligne et sur support physique. Pour en savoir plus sur les changements apportés, reportez-vous à {legalChangesLinkStart}cette adresse{legalChangesLinkEnd}.";
	}
}
