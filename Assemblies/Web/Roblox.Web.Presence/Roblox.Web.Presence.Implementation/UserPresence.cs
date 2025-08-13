using System;
using Roblox.Time;
using Roblox.Web.Presence.Enums;
using Roblox.Web.Presence.Interfaces;

namespace Roblox.Web.Presence.Implementation;

internal class UserPresence : IUserPresence
{
	public PresenceType UserPresenceType { get; set; }

	public string LastLocation { get; set; }

	public long? PlaceId { get; set; }

	public long? RootPlaceId { get; set; }

	public Guid? GameId { get; set; }

	public long? UniverseId { get; set; }

	public long UserId { get; set; }

	public UtcInstant LastOnline { get; set; }
}
