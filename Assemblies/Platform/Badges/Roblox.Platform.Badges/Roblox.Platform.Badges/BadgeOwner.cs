namespace Roblox.Platform.Badges;

/// <summary>
/// The owner of a <see cref="T:Roblox.Platform.Badges.Badge" />.
/// </summary>
public struct BadgeOwner
{
	/// <summary>
	/// The target Id of the owner.
	/// </summary>
	/// <remarks>
	/// An <see cref="T:Roblox.Platform.Membership.IUser" /> Id if the <see cref="P:Roblox.Platform.Badges.BadgeOwner.Type" /> is <see cref="F:Roblox.Platform.Badges.BadgeOwnerType.User" />,
	/// or an <see cref="T:Roblox.Platform.Groups.IGroup" /> Id if the <see cref="P:Roblox.Platform.Badges.BadgeOwner.Type" /> is <see cref="F:Roblox.Platform.Badges.BadgeOwnerType.Group" />.
	/// </remarks>
	public long Id { get; set; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Badges.BadgeOwnerType" />.
	/// </summary>
	public BadgeOwnerType Type { get; set; }
}
