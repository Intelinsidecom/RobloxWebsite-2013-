using System;
using Roblox.Instrumentation;

namespace BeIT.MemCached;

internal class MemcachedMonitor
{
	private const string _Category = "Roblox.MemcachedV2";

	internal IRawValueCounter PoolSizeForAllHosts { get; }

	internal IRawValueCounter AveragePoolSizePerHost { get; }

	internal IRawValueCounter AverageNonDisposedCreatedSocketsPerHost { get; }

	internal IRawValueCounter MaximumNonDisposedCreatedSocketsPerHost { get; }

	internal IRateOfCountsPerSecondCounter AcquireAttemptsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireSocketCreationSuccessesPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireSocketCreationFailuresPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireSocketCreationAbortDueToMaximumCountReachedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireSocketCreationAbortDueToRateLimitPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireSuccessesPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireFailuresPerSecond { get; }

	internal IRateOfCountsPerSecondCounter AcquireSocketCreationAbortedDueToBrokenCircuit { get; }

	internal IAverageValueCounter AcquireSocketCreationAverageTimeInMilliseconds { get; }

	internal IRateOfCountsPerSecondCounter AcquireSocketCreationTimeoutsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReturnAttemptsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReturnDirtySocketsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReturnSuccessesPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReturnPoolIsFullPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReturnSocketsDestroyedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionAttemptsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionSuccessesPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionErrorsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionFailuresToAcquirePerSecond { get; }

	internal IAverageValueCounter AverageResponseTimeInMilliseconds { get; }

	internal IRateOfCountsPerSecondCounter ExecutionTimeoutsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionIOErrorsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionCircuitBreakerErrorsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ExecutionNotSupportedErrorsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReadAttemptsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter ReadErrorsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter WriteAttemptsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter WriteErrorsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter RoundRobinExecutionFailuresPerSecond { get; }

	internal IRateOfCountsPerSecondCounter RoundRobinExecutionSuccessesPerSecond { get; }

	internal IRateOfCountsPerSecondCounter GetCommandReturnedValueMismatchedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PooledSocketDisposedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PooledSocketExplicitlyClosedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PooledSocketReadLeftoverBytesReadAttemptsPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PooledSocketForceResetAnyBytesReturnedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PooledSocketForceResetNoBytesReturnedPerSecond { get; }

	internal IRateOfCountsPerSecondCounter PooledSocketForceResetExceptionsPerSecond { get; }

	internal IFractionCounter SetValuesCompressedFraction { get; }

	internal IFractionCounter ReadValuesCompressedFraction { get; }

	internal MemcachedMonitor(ICounterRegistry counterRegistry, string instanceName)
	{
		if (counterRegistry == null)
		{
			throw new ArgumentNullException("counterRegistry");
		}
		if (string.IsNullOrWhiteSpace(instanceName))
		{
			throw new ArgumentException("instanceName");
		}
		PoolSizeForAllHosts = counterRegistry.GetRawValueCounter("Roblox.MemcachedV2", "PoolSizeForAllHosts", instanceName);
		AveragePoolSizePerHost = counterRegistry.GetRawValueCounter("Roblox.MemcachedV2", "AveragePoolSizePerHost", instanceName);
		AverageNonDisposedCreatedSocketsPerHost = counterRegistry.GetRawValueCounter("Roblox.MemcachedV2", "AverageNonDisposedCreatedSocketsPerHost", instanceName);
		MaximumNonDisposedCreatedSocketsPerHost = counterRegistry.GetRawValueCounter("Roblox.MemcachedV2", "MaximumNonDisposedCreatedSocketsPerHost", instanceName);
		AcquireAttemptsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireAttemptsPerSecond", instanceName);
		AcquireSocketCreationSuccessesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSocketCreationSuccessesPerSecond", instanceName);
		AcquireSocketCreationFailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSocketCreationFailuresPerSecond", instanceName);
		AcquireSuccessesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSuccessesPerSecond", instanceName);
		AcquireFailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireFailuresPerSecond", instanceName);
		AcquireSocketCreationAbortDueToMaximumCountReachedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSocketCreationAbortDueToMaximumCountReachedPerSecond", instanceName);
		AcquireSocketCreationAbortDueToRateLimitPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSocketCreationAbortDueToRateLimitPerSecond", instanceName);
		AcquireSocketCreationAbortedDueToBrokenCircuit = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSocketCreationAbortedDueToBrokenCircuit", instanceName);
		AcquireSocketCreationAverageTimeInMilliseconds = counterRegistry.GetAverageValueCounter("Roblox.MemcachedV2", "AcquireSocketCreationAverageTimeInMilliseconds", instanceName);
		AcquireSocketCreationTimeoutsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "AcquireSocketCreationTimeoutsPerSecond", instanceName);
		ReturnAttemptsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReturnAttemptsPerSecond", instanceName);
		ReturnDirtySocketsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReturnDirtySocketsPerSecond", instanceName);
		ReturnSuccessesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReturnSuccessesPerSecond", instanceName);
		ReturnPoolIsFullPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReturnPoolIsFullPerSecond", instanceName);
		ReturnSocketsDestroyedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReturnSocketsDestroyedPerSecond", instanceName);
		ExecutionAttemptsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionAttemptsPerSecond", instanceName);
		ExecutionSuccessesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionSuccessesPerSecond", instanceName);
		ExecutionErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionErrorsPerSecond", instanceName);
		ExecutionFailuresToAcquirePerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionFailuresToAcquirePerSecond", instanceName);
		AverageResponseTimeInMilliseconds = counterRegistry.GetAverageValueCounter("Roblox.MemcachedV2", "AverageResponseTimeInMilliseconds", instanceName);
		ExecutionTimeoutsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionTimeoutsPerSecond", instanceName);
		ExecutionIOErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionIOErrorsPerSecond", instanceName);
		ExecutionCircuitBreakerErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionCircuitBreakerErrorsPerSecond", instanceName);
		ExecutionNotSupportedErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ExecutionNotSupportedErrorsPerSecond", instanceName);
		ReadAttemptsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReadAttemptsPerSecond", instanceName);
		ReadErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "ReadErrorsPerSecond", instanceName);
		WriteAttemptsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "WriteAttemptsPerSecond", instanceName);
		WriteErrorsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "WriteErrorsPerSecond", instanceName);
		GetCommandReturnedValueMismatchedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "GetCommandReturnedValueMismatchedPerSecond", instanceName);
		PooledSocketDisposedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "PooledSocketDisposedPerSecond", instanceName);
		PooledSocketExplicitlyClosedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "PooledSocketExplicitlyClosedPerSecond", instanceName);
		PooledSocketReadLeftoverBytesReadAttemptsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "PooledSocketReadLeftoverBytesReadAttemptsPerSecond", instanceName);
		PooledSocketForceResetAnyBytesReturnedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "PooledSocketForceResetAnyBytesReturnedPerSecond", instanceName);
		PooledSocketForceResetNoBytesReturnedPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "PooledSocketForceResetNoBytesReturnedPerSecond", instanceName);
		PooledSocketForceResetExceptionsPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "PooledSocketForceResetExceptionsPerSecond", instanceName);
		RoundRobinExecutionFailuresPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "RoundRobinExecutionFailuresPerSecond", instanceName);
		RoundRobinExecutionSuccessesPerSecond = counterRegistry.GetRateOfCountsPerSecondCounter("Roblox.MemcachedV2", "RoundRobinExecutionSuccessesPerSecond", instanceName);
		SetValuesCompressedFraction = counterRegistry.GetFractionCounter("Roblox.MemcachedV2", "SetValuesCompressedFraction", instanceName);
		ReadValuesCompressedFraction = counterRegistry.GetFractionCounter("Roblox.MemcachedV2", "ReadValuesCompressedFraction", instanceName);
	}
}
