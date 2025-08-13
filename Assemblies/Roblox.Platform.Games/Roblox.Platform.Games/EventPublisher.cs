using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Games.Properties;

namespace Roblox.Platform.Games;

public class EventPublisher : IEventPublisher
{
	private readonly SnsPublisher _Publisher;

	private readonly ILogger _Logger;

	public EventPublisher(string topicArn, string awsAccessKey, string awsSecretAccessKey, ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger;
		try
		{
			_Publisher = new SnsPublisher(awsAccessKey, awsSecretAccessKey, RegionEndpoint.USEast1, topicArn, "Roblox.GamesV3.SNS", counterRegistry);
		}
		catch (Exception e)
		{
			if (Settings.Default.IsThrowExceptionOnPublisherInitializationEnabled)
			{
				_Logger.Error(e);
			}
		}
	}

	private void Publish(object message)
	{
		if (_Publisher != null)
		{
			_Publisher.Publish(message);
		}
		else if (Settings.Default.IsThrowExceptionOnPublishEnabled)
		{
			_Logger.Error("Sns Publisher failed to initialize");
		}
	}

	public void PublishGameUpdatedEvent(long placeid)
	{
		var message = new
		{
			Action = "GameUpdated",
			PlaceId = placeid
		};
		Publish(message);
	}

	public void PublishGameRemovedEvent(long placeid)
	{
		var message = new
		{
			Action = "GameRemoved",
			PlaceId = placeid
		};
		Publish(message);
	}
}
