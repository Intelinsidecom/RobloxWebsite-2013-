using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class WeChatResources_en_us : TranslationResourcesBase, IWeChatResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public virtual string ActionWeChatLogin => "WeChat Login";

	public WeChatResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string> { 
		{
			"Action.WeChatLogin",
			_GetTemplateForActionWeChatLogin()
		} });
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.WeChat";
	}

	protected virtual string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat Login";
	}
}
