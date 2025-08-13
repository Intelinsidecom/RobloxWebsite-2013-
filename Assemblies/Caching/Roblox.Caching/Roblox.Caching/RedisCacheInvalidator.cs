using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Roblox.Caching.Interfaces;
using StackExchange.Redis;

namespace Roblox.Caching;

internal class RedisCacheInvalidator : ICacheInvalidator
{
	private readonly IRedisInvalidationPerformanceMonitor _RedisInvalidationPerformanceMonitor;

	private readonly Func<IEnumerable<IRemoteCacheInvalidationSink>> _GetRemoteCacheInvalidationSinks;

	private readonly IRawMessageConsumer _RawMessageConsumer;

	private readonly IRedisInvalidationSettingsProvider _RedisInvalidationSettingsProvider;

	private readonly HashSet<string> _RegisteredEntities = new HashSet<string>();

	private readonly HashSet<string> _RegistrationAttemptedEntities = new HashSet<string>();

	private readonly Action<Exception> _ExceptionHandler;

	private RedisPublisher _Publisher;

	private RedisSubscriber _Subscriber;

	private bool _IsInitialized;

	private readonly object _InitializationLock = new object();

	public RedisCacheInvalidator(Func<IEnumerable<IRemoteCacheInvalidationSink>> getRemoteCacheInvalidationSinks, IRawMessageConsumer rawMessageConsumer, IRedisInvalidationSettingsProvider redisInvalidationInvalidationSettingsProvider, IRedisInvalidationPerformanceMonitor redisInvalidationPerformanceMonitor, Action<Exception> exceptionHandler)
	{
		_ExceptionHandler = exceptionHandler;
		_RedisInvalidationPerformanceMonitor = redisInvalidationPerformanceMonitor;
		_RedisInvalidationSettingsProvider = redisInvalidationInvalidationSettingsProvider;
		_GetRemoteCacheInvalidationSinks = getRemoteCacheInvalidationSinks;
		_RawMessageConsumer = rawMessageConsumer;
	}

	public void RegisterEntity(string entityType)
	{
		TryRegisterNewEntity(entityType);
	}

	public void RemoveRemoteKey(IRemoteCacheInvalidationSink cache, string key, string entityType)
	{
		RemoveRemoteKeyRaw(cache.Topic, key, entityType);
	}

	public void RemoveRemoteKeyRaw(string listenerTopic, string key, string entityType)
	{
		string message = listenerTopic + "|" + key;
		_Publisher?.PublishMessage(message, entityType);
	}

	public double GetMessagesReceivedPerSecond()
	{
		return _RedisInvalidationPerformanceMonitor.GetMessagesReceivedPerSecond();
	}

	private void TryRegisterNewEntity(string entityType)
	{
		InitializeOnce();
		lock (_RegisteredEntities)
		{
			if (_RegisteredEntities.Contains(entityType))
			{
				return;
			}
		}
		if (_Subscriber.RegisterEntity(entityType))
		{
			lock (_RegisteredEntities)
			{
				_RegisteredEntities.Add(entityType);
			}
		}
		lock (_RegistrationAttemptedEntities)
		{
			if (!_RegistrationAttemptedEntities.Contains(entityType))
			{
				_RegistrationAttemptedEntities.Add(entityType);
			}
		}
	}

	private void InitializeOnce()
	{
		if (_IsInitialized)
		{
			return;
		}
		lock (_InitializationLock)
		{
			if (_IsInitialized)
			{
				return;
			}
			IReadOnlyCollection<ISubscriber> pubSubHandles = _RedisInvalidationSettingsProvider.GetPubSubHandles();
			if (pubSubHandles == null || pubSubHandles.Count == 0)
			{
				Exception ex = new Exception("Fatal exception: Unable to initialize redis pub-sub handles");
				if (_RedisInvalidationSettingsProvider.IsThrowOnInitializationErrorEnabled())
				{
					throw ex;
				}
				_ExceptionHandler(ex);
			}
			else
			{
				_Publisher = GetRedisPublisher(pubSubHandles);
				_Subscriber = new RedisSubscriber(pubSubHandles, _RedisInvalidationSettingsProvider);
				_Subscriber.MessageReceived += HandleMessageReceived;
				_Subscriber.ExceptionOccured += _ExceptionHandler;
				_Publisher.Start();
				_Subscriber.Start();
				_RedisInvalidationSettingsProvider.OnPubSubHandlesAdded += OnPubSubHandlesAdded;
				_RedisInvalidationSettingsProvider.OnPubSubHandlesRemoved += OnPubSubHandlesRemoved;
				_IsInitialized = true;
			}
		}
	}

	private void HandleMessageReceived(string messageText)
	{
		if (messageText == null)
		{
			return;
		}
		int num = messageText.IndexOf('|');
		if (num == -1)
		{
			return;
		}
		string text = messageText.Substring(0, num);
		string key = messageText.Substring(num + 1);
		_RawMessageConsumer?.ReadMessage(text, key);
		string text2 = text.Substring("RBX-".Length);
		foreach (IRemoteCacheInvalidationSink item in _GetRemoteCacheInvalidationSinks())
		{
			if (text2.StartsWith(item.TopicNamespace) && !text2.EndsWith(item.NodeId))
			{
				item.OnRemoteRemove(key);
			}
		}
		_RedisInvalidationPerformanceMonitor?.MessagesReceivedPerSecond.Increment();
		_RedisInvalidationPerformanceMonitor?.TotalMessagesReceived.Increment();
	}

	private RedisPublisher GetRedisPublisher(IReadOnlyCollection<ISubscriber> pubSubHandles)
	{
		RedisPublisher redisPublisher = new RedisPublisher(pubSubHandles, _RedisInvalidationSettingsProvider);
		redisPublisher.ExceptionOccured += _ExceptionHandler;
		redisPublisher.QueueOverflowed += delegate
		{
			_ExceptionHandler(new Exception("Outgoing message queue (Redis) is full. Remote cache invalidation will fail. Investigate immediately."));
		};
		redisPublisher.PublishCompleted += OnPublishCompleted;
		return redisPublisher;
	}

	private void OnPublishCompleted(string message)
	{
		_RedisInvalidationPerformanceMonitor?.MessagesPublishedPerSecond.Increment();
		_RedisInvalidationPerformanceMonitor?.TotalMessagesPublished.Increment();
	}

	private void OnPubSubHandlesRemoved(IReadOnlyCollection<ISubscriber> handles)
	{
		_Publisher?.OnPubSubHandlesRemoved(handles);
		Task.Delay(_RedisInvalidationSettingsProvider.GetDelayToStopSubscribingAfterNodeRemoval()).ContinueWith(delegate
		{
			_Subscriber?.OnPubSubHandlesRemoved(handles);
		});
	}

	private void OnPubSubHandlesAdded(IReadOnlyCollection<ISubscriber> handles)
	{
		HashSet<string> registeredEntities;
		lock (_RegisteredEntities)
		{
			registeredEntities = new HashSet<string>(_RegisteredEntities);
		}
		_Subscriber?.OnPubSubHandlesAdded(handles, registeredEntities);
		Task.Delay(_RedisInvalidationSettingsProvider.GetDelayToStartPublishingAfterNodeAddition()).ContinueWith(delegate
		{
			_Publisher?.OnPubSubHandlesAdded(handles);
		});
	}
}
