namespace Roblox.Platform.Badges;

/// <summary>
/// A class that contains information about an entity
/// that can award badges.
/// </summary>
public interface IBadgeAwarder
{
	/// <summary>
	/// The Id of the awarder
	/// </summary>
	long Id { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Badges.BadgeAwarderType" />
	/// </summary>
	BadgeAwarderType Type { get; }
}
