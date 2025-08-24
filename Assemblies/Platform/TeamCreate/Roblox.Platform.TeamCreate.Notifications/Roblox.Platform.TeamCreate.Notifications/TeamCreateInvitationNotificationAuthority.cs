using System;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationNotificationAuthority" />.
/// </summary>
public class TeamCreateInvitationNotificationAuthority : ITeamCreateInvitationNotificationAuthority
{
	private readonly INotificationDistributor _NotificationDistributor;

	private readonly ITeamCreateInvitationNotificationKeyBuilder _KeyBuilder;

	private readonly ITeamCreateInvitationEventTargetBuilder _EventTargetBuilder;

	private readonly IUserFactory _UserFactory;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly ITeamCreateInvitationFloodCheckerFactory _FloodCheckerFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationNotificationAuthority" />.
	/// </summary>
	/// <param name="notificationDistributor">A <see cref="T:Roblox.Platform.Notifications.INotificationDistributor" /></param>
	/// <param name="keyBuilder">A <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationNotificationKeyBuilder" /></param>
	/// <param name="eventTargetBuilder">A <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetBuilder" /></param>
	/// <param name="userFactory">A <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="universeFactory">A <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="notificationDistributor" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="keyBuilder" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="eventTargetBuilder" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="floodCheckerFactory" /></exception>
	public TeamCreateInvitationNotificationAuthority(INotificationDistributor notificationDistributor, ITeamCreateInvitationNotificationKeyBuilder keyBuilder, ITeamCreateInvitationEventTargetBuilder eventTargetBuilder, IUserFactory userFactory, IUniverseFactory universeFactory, ITeamCreateInvitationFloodCheckerFactory floodCheckerFactory)
	{
		_NotificationDistributor = notificationDistributor ?? throw new ArgumentNullException("notificationDistributor");
		_KeyBuilder = keyBuilder ?? throw new ArgumentNullException("keyBuilder");
		_EventTargetBuilder = eventTargetBuilder ?? throw new ArgumentNullException("eventTargetBuilder");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		_FloodCheckerFactory = floodCheckerFactory ?? throw new ArgumentNullException("floodCheckerFactory");
	}

	/// <inheritdoc />
	public void ProcessUserInvitationEvent(long actorId, long inviteeId, long universeId)
	{
		IUser actor = _UserFactory.GetUser(actorId);
		if (actor == null)
		{
			throw new ArgumentException("Specified actor does not exist.", "actorId");
		}
		IUser invitee = _UserFactory.GetUser(inviteeId);
		if (invitee == null)
		{
			throw new ArgumentException("Specified inviter does not exist.", "inviteeId");
		}
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		if (universe == null)
		{
			throw new ArgumentException("Specified universe does not exist.", "universeId");
		}
		IFloodChecker floodChecker = _FloodCheckerFactory.GetFloodchecker(invitee, universe);
		if (!floodChecker.IsFlooded())
		{
			floodChecker.UpdateCount();
			TeamCreateInvitationNotification notification = new TeamCreateInvitationNotification(_KeyBuilder, _EventTargetBuilder)
			{
				Generator = new NotificationGenerator
				{
					GeneratorType = NotificationGeneratorType.User,
					GeneratorId = actor.Id
				},
				AddedUserId = invitee.Id,
				UniverseId = universe.Id,
				EventDate = DateTime.UtcNow
			};
			_NotificationDistributor.DistributeNotification(notification);
		}
	}

	/// <inheritdoc />
	public void ProcessUserInvitationRevokedEvent(long actorId, long inviteeId, long universeId)
	{
		IUser actor = _UserFactory.GetUser(actorId);
		if (actor == null)
		{
			throw new ArgumentException("Specified actor does not exist.", "actorId");
		}
		IUser invitee = _UserFactory.GetUser(inviteeId);
		if (invitee == null)
		{
			throw new ArgumentException("Specified inviter does not exist.", "inviteeId");
		}
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		if (universe == null)
		{
			throw new ArgumentException("Specified universe does not exist.", "universeId");
		}
		string notificationKey = _KeyBuilder.BuildKey(actor, invitee, universe);
		_NotificationDistributor.UpdateNotificationStatusByNotificationKey(UserToReceiver(invitee), NotificationSourceType.TeamCreateInvite, ReceiverNotificationStatus.Revoked, notificationKey);
	}

	/// <summary>
	/// A helper method replacing the IUser.ToReceiver() extension method.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> to convert to an <see cref="T:Roblox.Platform.Notifications.Core.IReceiver" /></param>
	/// <returns><paramref name="user" /> as a <see cref="T:Roblox.Platform.Notifications.Core.IReceiver" /></returns>
	internal virtual IReceiver UserToReceiver(IUser user)
	{
		return Roblox.Platform.Notifications.Core.Accessors.ReceiverAccessor.GetByReceiverTypeAndTarget(ReceiverType.User, user.Id);
	}
}
