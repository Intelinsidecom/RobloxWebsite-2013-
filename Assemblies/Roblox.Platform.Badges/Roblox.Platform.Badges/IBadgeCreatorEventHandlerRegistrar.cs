namespace Roblox.Platform.Badges;

/// <summary>
/// Registers <see cref="T:Roblox.Platform.Badges.IBadgeCreator" /> event handlers 
/// </summary>
public interface IBadgeCreatorEventHandlerRegistrar
{
	/// <summary>
	/// Registers event handlers
	/// </summary>
	/// <param name="badgeCreator"><see cref="T:Roblox.Platform.Badges.IBadgeCreator" /></param>
	void RegisterEventHandlers(IBadgeCreator badgeCreator);
}
