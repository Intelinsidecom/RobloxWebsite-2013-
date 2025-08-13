using System.Threading;
using Newtonsoft.Json;
using Roblox.Amazon.Sqs;
using Roblox.EventLog;
using Roblox.Platform.Notifications.Core.Properties;

namespace Roblox.Platform.Notifications.Core.Events;

public class NotificationEventPublisher : INotificationEventPublisher
{
	private SqsBatchSender _BatchSender;

	private readonly ILogger _Logger;

	public NotificationEventPublisher(ILogger logger)
	{
		_Logger = logger;
	}

	public void PublishNew(INotification message)
	{
		EnsureBatchSenderInitialized();
		NewNotification newNotification = new NewNotification(message);
		NotificationEvent notificationEvent = new NotificationEvent(NotificationEventType.NewNotification, JsonConvert.SerializeObject(newNotification));
		_BatchSender.SendMessage(JsonConvert.SerializeObject(notificationEvent));
	}

	public void PublishUpdate(NotificationUpdate update)
	{
		EnsureBatchSenderInitialized();
		NotificationEvent notificationEvent = new NotificationEvent(NotificationEventType.UpdateToNotification, JsonConvert.SerializeObject(update));
		_BatchSender.SendMessage(JsonConvert.SerializeObject(notificationEvent));
	}

	public void PublishCategoryUpdate(CategoryUpdate update)
	{
		EnsureBatchSenderInitialized();
		NotificationEvent notificationEvent = new NotificationEvent(NotificationEventType.UpdateToCategory, JsonConvert.SerializeObject(update));
		_BatchSender.SendMessage(JsonConvert.SerializeObject(notificationEvent));
	}

	private void EnsureBatchSenderInitialized()
	{
		LazyInitializer.EnsureInitialized(ref _BatchSender, delegate
		{
			string[] array = Settings.Default.NotificationsPublisherAwsAccessKeyAndSecretKey.Split(',');
			SqsBatchSender sqsBatchSender = new SqsBatchSender(array[0], array[1], Settings.Default.NotificationsPublisherAmazonSqsUrl, 10, 100, 0, retryInOtherRegions: true);
			sqsBatchSender.ExceptionOccured += _Logger.Error;
			sqsBatchSender.Start();
			return sqsBatchSender;
		});
	}
}
