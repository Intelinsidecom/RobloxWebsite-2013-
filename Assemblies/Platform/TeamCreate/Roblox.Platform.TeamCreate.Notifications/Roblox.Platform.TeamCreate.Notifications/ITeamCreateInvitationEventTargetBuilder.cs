using Roblox.Platform.Notifications.Core;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// Used to build the <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> for an <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" />.
/// </summary>
public interface ITeamCreateInvitationEventTargetBuilder
{
	/// <summary>
	/// Builds the <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> for an <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" />.
	/// </summary>
	/// <param name="notification">The <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotification" /></param>
	/// <returns>The built <see cref="T:Roblox.Platform.Notifications.Core.EventTarget" /> for the <paramref name="notification" /></returns>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="notification" /></exception>
	EventTarget BuildEventTarget(TeamCreateInvitationNotification notification);
}
