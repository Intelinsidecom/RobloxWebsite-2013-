using System;
using System.ComponentModel;

namespace Roblox.Amazon.DynamoDb.Properties;

/// <summary>
/// All settings for the <see cref="!:RobloxDaxClusterClient" />, populates the <see cref="!:RobloxDaxClusterClientDefaultSettings" />.
/// </summary>
internal interface IDaxClusterClientSettings : INotifyPropertyChanged
{
	/// <summary>
	/// Whether the circuit breaker is enabled.
	/// </summary>
	bool IsCircuitBreakerEnabled { get; }

	/// <summary>
	/// Whether asynchronous request timeout is enabled.
	/// </summary>
	bool IsAsyncRequestTimeoutEnabled { get; }

	/// <summary>
	/// The request timeout.
	/// </summary>
	TimeSpan RequestTimeout { get; }

	/// <summary>
	/// Amount of failures allowed before circuit breaker trip.
	/// </summary>
	int FailuresAllowedBeforeCircuitBreakerTrip { get; }

	/// <summary>
	/// Circuit breaker retry interval.
	/// </summary>
	TimeSpan CircuitBreakerRetryInterval { get; }

	/// <summary>
	/// Whether failures to trip on extended mode is enabled.
	/// </summary>
	bool IsFailuresToTripOnExtendedModeEnabled { get; }

	/// <summary>
	/// How often should read requests be retried?
	/// </summary>
	int ReadRetryCount { get; }

	/// <summary>
	/// How often should write requests be retried?
	/// </summary>
	int WriteRetryCount { get; }

	/// <summary>
	/// What should the <see cref="T:System.TimeSpan" /> between two health checks be?
	/// </summary>
	TimeSpan HealthCheckInterval { get; }

	/// <summary>
	/// How long to wait for the healthcheck response?
	/// </summary>
	TimeSpan HealthCheckTimeout { get; }

	/// <summary>
	/// How many concurrent pending connections to allow?
	/// </summary>
	int MaxPendingConnections { get; }

	TimeSpan ClusterUpdateThresholdTime { get; }

	TimeSpan ClusterUpdateInterval { get; }

	TimeSpan MaxRetryDelayTime { get; }

	TimeSpan ConnectTimeout { get; }

	/// <summary>
	/// The default region endpoint, e.g. us-east-1.
	/// </summary>
	string RegionEndpointSystemName { get; }
}
