using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Groups.Properties;

namespace Roblox.Platform.Groups.Events;

public class ClanEventPublisher
{
	private static SnsPublisher _Publisher;

	static ClanEventPublisher()
	{
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.ClanEventPublisherSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.ClanEventPublisherSnsTopicArn, InitializePublisher);
	}

	private static void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.ClanEventPublisherSnsAwsAccessKeyAndSecretCSV.Split(',');
		_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.ClanEventPublisherSnsTopicArn, "Roblox.ClanEventPublisher", StaticCounterRegistry.Instance);
	}

	private static void PublishClanEvent(ClanEventType eventType, long clanId, long? userId = null, long? enemyClanId = null)
	{
		if (Settings.Default.PublishClanEventsToSnsEnabled)
		{
			ClanEventMessage message = new ClanEventMessage
			{
				EventType = (byte)eventType,
				ClanId = clanId,
				UserId = userId,
				EnemyClanId = enemyClanId
			};
			_Publisher.Publish(message);
		}
	}

	public static void PublishUserJoinedClan(long clanId, long userId)
	{
		PublishClanEvent(ClanEventType.UserJoinedClan, clanId, userId);
	}

	public static void PublishUserLeftClan(long clanId, long userId)
	{
		PublishClanEvent(ClanEventType.UserLeftClan, clanId, userId);
	}

	public static void PublishClanDeleted(long clanId)
	{
		PublishClanEvent(ClanEventType.ClanDeleted, clanId);
	}

	public static void PublishClanEnemyStatusTerminated(long clanId, long enemyClanId)
	{
		PublishClanEvent(ClanEventType.ClanEnemyStatusTerminated, clanId, null, enemyClanId);
	}
}
