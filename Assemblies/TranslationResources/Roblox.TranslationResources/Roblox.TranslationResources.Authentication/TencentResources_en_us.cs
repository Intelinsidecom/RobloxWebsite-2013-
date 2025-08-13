using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class TencentResources_en_us : TranslationResourcesBase, ITencentResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.QQLogin"
	/// button text for logging in with QQ (social network application)
	/// English String: "QQ Login"
	/// </summary>
	public virtual string ActionQQLogin => "QQ Login";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat (social network application)
	/// English String: "WeChat Login"
	/// </summary>
	public virtual string ActionWeChatLogin => "WeChat Login";

	public TencentResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.QQLogin",
				_GetTemplateForActionQQLogin()
			},
			{
				"Action.WeChatLogin",
				_GetTemplateForActionWeChatLogin()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.Tencent";
	}

	protected virtual string _GetTemplateForActionQQLogin()
	{
		return "QQ Login";
	}

	protected virtual string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat Login";
	}
}
