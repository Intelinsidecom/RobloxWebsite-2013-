using System;
using StackExchange.Redis;

namespace Roblox.RealTimeNotifications;

internal class RedisSubscriptionResult : ISubscriptionResult
{
	private readonly string _ChannelName;

	private readonly string _ServerId;

	private readonly object _CallbackAction;

	public string ChannelName => _ChannelName;

	public string ServerId => _ServerId;

	public object CallbackAction => _CallbackAction;

	public RedisSubscriptionResult(string channelName, string serverId, Action<RedisChannel, RedisValue> callbackAction)
	{
		_ChannelName = channelName;
		_ServerId = serverId;
		_CallbackAction = callbackAction;
	}
}
