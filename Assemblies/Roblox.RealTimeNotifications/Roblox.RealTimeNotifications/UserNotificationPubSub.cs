using Roblox.Redis;

namespace Roblox.RealTimeNotifications;

internal class UserNotificationPubSub : RedisPubSub<long, UserNotification>
{
	private const string _ChannelNamePrefix = "UserNotifications_User:";

	public UserNotificationPubSub(IRedisClient redisClient)
		: base(redisClient)
	{
	}

	public override string KeyToChannelName(long userId)
	{
		return "UserNotifications_User:" + userId;
	}

	public override long ChannelNameToKey(string channelName)
	{
		if (!channelName.StartsWith("UserNotifications_User:"))
		{
			throw new PubSubChannelNameParseException("Not a valid UserNotificationPubSub Channel Name: '" + channelName + "'");
		}
		if (long.TryParse(channelName.Substring("UserNotifications_User:".Length), out var id))
		{
			return id;
		}
		throw new PubSubChannelNameParseException("Not a valid UserNotificationPubSub Channel Name: '" + channelName + "'");
	}
}
