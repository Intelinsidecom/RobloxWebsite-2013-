namespace Roblox.Platform.Badges;

internal class BadgeIdentifierFactory : IBadgeIdentifierFactory
{
	/// <summary>
	/// Returns wrapper which implements <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />
	/// </summary>
	/// <param name="id">Badge Id</param>
	/// <returns><see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" /></returns>
	public IBadgeIdentifier Get(long id)
	{
		return new BadgeIdentifier
		{
			Id = id
		};
	}
}
