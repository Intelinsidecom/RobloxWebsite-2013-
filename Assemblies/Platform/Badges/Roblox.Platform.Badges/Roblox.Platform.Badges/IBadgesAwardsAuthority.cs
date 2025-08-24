using System;
using System.Collections.Generic;
using Roblox.Platform.Core.ExclusiveStartPaging;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Badges;

/// <summary>
/// Authority resonsible for Badges awards
/// </summary>
public interface IBadgesAwardsAuthority
{
	/// <summary>
	/// Gets the allowed page sizes.
	/// </summary>
	IReadOnlyCollection<int> AllowedPageSizes { get; }

	/// <summary>
	/// Gets the maximum allowed page size.
	/// </summary>
	int MaxPageSize { get; }

	/// <summary>
	/// Gets the minimum allowed page size.
	/// </summary>
	int MinPageSize { get; }

	/// <summary>
	/// Raises when an <see cref="T:Roblox.Platform.Membership.IUser" /> is awarded a <see cref="T:Roblox.Platform.Badges.Badge" />.
	/// </summary>
	event Action<IBadgeIdentifier, IUserIdentifier> BadgeAwarded;

	/// <summary>
	/// Awards the badge to the specified user.
	/// </summary>
	/// <param name="recipient">The userIdentifier <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.</param>
	/// <param name="badgeIdentifier">The badge identifier.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// userIdentifier
	/// or
	/// badgeIdentifier
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	/// userIdentifier target id less than or equal to zero 
	/// or
	/// badgeIdentifier.TargetId less than or equal to zero 
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">
	/// Throws when a platform operation is not currently available at no fault of the caller.
	/// Possible reason: a datastore or related service is not available.
	/// </exception>
	/// <returns>
	/// <c>true</c> if the specified user is awarded; otherwise, <c>false</c>.
	/// </returns>
	bool Award(IUserIdentifier recipient, IBadgeIdentifier badgeIdentifier);

	/// <summary>
	/// Determines whether the specified user is awarded.
	/// </summary>
	/// <param name="userIdentifier">The userIdentifier <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.</param>
	/// <param name="badgeIdentifier">The badge identifier.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// userIdentifier
	/// or
	/// badgeIdentifier
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	/// userIdentifier target id equal to zero 
	/// or
	/// badgeIdentifier.TargetId less than or equal to zero 
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">
	/// Throws when a platform operation is not currently available at no fault of the caller.
	/// Possible reason: a datastore or related service is not available.
	/// </exception>
	/// <returns>
	///   <c>true</c> if the specified user is awarded; otherwise, <c>false</c>.
	/// </returns>
	bool IsAwarded(IUserIdentifier userIdentifier, IBadgeIdentifier badgeIdentifier);

	/// <summary>
	/// Gets the <see cref="T:System.DateTime" /> a <see cref="T:Roblox.Platform.Badges.Badge" /> was awarded to an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="badge">The <see cref="T:Roblox.Platform.Badges.IBadgeIdentifier" />.</param>
	/// <returns>The <see cref="T:System.DateTime" /> if the <see cref="T:Roblox.Platform.Membership.IUser" /> has the badge (otherwise <c>null</c>.)</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="user" />, <paramref name="badge" /></exception>
	DateTime? GetBadgeAwardedDate(IUserIdentifier user, IBadgeIdentifier badge);

	/// <summary>
	/// Revokes the badge from the specified user.
	/// </summary>
	/// <param name="recipient">The userIdentifier <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" />.</param>
	/// <param name="badgeIdentifier">The badge identifier.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// userIdentifier
	/// or
	/// badgeIdentifier
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">
	/// userIdentifier target id less than or equal to zero 
	/// or
	/// badgeIdentifier.TargetId less than or equal to zero 
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">
	/// Throws when a platform operation is not currently available at no fault of the caller.
	/// Possible reason: a datastore or related service is not available.
	/// </exception>
	/// <returns>
	/// <c>true</c> if the specified badge is revoked; otherwise, <c>false</c>.
	/// </returns>
	bool Revoke(IUserIdentifier recipient, IBadgeIdentifier badgeIdentifier);

	/// <summary>
	/// Gets the awarded badges by user identifier (ExclusiveStartItem based paging).
	/// </summary>
	/// <param name="recipient">The userIdentifier.</param>
	/// <param name="exclusiveStartKeyInfo">The exclusive start key details.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// userIdentifier
	/// or
	/// exclusiveStartDetails
	/// </exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Recipient TargetId has to be larger than zero</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformOperationUnavailableException">
	/// Throws when a platform operation is not currently available at no fault of the caller.
	/// Possible reason: a datastore or related service is not available.
	/// </exception>
	/// <returns>
	/// <see cref="T:Roblox.Platform.Core.ExclusiveStartPaging.IPlatformPageResponse`2" /> Platform page response which contain collection 
	/// of awarded badge identifiers <see cref="T:Roblox.Platform.Badges.IAwardedBadgeIdentifier" />
	/// </returns>
	IPlatformPageResponse<IAwardedBadgeIdentifier, IAwardedBadgeIdentifier> GetAwardedBadgesIdentifiersByRecipient(IUserIdentifier recipient, IExclusiveStartKeyInfo<IAwardedBadgeIdentifier> exclusiveStartKeyInfo);
}
