using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace Roblox.RealTimeNotifications.Client;

public interface IRealTimeNotificationsClient
{
	PublishUserNotificationResult PublishUserNotification(long userId, JObject message, string notificationNamespace);

	Task<PublishUserNotificationResult> PublishUserNotificationAsync(long userId, JObject message, string notificationNamespace, CancellationToken cancellationToken);

	MultiPublishUserNotificationResult MultiPublishUserNotification(IReadOnlyList<long> userIds, JObject message, string notificationNamespace);

	Task<MultiPublishUserNotificationResult> MultiPublishUserNotificationAsync(IReadOnlyList<long> userIds, JObject message, string notificationNamespace, CancellationToken cancellationToken);

	PublishUserNotificationResult PublishBulkUserNotification(long userId, ICollection<JObject> messages, string notificationNamespace);

	Task<PublishUserNotificationResult> PublishBulkUserNotificationAsync(long userId, ICollection<JObject> messages, string notificationNamespace, CancellationToken cancellationToken);
}
