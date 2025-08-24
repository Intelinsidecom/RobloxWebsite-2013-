using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.DataAccess;
using Roblox.EventLog;
using Roblox.Platform.Membership;
using Roblox.Platform.Notifications.Core;
using Roblox.Platform.Notifications.Stream.Properties;
using Roblox.Redis.Lru;

namespace Roblox.Platform.Notifications.Stream;

public class NotificationStreamFactory : INotificationStreamFactory
{
	private const string _FirstInteractionScreenName = "NotificationStreamFirstInteraction";

	private readonly INotificationStreamAccessor _NotificationStreamAccessor;

	private readonly RobloxScreen _NotificationStreamScreen;

	private readonly ILogger _Logger;

	public NotificationStreamFactory(INotificationEventPublisher notificationEventPublisher, INotificationStreamRedisClients notificationStreamRedisClients, ILogger logger, IStreamNotificationEventPublisher streamNotificationEventPublisher)
	{
		_NotificationStreamAccessor = new NotificationStreamAccessor(notificationEventPublisher, notificationStreamRedisClients.EphemeralRedisClient, RedisLruClient.GetInstance(), logger, streamNotificationEventPublisher, new UnreadCountTracker(notificationStreamRedisClients.EphemeralRedisClient, GetUtcNow), new HourlyEventCountTracker(notificationStreamRedisClients.PersistentRedisClient, Settings.Default.NotificationStreamEventExpirationDelay));
		_NotificationStreamScreen = RobloxScreen.Get("NotificationStreamFirstInteraction");
		_Logger = logger;
	}

	public ICollection<INotificationStreamEventGroupWithMetadata> GetRecentNotifications(IReceiver receiver, int startIndex, int maxRows)
	{
		return (from r in _NotificationStreamAccessor.GetRecentNotifications(receiver, startIndex, maxRows)
			select new NotificationStreamEventGroupWithMetadata
			{
				EventCount = r.EventCount,
				EventDate = r.EventDate,
				Events = r.Events?.Select((Func<NotificationStreamEvent, INotificationStreamEvent>)((NotificationStreamEvent ev) => ev)).ToList(),
				SourceType = r.SourceType
			}).Select((Func<NotificationStreamEventGroupWithMetadata, INotificationStreamEventGroupWithMetadata>)((NotificationStreamEventGroupWithMetadata result) => result)).ToList();
	}

	public long GetUnreadNotificationCount(IReceiver receiver)
	{
		long unreadCount = _NotificationStreamAccessor.GetUnreadNotificationCount(receiver);
		if (unreadCount >= 0)
		{
			return unreadCount;
		}
		_Logger.Warning($"The Notification Stream Unread Count is negative for receiver: {receiver.Id}");
		return 0L;
	}

	public void MarkUserInteractedWithNotificationStream(IUser user)
	{
		UserScreenSetting userScreen = UserScreenSetting.GetUserScreenSettingByUserIdRobloxScreenIdAndParameter(user.Id, _NotificationStreamScreen.ID, string.Empty);
		if (userScreen == null)
		{
			UserScreenSetting.CreateNew(user.Id, _NotificationStreamScreen.ID, issuppressed: true, string.Empty);
			return;
		}
		userScreen.IsSuppressed = true;
		userScreen.Save();
	}

	public bool HasUserInteractedWithNotificationStream(IUser user)
	{
		return (UserScreenSetting.GetUserScreenSettingByUserIdRobloxScreenIdAndParameter(user.Id, _NotificationStreamScreen.ID, string.Empty) ?? UserScreenSetting.CreateNew(user.Id, _NotificationStreamScreen.ID, issuppressed: false, string.Empty)).IsSuppressed;
	}

	public bool IsUserAccountOldEnoughForNotificationStreamPrompt(IUser user)
	{
		return DateTime.Now.Subtract(user.Created) >= Settings.Default.NotificationStreamPromptAccountAgeRequirement;
	}

	public bool ShouldShowNotificationStreamPromptToUser(IUser user)
	{
		if (!HasUserInteractedWithNotificationStream(user))
		{
			return IsUserAccountOldEnoughForNotificationStreamPrompt(user);
		}
		return false;
	}

	private static DateTime GetUtcNow()
	{
		return DateTime.UtcNow;
	}
}
