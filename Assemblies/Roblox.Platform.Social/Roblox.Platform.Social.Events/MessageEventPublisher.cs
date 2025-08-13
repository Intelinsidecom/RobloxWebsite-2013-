using System;
using Amazon;
using Roblox.Amazon.Sns;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Instrumentation;
using Roblox.Platform.Social.Properties;
using Roblox.RealTimeNotifications;

namespace Roblox.Platform.Social.Events;

public class MessageEventPublisher : IMessageEventPublisher
{
	private static string RealTimeMessageNotificationNamespace = "MessageNotification";

	private readonly ILogger _Logger;

	private SnsPublisher _Publisher;

	private readonly UserNotificationPublisher<UserNotificationMessage> _UserNotificationPublisherForMessage;

	private readonly ICounterRegistry _CounterRegistry;

	public MessageEventPublisher(ILogger logger, ICounterRegistry counterRegistry)
	{
		_Logger = logger;
		_CounterRegistry = counterRegistry;
		_UserNotificationPublisherForMessage = new UserNotificationPublisher<UserNotificationMessage>(logger, RealTimeMessageNotificationNamespace);
		InitializePublisher();
		Settings.Default.MonitorChanges((Settings s) => s.MessageEventPublisherSnsAwsAccessKeyAndSecretKey, InitializePublisher);
		Settings.Default.MonitorChanges((Settings s) => s.MessageEventSnsTopicArn, InitializePublisher);
	}

	private void InitializePublisher()
	{
		string[] awsKeys = Settings.Default.MessageEventPublisherSnsAwsAccessKeyAndSecretKey.Split(',');
		_Publisher = new SnsPublisher(awsKeys[0], awsKeys[1], RegionEndpoint.USEast1, Settings.Default.MessageEventSnsTopicArn, "Roblox.MessageEventPublisher", _CounterRegistry);
		_Publisher.SnsError += OnSnsError;
	}

	private void PublishMessageToSns(MessageEventType type, long messageId)
	{
		if (Settings.Default.PublishMessageEventsToSnsEnabled)
		{
			MessageEvent messageEvent = new MessageEvent(type, messageId);
			_Publisher.Publish(messageEvent);
		}
	}

	private void PublishMessageToRealTimeNotication(MessageEventType type, long messageId, long recipientUserId)
	{
		if (Settings.Default.PublishRealTimeMessageEvents)
		{
			UserNotificationMessage userNotificationMessage = new UserNotificationMessage(type, messageId);
			_UserNotificationPublisherForMessage.Publish(recipientUserId, userNotificationMessage);
		}
	}

	/// <summary>
	/// Publish a message event.
	/// </summary>
	/// <param name="type">The type of message event</param>
	/// <param name="messageId">The id of the message</param>
	/// <param name="recipientUserId">The user that will receive the message.</param>
	public void Publish(MessageEventType type, long messageId, long recipientUserId)
	{
		PublishMessageToSns(type, messageId);
		PublishMessageToRealTimeNotication(type, messageId, recipientUserId);
	}

	private void OnSnsError(Exception e, string message)
	{
		_Logger.Error($"Error sending SNS: {e}.\nMessage: {message}");
	}
}
