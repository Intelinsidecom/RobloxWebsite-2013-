namespace Roblox.Platform.Badges;

/// <summary>
/// Registers <see cref="T:Roblox.Platform.Badges.IBadgeUpdater" /> event handlers 
/// </summary>
public interface IBadgeUpdaterEventHandlerRegistrar
{
	/// <summary>
	/// Registers <see cref="T:Roblox.Platform.Badges.IBadgeUpdater" /> event handlers
	/// </summary>
	/// <param name="badgeUpdater"><see cref="T:Roblox.Platform.Badges.IBadgeUpdater" /></param>
	void RegisterEventHandlers(IBadgeUpdater badgeUpdater);
}
