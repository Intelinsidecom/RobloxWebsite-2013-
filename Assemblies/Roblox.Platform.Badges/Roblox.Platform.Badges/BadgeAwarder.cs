namespace Roblox.Platform.Badges;

/// <inheritdoc cref="T:Roblox.Platform.Badges.IBadgeAwarder" />
internal class BadgeAwarder : IBadgeAwarder
{
	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwarder.Id" />
	public long Id { get; set; }

	/// <inheritdoc cref="P:Roblox.Platform.Badges.IBadgeAwarder.Type" />
	public BadgeAwarderType Type { get; set; }
}
