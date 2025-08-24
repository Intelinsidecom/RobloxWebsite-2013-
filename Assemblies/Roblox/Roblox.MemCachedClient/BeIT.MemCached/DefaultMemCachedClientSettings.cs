using System;
using System.Collections.Generic;
using System.Net.Sockets;

namespace BeIT.MemCached;

internal class DefaultMemCachedClientSettings : IMemCachedClientSettings
{
	public int MaximumNumberOfSocketsPerPool => int.MaxValue;

	public TimeSpan PooledSocketConstructionSocketConnectTimeout => TimeSpan.FromSeconds(1.0);

	public TimeSpan ConnectionCircuitBreakerRetryInterval => TimeSpan.MaxValue;

	public bool IsExecutionCircuitBreakerEnabled => false;

	public TimeSpan ExecutionCircuitBreakerRetryInterval => TimeSpan.MaxValue;

	public HashSet<SocketError> SocketErrorsThatTripExecutionCircuitBreaker { get; } = new HashSet<SocketError> { SocketError.TimedOut };


	public int ExecutionCircuitBreakerExceptionCountForTripping => 1;

	public TimeSpan ExecutionCircuitBreakerExceptionIntervalForTripping { get; } = TimeSpan.MaxValue;


	public IReadOnlyDictionary<string, TimeSpan> PerHostExpiryOverrides { get; } = new Dictionary<string, TimeSpan>();


	public bool PerHostExpiryOverridesEnabled { get; }

	public int ConnectionCircuitBreakerExceptionCountForTripping { get; } = 1;


	public TimeSpan ConnectionCircuitBreakerExceptionIntervalForTripping { get; } = TimeSpan.FromMilliseconds(100.0);


	public HashSet<string> ExceptionTypeNamesToForceResetBytes { get; } = new HashSet<string>();


	public int ForceResetBytesMaxAttempts { get; } = 1;


	public int ForceResetBytesMaxNumberOfBytes { get; } = 256;


	public bool LogVerboseExceptions { get; }

	public bool IsRespectingMaxPoolSizeEnabled { get; } = true;


	public bool UseRoundRobinSocketPoolSelection { get; }

	public int MaximumSelectionAttemptsForRoundRobin { get; }

	public uint CompressionThreshold { get; } = 131072u;


	public TimeSpan SendReceiveTimeout { get; } = TimeSpan.FromMilliseconds(2000.0);


	public uint MinimumPoolSize { get; } = 5u;


	public uint MaximumPoolSize { get; } = 100u;


	public TimeSpan SocketRecycleAge { get; } = TimeSpan.FromMinutes(30.0);


	public IMemcachedClientDnsSettings DnsSettings => new FakeDnsSettings();

	public TimeSpan EndpointCacheExpiry { get; } = TimeSpan.FromMinutes(2.0);


	public bool IsConnectionCreationRateLimitingEnabled { get; }

	public TimeSpan ConnectionCreationRateLimitPeriodLength { get; } = TimeSpan.FromSeconds(1.0);


	public int MaximumConnectionCreationsPerPeriod { get; } = 10;

}
