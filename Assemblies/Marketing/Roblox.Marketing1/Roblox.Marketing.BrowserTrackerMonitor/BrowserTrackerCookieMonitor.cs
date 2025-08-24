using System;
using System.Collections.Concurrent;
using System.Linq;
using Roblox.Instrumentation;

namespace Roblox.Marketing.BrowserTrackerMonitor;

public class BrowserTrackerCookieMonitor
{
	private readonly ConcurrentDictionary<string, BrowserTrackerCounter> _BrowserTrackerInstanceDictionary = new ConcurrentDictionary<string, BrowserTrackerCounter>();

	private readonly ICounterRegistry _CounterRegistry;

	public BrowserTrackerCookieMonitor(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		foreach (string instanceName in Enum.GetNames(typeof(BrowserTrackerInstancesEnum)).ToList())
		{
			string key = instanceName;
			_BrowserTrackerInstanceDictionary[key] = new BrowserTrackerCounter(_CounterRegistry, instanceName);
		}
	}

	public void Increment(string instanceName)
	{
		if (_BrowserTrackerInstanceDictionary.TryGetValue(instanceName, out var counter))
		{
			counter.Increment();
			return;
		}
		lock (_BrowserTrackerInstanceDictionary)
		{
			_BrowserTrackerInstanceDictionary[instanceName] = new BrowserTrackerCounter(_CounterRegistry, instanceName);
		}
	}
}
