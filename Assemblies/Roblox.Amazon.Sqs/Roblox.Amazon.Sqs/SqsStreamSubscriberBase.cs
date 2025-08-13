using System;
using Newtonsoft.Json;
using Roblox.EventLog;
using Roblox.Time;

namespace Roblox.Amazon.Sqs;

public abstract class SqsStreamSubscriberBase : SqsThrottlingStreamSubscriberBase
{
	protected virtual bool IsIgnoreStaleMessagesEnabled => false;

	protected virtual TimeSpan TimeElapsedForMessageToBeConsideredStale => default(TimeSpan);

	protected abstract void ProcessMessage(string message);

	protected SqsStreamSubscriberBase(string perfmonInstanceName, ILogger logger)
		: base(perfmonInstanceName, logger)
	{
	}

	protected override bool ProcessMessage(ISqsMessage message)
	{
		ProcessMessage(message.Message);
		return true;
	}

	/// <summary>
	/// Deserializes the string message into the provided type (using Newtonsoft.Json). Does no exception handling - up to consumers how to handle deserialization exceptions.
	/// </summary>
	/// <param name="message"></param>
	/// <returns></returns>
	/// <exception cref="T:Newtonsoft.Json.JsonSerializationException">Thrown when the message cannot be deserialized into the given object</exception>
	protected T DeserializeMessage<T>(string message)
	{
		return JsonConvert.DeserializeObject<T>(JsonConvert.DeserializeObject<SqsMessage>(message).Message);
	}

	/// <summary>
	/// Utility method to check if AWS credentials have been configured for the subscriber correctly
	/// </summary>
	/// <returns>true if AWS credentials and SQS url are configured, false otherwise</returns>
	public bool IsSqsCredentialsConfigured()
	{
		if (!string.IsNullOrWhiteSpace(AwsAccessKeyAndSecretAccessKey))
		{
			return !string.IsNullOrWhiteSpace(AmazonSqsUrl);
		}
		return false;
	}

	/// <summary>
	/// Utility method to check if a message should be ignored - timestamp greater than a configured threshold
	/// This is disabled by default, and should be enabled in the derived sqs stream Implementations
	/// </summary>
	/// <param name="messageTimeStamp">sqs message timestamp</param>
	/// <param name="onDateTimeCoerced">callback on utc time coercion from DateTime failure</param>
	/// <returns>true if message is stale and should be Ignored</returns>
	protected bool IsMessageOutdated(DateTime? messageTimeStamp, Action<DateTimeKind> onDateTimeCoerced = null)
	{
		if (IsIgnoreStaleMessagesEnabled && TimeElapsedForMessageToBeConsideredStale != default(TimeSpan))
		{
			UtcInstant messageTimestampUtc = (messageTimeStamp.HasValue ? UtcInstant.CoerceFrom(messageTimeStamp.Value, onDateTimeCoerced) : null);
			if (messageTimestampUtc != null && DateTime.UtcNow.Subtract(messageTimestampUtc) > TimeElapsedForMessageToBeConsideredStale)
			{
				return true;
			}
		}
		return false;
	}
}
