using System;
using System.ComponentModel;

namespace Roblox.Caching.ClusterSettings;

public interface IExposedMemCachedClientSettings : INotifyPropertyChanged
{
	int MaximumNumberOfSocketsPerPool { get; }

	TimeSpan PooledSocketConstructionSocketConnectTimeout { get; }

	TimeSpan ConnectionCircuitBreakerRetryInterval { get; }

	bool IsExecutionCircuitBreakerEnabled { get; }

	TimeSpan ExecutionCircuitBreakerRetryInterval { get; }

	string SocketErrorsThatTripExecutionCircuitBreakerCsv { get; }

	int ExecutionCircuitBreakerExceptionCountForTripping { get; }

	TimeSpan ExecutionCircuitBreakerExceptionIntervalForTripping { get; }

	string PerHostExpiryOverridesCsv { get; }

	bool PerHostExpiryOverridesEnabled { get; }

	int ConnectionCircuitBreakerExceptionCountForTripping { get; }

	TimeSpan ConnectionCircuitBreakerExceptionIntervalForTripping { get; }

	string ExceptionTypeNamesToForceResetBytesCsv { get; }

	int ForceResetBytesMaxAttempts { get; }

	int ForceResetBytesMaxNumberOfBytes { get; }

	bool LogVerboseExceptions { get; }

	bool IsRespectingMaxPoolSizeEnabled { get; }

	bool UseRoundRobinSocketPoolSelection { get; }

	int MaximumSelectionAttemptsForRoundRobin { get; }

	uint CompressionThreshold { get; }

	uint MinimumPoolSize { get; }

	uint MaximumPoolSize { get; }

	TimeSpan SendReceiveTimeout { get; }

	TimeSpan SocketRecycleAge { get; }

	bool IsUpgradedDnsResolvingEnabled { get; }

	bool IsConnectionCreationRateLimitingEnabled { get; }

	TimeSpan ConnectionCreationRateLimitPeriodLength { get; }

	int MaximumConnectionCreationsPerPeriod { get; }
}
