using System;

namespace Roblox.Kickbox.Properties;

/// <summary>
/// Interface for settins to Kickbox
/// </summary>
public interface IKickboxSettings
{
	/// <summary>
	/// The Kickbox https endpoint
	/// </summary>
	string KickboxDisposableApiEndpoint { get; }

	/// <summary>
	/// The URI of the endpoint
	/// </summary>
	string KickboxDisposableApiUri { get; }

	/// <summary>
	/// The URI if the API
	/// </summary>
	string KickboxUri { get; }

	/// <summary>
	/// Private API key for Kickbox
	/// </summary>
	string KickboxApiKey { get; }

	/// <summary>
	/// Separate circuit breaker retry interval for Kickbox
	/// </summary>
	TimeSpan KickboxCircuitBreakerRetryInterval { get; }

	/// <summary>
	/// Adjustable client retry. Kickbox requests can take up to 10+ seconds
	/// </summary>
	TimeSpan KickboxClientTimeoutInterval { get; }

	/// <summary>
	/// Enable detailed error logging in Windows Event Logs
	/// </summary>
	bool IsDetailedKickboxErrorLoggingEnabled { get; }

	string DisposableDomainCachePrefix { get; }

	string SafeDomainCachePrefix { get; }
}
