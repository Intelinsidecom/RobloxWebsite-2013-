using System;
using System.Collections.Generic;
using Roblox.Platform.Presence;
using Roblox.TranslationResources.Common;

namespace Roblox.Web.Presence;

internal class FilteredPresence : IPresence
{
	private enum _LocationType
	{
		Offline,
		Online,
		InGame,
		Studio
	}

	private static readonly Dictionary<_LocationType, string> _PresenceText = new Dictionary<_LocationType, string>
	{
		{
			_LocationType.Offline,
			"Offline"
		},
		{
			_LocationType.Online,
			"Online"
		},
		{
			_LocationType.InGame,
			"Playing"
		},
		{
			_LocationType.Studio,
			"Creating"
		}
	};

	public Guid? GameId { get; private set; }

	public bool IsOnline { get; private set; }

	public string LastLocation { get; private set; }

	public DateTime LastOnline { get; private set; }

	public LocationType? LocationType { get; private set; }

	public long? PlaceId { get; private set; }

	public long VisitorId { get; private set; }

	public PresenceType PresenceType { get; private set; }

	public long? UniverseId { get; private set; }

	public FilteredPresence(IPresence presence, IPresenceResources presenceResources)
	{
		string presenceText;
		if (presenceResources != null)
		{
			switch (presence.LocationType)
			{
			case Roblox.Platform.Presence.LocationType.Game:
				presenceText = presenceResources.LabelPlaying;
				break;
			case Roblox.Platform.Presence.LocationType.Studio:
			case Roblox.Platform.Presence.LocationType.CloudEdit:
				presenceText = presenceResources.LabelCreating;
				break;
			default:
				presenceText = (presence.IsOnline ? presenceResources.LabelOnline : presenceResources.LabelOffline);
				break;
			}
		}
		else
		{
			switch (presence.LocationType)
			{
			case Roblox.Platform.Presence.LocationType.Game:
				presenceText = _PresenceText[_LocationType.InGame];
				break;
			case Roblox.Platform.Presence.LocationType.Studio:
			case Roblox.Platform.Presence.LocationType.CloudEdit:
				presenceText = _PresenceText[_LocationType.Studio];
				break;
			default:
				presenceText = (presence.IsOnline ? _PresenceText[_LocationType.Online] : _PresenceText[_LocationType.Offline]);
				break;
			}
		}
		GameId = null;
		PlaceId = null;
		LastLocation = presenceText;
		IsOnline = presence.IsOnline;
		LastOnline = presence.LastOnline;
		LocationType = presence.LocationType;
		VisitorId = presence.VisitorId;
		PresenceType = presence.PresenceType;
	}

	public void AddPlaceInfoToPresence(IPresence presence, IPresenceResources presenceResources)
	{
		GameId = presence.GameId;
		PlaceId = presence.PlaceId;
		UniverseId = presence.UniverseId;
		Asset place = Asset.Get(presence.PlaceId);
		if (place == null)
		{
			return;
		}
		if (presenceResources != null)
		{
			LocationType? locationType = presence.LocationType;
			if (locationType.HasValue)
			{
				switch (locationType.GetValueOrDefault())
				{
				case Roblox.Platform.Presence.LocationType.Game:
					LastLocation = presenceResources.LabelPlayingGame(place.Name);
					break;
				case Roblox.Platform.Presence.LocationType.Studio:
				case Roblox.Platform.Presence.LocationType.CloudEdit:
					LastLocation = presenceResources.LabelCreatingGame(place.Name);
					break;
				case Roblox.Platform.Presence.LocationType.Xbox:
					break;
				}
			}
		}
		else
		{
			LastLocation = LastLocation + " " + place.Name;
		}
	}
}
