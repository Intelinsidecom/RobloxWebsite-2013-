using System;
using Roblox.Instrumentation;

namespace Roblox.Caching.Diagnostics;

internal class MigrationStateMonitor : IMigrationStateMonitor
{
	private const string _Category = "Roblox.Caching.MigrationSharedCacheClientStates";

	private readonly ICounterRegistry _CounterRegistry;

	public MigrationStateMonitor(ICounterRegistry counterRegistry)
	{
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
	}

	public void RecordMigrationState(string metricsIdentifier, MigrationStateChange migrationStateChange)
	{
		if (!string.IsNullOrWhiteSpace(metricsIdentifier) && IsValid(migrationStateChange))
		{
			_CounterRegistry.GetRawValueCounter("Roblox.Caching.MigrationSharedCacheClientStates", "SourceMigrationState", metricsIdentifier).Set((long)migrationStateChange.SourceState);
			_CounterRegistry.GetRawValueCounter("Roblox.Caching.MigrationSharedCacheClientStates", "DestinationMigrationState", metricsIdentifier).Set((long)migrationStateChange.DestinationState);
		}
	}

	private bool IsValid(MigrationStateChange stateChange)
	{
		bool num = Enum.IsDefined(typeof(MigrationState), stateChange.SourceState);
		bool flag = Enum.IsDefined(typeof(MigrationState), stateChange.DestinationState);
		if (num && flag)
		{
			return !stateChange.IsSourceAndDestinationStateSame;
		}
		return false;
	}
}
