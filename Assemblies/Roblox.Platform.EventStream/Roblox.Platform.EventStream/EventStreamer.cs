using System;
using System.Collections.Generic;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.EventStream.Properties;

namespace Roblox.Platform.EventStream;

public class EventStreamer : IEventStreamer
{
	private readonly ILogger _Logger;

	private readonly IEventSender _KinesisFirehoseSender;

	private readonly EventStreamerPerformanceMonitor _Perfmon;

	public EventStreamer(ICounterRegistry counterRegistry, ILogger logger)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_KinesisFirehoseSender = new AmazonKinesisFirehoseEventSender(logger);
		_Perfmon = new EventStreamerPerformanceMonitor(counterRegistry);
	}

	public void StreamEvent(string target, string eventType, IReadOnlyCollection<KeyValuePair<string, string>> eventParameters, string clientIp, bool isTrustedSource, string partitionKey = null)
	{
		if (string.IsNullOrWhiteSpace(target))
		{
			throw new ArgumentException("target is required");
		}
		if (string.IsNullOrWhiteSpace(eventType))
		{
			throw new ArgumentException("eventType is required");
		}
		if (!EventValidationUtils.ValidateTarget(target))
		{
			throw new InvalidEventTargetException("Invalid target " + target);
		}
		_Perfmon.MessagesAttemptedToSentPerSecond.Increment();
		if (Settings.Default.StreamToAmazonKinesisFirehoseEventEnabled)
		{
			_KinesisFirehoseSender.PublishEvent(target, eventType, eventParameters, clientIp, isTrustedSource);
		}
	}
}
