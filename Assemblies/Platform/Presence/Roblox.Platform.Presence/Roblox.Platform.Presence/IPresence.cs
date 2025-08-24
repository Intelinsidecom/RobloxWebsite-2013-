using System;

namespace Roblox.Platform.Presence;

/// <summary>
/// A report about the last location of a specific user.
/// </summary>
public interface IPresence
{
	/// <summary>
	/// The id of the visitor.
	/// </summary>
	long VisitorId { get; }

	/// <summary>
	/// The id of the place the user was last seen in, either online or in team create.
	/// </summary>
	long? PlaceId { get; }

	/// <summary>
	/// The <see cref="T:System.Guid" /> of the game the user was last seen in.
	/// </summary>
	Guid? GameId { get; }

	/// <summary>
	/// Whether the user is currently online.
	/// </summary>
	bool IsOnline { get; }

	/// <summary>
	/// The last time we saw this user.
	/// </summary>
	DateTime LastOnline { get; }

	/// <summary>
	/// The type of the last location.
	/// </summary>
	LocationType? LocationType { get; }

	/// <summary>
	/// The type of this report.
	/// </summary>
	PresenceType PresenceType { get; }

	/// <summary>
	/// UniverseId of the place user was last seen in, either online or in team create.
	/// </summary>
	long? UniverseId { get; }
}
