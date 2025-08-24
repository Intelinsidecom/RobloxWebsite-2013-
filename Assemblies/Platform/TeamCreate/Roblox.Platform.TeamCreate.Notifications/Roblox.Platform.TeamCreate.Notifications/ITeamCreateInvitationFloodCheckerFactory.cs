using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// A wrapper around an <see cref="T:Roblox.FloodCheckers.Core.IFloodCheckerFactory`1" /> which can create <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" />s to handle floodchecking team create invitation notifications.
/// This exists to extract the responsiblity as to how floodchecking is configured out of the <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationNotificationAuthority" />.
/// </summary>
public interface ITeamCreateInvitationFloodCheckerFactory
{
	/// <summary>
	/// Gets a floodchecker which handles floodchecking team create notifications for the <paramref name="invitee" /> to the <paramref name="universe" />.
	/// </summary>
	/// <param name="invitee">The <see cref="T:Roblox.Platform.Membership.IUser" />being invited to the <paramref name="universe" />.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> the <paramref name="invitee" /> is being invited to.</param>
	/// <returns>The <see cref="T:Roblox.FloodCheckers.Core.IFloodChecker" /> to use for the specified case.</returns>
	IFloodChecker GetFloodchecker(IUser invitee, IUniverse universe);
}
