using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class SecurityNotificationResources_en_us : TranslationResourcesBase, ISecurityNotificationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.Important"
	/// English String: "Important"
	/// </summary>
	public virtual string HeadingImportant => "Important";

	public SecurityNotificationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Description.SecurityNotificationText",
				_GetTemplateForDescriptionSecurityNotificationText()
			},
			{
				"Description.SecurityNotificationTextWarning",
				_GetTemplateForDescriptionSecurityNotificationTextWarning()
			},
			{
				"Heading.Important",
				_GetTemplateForHeadingImportant()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.SecurityNotification";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationText"
	/// English String: "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}."
	/// </summary>
	public virtual string DescriptionSecurityNotificationText(string aTagStartWithHref, string emailMailToLink, string hrefEnd, string emailText, string aTagEnd)
	{
		return $"For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}.";
	}

	protected virtual string _GetTemplateForDescriptionSecurityNotificationText()
	{
		return "For the safety and security of your account, your Roblox password has been reset. To regain access to your account, please type in your email or phone number and click the submit button on this page. If you do not have an email or phone number associated with your account, please contact Roblox customer service at {aTagStartWithHref}{emailMailToLink}{hrefEnd}{emailText}{aTagEnd}.";
	}

	/// <summary>
	/// Key: "Description.SecurityNotificationTextWarning"
	/// English String: "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised."
	/// </summary>
	public virtual string DescriptionSecurityNotificationTextWarning(string startSpan, string endSpan)
	{
		return $"Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised.";
	}

	protected virtual string _GetTemplateForDescriptionSecurityNotificationTextWarning()
	{
		return "Please choose a password that is brand {startSpan}new{endSpan} and {startSpan}unique{endSpan} to Roblox, do not use this password on any other site. This is the best way to prevent your Roblox account from getting compromised.";
	}

	protected virtual string _GetTemplateForHeadingImportant()
	{
		return "Important";
	}
}
