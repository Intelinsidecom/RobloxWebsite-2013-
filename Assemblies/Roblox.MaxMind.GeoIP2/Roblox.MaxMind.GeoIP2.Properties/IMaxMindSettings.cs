using System;

namespace Roblox.MaxMind.GeoIP2.Properties;

public interface IMaxMindSettings
{
	/// <summary>
	/// The MaxMind API Endpoint
	/// </summary>
	string GeoIP2ServiceEndpoint { get; }

	/// <summary>
	/// Default API timeout
	/// </summary>
	TimeSpan GeoIP2WebClientTimeout { get; }

	/// <summary>
	/// The account username
	/// </summary>
	string GeoIP2Username { get; }

	/// <summary>
	/// The account password
	/// </summary>
	string GeoIP2Password { get; }

	/// <summary>
	/// Override retry interval
	/// </summary>
	TimeSpan GeoIP2CircuitBreakerRetryInterval { get; }

	/// <summary>
	/// Whether to enable http-level error logging
	/// </summary>
	bool EnableDetailedErrorLogging { get; }

	/// <summary>
	/// use basic auth header instead of built-in .net
	/// </summary>
	bool UseDirectHttpBasicAuthHeader { get; }
}
