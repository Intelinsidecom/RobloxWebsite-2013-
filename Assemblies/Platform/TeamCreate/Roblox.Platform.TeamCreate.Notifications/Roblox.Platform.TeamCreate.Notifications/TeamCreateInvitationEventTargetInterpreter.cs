using System;
using Roblox.Platform.Assets;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationEventTargetInterpreter" />.
/// </summary>
public class TeamCreateInvitationEventTargetInterpreter : ITeamCreateInvitationEventTargetInterpreter
{
	private readonly IUserFactory _UserFactory;

	private readonly IUniverseFactory _UniverseFactory;

	private readonly IPlaceFactory _PlaceFactory;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationEventTargetInterpreter" />.
	/// </summary>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="universeFactory">An <see cref="T:Roblox.Platform.Universes.IUniverseFactory" /></param>
	/// <param name="placeFactory">An <see cref="T:Roblox.Platform.Assets.IPlaceFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="userFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="universeFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="placeFactory" /></exception>
	public TeamCreateInvitationEventTargetInterpreter(IUserFactory userFactory, IUniverseFactory universeFactory, IPlaceFactory placeFactory)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_UniverseFactory = universeFactory ?? throw new ArgumentNullException("universeFactory");
		_PlaceFactory = placeFactory ?? throw new ArgumentNullException("placeFactory");
	}

	/// <inheritdoc />
	public TeamCreateInvitationDetail BuildDetail(EventTarget eventTarget, DateTime eventTime)
	{
		(long inviterUserId, long inviteeUserId, long universeId) tuple = ParseKey(eventTarget);
		long inviterUserId = tuple.inviterUserId;
		long inviteeUserId = tuple.inviteeUserId;
		long universeId = tuple.universeId;
		IUser inviter = _UserFactory.GetUser(inviterUserId);
		if (inviter == null)
		{
			throw new ArgumentException("Specified generator user does not exist.", "eventTarget");
		}
		IUser invitee = _UserFactory.GetUser(inviteeUserId);
		if (invitee == null)
		{
			throw new ArgumentException("Specified invited user does not exist.", "eventTarget");
		}
		IUniverse universe = _UniverseFactory.GetUniverse(universeId);
		if (universe == null)
		{
			throw new ArgumentException("Specified universe does not exist.", "eventTarget");
		}
		string gameName = universe.Name;
		if (universe.RootPlaceId.HasValue)
		{
			IPlace rootPlace = _PlaceFactory.Get(universe.RootPlaceId.Value);
			if (rootPlace != null)
			{
				gameName = rootPlace.Name;
			}
		}
		return new TeamCreateInvitationDetail
		{
			ActingUserId = inviter.Id,
			ActingUsername = inviter.Name,
			AffectedUserId = invitee.Id,
			AffectedUsername = invitee.Name,
			UniverseId = universe.Id,
			UniverseName = gameName,
			RootPlaceId = (universe.RootPlaceId ?? 0)
		};
	}

	/// <inheritdoc />
	public IUser GetInvitee(EventTarget eventTarget)
	{
		long inviteeUserId = ParseKey(eventTarget).inviteeUserId;
		return _UserFactory.GetUser(inviteeUserId);
	}

	private (long inviterUserId, long inviteeUserId, long universeId) ParseKey(EventTarget eventTarget)
	{
		if (string.IsNullOrEmpty(eventTarget))
		{
			throw new ArgumentNullException("eventTarget");
		}
		string[] array = eventTarget.ToString().Split('_');
		if (array.Length != 3)
		{
			throw new ArgumentException("Invalid event target format.", "eventTarget");
		}
		if (!long.TryParse(array[0], out var inviterUserId))
		{
			throw new ArgumentException("EventTarget did not have a valid inviter user id.", "eventTarget");
		}
		if (!long.TryParse(array[1], out var inviteeUserId))
		{
			throw new ArgumentException("EventTarget did not have a valid invitee user id.", "eventTarget");
		}
		if (!long.TryParse(array[2], out var universeId))
		{
			throw new ArgumentException("EventTarget did not have a valid universe id.", "eventTarget");
		}
		return (inviterUserId, inviteeUserId, universeId);
	}
}
