using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Feature;

internal class GameGearOptionsDisplayResources_en_us : TranslationResourcesBase, IGameGearOptionsDisplayResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "LabelAllGenreAllowed"
	/// English String: "All Genres Allowed"
	/// </summary>
	public virtual string LabelAllGenreAllowed => "All Genres Allowed";

	/// <summary>
	/// Key: "LabelNoGear"
	/// English String: "No Gear Allowed"
	/// </summary>
	public virtual string LabelNoGear => "No Gear Allowed";

	public GameGearOptionsDisplayResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"LabelAllGenreAllowed",
				_GetTemplateForLabelAllGenreAllowed()
			},
			{
				"LabelGearOnly",
				_GetTemplateForLabelGearOnly()
			},
			{
				"LabelNoGear",
				_GetTemplateForLabelNoGear()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Feature.GameGearOptionsDisplay";
	}

	protected virtual string _GetTemplateForLabelAllGenreAllowed()
	{
		return "All Genres Allowed";
	}

	/// <summary>
	/// Key: "LabelGearOnly"
	/// English String: "{GearName} Gear Only"
	/// </summary>
	public virtual string LabelGearOnly(string GearName)
	{
		return $"{GearName} Gear Only";
	}

	protected virtual string _GetTemplateForLabelGearOnly()
	{
		return "{GearName} Gear Only";
	}

	protected virtual string _GetTemplateForLabelNoGear()
	{
		return "No Gear Allowed";
	}
}
