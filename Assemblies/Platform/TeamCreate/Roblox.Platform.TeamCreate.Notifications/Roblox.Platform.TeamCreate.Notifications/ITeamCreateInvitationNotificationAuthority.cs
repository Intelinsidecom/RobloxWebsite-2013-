namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// Used to process events originating from the team create platform code, sends notifications to the involved parties accordingly.
/// </summary>
public interface ITeamCreateInvitationNotificationAuthority
{
	/// <summary>
	/// Process that an user has to been invited to a team create.
	/// </summary>
	/// <param name="actorId">The id of the user inviting the <paramref name="inviteeId" />"/&gt;.</param>
	/// <param name="inviteeId">The id of the user being invited.</param>
	/// <param name="universeId">The id of the universe the <paramref name="inviteeId" /> is being invited to.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="actorId" /> is not a valid user</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="inviteeId" /> is not a valid user</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="universeId" /> is not a valid universe</exception>
	void ProcessUserInvitationEvent(long actorId, long inviteeId, long universeId);

	/// <summary>
	/// Process that an user's invitation to a team create has been revoked.
	/// </summary>
	/// <param name="actorId">The id of the user removing the <paramref name="inviteeId" />"/&gt;.</param>
	/// <param name="inviteeId">The id of the user being removed.</param>
	/// <param name="universeId">The id of the universe the <paramref name="inviteeId" /> is no longer being invited to.</param>
	/// <exception cref="T:System.ArgumentException"><paramref name="actorId" /> is not a valid user</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="inviteeId" /> is not a valid user</exception>
	/// <exception cref="T:System.ArgumentException"><paramref name="universeId" /> is not a valid universe</exception>
	void ProcessUserInvitationRevokedEvent(long actorId, long inviteeId, long universeId);
}
