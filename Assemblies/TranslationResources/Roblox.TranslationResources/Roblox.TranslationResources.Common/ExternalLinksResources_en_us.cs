using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class ExternalLinksResources_en_us : TranslationResourcesBase, IExternalLinksResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Link.Help"
	/// Help page link
	/// English String: "https://en.help.roblox.com/hc/en-us"
	/// </summary>
	public virtual string LinkHelp => "https://en.help.roblox.com/hc/en-us";

	/// <summary>
	/// Key: "Link.PrivacyPolicy"
	/// Privacy Policy link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-"
	/// </summary>
	public virtual string LinkPrivacyPolicy => "https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-";

	/// <summary>
	/// Key: "Link.RobuxHelp"
	/// Help page for Robux
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/203313200-How-to-Get-Robux/"
	/// </summary>
	public virtual string LinkRobuxHelp => "https://en.help.roblox.com/hc/en-us/articles/203313200-How-to-Get-Robux/";

	/// <summary>
	/// Key: "Link.SafetyHelp"
	/// Help page for Parents, Safety, and Moderation
	/// English String: "https://en.help.roblox.com/hc/en-us/categories/200213830-Parents-Safety-and-Moderation"
	/// </summary>
	public virtual string LinkSafetyHelp => "https://en.help.roblox.com/hc/en-us/categories/200213830-Parents-Safety-and-Moderation";

	/// <summary>
	/// Key: "Link.TermsOfService"
	/// Terms of Use link
	/// English String: "https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use"
	/// </summary>
	public virtual string LinkTermsOfService => "https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use";

	public ExternalLinksResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Link.Help",
				_GetTemplateForLinkHelp()
			},
			{
				"Link.PrivacyPolicy",
				_GetTemplateForLinkPrivacyPolicy()
			},
			{
				"Link.RobuxHelp",
				_GetTemplateForLinkRobuxHelp()
			},
			{
				"Link.SafetyHelp",
				_GetTemplateForLinkSafetyHelp()
			},
			{
				"Link.TermsOfService",
				_GetTemplateForLinkTermsOfService()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.ExternalLinks";
	}

	protected virtual string _GetTemplateForLinkHelp()
	{
		return "https://en.help.roblox.com/hc/en-us";
	}

	protected virtual string _GetTemplateForLinkPrivacyPolicy()
	{
		return "https://en.help.roblox.com/hc/en-us/articles/115004630823-Roblox-Privacy-and-Cookie-Policy-";
	}

	protected virtual string _GetTemplateForLinkRobuxHelp()
	{
		return "https://en.help.roblox.com/hc/en-us/articles/203313200-How-to-Get-Robux/";
	}

	protected virtual string _GetTemplateForLinkSafetyHelp()
	{
		return "https://en.help.roblox.com/hc/en-us/categories/200213830-Parents-Safety-and-Moderation";
	}

	protected virtual string _GetTemplateForLinkTermsOfService()
	{
		return "https://en.help.roblox.com/hc/en-us/articles/115004647846-Roblox-Terms-of-Use";
	}
}
