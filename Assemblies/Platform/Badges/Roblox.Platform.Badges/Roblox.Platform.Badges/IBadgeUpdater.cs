using System;
using Roblox.Platform.MembershipCore;
using Roblox.TextFilter.Client;

namespace Roblox.Platform.Badges;

/// <summary>
/// Performs updates on <see cref="T:Roblox.Platform.Badges.Badge" />
/// </summary>
public interface IBadgeUpdater
{
	/// <summary>
	/// Raises on Badge successfully updated.
	/// </summary>
	event Action<Badge, BadgeUpdateType> BadgeUpdated;

	/// <summary>
	/// Updates Badge name and description
	/// </summary>
	/// <param name="badge"></param>
	/// <param name="textAuthor"></param>
	/// <param name="newName"></param>
	/// <param name="newDescription"></param>
	/// <param name="actorUserIdentity"></param>
	void SetNameAndDescription(Badge badge, IClientTextAuthor textAuthor, string newName, string newDescription, IUserIdentifier actorUserIdentity);

	/// <summary>
	/// Updates Badge image
	/// </summary>
	/// <param name="badge"></param>
	/// <param name="imageId"></param>
	void SetImage(Badge badge, long imageId);

	/// <summary>
	/// Updates Badge enable state
	/// </summary>
	/// <param name="badge"></param>
	/// <param name="isEnabled"></param>
	void SetEnabled(Badge badge, bool isEnabled);
}
