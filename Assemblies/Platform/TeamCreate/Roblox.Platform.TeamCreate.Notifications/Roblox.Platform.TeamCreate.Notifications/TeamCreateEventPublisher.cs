using System;
using Amazon;
using Newtonsoft.Json;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Membership;
using Roblox.Platform.TeamCreate.Notifications.Properties;
using Roblox.Platform.Universes;

namespace Roblox.Platform.TeamCreate.Notifications;

/// <summary>
/// The default implementation of an <see cref="T:Roblox.Platform.TeamCreate.Notifications.ITeamCreateEventPublisher" />.
/// This class is not unit-testable due to the usage of an <see cref="T:Roblox.Amazon.Sns.SnsPublisher" />.
/// </summary>
public class TeamCreateEventPublisher : ITeamCreateEventPublisher
{
	private SnsPublisher _Publisher;

	private readonly ICounterRegistry _CounterRegistry;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.TeamCreate.Notifications.TeamCreateEventPublisher" />.
	/// </summary>
	public TeamCreateEventPublisher(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.TeamCreateEventsSnsAwsAccessKeyAndSecretKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.TeamCreateEventsSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.TeamCreateEventsSnsAwsAccessKeyAndSecretKey.Split(',');
		if (awsKeys.Length == 2)
		{
			_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.TeamCreateEventsSnsTopicArn, "Roblox.TeamCreateEventPublisher", _CounterRegistry);
		}
	}

	/// <inheritdoc />
	public void PublishTeamCreateInvitation(IUser actor, IUser target, IUniverse universe)
	{
		if (actor == null)
		{
			throw new ArgumentNullException("actor");
		}
		if (target == null)
		{
			throw new ArgumentNullException("actor");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("actor");
		}
		if (Settings.Default.IsTeamCreateEventsPublishingEnabled)
		{
			TeamCreateInvitationEventArgs teamCreateEventArgs = new TeamCreateInvitationEventArgs
			{
				UserId = actor.Id,
				AffectedUserId = target.Id,
				UniverseId = universe.Id
			};
			TeamCreateEvent teamCreateEvent = new TeamCreateEvent
			{
				EventType = TeamCreateEventType.UserInvited,
				EventArgs = JsonConvert.SerializeObject(teamCreateEventArgs)
			};
			_Publisher.Publish(teamCreateEvent);
		}
	}

	/// <inheritdoc />
	public void PublishTeamCreateRevokedInvitation(IUser actor, IUser target, IUniverse universe)
	{
		if (actor == null)
		{
			throw new ArgumentNullException("actor");
		}
		if (target == null)
		{
			throw new ArgumentNullException("actor");
		}
		if (universe == null)
		{
			throw new ArgumentNullException("actor");
		}
		if (Settings.Default.IsTeamCreateEventsPublishingEnabled)
		{
			TeamCreateInvitationRevokedEventArgs teamCreateEventArgs = new TeamCreateInvitationRevokedEventArgs
			{
				UserId = actor.Id,
				AffectedUserId = target.Id,
				UniverseId = universe.Id
			};
			TeamCreateEvent teamCreateEvent = new TeamCreateEvent
			{
				EventType = TeamCreateEventType.UserInvitationRevoked,
				EventArgs = JsonConvert.SerializeObject(teamCreateEventArgs)
			};
			_Publisher.Publish(teamCreateEvent);
		}
	}
}
