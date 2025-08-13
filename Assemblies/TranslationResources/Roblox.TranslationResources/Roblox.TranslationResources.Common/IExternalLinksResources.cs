namespace Roblox.TranslationResources.Common;

public interface IExternalLinksResources : ITranslationResources
{
	/// <summary>
	/// Key: "Link.Help"
	/// Help page link
	/// English String: "https://en.help.roblox.com/hc/en-us"
	/// </summary>
	string LinkHelp { get; }

	/// <summary>
	/// Key: "Link.PrivacyPolicy"
	/// Privacy Policy link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-"
	/// </summary>
	string LinkPrivacyPolicy { get; }

	/// <summary>
	/// Key: "Link.RobuxHelp"
	/// Help page for Robux
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/203313200-How-to-Get-Robux/"
	/// </summary>
	string LinkRobuxHelp { get; }

	/// <summary>
	/// Key: "Link.SafetyHelp"
	/// Help page for Parents, Safety, and Moderation
	/// English String: "https://en.help.roblox.com/hc/en-us/categories/200213830-Parents-Safety-and-Moderation"
	/// </summary>
	string LinkSafetyHelp { get; }

	/// <summary>
	/// Key: "Link.TermsOfService"
	/// Terms of Use link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use"
	/// </summary>
	string LinkTermsOfService { get; }
}
