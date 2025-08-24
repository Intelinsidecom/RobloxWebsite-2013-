namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides ExternalLinksResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ExternalLinksResources_es_es : ExternalLinksResources_en_us, IExternalLinksResources, ITranslationResources
{
	/// <summary>
	/// Key: "Link.Help"
	/// Help page link
	/// English String: "https://en.help.roblox.com/hc/en-us"
	/// </summary>
	public override string LinkHelp => "https://en.help.roblox.com/hc/es";

	/// <summary>
	/// Key: "Link.PrivacyPolicy"
	/// Privacy Policy link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-"
	/// </summary>
	public override string LinkPrivacyPolicy => "https://en.help.roblox.com/hc/es/articles/115004630823-Pol%C3%ADtica-de-privacidad-y-de-cookies-de-Roblox";

	/// <summary>
	/// Key: "Link.RobuxHelp"
	/// Help page for Robux
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/203313200-How-to-Get-Robux/"
	/// </summary>
	public override string LinkRobuxHelp => "https://en.help.roblox.com/hc/es/articles/203313200-C%C3%B3mo-Obtener-Robux-RBX";

	/// <summary>
	/// Key: "Link.TermsOfService"
	/// Terms of Use link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use"
	/// </summary>
	public override string LinkTermsOfService => "https://en.help.roblox.com/hc/es/articles/115004647846-T%C3%A9rminos-de-uso-de-Roblox";

	public ExternalLinksResources_es_es(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLinkHelp()
	{
		return "https://en.help.roblox.com/hc/es";
	}

	protected override string _GetTemplateForLinkPrivacyPolicy()
	{
		return "https://en.help.roblox.com/hc/es/articles/115004630823-Pol%C3%ADtica-de-privacidad-y-de-cookies-de-Roblox";
	}

	protected override string _GetTemplateForLinkRobuxHelp()
	{
		return "https://en.help.roblox.com/hc/es/articles/203313200-C%C3%B3mo-Obtener-Robux-RBX";
	}

	protected override string _GetTemplateForLinkTermsOfService()
	{
		return "https://en.help.roblox.com/hc/es/articles/115004647846-T%C3%A9rminos-de-uso-de-Roblox";
	}
}
