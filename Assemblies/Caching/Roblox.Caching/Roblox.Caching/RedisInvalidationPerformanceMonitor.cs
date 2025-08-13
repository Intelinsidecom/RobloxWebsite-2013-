using System;
using Roblox.Instrumentation;

namespace Roblox.Caching;

internal class RedisInvalidationPerformanceMonitor : IRedisInvalidationPerformanceMonitor
{
	private readonly ICounterRegistry _CounterRegistry;

	private const string _PerformanceCategory = "Roblox.CacheInvalidation.Redis";

	private static IRedisInvalidationPerformanceMonitor _Instance;

	private static readonly object _InstanceCreationLock = new object();

	private IRateOfCountsPerSecondCounter MessagesReceivedPerSecondInstrumentation { get; set; }

	public IRateOfCountsPerSecondCounter MessagesPublishedPerSecond { get; set; }

	public IRateOfCountsPerSecondCounter MessagesReceivedPerSecond { get; set; }

	public IRawValueCounter TotalMessagesPublished { get; set; }

	public IRawValueCounter TotalMessagesReceived { get; set; }

	private RedisInvalidationPerformanceMonitor(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		MessagesPublishedPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CacheInvalidation.Redis", "MessagesPublishedPerSecond");
		MessagesReceivedPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter("Roblox.CacheInvalidation.Redis", "MessagesReceivedPerSecond");
		TotalMessagesPublished = _CounterRegistry.GetRawValueCounter("Roblox.CacheInvalidation.Redis", "TotalMessagesPublished");
		TotalMessagesReceived = _CounterRegistry.GetRawValueCounter("Roblox.CacheInvalidation.Redis", "TotalMessagesReceived");
	}

	public static IRedisInvalidationPerformanceMonitor GetInstance(Action<Exception> exceptionHandler)
	{
		if (_Instance == null)
		{
			lock (_InstanceCreationLock)
			{
				if (_Instance == null)
				{
					IRedisInvalidationPerformanceMonitor instance = null;
					try
					{
						instance = new RedisInvalidationPerformanceMonitor(StaticCounterRegistry.Instance);
					}
					catch (Exception obj)
					{
						exceptionHandler(obj);
					}
					_Instance = instance;
				}
			}
		}
		return _Instance;
	}

	public double GetMessagesReceivedPerSecond()
	{
		return ((CounterBase)MessagesReceivedPerSecond).GetLastFlushValue();
	}
}
