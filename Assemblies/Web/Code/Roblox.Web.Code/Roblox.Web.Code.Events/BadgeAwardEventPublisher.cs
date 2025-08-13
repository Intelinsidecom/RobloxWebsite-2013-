using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Web.Code.Properties;

namespace Roblox.Web.Code.Events;

public class BadgeAwardEventPublisher
{
	private SnsPublisher _Publisher;

	private readonly ICounterRegistry _CounterRegistry;

	public BadgeAwardEventPublisher(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.BadgeAwardEventsSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.BadgeAwardEventsSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.BadgeAwardEventsSnsAwsAccessKeyAndSecretCSV.Split(',');
		if (awsKeys.Length == 2)
		{
			_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.BadgeAwardEventsSnsTopicArn, "Roblox.BadgeAwardEventPublisher", _CounterRegistry);
		}
	}

	public void Publish(long userId, int badgeTypeId)
	{
		if (Settings.Default.PublisherBadgeAwardEventsToSnsEnabled)
		{
			BadgeAwardEvent messageEvent = new BadgeAwardEvent(userId, badgeTypeId);
			_Publisher.Publish(messageEvent);
		}
	}
}
