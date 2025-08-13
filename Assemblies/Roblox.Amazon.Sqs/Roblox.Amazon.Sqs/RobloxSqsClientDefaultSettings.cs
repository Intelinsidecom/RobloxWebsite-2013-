using System;

namespace Roblox.Amazon.Sqs;

/// <summary>
/// RobloxSqsClient default settings <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClient" />.
/// </summary>
public sealed class RobloxSqsClientDefaultSettings : IEquatable<RobloxSqsClientDefaultSettings>
{
	/// <summary>
	/// Gets a value indicating whether circuit breaker is enabled.
	/// </summary>
	public bool IsCircuitBreakerEnabled { get; }

	/// <summary>
	/// Gets a value indicating whether asynchronous request timeout is enabled.
	/// </summary>
	public bool IsAsyncRequestTimeoutEnabled { get; }

	/// <summary>
	/// Gets a value indicating whether throttle retries is enabled.
	/// </summary>
	public bool IsThrottleRetriesEnabled { get; }

	/// <summary>
	/// Gets the request timeout.
	/// </summary>
	public TimeSpan RequestTimeout { get; }

	/// <summary>
	/// Gets the read write timeout.
	/// </summary>
	public TimeSpan ReadWriteTimeout { get; }

	/// <summary>
	/// Gets the amount of failures allowed before circuit breaker trip.
	/// </summary>
	public int FailuresAllowedBeforeCircuitBreakerTrip { get; }

	/// <summary>
	/// Gets the circuit breaker retry interval.
	/// </summary>
	public TimeSpan CircuitBreakerRetryInterval { get; }

	/// <summary>
	/// Gets the maximum error retry.
	/// </summary>
	public int MaxErrorRetry { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Amazon.Sqs.RobloxSqsClientDefaultSettings" /> class.
	/// </summary>
	/// <param name="isCircuitBreakerEnabled">if set to <c>true</c> then circuit breaker is enabled.</param>
	/// <param name="isAsyncRequestTimeoutEnabled">if set to <c>true</c> then asynchronous request timeout is enabled.</param>
	/// <param name="isThrottleRetriesEnabled">if set to <c>true</c> throttle retries is enabled.</param>
	/// <param name="requestTimeout">The request timeout.</param>
	/// <param name="readWriteTimeout">The read write timeout.</param>
	/// <param name="failuresAllowedBeforeCircuitBreakerTrip">The failures allowed before circuit breaker trip.</param>
	/// <param name="circuitBreakerRetryInterval">The circuit breaker retry interval.</param>
	/// <param name="maxErrorRetry">The maximum error retry.</param>
	public RobloxSqsClientDefaultSettings(bool isCircuitBreakerEnabled, bool isAsyncRequestTimeoutEnabled, bool isThrottleRetriesEnabled, TimeSpan requestTimeout, TimeSpan readWriteTimeout, int failuresAllowedBeforeCircuitBreakerTrip, TimeSpan circuitBreakerRetryInterval, int maxErrorRetry)
	{
		IsCircuitBreakerEnabled = isCircuitBreakerEnabled;
		IsAsyncRequestTimeoutEnabled = isAsyncRequestTimeoutEnabled;
		IsThrottleRetriesEnabled = isThrottleRetriesEnabled;
		RequestTimeout = requestTimeout;
		ReadWriteTimeout = readWriteTimeout;
		FailuresAllowedBeforeCircuitBreakerTrip = failuresAllowedBeforeCircuitBreakerTrip;
		CircuitBreakerRetryInterval = circuitBreakerRetryInterval;
		MaxErrorRetry = maxErrorRetry;
	}

	/// <summary>
	/// Determines whether the specified <see cref="T:System.Object" />, is equal to this instance.
	/// </summary>
	/// <param name="obj">The <see cref="T:System.Object" /> to compare with this instance.</param>
	/// <returns>
	///   <c>true</c> if the specified <see cref="T:System.Object" /> is equal to this instance; otherwise, <c>false</c>.
	/// </returns>
	public override bool Equals(object obj)
	{
		if (obj == null)
		{
			return false;
		}
		if (this == obj)
		{
			return true;
		}
		if (obj.GetType() == GetType())
		{
			return Equals((RobloxSqsClientDefaultSettings)obj);
		}
		return false;
	}

	/// <summary>
	/// Returns a hash code for this instance.
	/// </summary>
	/// <returns>
	/// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table. 
	/// </returns>
	public override int GetHashCode()
	{
		return (((((((((((((IsCircuitBreakerEnabled.GetHashCode() * 397) ^ IsAsyncRequestTimeoutEnabled.GetHashCode()) * 397) ^ IsThrottleRetriesEnabled.GetHashCode()) * 397) ^ RequestTimeout.GetHashCode()) * 397) ^ ReadWriteTimeout.GetHashCode()) * 397) ^ FailuresAllowedBeforeCircuitBreakerTrip.GetHashCode()) * 397) ^ CircuitBreakerRetryInterval.GetHashCode()) * 397) ^ MaxErrorRetry.GetHashCode();
	}

	/// <summary>
	/// Indicates whether the current object is equal to another object of the same type.
	/// </summary>
	/// <param name="other">An object to compare with this object.</param>
	/// <returns>
	/// true if the current object is equal to the <paramref name="other" /> parameter; otherwise, false.
	/// </returns>
	public bool Equals(RobloxSqsClientDefaultSettings other)
	{
		if (other == null)
		{
			return false;
		}
		if (this == other)
		{
			return true;
		}
		if (IsCircuitBreakerEnabled == other.IsCircuitBreakerEnabled && IsAsyncRequestTimeoutEnabled == other.IsAsyncRequestTimeoutEnabled && IsThrottleRetriesEnabled == other.IsThrottleRetriesEnabled && RequestTimeout == other.RequestTimeout && ReadWriteTimeout == other.ReadWriteTimeout && FailuresAllowedBeforeCircuitBreakerTrip == other.FailuresAllowedBeforeCircuitBreakerTrip && CircuitBreakerRetryInterval == other.CircuitBreakerRetryInterval)
		{
			return MaxErrorRetry == other.MaxErrorRetry;
		}
		return false;
	}
}
