namespace Roblox.Platform.Badges;

/// <summary>
/// Badge Identifier Factory
/// </summary>
public interface IBadgeIdentifierFactory
{
	/// <summary>
	/// Returns wrapper which implements <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />
	/// </summary>
	/// <param name="id">Badge Id</param>
	/// <returns>Instance of <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" /></returns>
	IBadgeIdentifier Get(long id);
}
