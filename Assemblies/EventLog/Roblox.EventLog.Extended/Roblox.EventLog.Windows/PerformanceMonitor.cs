using System;
using System.Collections.Concurrent;
using System.Diagnostics;

namespace Roblox.EventLog.Windows;

internal static class PerformanceMonitor
{
	private static readonly ConcurrentDictionary<string, PerformanceManager> _Counters = new ConcurrentDictionary<string, PerformanceManager>();

	private static void IncrementTrimmedEventCounter(bool isMessageTrimmed, PerformanceManager manager)
	{
		if (isMessageTrimmed)
		{
			manager.TrimmedEventsLoggedPerSecond.Increment();
		}
	}

	public static void IncrementCounters(string logName, bool isMessageTrimmed, EventLogEntryType logEntryType)
	{
		if (string.IsNullOrEmpty(logName))
		{
			throw new ArgumentNullException("logName", "Log name cannot be empty");
		}
		if (_Counters.TryGetValue(logName, out var manager))
		{
			IncrementTrimmedEventCounter(isMessageTrimmed, manager);
			Increment(manager, logEntryType);
			return;
		}
		manager = new PerformanceManager(logName);
		_Counters.TryAdd(logName, manager);
		IncrementTrimmedEventCounter(isMessageTrimmed, manager);
		Increment(manager, logEntryType);
	}

	private static void Increment(PerformanceManager manager, EventLogEntryType logEntryType)
	{
		switch (logEntryType)
		{
		case EventLogEntryType.Error:
			manager.ErrorsLoggedPerSecond.Increment();
			break;
		case EventLogEntryType.Warning:
			manager.WarningsLoggedPerSecond.Increment();
			break;
		case EventLogEntryType.Information:
		case EventLogEntryType.SuccessAudit:
		case EventLogEntryType.FailureAudit:
			manager.InformationLoggedPerSecond.Increment();
			break;
		}
	}
}
