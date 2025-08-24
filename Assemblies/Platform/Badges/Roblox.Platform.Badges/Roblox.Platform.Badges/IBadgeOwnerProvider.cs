namespace Roblox.Platform.Badges;

/// <summary>
/// A class to retrieve an <see cref="T:Roblox.Platform.Badges.BadgeOwner" /> from a <see cref="T:Roblox.Platform.Badges.Badge" />.
/// </summary>
public interface IBadgeOwnerProvider
{
	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Badges.BadgeOwner" /> from a <see cref="T:Roblox.Platform.Badges.Badge" />.
	/// </summary>
	/// <remarks>
	/// The owner will match the <see cref="P:Roblox.Platform.Badges.Badge.Awarder" /> owner.
	/// Right now there is only a <see cref="T:Roblox.Platform.Badges.BadgeAwarderType" /> of <see cref="F:Roblox.Platform.Badges.BadgeAwarderType.Place" />
	/// so the owner will be the place owner.
	/// </remarks>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.Badge" />.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Badges.BadgeOwner" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="badge" /></exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="badge" /> awarder type must be <see cref="F:Roblox.Platform.Badges.BadgeAwarderType.Place" />.</exception>
	/// <exception cref="T:Roblox.Data.DataIntegrityException"><paramref name="badge" /> awarder does not exist.</exception>
	BadgeOwner GetBadgeOwner(Badge badge);
}
