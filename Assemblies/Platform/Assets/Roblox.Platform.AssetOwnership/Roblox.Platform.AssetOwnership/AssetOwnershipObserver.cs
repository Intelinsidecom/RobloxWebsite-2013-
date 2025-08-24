using System;
using System.Collections.Concurrent;
using System.Diagnostics;
using Roblox.EventLog;
using Roblox.Instrumentation;

namespace Roblox.Platform.AssetOwnership;

internal class AssetOwnershipObserver : IAssetOwnershipObserver
{
	internal readonly ActionResultCounter TotalCounterSet;

	private const string _TotalInstanceAction = "Total";

	private const string _Category = "Roblox.Platform.AssetOwnership";

	private const int _MaximumInstanceNameLength = 127;

	/// <summary>
	/// Write every named action+result enum to its own counter.
	/// </summary>
	private readonly ConcurrentDictionary<string, ActionResultCounter> _ActionResultCounters = new ConcurrentDictionary<string, ActionResultCounter>();

	private readonly ILogger _Logger;

	private ConcurrentDictionary<long, Stopwatch> _RequestTimers;

	private ICounterRegistry _CounterRegistry;

	public AssetOwnershipObserver(ILogger logger)
	{
		_RequestTimers = new ConcurrentDictionary<long, Stopwatch>();
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_CounterRegistry = StaticCounterRegistry.Instance;
		TotalCounterSet = GetOrCreateActionResult("Total");
	}

	/// <summary>
	/// we count totals, and start timers by requestId.
	/// </summary>
	public virtual void OnExecutionStarted(AssetOwnershipActionEventArgs e)
	{
		Stopwatch stopwatch = Stopwatch.StartNew();
		_RequestTimers.GetOrAdd(e.RequestId, stopwatch);
		TotalCounterSet.ActionResultsPerSecond.Increment();
	}

	/// <summary>
	/// We sample for average response time.
	/// the average reqs/sec for this action+result
	/// the average response time for this action+result
	/// </summary>
	public virtual void OnExecutionFinished(AssetOwnershipActionEventArgs e)
	{
		ActionResultCounter actionResultCounterSet = GetOrCreateActionResult(MakeActionResultName(e.Action, e.Result));
		actionResultCounterSet.ActionResultsPerSecond.Increment();
		if (_RequestTimers.TryRemove(e.RequestId, out var stopwatch))
		{
			stopwatch.Stop();
			double elapsedMilliseconds = stopwatch.Elapsed.TotalMilliseconds;
			TotalCounterSet.AverageResponseTime.Sample(elapsedMilliseconds);
			actionResultCounterSet.AverageResponseTime.Sample(elapsedMilliseconds);
		}
	}

	private ActionResultCounter GetOrCreateActionResult(string actionResult)
	{
		return _ActionResultCounters.GetOrAdd(actionResult, ActionResultCounterFactory);
	}

	private ActionResultCounter ActionResultCounterFactory(string actionResult)
	{
		if (actionResult.Length > 127)
		{
			actionResult = actionResult.Substring(0, 127);
		}
		ActionResultCounter result = new ActionResultCounter(_CounterRegistry, "Roblox.Platform.AssetOwnership", actionResult);
		_Logger.Info(() => $"Created actionResultCounter for: {actionResult}");
		return result;
	}

	private string MakeActionResultName(string action, string result)
	{
		return $"{action} | {result}";
	}
}
