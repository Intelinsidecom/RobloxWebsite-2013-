using Roblox.Platform.Membership;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// Publishes events around the team create feature.
/// </summary>
public interface ITeamCreateEventPublisher
{
	/// <summary>
	/// A user was invited to a team create.
	/// </summary>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> inviting the <paramref name="target" /></param>
	/// <param name="target">The <see cref="T:Roblox.Platform.Membership.IUser" /> being invited.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> the <see cref="T:Roblox.Platform.Membership.IUser" /> is invited to.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="actor" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="target" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universe" /></exception>
	void PublishTeamCreateInvitation(IUser actor, IUser target, IUniverse universe);

	/// <summary>
	/// A user was removed from a team create.
	/// </summary>
	/// <param name="actor">The <see cref="T:Roblox.Platform.Membership.IUser" /> removing the <paramref name="target" /></param>
	/// <param name="target">The <see cref="T:Roblox.Platform.Membership.IUser" /> being removed.</param>
	/// <param name="universe">The <see cref="T:Roblox.Platform.Universes.IUniverse" /> the <see cref="T:Roblox.Platform.Membership.IUser" /> is no longer invited to.</param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="actor" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="target" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universe" /></exception>
	void PublishTeamCreateRevokedInvitation(IUser actor, IUser target, IUniverse universe);
}
