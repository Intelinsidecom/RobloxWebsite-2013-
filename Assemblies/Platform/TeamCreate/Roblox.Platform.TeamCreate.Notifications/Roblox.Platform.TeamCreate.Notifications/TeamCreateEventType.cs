namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The different types of <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateEvent" />s.
/// </summary>
internal enum TeamCreateEventType
{
	/// <summary>
	/// A user is invited to a team create.
	/// </summary>
	UserInvited,
	/// <summary>
	/// A user's invitation is revoked.
	/// </summary>
	UserInvitationRevoked
}
