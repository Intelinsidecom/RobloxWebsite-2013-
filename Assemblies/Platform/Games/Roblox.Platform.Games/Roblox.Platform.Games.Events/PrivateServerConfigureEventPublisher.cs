using System.Collections.Generic;
using System.Linq;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games.Events;

public class PrivateServerConfigureEventPublisher
{
	private static SnsPublisher _Publisher;

	static PrivateServerConfigureEventPublisher()
	{
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.PrivateServerConfigurationSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PrivateServerConfigurationSnsTopicArn, InitializePublisher);
	}

	private static void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.PrivateServerConfigurationSnsAwsAccessKeyAndSecretCSV.Split(',');
		_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.PrivateServerConfigurationSnsTopicArn, "Roblox.PrivateServerConfiguration", StaticCounterRegistry.Instance);
	}

	public static void PublishModifyWhitelistEvent(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.ModifyWhiteList }, privateServerId);
	}

	public static void PublishOwnerDeactivateEvent(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.OwnerDeactivate }, privateServerId);
	}

	public static void PublishOwnerCancelEvent(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.OwnerCancel }, privateServerId);
	}

	public static void PublishOwnerActivateEvent(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.OwnerActivate }, privateServerId);
	}

	public static void PublishOwnerDisallowFriendsEvent(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.OwnerDisallowFriends }, privateServerId);
	}

	public static void PublishOwnerAllowFriendsEvent(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.OwnerAllowFriends }, privateServerId);
	}

	public static void PublishOwnerChangeAllowedClans(long privateServerId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.OwnerChangeAllowedClans }, privateServerId);
	}

	public static void PublishDeveloperDisallowEvent(long universeId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.DeveloperDisallow }, null, universeId);
	}

	public static void PublishDeveloperAllowEvent(long universeId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.DeveloperAllow }, null, universeId);
	}

	public static void PublishDeveloperChangePriceEvent(long universeId)
	{
		PublishEvents(new ServerConfigurationEventType[1] { ServerConfigurationEventType.DeveloperChangePrice }, null, universeId);
	}

	public static void PublishEvents(IEnumerable<ServerConfigurationEventType> serverConfigurationEventTypes, long? privateServerId = null, long? universeId = null)
	{
		if (Settings.Default.PublishPrivateServerConfigurationEventsToSnsEnabled && (privateServerId.HasValue || universeId.HasValue))
		{
			PrivateServerConfigureMessage message = new PrivateServerConfigureMessage
			{
				PrivateServerId = privateServerId,
				UniverseId = universeId
			};
			List<byte> eventTypes = new List<byte>(serverConfigurationEventTypes.Select((ServerConfigurationEventType et) => (byte)et));
			if (eventTypes.Any())
			{
				message.EventTypes = eventTypes;
				_Publisher.Publish(message);
			}
		}
	}
}
