using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat.Events;

internal class PlayTogetherEventsPublisher : IPlayTogetherEventsPublisher
{
	private static ILogger _Logger;

	private SnsPublisher _Publisher;

	private readonly ICounterRegistry _CounterRegistry;

	public PlayTogetherEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger;
		_CounterRegistry = counterRegistry;
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.AwsAccessKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.AwsSecretAccessKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.PlayTogetherEventSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		_Logger.Info("Initializing Play Together Events Publisher");
		string[] keys = Settings.Default.PlayTogetherAwsAccessKeyAndSecretCSV.Split(',');
		_Publisher = new SnsPublisher(keys[0], keys[1], RegionEndpoint.USEast1, Settings.Default.PlayTogetherEventSnsTopicArn, "Roblox.PlayTogetherEventPublisher", _CounterRegistry);
		_Publisher.SnsError += OnSnsError;
	}

	private void OnSnsError(Exception exp, string message)
	{
		_Logger.Error($"Error sending SNS: {exp}.\nMessage: {message}");
	}

	public void Publish(PlayTogetherEvent eventToPublish)
	{
		if (Settings.Default.IsPlayTogetherPublishingEnabled)
		{
			_Publisher.Publish(eventToPublish);
		}
	}
}
