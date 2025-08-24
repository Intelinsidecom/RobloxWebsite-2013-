namespace Roblox.FloodCheckers.Core;

/// <summary>
/// Provides the number of seconds the caller must wait until they can send a request that will not be flood checked,
/// if the caller is flooded.
/// </summary>
public interface IRetryAfterFloodChecker : IFloodChecker, IBasicFloodChecker
{
	/// <summary>
	/// Returns the amount of time in seconds until the caller can send a request that will not be flood checked. Null if the caller is not flood checked.
	/// </summary>
	int? RetryAfter();
}
