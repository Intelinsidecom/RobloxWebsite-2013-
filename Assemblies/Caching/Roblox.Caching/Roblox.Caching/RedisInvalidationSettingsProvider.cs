using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Roblox.Caching.Properties;
using Roblox.Configuration;
using Roblox.Instrumentation;
using Roblox.Redis;
using StackExchange.Redis;

namespace Roblox.Caching;

internal class RedisInvalidationSettingsProvider : IRedisInvalidationSettingsProvider
{
	private volatile IReadOnlyCollection<ISubscriber> _PubSubHandles;

	private readonly object _Lock = new object();

	private readonly ICounterRegistry _CounterRegistry;

	private HashSet<string> _RedisEndpoints;

	private static readonly IRedisInvalidationSettingsProvider _Instance = new RedisInvalidationSettingsProvider(StaticCounterRegistry.Instance);

	public event Action<IReadOnlyCollection<ISubscriber>> OnPubSubHandlesAdded;

	public event Action<IReadOnlyCollection<ISubscriber>> OnPubSubHandlesRemoved;

	public event Action<int> OnNumberOfAttemptsForTopicSubscriptionChanged;

	public event Action<int> OnRetryIntervalForTopicSubscriptionsChanged;

	public event Action<Exception> OnException;

	private RedisInvalidationSettingsProvider(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		InvalidationSettings.Default.MonitorChanges<InvalidationSettings, string>((Expression<Func<InvalidationSettings, string>>)((InvalidationSettings s) => s.RedisEndpointsForInvalidation), (Action<string>)HandleEndpointsRefresh);
		InvalidationSettings.Default.MonitorChanges<InvalidationSettings, int>((Expression<Func<InvalidationSettings, int>>)((InvalidationSettings s) => s.NumberOfAttemptsForTopicSubscription), (Action<int>)delegate(int newValue)
		{
			try
			{
				this.OnNumberOfAttemptsForTopicSubscriptionChanged?.Invoke(newValue);
			}
			catch (Exception obj2)
			{
				this.OnException?.Invoke(obj2);
			}
		});
		InvalidationSettings.Default.MonitorChanges<InvalidationSettings, int>((Expression<Func<InvalidationSettings, int>>)((InvalidationSettings s) => s.RetryIntervalForTopicSubscriptionsInMilliSeconds), (Action<int>)delegate(int newValue)
		{
			try
			{
				this.OnRetryIntervalForTopicSubscriptionsChanged?.Invoke(newValue);
			}
			catch (Exception obj)
			{
				this.OnException?.Invoke(obj);
			}
		});
	}

	public static IRedisInvalidationSettingsProvider GetInstance()
	{
		return _Instance;
	}

	public int GetNumberOfAttemptsForInvalidationMessageDelivery()
	{
		return InvalidationSettings.Default.NumberOfAttemptsForInvalidationMessageDelivery;
	}

	public TimeSpan GetDelayToStopSubscribingAfterNodeRemoval()
	{
		return InvalidationSettings.Default.DelayToStopSubscribingAfterNodeRemoval;
	}

	public TimeSpan GetDelayToStartPublishingAfterNodeAddition()
	{
		return InvalidationSettings.Default.DelayToStartPublishingAfterNodeAddition;
	}

	public int GetNumberOfAttemptsForTopicSubscription()
	{
		return InvalidationSettings.Default.NumberOfAttemptsForTopicSubscription;
	}

	public int GetRetryIntervalForTopicSubscriptionsInMilliseconds()
	{
		return InvalidationSettings.Default.RetryIntervalForTopicSubscriptionsInMilliSeconds;
	}

	public int GetInvalidationPublisherQueueSize()
	{
		return InvalidationSettings.Default.RedisInvalidationQueueSize;
	}

	public bool IsThrowOnInitializationErrorEnabled()
	{
		return InvalidationSettings.Default.ThrowOnInitializationErrorEnabled;
	}

	public IReadOnlyCollection<ISubscriber> GetPubSubHandles()
	{
		if (_PubSubHandles != null)
		{
			return _PubSubHandles;
		}
		lock (_Lock)
		{
			if (_PubSubHandles != null)
			{
				return _PubSubHandles;
			}
			try
			{
				_RedisEndpoints = MultiValueSettingParser.ParseCommaDelimitedListString(InvalidationSettings.Default.RedisEndpointsForInvalidation);
				if (_RedisEndpoints.Any())
				{
					_PubSubHandles = GetPubSubHandlesFromEndpoints(_RedisEndpoints.ToArray());
				}
			}
			catch (Exception obj)
			{
				this.OnException?.Invoke(obj);
			}
		}
		return _PubSubHandles;
	}

	private void HandleEndpointsRefresh(string newSettingsValue)
	{
		try
		{
			if (_PubSubHandles == null)
			{
				return;
			}
			IReadOnlyCollection<ISubscriber> pubSubHandles = _PubSubHandles;
			HashSet<string> hashSet = MultiValueSettingParser.ParseCommaDelimitedListString(newSettingsValue);
			List<string> list = _RedisEndpoints.Except(hashSet).ToList();
			List<string> list2 = hashSet.Except(_RedisEndpoints).ToList();
			if (list.Count != 0 || list2.Count != 0)
			{
				_RedisEndpoints = hashSet;
				HashSet<string> removedEndpointsHashSet = new HashSet<string>(list);
				IReadOnlyCollection<ISubscriber> pubSubHandlesFromEndpoints = GetPubSubHandlesFromEndpoints(list2);
				List<ISubscriber> obj = pubSubHandles.Where((ISubscriber handle) => removedEndpointsHashSet.Contains(handle.Multiplexer.GetIpPortCombo())).ToList();
				_PubSubHandles = (from handle in _PubSubHandles.Union(pubSubHandlesFromEndpoints)
					where !removedEndpointsHashSet.Contains(handle.Multiplexer.GetIpPortCombo())
					select handle).ToList();
				this.OnPubSubHandlesAdded?.Invoke(pubSubHandlesFromEndpoints);
				this.OnPubSubHandlesRemoved?.Invoke(obj);
			}
		}
		catch (Exception obj2)
		{
			this.OnException?.Invoke(obj2);
		}
	}

	private IReadOnlyCollection<ISubscriber> GetPubSubHandlesFromEndpoints(IEnumerable<string> endpoints)
	{
		return new RedisClient(_CounterRegistry, endpoints.ToArray(), "Roblox.Caching.Invalidator", this.OnException).GetAllSubscribers();
	}
}
