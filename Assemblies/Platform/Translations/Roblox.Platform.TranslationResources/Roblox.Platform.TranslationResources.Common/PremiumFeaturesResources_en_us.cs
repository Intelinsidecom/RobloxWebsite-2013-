using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class PremiumFeaturesResources_en_us : TranslationResourcesBase, IPremiumFeaturesResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.RobloxPremiumName"
	/// English String: "Roblox Premium"
	/// </summary>
	public virtual string LabelRobloxPremiumName => "Roblox Premium";

	public PremiumFeaturesResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.RobloxPremium",
				_GetTemplateForLabelRobloxPremium()
			},
			{
				"Label.RobloxPremiumName",
				_GetTemplateForLabelRobloxPremiumName()
			},
			{
				"Label.RobuxPackage",
				_GetTemplateForLabelRobuxPackage()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.PremiumFeatures";
	}

	/// <summary>
	/// Key: "Label.RobloxPremium"
	/// English String: "Roblox Premium {amount}"
	/// </summary>
	public virtual string LabelRobloxPremium(string amount)
	{
		return $"Roblox Premium {amount}";
	}

	protected virtual string _GetTemplateForLabelRobloxPremium()
	{
		return "Roblox Premium {amount}";
	}

	protected virtual string _GetTemplateForLabelRobloxPremiumName()
	{
		return "Roblox Premium";
	}

	/// <summary>
	/// Key: "Label.RobuxPackage"
	/// English String: "{amount} Robux"
	/// </summary>
	public virtual string LabelRobuxPackage(string amount)
	{
		return $"{amount} Robux";
	}

	protected virtual string _GetTemplateForLabelRobuxPackage()
	{
		return "{amount} Robux";
	}
}
