using System.Collections.Concurrent;
using Roblox.Instrumentation;

namespace Roblox.Mssql;

internal class DatabaseMonitor
{
	private readonly ICounterRegistry _CounterRegistry;

	private readonly string _Category;

	private readonly ConcurrentDictionary<string, ExecutionCounterSet> _ActionMonitors = new ConcurrentDictionary<string, ExecutionCounterSet>();

	private readonly ExecutionCounterSet _TotalCounterSet;

	private const int _MaximumInstanceNameLength = 127;

	private const string _AverageResponseTimeCounterName = "Avg Response Time";

	private const string _FailuresPerSecondCounterName = "Failures/s";

	private const string _RequestsOutstandingCounterName = "Requests Outstanding";

	private const string _RequestsPerSecondCounterName = "Requests/s";

	private const string _TotalInstanceName = "_Total";

	internal DatabaseMonitor(string databaseName, ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry;
		_Category = "Roblox.Mssql." + databaseName;
		_TotalCounterSet = GetOrCreateAction("_Total");
	}

	internal IAverageValueCounter GetAverageResponseTime()
	{
		return _TotalCounterSet.AverageResponseTime;
	}

	internal IRateOfCountsPerSecondCounter GetFailuresPerSecond()
	{
		return _TotalCounterSet.FailuresPerSecond;
	}

	internal IRawValueCounter GetRequestsOutstanding()
	{
		return _TotalCounterSet.RequestsOutstanding;
	}

	internal IRateOfCountsPerSecondCounter GetRequestsPerSecond()
	{
		return _TotalCounterSet.RequestsPerSecond;
	}

	internal ExecutionCounterSet GetOrCreateAction(string actionName)
	{
		if (actionName.Length > 127)
		{
			actionName = actionName.Substring(0, 127);
		}
		return _ActionMonitors.GetOrAdd(actionName, CreateActionMonitor);
	}

	private ExecutionCounterSet CreateActionMonitor(string actionName)
	{
		IRateOfCountsPerSecondCounter rateOfCountsPerSecondCounter = _CounterRegistry.GetRateOfCountsPerSecondCounter(_Category, "Requests/s", actionName);
		IRateOfCountsPerSecondCounter failuresPerSecond = _CounterRegistry.GetRateOfCountsPerSecondCounter(_Category, "Failures/s", actionName);
		IRawValueCounter requestsOutstanding = _CounterRegistry.GetRawValueCounter(_Category, "Requests Outstanding", actionName);
		IAverageValueCounter averageResponseTime = _CounterRegistry.GetAverageValueCounter(_Category, "Avg Response Time", actionName);
		return new ExecutionCounterSet(rateOfCountsPerSecondCounter, failuresPerSecond, requestsOutstanding, averageResponseTime);
	}
}
