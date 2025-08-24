using System;

namespace Roblox.Platform.Presence;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.Presence.IPresence" />, for internal use.
/// </summary>
internal class Presence : IPresence
{
	public long VisitorId { get; private set; }

	public Guid? GameId { get; private set; }

	public bool IsOnline { get; set; }

	public DateTime LastOnline { get; set; }

	public LocationType? LocationType { get; private set; }

	public long? PlaceId { get; set; }

	public PresenceType PresenceType { get; }

	public long? UniverseId { get; private set; }

	internal Presence(long visitorId, bool isOnline, DateTime lastOnline, long? placeId, Guid? gameId, LocationType? locationType, long? universeId)
	{
		VisitorId = visitorId;
		GameId = gameId;
		IsOnline = isOnline;
		LastOnline = lastOnline;
		LocationType = locationType;
		PlaceId = placeId;
		PresenceType = GetPresenceTypeFromLocationTypeAndIsOnline(isOnline, locationType);
		UniverseId = universeId;
	}

	private PresenceType GetPresenceTypeFromLocationTypeAndIsOnline(bool isOnline, LocationType? locationType)
	{
		if (isOnline)
		{
			switch (locationType)
			{
			case Roblox.Platform.Presence.LocationType.Game:
				return PresenceType.InGame;
			case Roblox.Platform.Presence.LocationType.Studio:
			case Roblox.Platform.Presence.LocationType.CloudEdit:
				return PresenceType.InStudio;
			default:
				return PresenceType.Online;
			}
		}
		return PresenceType.Offline;
	}
}
