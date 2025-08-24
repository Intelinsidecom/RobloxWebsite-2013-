using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace BeIT.MemCached;

public interface IMemCachedClientSettings
{
	IMemcachedClientDnsSettings DnsSettings { get; }

	int MaximumNumberOfSocketsPerPool { get; }

	TimeSpan PooledSocketConstructionSocketConnectTimeout { get; }

	TimeSpan ConnectionCircuitBreakerRetryInterval { get; }

	int ConnectionCircuitBreakerExceptionCountForTripping { get; }

	TimeSpan ConnectionCircuitBreakerExceptionIntervalForTripping { get; }

	bool IsExecutionCircuitBreakerEnabled { get; }

	TimeSpan ExecutionCircuitBreakerRetryInterval { get; }

	HashSet<SocketError> SocketErrorsThatTripExecutionCircuitBreaker { get; }

	int ExecutionCircuitBreakerExceptionCountForTripping { get; }

	TimeSpan ExecutionCircuitBreakerExceptionIntervalForTripping { get; }

	IReadOnlyDictionary<string, TimeSpan> PerHostExpiryOverrides { get; }

	bool PerHostExpiryOverridesEnabled { get; }

	HashSet<string> ExceptionTypeNamesToForceResetBytes { get; }

	int ForceResetBytesMaxAttempts { get; }

	int ForceResetBytesMaxNumberOfBytes { get; }

	bool LogVerboseExceptions { get; }

	bool IsRespectingMaxPoolSizeEnabled { get; }

	bool UseRoundRobinSocketPoolSelection { get; }

	int MaximumSelectionAttemptsForRoundRobin { get; }

	uint CompressionThreshold { get; }

	TimeSpan SendReceiveTimeout { get; }

	uint MinimumPoolSize { get; }

	uint MaximumPoolSize { get; }

	TimeSpan SocketRecycleAge { get; }

	TimeSpan EndpointCacheExpiry { get; }

	bool IsConnectionCreationRateLimitingEnabled { get; }

	TimeSpan ConnectionCreationRateLimitPeriodLength { get; }

	int MaximumConnectionCreationsPerPeriod { get; }
}
