using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Party.Properties;

namespace Roblox.Platform.Party.Events;

public class PartyEventsPublisher : IPartyEventsPublisher
{
	private SnsPublisher _Publisher;

	private readonly ICounterRegistry _CounterRegistry;

	public PartyEventsPublisher(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.PartyEventsSnsAwsAccessKeyAndSecretKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PartyEventsSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.PartyEventsSnsAwsAccessKeyAndSecretKey.Split(',');
		_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.PartyEventsSnsTopicArn, "Roblox.PartyEventPublisher", _CounterRegistry);
	}

	public void Publish(Guid partyId, PartyEventType partyEventType, long? affectedUserId = null)
	{
		if (Settings.Default.IsPartyEventPublishingEnabled && (partyEventType == PartyEventType.PartyReadyToBeDeleted || Settings.Default.IsPartyNonDeletionEventPublishingEnabled))
		{
			PartyEvent message = new PartyEvent
			{
				PartyEventType = partyEventType,
				PartyId = partyId,
				AffectedUserId = affectedUserId
			};
			_Publisher.Publish(message);
		}
	}
}
