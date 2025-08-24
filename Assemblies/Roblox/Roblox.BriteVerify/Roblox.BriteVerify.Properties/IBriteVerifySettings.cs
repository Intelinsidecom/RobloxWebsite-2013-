using System;

namespace Roblox.BriteVerify.Properties;

/// <summary>
/// Interface for settins to BriteVerify
/// </summary>
public interface IBriteVerifySettings
{
	/// <summary>
	/// The BriteVerify https endpoint
	/// </summary>
	string BriteVerifyApiEndpoint { get; }

	/// <summary>
	/// The URI if the API
	/// </summary>
	string BriteVerifyUri { get; }

	/// <summary>
	/// Private API key for BriteVerify
	/// </summary>
	string BriteVerifyApiKey { get; }

	/// <summary>
	/// Separate circuit breaker retry interval for BriteVerify
	/// </summary>
	TimeSpan BriteVerifyCircuitBreakerRetryInterval { get; }

	/// <summary>
	/// Adjustable client retry. BriteVerify requests can take up to 10+ seconds
	/// </summary>
	TimeSpan BriteVerifyClientTimeoutInterval { get; }

	/// <summary>
	/// Enable detailed error logging in Windows Event Logs
	/// </summary>
	bool IsDetailedBriteVerifyErrorLoggingEnabled { get; }
}
