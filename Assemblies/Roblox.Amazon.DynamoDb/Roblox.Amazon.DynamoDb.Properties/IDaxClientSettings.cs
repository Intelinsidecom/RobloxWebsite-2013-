using System;
using System.ComponentModel;

namespace Roblox.Amazon.DynamoDb.Properties;

/// <summary>
/// All settings for the <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClient" />, populates the <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientDefaultSettings" />.
/// </summary>
internal interface IDaxClientSettings : INotifyPropertyChanged
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
	/// Whether throttle retries is enabled.
	/// </summary>
	bool IsThrottleRetriesEnabled { get; }

	/// <summary>
	/// The request timeout.
	/// </summary>
	TimeSpan RequestTimeout { get; }

	/// <summary>
	/// The read write timeout.
	/// </summary>
	TimeSpan ReadWriteTimeout { get; }

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
	/// Maximum error retry.
	/// </summary>
	int MaxErrorRetry { get; }

	/// <summary>
	/// The default region endpoint, e.g. us-east-1.
	/// </summary>
	string RegionEndpointSystemName { get; }
}
