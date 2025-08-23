using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Web.Code.Properties;

namespace Roblox.Web.Code.Events;

public class WebSessionEventPublisher
{
	private static SnsPublisher _Publisher;

	static WebSessionEventPublisher()
	{
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.WebSessionSnsAwsAccessKeyAndSecretCSV, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.WebSessionSnsTopicArn, InitializePublisher);
	}

	private static void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.WebSessionSnsAwsAccessKeyAndSecretCSV.Split(',');
		_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.WebSessionSnsTopicArn, "Roblox.WebSessionEventPublisher", StaticCounterRegistry.Instance);
	}

	public static void Publish(long userId, byte platformTypeId, DateTime sessionStartTime, bool isSignupSession)
	{
		if (Settings.Default.PublishWebSessionEventsToSnsEnabled)
		{
			SessionStartMessage message = new SessionStartMessage
			{
				UserId = userId,
				PlatformTypeId = platformTypeId,
				SessionStartTime = sessionStartTime,
				IsSignupSession = isSignupSession
			};
			_Publisher.Publish(message);
		}
	}
}
