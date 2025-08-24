namespace Roblox.Platform.Social.PlayerInteractions;

/// <summary>
/// The factory interface which provide <see cref="T:Roblox.Platform.Social.PlayerInteractions.IPlayerInteractionDataAccessor" />
/// </summary>
public interface IPlayerInteractionDataAccessorFactory
{
	/// <summary>
	/// Returns the <see cref="T:Roblox.Platform.Social.PlayerInteractions.IPlayerInteractionDataAccessor" />
	/// </summary>
	/// <returns></returns>
	IPlayerInteractionDataAccessor GetPlayerInteractionDataAccessor();
}
