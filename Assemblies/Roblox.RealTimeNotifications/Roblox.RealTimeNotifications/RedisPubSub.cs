using System;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.RealTimeNotifications;

public abstract class RedisPubSub<TKeyInput, TPublishMessage> : IPubSub<TKeyInput, TPublishMessage>, IPublisher<TKeyInput, TPublishMessage>, ISubscriber<TKeyInput, TPublishMessage>
{
	private readonly IRedisClient _RedisClient;

	private static int _AsyncThrottleCounter;

	protected RedisPubSub(IRedisClient redisClient)
	{
		_RedisClient = redisClient;
	}

	public abstract string KeyToChannelName(TKeyInput input);

	public abstract TKeyInput ChannelNameToKey(string channelName);

	public ISubscriptionResult Subscribe(TKeyInput key, Action<string, TPublishMessage> successCallback, Action<Exception> errorCallback = null)
	{
		string channelName = KeyToChannelName(key);
		ISubscriber subscriber = _RedisClient.GetSubscriber(channelName);
		subscriber.Subscribe(channelName, typedCallback);
		if (!subscriber.IsConnected())
		{
			throw new PubSubSubcriptionException("Attempt to subscribe was unsuccessful");
		}
		string serverId = GetServerId(subscriber);
		return new RedisSubscriptionResult(channelName, serverId, typedCallback);
		void typedCallback(RedisChannel channel, RedisValue message)
		{
			try
			{
				TPublishMessage deserializedMessage = JsonConvert.DeserializeObject<TPublishMessage>(message);
				successCallback(channel, deserializedMessage);
			}
			catch (Exception ex)
			{
				errorCallback?.Invoke(ex);
			}
		}
	}

	public void SubscribeToServerDisconnect(TKeyInput key, Action<string, string> onConnectionFail)
	{
		string channelName = KeyToChannelName(key);
		ISubscriber subscriber = _RedisClient.GetSubscriber(channelName);
		string serverId = GetServerId(subscriber);
		subscriber.Multiplexer.ConnectionFailed += delegate(object sender, ConnectionFailedEventArgs args)
		{
			onConnectionFail(serverId, args.FailureType.ToString());
		};
		_RedisClient.Refreshed += delegate
		{
			onConnectionFail(serverId, "Redis Client Refreshed");
		};
	}

	public bool IsSubscribed(string channel)
	{
		return _RedisClient.GetSubscriber(channel).IsConnected(channel);
	}

	public void Unsubscribe(ISubscriptionResult subscriptionResult)
	{
		_RedisClient.GetSubscriber(subscriptionResult.ChannelName).Unsubscribe(subscriptionResult.ChannelName, (Action<RedisChannel, RedisValue>)subscriptionResult.CallbackAction);
	}

	public long Publish(TKeyInput key, TPublishMessage message)
	{
		string channelName = KeyToChannelName(key);
		return _RedisClient.GetSubscriber(channelName).Publish(message: JsonConvert.SerializeObject(message), channel: channelName);
	}

	private static string GetServerId(ISubscriber subscriber)
	{
		return string.Join(",", from x in subscriber.Multiplexer.GetEndPoints()
			select x.Serialize());
	}
}
