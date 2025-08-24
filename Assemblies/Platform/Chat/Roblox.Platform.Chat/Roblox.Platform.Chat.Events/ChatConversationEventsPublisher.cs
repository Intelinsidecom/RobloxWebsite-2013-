using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Chat.Properties;

namespace Roblox.Platform.Chat.Events;

internal class ChatConversationEventsPublisher : ChatEventsPublisherBase<ChatConversationEvent>
{
	public ChatConversationEventsPublisher(ILogger logger, ICounterRegistry counterRegistry)
		: base(logger, (Func<bool>)(() => Settings.Default.IsChatConversationEventPublishingEnabled), counterRegistry)
	{
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.ChatConversationEventsAwsAccessKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.ChatConversationEventsAwsSecretKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.ChatConversationEventsSnsTopicArn, InitializePublisher);
	}

	protected sealed override void InitializePublisher()
	{
		Logger.Info("Initializing Chat Conversation Events Publisher");
		Publisher = new SnsPublisher(Settings.Default.ChatConversationEventsAwsAccessKey, Settings.Default.ChatConversationEventsAwsSecretKey, RegionEndpoint.USEast1, Settings.Default.ChatConversationEventsSnsTopicArn, "Roblox.ChatConversationEventsPublisher", CounterRegistry);
		Publisher.SnsError += base.OnSnsError;
	}
}
