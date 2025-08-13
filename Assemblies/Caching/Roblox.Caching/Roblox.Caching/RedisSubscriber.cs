using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace Roblox.Caching;

internal class RedisSubscriber
{
	private class SubscriptionRetriableItem : IRetriableItem
	{
		public int CurrentAttempt { get; set; }

		public string EntityType { get; set; }

		public ISubscriber Subscriber { get; set; }

		public override string ToString()
		{
			return $"CurrentAttempt:{CurrentAttempt}_EntityType:{EntityType}_Subscriber:{Subscriber?.Multiplexer?.Configuration}";
		}
	}

	private static RetryQueue<SubscriptionRetriableItem> _RetryQueue;

	private bool _IsRunning;

	private readonly ConcurrentDictionary<string, ISubscriber> _SubscribersByEndpoint = new ConcurrentDictionary<string, ISubscriber>();

	public event Action<string> MessageReceived;

	public event Action<Exception> ExceptionOccured;

	public RedisSubscriber(IReadOnlyCollection<ISubscriber> pubSubHandles, IRedisInvalidationSettingsProvider redisInvalidationSettingsProvider)
	{
		foreach (ISubscriber pubSubHandle in pubSubHandles)
		{
			string pubSubLookupKey = GetPubSubLookupKey(pubSubHandle);
			_SubscribersByEndpoint.TryAdd(pubSubLookupKey, pubSubHandle);
		}
		_RetryQueue = new RetryQueue<SubscriptionRetriableItem>(RetrySubscribingToTopic, redisInvalidationSettingsProvider.GetNumberOfAttemptsForTopicSubscription(), redisInvalidationSettingsProvider.GetRetryIntervalForTopicSubscriptionsInMilliseconds());
		_RetryQueue.OnFatalFailure += this.ExceptionOccured;
		redisInvalidationSettingsProvider.OnNumberOfAttemptsForTopicSubscriptionChanged += delegate(int newValue)
		{
			_RetryQueue.MaxAttempts = newValue;
		};
		redisInvalidationSettingsProvider.OnRetryIntervalForTopicSubscriptionsChanged += delegate(int newValue)
		{
			_RetryQueue.RetryIntervalInMilliseconds = newValue;
		};
	}

	public void Stop()
	{
		if (_IsRunning)
		{
			_IsRunning = false;
		}
	}

	public void Start()
	{
		if (!_IsRunning)
		{
			_IsRunning = true;
		}
	}

	public bool RegisterEntity(string entityType)
	{
		try
		{
			List<Task> list = new List<Task>(_SubscribersByEndpoint.Values.Count);
			List<ISubscriber> list2 = _SubscribersByEndpoint.Values.ToList();
			foreach (ISubscriber value in _SubscribersByEndpoint.Values)
			{
				Task item = value.SubscribeAsync(entityType, MessageHandler);
				list.Add(item);
			}
			Task.WaitAll(list.ToArray());
			for (int i = 0; i < list.Count; i++)
			{
				if (list[i].Exception != null)
				{
					_RetryQueue.AddItem(new SubscriptionRetriableItem
					{
						EntityType = entityType,
						Subscriber = list2[i]
					});
				}
			}
		}
		catch (Exception obj)
		{
			this.ExceptionOccured?.Invoke(obj);
			return false;
		}
		return true;
	}

	private void RetrySubscribingToTopic(SubscriptionRetriableItem item)
	{
		string entityType = item.EntityType;
		item.Subscriber.Subscribe(entityType, MessageHandler);
	}

	private void MessageHandler(RedisChannel topic, RedisValue redisValue)
	{
		if (!_IsRunning || this.MessageReceived == null)
		{
			return;
		}
		string obj = redisValue.ToString();
		try
		{
			this.MessageReceived(obj);
		}
		catch (Exception obj2)
		{
			this.ExceptionOccured?.Invoke(obj2);
		}
	}

	public void OnPubSubHandlesAdded(IReadOnlyCollection<ISubscriber> pubSubHandles, HashSet<string> registeredEntities)
	{
		foreach (ISubscriber pubSubHandle in pubSubHandles)
		{
			foreach (string registeredEntity in registeredEntities)
			{
				pubSubHandle.Subscribe(registeredEntity, MessageHandler);
			}
			string pubSubLookupKey = GetPubSubLookupKey(pubSubHandle);
			_SubscribersByEndpoint.TryAdd(pubSubLookupKey, pubSubHandle);
		}
	}

	public void OnPubSubHandlesRemoved(IReadOnlyCollection<ISubscriber> pubSubHandles)
	{
		foreach (ISubscriber pubSubHandle in pubSubHandles)
		{
			string pubSubLookupKey = GetPubSubLookupKey(pubSubHandle);
			if (_SubscribersByEndpoint.TryRemove(pubSubLookupKey, out var value))
			{
				value.UnsubscribeAll(CommandFlags.FireAndForget);
			}
		}
	}

	public void OnEntityDeregistered(string entityType)
	{
		foreach (ISubscriber value2 in _SubscribersByEndpoint.Values)
		{
			string pubSubLookupKey = GetPubSubLookupKey(value2);
			if (_SubscribersByEndpoint.TryGetValue(pubSubLookupKey, out var value))
			{
				value.Unsubscribe(entityType, null, CommandFlags.FireAndForget);
			}
		}
	}

	private static string GetPubSubLookupKey(ISubscriber pubSubHandle)
	{
		return pubSubHandle.Multiplexer.Configuration;
	}
}
