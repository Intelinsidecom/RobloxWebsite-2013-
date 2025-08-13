namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides TermsOfServiceResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class TermsOfServiceResources_es_es : TermsOfServiceResources_en_us, ITermsOfServiceResources, ITranslationResources
{
	/// <summary>
	/// Key: "Heading.TosAgreementTitle"
	/// English String: "TERMS OF USE AGREEMENT"
	/// </summary>
	public override string HeadingTosAgreementTitle => "CONTRATO DE TÉRMINOS DE USO";

	/// <summary>
	/// Key: "Heading.TosHaveChangedTitle"
	/// English String: "TERMS OF USE HAVE CHANGED"
	/// </summary>
	public override string HeadingTosHaveChangedTitle => "SE HAN MODIFICADO LOS TÉRMINOS DE USO";

	/// <summary>
	/// Key: "Label.IAgree"
	/// English String: "I AGREE"
	/// </summary>
	public override string LabelIAgree => "ACEPTO";

	public TermsOfServiceResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForHeadingTosAgreementTitle()
	{
		return "CONTRATO DE TÉRMINOS DE USO";
	}

	protected override string _GetTemplateForHeadingTosHaveChangedTitle()
	{
		return "SE HAN MODIFICADO LOS TÉRMINOS DE USO";
	}

	protected override string _GetTemplateForLabelIAgree()
	{
		return "ACEPTO";
	}

	/// <summary>
	/// Key: "Message.AgreeToTosAndPrivacyBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd} and {privacyLinkStart}Privacy Policy{privacyLinkEnd}. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageAgreeToTosAndPrivacyBody(string tosLinkStart, string tosLinkEnd, string privacyLinkStart, string privacyLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Al hacer clic en \"Acepto\", aceptas los {tosLinkStart}Términos de uso{tosLinkEnd} y la {privacyLinkStart}Política de privacidad{privacyLinkEnd}. Puedes obtener más información sobre lo que está cambiando {legalChangesLinkStart}aquí{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageAgreeToTosAndPrivacyBody()
	{
		return "Al hacer clic en \"Acepto\", aceptas los {tosLinkStart}Términos de uso{tosLinkEnd} y la {privacyLinkStart}Política de privacidad{privacyLinkEnd}. Puedes obtener más información sobre lo que está cambiando {legalChangesLinkStart}aquí{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreeChangeBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Terms of Use{tosLinkEnd}, including the license to us of past and future content you provide to the service, for our online and offline (such as in tangible items) use. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreeChangeBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Al hacer clic en \"Acepto\", aceptas los {tosLinkStart}Términos de uso{tosLinkEnd}, incluso la cesión a Roblox del derecho de uso en línea y sin conexión (por ejemplo, en objetos tangibles) de todo contenido pasado y futuro que proporciones al servicio. Puedes obtener más información sobre lo que está cambiando {legalChangesLinkStart}aquí{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreeChangeBody()
	{
		return "Al hacer clic en \"Acepto\", aceptas los {tosLinkStart}Términos de uso{tosLinkEnd}, incluso la cesión a Roblox del derecho de uso en línea y sin conexión (por ejemplo, en objetos tangibles) de todo contenido pasado y futuro que proporciones al servicio. Puedes obtener más información sobre lo que está cambiando {legalChangesLinkStart}aquí{legalChangesLinkEnd}.";
	}

	/// <summary>
	/// Key: "Message.TosAgreementBody"
	/// English String: "By clicking \"I Agree\", you are agreeing to the {tosLinkStart}Roblox Terms of Use{tosLinkEnd}. This includes the license to Roblox of past and future content you provide to the service for our use online, offline, and in tangible items. You can learn more about what is changing {legalChangesLinkStart}here{legalChangesLinkEnd}."
	/// </summary>
	public override string MessageTosAgreementBody(string tosLinkStart, string tosLinkEnd, string legalChangesLinkStart, string legalChangesLinkEnd)
	{
		return $"Al hacer clic en \"Acepto\", aceptas los {tosLinkStart}Términos de uso de Roblox{tosLinkEnd}. Esto incluye la cesión a Roblox del derecho de uso en línea, sin conexión y en objetos tangibles de todo contenido pasado y futuro que proporciones al servicio. Puedes obtener más información sobre lo que está cambiando {legalChangesLinkStart}aquí{legalChangesLinkEnd}.";
	}

	protected override string _GetTemplateForMessageTosAgreementBody()
	{
		return "Al hacer clic en \"Acepto\", aceptas los {tosLinkStart}Términos de uso de Roblox{tosLinkEnd}. Esto incluye la cesión a Roblox del derecho de uso en línea, sin conexión y en objetos tangibles de todo contenido pasado y futuro que proporciones al servicio. Puedes obtener más información sobre lo que está cambiando {legalChangesLinkStart}aquí{legalChangesLinkEnd}.";
	}
}
