using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Roblox.EventLog;
using Roblox.RealTimeNotifications.Properties;

namespace Roblox.RealTimeNotifications;

public class SubscriptionProxy<TKeyInput, TSubscriberId, TPublishMessage> : ISubscriptionProxy<TKeyInput, TSubscriberId>
{
	/// <summary>
	/// Event handler when the server which is serving the subscription disconnects.
	/// </summary>
	/// <param name="serverId">The server id.</param>
	/// <param name="reason">The reason of disconnection.</param>
	public delegate void SubscriptionServerDisconnectEventHandler(string serverId, string reason);

	private readonly ISubscriber<TKeyInput, TPublishMessage> _Subscriber;

	private readonly Action<string, TPublishMessage> _MessageHandler;

	private readonly Action<TKeyInput, string, SubscriptionEvent> _SubscriptionEventHandler;

	private readonly ILogger _Logger;

	private readonly ConcurrentDictionary<TKeyInput, SubscriptionStatus<TKeyInput, TSubscriberId>> _SubscriptionConsumers = new ConcurrentDictionary<TKeyInput, SubscriptionStatus<TKeyInput, TSubscriberId>>();

	private readonly Dictionary<string, HashSet<SubscriptionStatus<TKeyInput, TSubscriberId>>> _SubscribedServers = new Dictionary<string, HashSet<SubscriptionStatus<TKeyInput, TSubscriberId>>>();

	private const int _GetStatusLockAttemptLimit = 5;

	/// <summary>
	/// Callback method when the subscription server disconnect.
	/// </summary>
	public event SubscriptionServerDisconnectEventHandler OnSubscriptionServerDisconnect;

	public SubscriptionProxy(ISubscriber<TKeyInput, TPublishMessage> subscriber, Action<string, TPublishMessage> messageHandler, Action<TKeyInput, string, SubscriptionEvent> subscriptionEventHandler, ILogger logger)
	{
		_Subscriber = subscriber;
		_MessageHandler = messageHandler;
		_SubscriptionEventHandler = subscriptionEventHandler;
		_Logger = logger;
	}

	public string Subscribe(TKeyInput key, TSubscriberId uniqueSubscriberId, bool isReconnect)
	{
		string channelName = null;
		PerformLockedStatusUpdate(key, delegate(SubscriptionStatus<TKeyInput, TSubscriberId> subscriptionStatus)
		{
			subscriptionStatus.Consumers.Add(uniqueSubscriberId);
			if (subscriptionStatus.SubscriptionResult == null)
			{
				subscriptionStatus.SubscriptionResult = _Subscriber.Subscribe(key, HandleRedisUpdate);
				RecordServerForDisconnectNotification(subscriptionStatus);
			}
			channelName = subscriptionStatus.SubscriptionResult.ChannelName;
			_SubscriptionEventHandler(key, uniqueSubscriberId.ToString(), isReconnect ? SubscriptionEvent.Reconnected : SubscriptionEvent.Subscribed);
		});
		return channelName;
	}

	public void Unsubscribe(TKeyInput key, TSubscriberId uniqueSubscriberId)
	{
		PerformLockedStatusUpdate(key, delegate(SubscriptionStatus<TKeyInput, TSubscriberId> subscriptionStatus)
		{
			subscriptionStatus.Consumers.Remove(uniqueSubscriberId);
			if (subscriptionStatus.Consumers.Count == 0)
			{
				Task.Delay(Settings.Default.SubscriptionProxyUnsubscribeDelay).ContinueWith(delegate
				{
					PerformUnsubscribe(key);
				});
			}
		});
	}

	private void PerformUnsubscribe(TKeyInput key)
	{
		try
		{
			PerformLockedStatusUpdate(key, delegate(SubscriptionStatus<TKeyInput, TSubscriberId> subscriptionStatus)
			{
				if (subscriptionStatus.Consumers.Count == 0)
				{
					if (subscriptionStatus.SubscriptionResult != null)
					{
						try
						{
							_Subscriber.Unsubscribe(subscriptionStatus.SubscriptionResult);
						}
						catch (Exception ex2)
						{
							_Logger.Error(ex2);
						}
						try
						{
							RemoveFromServerDisconnectNotification(subscriptionStatus);
						}
						catch (Exception ex3)
						{
							_Logger.Error(ex3);
						}
					}
					_SubscriptionConsumers.TryRemove(key, out subscriptionStatus);
				}
			});
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	private void HandleRedisUpdate(string channel, TPublishMessage notification)
	{
		_MessageHandler(channel, notification);
	}

	private void PerformLockedStatusUpdate(TKeyInput key, Action<SubscriptionStatus<TKeyInput, TSubscriberId>> updateAction)
	{
		for (int attemptCount = 0; attemptCount < 5; attemptCount++)
		{
			SubscriptionStatus<TKeyInput, TSubscriberId> currentSubscriptionStatus = _SubscriptionConsumers.GetOrAdd(key, (TKeyInput x) => new SubscriptionStatus<TKeyInput, TSubscriberId>(key));
			lock (currentSubscriptionStatus)
			{
				if (currentSubscriptionStatus == _SubscriptionConsumers.GetOrAdd(key, (TKeyInput x) => new SubscriptionStatus<TKeyInput, TSubscriberId>(key)))
				{
					updateAction(currentSubscriptionStatus);
					return;
				}
			}
		}
		throw new SubscriptionProxyException("Failed to obtain lock on current subscription after " + 5 + " attempts");
	}

	/// <summary>
	/// We want to record which server each channel is subscribed on so we can notify the consumers if the server connection is lost
	/// </summary>
	/// <param name="subscriptionStatus"></param>
	private void RecordServerForDisconnectNotification(SubscriptionStatus<TKeyInput, TSubscriberId> subscriptionStatus)
	{
		lock (_SubscribedServers)
		{
			string serverId = subscriptionStatus.SubscriptionResult.ServerId;
			if (_SubscribedServers.TryGetValue(serverId, out var subscriptionSet))
			{
				subscriptionSet.Add(subscriptionStatus);
				return;
			}
			_SubscribedServers.Add(serverId, new HashSet<SubscriptionStatus<TKeyInput, TSubscriberId>> { subscriptionStatus });
			_Subscriber.SubscribeToServerDisconnect(subscriptionStatus.Key, HandleServerDisconnect);
		}
	}

	private void RemoveFromServerDisconnectNotification(SubscriptionStatus<TKeyInput, TSubscriberId> subscriptionStatus)
	{
		lock (_SubscribedServers)
		{
			string serverId = subscriptionStatus.SubscriptionResult.ServerId;
			if (_SubscribedServers.TryGetValue(serverId, out var subscriptionSet))
			{
				subscriptionSet.Remove(subscriptionStatus);
				if (subscriptionSet.Count == 0)
				{
					_SubscribedServers.Remove(serverId);
				}
			}
		}
	}

	/// <summary>
	/// Handle the failure of one of the server nodes that is serving currently subscribed channels
	/// </summary>
	/// <param name="serverId"></param>
	/// <param name="reason"></param>
	private void HandleServerDisconnect(string serverId, string reason)
	{
		try
		{
			this.OnSubscriptionServerDisconnect?.Invoke(serverId, reason);
		}
		catch (Exception ex)
		{
			_Logger?.Error(ex);
		}
		List<SubscriptionStatus<TKeyInput, TSubscriberId>> serverSubscriptions = new List<SubscriptionStatus<TKeyInput, TSubscriberId>>();
		lock (_SubscribedServers)
		{
			if (_SubscribedServers.TryGetValue(serverId, out var subscriptionSet))
			{
				serverSubscriptions = subscriptionSet.ToList();
				_SubscribedServers.Remove(serverId);
			}
		}
		foreach (SubscriptionStatus<TKeyInput, TSubscriberId> iteratedSubscriptionStatus in serverSubscriptions)
		{
			SubscriptionStatus<TKeyInput, TSubscriberId> subscriptionStatus = iteratedSubscriptionStatus;
			PerformLockedStatusUpdate(iteratedSubscriptionStatus.Key, delegate(SubscriptionStatus<TKeyInput, TSubscriberId> currentSubscriptionStatus)
			{
				if (subscriptionStatus == currentSubscriptionStatus)
				{
					_SubscriptionConsumers.TryRemove(currentSubscriptionStatus.Key, out var _);
					try
					{
						_Subscriber.Unsubscribe(subscriptionStatus.SubscriptionResult);
					}
					catch (Exception ex2)
					{
						_Logger.Error(ex2);
					}
					try
					{
						_SubscriptionEventHandler(currentSubscriptionStatus.Key, currentSubscriptionStatus.SubscriptionResult.ChannelName, SubscriptionEvent.ConnectionLost);
					}
					catch (Exception ex3)
					{
						_Logger.Error(ex3);
					}
				}
			});
		}
	}
}
