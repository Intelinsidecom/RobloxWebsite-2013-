using Roblox.EventLog;
namespace Roblox.Platform.RealTimeNotifications
{
    public static class UserNotificationSubscriberFactory
    {
        public static ISubscriber<long, UserNotification> Get(ILogger logger)
        {
            return new UserNotificationPubSub(UserNotificationRedisClientProvider.GetRedisClient(logger));
        }
    }
}
