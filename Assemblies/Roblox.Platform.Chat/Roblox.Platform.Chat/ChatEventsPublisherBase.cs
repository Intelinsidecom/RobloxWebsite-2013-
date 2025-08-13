using System;
using Roblox.Amazon.Sns;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.Chat;

internal abstract class ChatEventsPublisherBase<T> where T : IChatEvent
{
	protected readonly ILogger Logger;

	protected SnsPublisher Publisher;

	protected readonly ICounterRegistry CounterRegistry;

	protected readonly Func<bool> IsPublishingEventEnabled;

	protected ChatEventsPublisherBase(ILogger logger, Func<bool> isPublishingEventEnabled, ICounterRegistry counterRegistry)
	{
		Logger = logger;
		IsPublishingEventEnabled = isPublishingEventEnabled;
		CounterRegistry = counterRegistry;
	}

	protected abstract void InitializePublisher();

	public void Publish(T eventToPublish, bool useDelay = false)
	{
		if (IsPublishingEventEnabled != null && IsPublishingEventEnabled())
		{
			Publisher?.Publish(eventToPublish);
		}
	}

	protected void OnSnsError(Exception e, string message)
	{
		Logger.Error($"Error sending SNS: {e}.\nMessage: {message}");
	}
}
