using System;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.TeamCreate.Notifications.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateInvitationFloodCheckerFactory" />.
/// </summary>
public class TeamCreateInvitationFloodCheckerFactory : ITeamCreateInvitationFloodCheckerFactory
{
	private const string _FloodCheckerCategory = "Roblox.TeamCreate.Notifications.TeamCreateInvitation";

	private readonly IFloodCheckerFactory<IFloodChecker> _FloodCheckerFactory;

	private readonly Func<int> _FloodCheckerLimitGetter;

	private readonly Func<TimeSpan> _FloodCheckerLimitWindowGetter;

	private readonly Func<bool> _FloodCheckerEnabledGetter;

	private readonly Func<bool> _FloodCheckerRecordGlobalEventsGetter;

	private readonly ILogger _Logger;

	private string _FloodCheckerKey(long inviteeId, long universeId)
	{
		return $"{inviteeId}_{universeId}";
	}

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationFloodCheckerFactory" />.
	/// </summary>
	/// <param name="floodCheckerFactory">An <see cref="T:Roblox.FloodCheckers.Core.IFloodCheckerFactory`1" /></param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="floodCheckerFactory" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
	public TeamCreateInvitationFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, ILogger logger)
		: this(floodCheckerFactory, () => Settings.Default.TeamCreateInvitationFloodcheckerLimit, () => Settings.Default.TeamCreateInvitationFloodcheckerLimitWindow, () => Settings.Default.TeamCreateInvitationFloodcheckerEnabled, () => Settings.Default.TeamCreateInvitationFloodcheckerRecordGlobalEventsEnabled, logger)
	{
	}

	/// <summary>
	/// An internal constructor for the <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateInvitationFloodCheckerFactory" />.
	/// </summary>
	/// <param name="floodCheckerFactory">An <see cref="T:Roblox.FloodCheckers.Core.IFloodCheckerFactory`1" /></param>
	/// <param name="floodCheckerLimitGetter">A <see cref="T:System.Func`1" /> to get the total count of allowed notifications per user:universe in the specified window.</param>
	/// <param name="floodCheckerLimitWindowGetter">An <see cref="T:System.Func`1" /> to get the window size.</param>
	/// <param name="floodCheckerEnabledGetter">An <see cref="T:System.Func`1" /> which dictates whether floodchecking is enabled.</param>
	/// <param name="floodCheckerRecordGlobalEventsGetter">An <see cref="T:System.Func`1" /> which dictates as to whether we should record global events.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="floodCheckerLimitGetter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="floodCheckerLimitWindowGetter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="floodCheckerEnabledGetter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="floodCheckerRecordGlobalEventsGetter" /></exception>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="logger" /></exception>
	internal TeamCreateInvitationFloodCheckerFactory(IFloodCheckerFactory<IFloodChecker> floodCheckerFactory, Func<int> floodCheckerLimitGetter, Func<TimeSpan> floodCheckerLimitWindowGetter, Func<bool> floodCheckerEnabledGetter, Func<bool> floodCheckerRecordGlobalEventsGetter, ILogger logger)
	{
		_FloodCheckerFactory = floodCheckerFactory ?? throw new ArgumentNullException("floodCheckerFactory");
		_FloodCheckerLimitGetter = floodCheckerLimitGetter ?? throw new ArgumentNullException("floodCheckerLimitGetter");
		_FloodCheckerLimitWindowGetter = floodCheckerLimitWindowGetter ?? throw new ArgumentNullException("floodCheckerLimitWindowGetter");
		_FloodCheckerEnabledGetter = floodCheckerEnabledGetter ?? throw new ArgumentNullException("floodCheckerEnabledGetter");
		_FloodCheckerRecordGlobalEventsGetter = floodCheckerRecordGlobalEventsGetter ?? throw new ArgumentNullException("floodCheckerRecordGlobalEventsGetter");
		_Logger = logger ?? throw new ArgumentNullException("logger");
	}

	/// <inheritdoc />
	public IFloodChecker GetFloodchecker(IUser invitee, IUniverse universe)
	{
		if (invitee == null)
		{
			throw new ArgumentNullException("invitee");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("universe");
		}
		string key = _FloodCheckerKey(invitee.Id, universe.Id);
		return _FloodCheckerFactory.GetFloodChecker("Roblox.TeamCreate.Notifications.TeamCreateInvitation", key, _FloodCheckerLimitGetter, _FloodCheckerLimitWindowGetter, _FloodCheckerEnabledGetter, _FloodCheckerRecordGlobalEventsGetter, _Logger);
	}
}
