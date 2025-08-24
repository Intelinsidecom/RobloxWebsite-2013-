namespace Roblox.TranslationResources.Common;

/// <summary>
/// This class overrides ExternalLinksResources_en_us to provide locale specific translations where possible,
/// using the base translations where they are not provided
/// </summary>
internal class ExternalLinksResources_zh_cjv : ExternalLinksResources_en_us, IExternalLinksResources, ITranslationResources
{
	/// <summary>
	/// Key: "Link.Help"
	/// Help page link
	/// English String: "https://en.help.roblox.com/hc/en-us"
	/// </summary>
	public override string LinkHelp => "https://en.help.roblox.com/hc/zh-cn";

	/// <summary>
	/// Key: "Link.PrivacyPolicy"
	/// Privacy Policy link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-"
	/// </summary>
	public override string LinkPrivacyPolicy => "https://en.help.roblox.com/hc/zh-cn/articles/115004630823";

	/// <summary>
	/// Key: "Link.RobuxHelp"
	/// Help page for Robux
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/203313200-How-to-Get-Robux/"
	/// </summary>
	public override string LinkRobuxHelp => "https://en.help.roblox.com/hc/zh-cn/articles/203313200-%E5%A6%82%E4%BD%95%E8%8E%B7%E5%8F%96Robux";

	/// <summary>
	/// Key: "Link.SafetyHelp"
	/// Help page for Parents, Safety, and Moderation
	/// English String: "https://en.help.roblox.com/hc/en-us/categories/200213830-Parents-Safety-and-Moderation"
	/// </summary>
	public override string LinkSafetyHelp => "";

	/// <summary>
	/// Key: "Link.TermsOfService"
	/// Terms of Use link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use"
	/// </summary>
	public override string LinkTermsOfService => "https://en.help.roblox.com/hc/zh-cn/articles/115004647846";

	public ExternalLinksResources_zh_cjv(TranslationResourceState state)
		: base(state)
	{
	}

	protected override string _GetTemplateForLinkHelp()
	{
		return "https://en.help.roblox.com/hc/zh-cn";
	}

	protected override string _GetTemplateForLinkPrivacyPolicy()
	{
		return "https://en.help.roblox.com/hc/zh-cn/articles/115004630823";
	}

	protected override string _GetTemplateForLinkRobuxHelp()
	{
		return "https://en.help.roblox.com/hc/zh-cn/articles/203313200-%E5%A6%82%E4%BD%95%E8%8E%B7%E5%8F%96Robux";
	}

	protected override string _GetTemplateForLinkSafetyHelp()
	{
		return "";
	}

	protected override string _GetTemplateForLinkTermsOfService()
	{
		return "https://en.help.roblox.com/hc/zh-cn/articles/115004647846";
	}
}
