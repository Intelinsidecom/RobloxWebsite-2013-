using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// Handles parsing the <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> for the <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" />.
/// Can build the <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationDetail" /> from an <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" />.
/// </summary>
public interface ITeamCreateInvitationEventTargetInterpreter
{
	/// <summary>
	/// Builds a <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationDetail" /> from an <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" />.
	/// </summary>
	/// <param name="eventTarget">The <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> of the notification for which the details should be built.</param>
	/// <param name="eventDate">The time the notification was sent.</param>
	/// <returns>The created <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationDetail" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTarget" /></exception>
	/// <exception cref="T:System.ArgumentException">the actor specfied within the <paramref name="eventTarget" /> does not exist</exception>
	/// <exception cref="T:System.ArgumentException">the invitee specfied within the <paramref name="eventTarget" /> does not exist</exception>
	/// <exception cref="T:System.ArgumentException">the universe specfied within the <paramref name="eventTarget" /> does not exist</exception>
	TeamCreateInvitationDetail BuildDetail(EventTarget eventTarget, DateTime eventDate);

	/// <summary>
	/// Extracts the invited <see cref="T:Roblox.Platform.Membership.IUser" /> from an <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> for a <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" />.
	/// </summary>
	/// <param name="eventTarget">The <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> for a <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" /></param>
	/// <returns>the invited <see cref="T:Roblox.Platform.Membership.IUser" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTarget" /></exception>
	IUser GetInvitee(EventTarget eventTarget);
}
