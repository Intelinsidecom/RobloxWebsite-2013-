using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.Badges;

/// <summary>
/// A class for creating badges.
/// </summary>
public interface IBadgeCreator
{
	/// <summary>
	/// Raises on Badge successfully created.
	/// </summary>
	event Action<Badge> BadgeCreated;

	/// <summary>
	/// Raises on Badge creation failure.
	/// </summary>
	event Action<BadgeCreationFailureReason> BadgeCreationFailed;

	/// <summary>
	/// Creates a badge to be awarded by an <see cref="T:Roblox.Platform.Universes.IUniverse" />
	/// </summary>
	/// <param name="creatingUser">The <see cref="T:Roblox.Platform.Membership.IUser" /> creating the badge.</param>
	/// <param name="awardingUniverse">The awarding <see cref="T:Roblox.Platform.Universes.IUniverse" />.</param>
	/// <param name="badgeIcon">The badge icon <see cref="T:Roblox.Platform.Assets.IImage" />.</param>
	/// <param name="name">The name of the badge.</param>
	/// <param name="description">The badge description.</param>
	/// <param name="platform">The platform the <see cref="T:Roblox.Platform.Membership.IUser" /> is purchasing the badge from. An unfortunate requirement of Marketplace client.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.Badges.Badge" />.</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="creatingUser" />, <paramref name="awardingUniverse" />, <paramref name="badgeIcon" />, <paramref name="platform" /></exception>
	/// <exception cref="T:System.ArgumentException">
	/// - <paramref name="name" /> is null or whitespace.
	/// - <paramref name="name" /> is longer than <see cref="P:Roblox.Platform.Badges.Properties.ISettings.MaxBadgeNameLength" />
	/// - <paramref name="description" /> is longer than <see cref="P:Roblox.Platform.Badges.Properties.ISettings.MaxBadgeDescriptionLength" />
	/// - <paramref name="awardingUniverse" /> does not have valid root place.
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Badges.UnauthorizedBadgeCreationException"><paramref name="creatingUser" /> does not have access to create badges for <paramref name="awardingUniverse" />.</exception>
	/// <exception cref="T:Roblox.Platform.Badges.UnauthorizedBadgeIconUsageException"><paramref name="creatingUser" /> does not have use <paramref name="badgeIcon" /> for the badge.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">Issue with dependant service for badge creation.</exception>
	/// <exception cref="!:PlatformBadgeTextFullyModeratedException">Badge text failed moderation check.</exception>
	Badge CreateBadge(IUser creatingUser, string name, string description, IUniverse awardingUniverse, IImage badgeIcon, IPlatform platform);
}
