using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat.Events;

internal class ChatEventsPublisher : ChatEventsPublisherBase<ChatEvent>
{
	public ChatEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
		: base(logger, (Func<bool>)(() => Settings.Default.IsChatEventPublishingEnabled), counterRegistry)
	{
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.AwsAccessKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.AwsSecretAccessKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.ChatEventSnsTopicArn, InitializePublisher);
	}

	protected sealed override void InitializePublisher()
	{
		Logger.Info("Initializing Chat Events Publisher");
		Publisher = new SnsPublisher(Settings.Default.AwsAccessKey, Settings.Default.AwsSecretAccessKey, RegionEndpoint.USEast1, Settings.Default.ChatEventSnsTopicArn, "Roblox.ChatEventPublisher", CounterRegistry);
		Publisher.SnsError += base.OnSnsError;
	}
}
