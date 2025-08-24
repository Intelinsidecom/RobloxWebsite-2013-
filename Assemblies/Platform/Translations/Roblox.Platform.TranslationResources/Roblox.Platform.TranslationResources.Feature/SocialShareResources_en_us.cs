using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class SocialShareResources_en_us : TranslationResourcesBase, ISocialShareResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Share"
	/// Label for share button.
	/// English String: "Share"
	/// </summary>
	public virtual string ActionShare => "Share";

	public SocialShareResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string> { 
		{
			"Action.Share",
			_GetTemplateForActionShare()
		} });
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.SocialShare";
	}

	protected virtual string _GetTemplateForActionShare()
	{
		return "Share";
	}
}
