using System;
using Roblox.Time;
using Roblox.Web.Presence.Enums;

namespace Roblox.Web.Presence.Interfaces;

public interface IUserPresence
{
	PresenceType UserPresenceType { get; set; }

	string LastLocation { get; set; }

	long? PlaceId { get; set; }

	long? RootPlaceId { get; set; }

	Guid? GameId { get; set; }

	long? UniverseId { get; set; }

	long UserId { get; set; }

	UtcInstant LastOnline { get; set; }
}
