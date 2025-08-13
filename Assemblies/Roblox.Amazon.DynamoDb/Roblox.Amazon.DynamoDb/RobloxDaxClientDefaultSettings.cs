using System;
using Amazon;
using Roblox.Amazon.DynamoDb.Properties;

namespace Roblox.Amazon.DynamoDb;

/// <summary>
/// Default settings for the <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClient" />.
/// </summary>
/// <remarks>Should be converted to a readonly struct once C# 7.2 is available.</remarks>
public struct RobloxDaxClientDefaultSettings
{
	/// <summary>
	/// Gets a value indicating whether circuit breaker is enabled.
	/// </summary>
	public readonly bool IsCircuitBreakerEnabled;

	/// <summary>
	/// Gets a value indicating whether asynchronous request timeout is enabled.
	/// </summary>
	public readonly bool IsAsyncRequestTimeoutEnabled;

	/// <summary>
	/// Gets a value indicating whether throttle retries is enabled.
	/// </summary>
	public readonly bool IsThrottleRetriesEnabled;

	/// <summary>
	/// Gets the request timeout.
	/// </summary>
	public readonly TimeSpan RequestTimeout;

	/// <summary>
	/// Gets the read write timeout.
	/// </summary>
	public readonly TimeSpan ReadWriteTimeout;

	/// <summary>
	/// Gets the amount of failures allowed before circuit breaker trip.
	/// </summary>
	public readonly int FailuresAllowedBeforeCircuitBreakerTrip;

	/// <summary>
	/// Gets the circuit breaker retry interval.
	/// </summary>
	public readonly TimeSpan CircuitBreakerRetryInterval;

	/// <summary>
	/// Gets the maximum error retry.
	/// </summary>
	public readonly int MaxErrorRetry;

	/// <summary>
	/// The default <see cref="F:Roblox.Amazon.DynamoDb.RobloxDaxClientDefaultSettings.RegionEndpoint" />.
	/// </summary>
	public readonly RegionEndpoint RegionEndpoint;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Amazon.DynamoDb.RobloxDaxClientDefaultSettings" />.
	/// </summary>
	/// <param name="settings">A <see cref="T:Roblox.Amazon.DynamoDb.Properties.IDaxClientSettings" /></param>
	/// <exception cref="T:System.ArgumentNullException"><paramref name="settings" /></exception>
	internal RobloxDaxClientDefaultSettings(IDaxClientSettings settings)
	{
		if (settings == null)
		{
			throw new ArgumentNullException("settings");
		}
		IsCircuitBreakerEnabled = settings.IsCircuitBreakerEnabled;
		IsAsyncRequestTimeoutEnabled = settings.IsAsyncRequestTimeoutEnabled;
		IsThrottleRetriesEnabled = settings.IsThrottleRetriesEnabled;
		RequestTimeout = settings.RequestTimeout;
		ReadWriteTimeout = settings.ReadWriteTimeout;
		FailuresAllowedBeforeCircuitBreakerTrip = settings.FailuresAllowedBeforeCircuitBreakerTrip;
		CircuitBreakerRetryInterval = settings.CircuitBreakerRetryInterval;
		MaxErrorRetry = settings.MaxErrorRetry;
		RegionEndpoint = RegionEndpoint.GetBySystemName(settings.RegionEndpointSystemName) ?? throw new ArgumentException($"Invalid RegionEndpoint {settings.RegionEndpointSystemName}", "settings");
	}
}
