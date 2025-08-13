using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class ChinaPaymentResources_en_us : TranslationResourcesBase, IChinaPaymentResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Heading.Error"
	/// English String: "Error"
	/// </summary>
	public virtual string HeadingError => "Error";

	/// <summary>
	/// Key: "Message.ScriptNotLoadError"
	/// English String: "We have a problem loading the Midas script now. Please try again later"
	/// </summary>
	public virtual string MessageScriptNotLoadError => "We have a problem loading the Midas script now. Please try again later";

	/// <summary>
	/// Key: "Message.SessionExpiredError"
	/// English String: "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again."
	/// </summary>
	public virtual string MessageSessionExpiredError => "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again.";

	public ChinaPaymentResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Heading.Error",
				_GetTemplateForHeadingError()
			},
			{
				"Message.ScriptNotLoadError",
				_GetTemplateForMessageScriptNotLoadError()
			},
			{
				"Message.SessionExpiredError",
				_GetTemplateForMessageSessionExpiredError()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.ChinaPayment";
	}

	protected virtual string _GetTemplateForHeadingError()
	{
		return "Error";
	}

	protected virtual string _GetTemplateForMessageScriptNotLoadError()
	{
		return "We have a problem loading the Midas script now. Please try again later";
	}

	protected virtual string _GetTemplateForMessageSessionExpiredError()
	{
		return "Looks like your WeChat session is expired and we cannot process your request. Please log out and log in again.";
	}
}
