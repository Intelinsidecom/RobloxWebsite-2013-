using System;
using System.Diagnostics.CodeAnalysis;
using Newtonsoft.Json;
using Roblox.Amazon.Firehose;
using Roblox.EventLog;
using Roblox.Platform.EventStream.Properties;

namespace Roblox.Platform.EventStream;

public class PushNotificationDataSender : IPushNotificationDataSender
{
	private readonly AmazonKinesisFirehoseBatchEventSender _AmazonKinesisFirehoseBatchEventSender;

	private readonly ILogger _Logger;

	/// <summary>
	/// Creates a PushNotificationDataSender with AWS Firehose settings with Push Notification STream Name
	/// </summary>
	/// <param name="logger"></param>
	public PushNotificationDataSender(ILogger logger)
	{
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AmazonKinesisFirehoseBatchEventSender = new AmazonKinesisFirehoseBatchEventSender(logger, Settings.Default.AmazonKinesisFirehoseAwsPushNotificationAccessKey, Settings.Default.AmazonKinesisFirehoseAwsPushNotificationAccessSecretKey, Settings.Default.AmazonKinesisFirehosePushNotificationStreamName, Settings.Default.AmazonKinesisFirehoseMaxBufferSizeOfRecord, Settings.Default.AmazonKinesisFirehoseMaxMessagesPerBatchRequest, Settings.Default.AmazonKinesisFirehoseMaxTimeoutPerMessage);
	}

	/// <inheritdoc cref="M:Roblox.Platform.EventStream.IPushNotificationDataSender.PublishData(Roblox.Platform.EventStream.IPushNotificationData)" />
	public void PublishData(IPushNotificationData pushNotificationData)
	{
		if (Settings.Default.IsStreamPushNotificationDataEnabled)
		{
			try
			{
				string formatted = JsonConvert.SerializeObject(pushNotificationData);
				EnqueueWork(formatted);
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
				throw;
			}
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual void EnqueueWork(string data)
	{
		_AmazonKinesisFirehoseBatchEventSender.EnqueueWork(data);
	}
}
