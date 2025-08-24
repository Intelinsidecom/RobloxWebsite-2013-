using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Moderation;

internal class ModeratorActionsResources_en_us : TranslationResourcesBase, IModeratorActionsResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.ScrubText"
	/// English String: "[ Content Deleted ]"
	/// </summary>
	public virtual string LabelScrubText => "[ Content Deleted ]";

	public ModeratorActionsResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string> { 
		{
			"Label.ScrubText",
			_GetTemplateForLabelScrubText()
		} });
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Moderation.ModeratorActions";
	}

	protected virtual string _GetTemplateForLabelScrubText()
	{
		return "[ Content Deleted ]";
	}
}
