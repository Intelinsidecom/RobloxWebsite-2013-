namespace Roblox.Platform.Badges;

/// <summary>
/// Registers <see cref="T:Roblox.Platform.Badges.IBadgesAwardsAuthority" /> event handlers 
/// </summary>
public interface IBadgesAwardsAuthorityEventHandlerRegistrar
{
	/// <summary>
	/// Registers <see cref="T:Roblox.Platform.Badges.IBadgesAwardsAuthority" /> event handlers
	/// </summary>
	/// <param name="badgesAwardsAuthority"><see cref="T:Roblox.Platform.Badges.IBadgesAwardsAuthority" /></param>
	void RegisterEventHandlers(IBadgesAwardsAuthority badgesAwardsAuthority);
}
