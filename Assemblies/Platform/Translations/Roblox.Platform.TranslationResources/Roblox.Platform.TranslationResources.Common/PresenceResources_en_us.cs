using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Common;

internal class PresenceResources_en_us : TranslationResourcesBase, IPresenceResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Label.Creating"
	/// English String: "Creating"
	/// </summary>
	public virtual string LabelCreating => "Creating";

	/// <summary>
	/// Key: "Label.Offline"
	/// English String: "Offline"
	/// </summary>
	public virtual string LabelOffline => "Offline";

	/// <summary>
	/// Key: "Label.Online"
	/// English String: "Online"
	/// </summary>
	public virtual string LabelOnline => "Online";

	/// <summary>
	/// Key: "Label.Playing"
	/// English String: "Playing"
	/// </summary>
	public virtual string LabelPlaying => "Playing";

	public PresenceResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Label.Creating",
				_GetTemplateForLabelCreating()
			},
			{
				"Label.CreatingGame",
				_GetTemplateForLabelCreatingGame()
			},
			{
				"Label.Offline",
				_GetTemplateForLabelOffline()
			},
			{
				"Label.Online",
				_GetTemplateForLabelOnline()
			},
			{
				"Label.Playing",
				_GetTemplateForLabelPlaying()
			},
			{
				"Label.PlayingGame",
				_GetTemplateForLabelPlayingGame()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Common.Presence";
	}

	protected virtual string _GetTemplateForLabelCreating()
	{
		return "Creating";
	}

	/// <summary>
	/// Key: "Label.CreatingGame"
	/// English String: "Creating {placeName}"
	/// </summary>
	public virtual string LabelCreatingGame(string placeName)
	{
		return $"Creating {placeName}";
	}

	protected virtual string _GetTemplateForLabelCreatingGame()
	{
		return "Creating {placeName}";
	}

	protected virtual string _GetTemplateForLabelOffline()
	{
		return "Offline";
	}

	protected virtual string _GetTemplateForLabelOnline()
	{
		return "Online";
	}

	protected virtual string _GetTemplateForLabelPlaying()
	{
		return "Playing";
	}

	/// <summary>
	/// Key: "Label.PlayingGame"
	/// English String: "Playing {placeName}"
	/// </summary>
	public virtual string LabelPlayingGame(string placeName)
	{
		return $"Playing {placeName}";
	}

	protected virtual string _GetTemplateForLabelPlayingGame()
	{
		return "Playing {placeName}";
	}
}
