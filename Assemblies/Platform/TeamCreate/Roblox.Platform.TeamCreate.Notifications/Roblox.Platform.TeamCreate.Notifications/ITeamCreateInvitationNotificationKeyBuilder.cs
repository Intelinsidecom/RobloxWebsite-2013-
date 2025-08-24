using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// A builder to create the key uniquely identifying each notification.
/// </summary>
public interface ITeamCreateInvitationNotificationKeyBuilder
{
	/// <summary>
	/// Builds the key for a notification.
	/// </summary>
	/// <param name="inviter">The <see cref="T:Roblox.Platform.Membership.IUser" /> inviting the <paramref name="invitee" /></param>
	/// <param name="invitee">The <see cref="T:Roblox.Platform.Membership.IUser" /> being invited.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> the <paramref name="invitee" /> is being invited to.</param>
	/// <returns>the key identifying the notification</returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="inviter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="invitee" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universe" /></exception>
	string BuildKey(IUser inviter, IUser invitee, IUniverse universe);

	/// <summary>
	/// Builds the key for a notification.
	/// </summary>
	/// <param name="inviterUserId"></param>
	/// <param name="inviteeUserId"></param>
	/// <param name="universeId"></param>
	/// <returns>the key identifying the notification</returns>
	string BuildKey(long inviterUserId, long inviteeUserId, long universeId);
}
