namespace Roblox.AuthenticationV2;

/// <summary>
/// Writes telemetry for AuthenticationV2
/// </summary>
public interface IAuthenticationV2Telemetry
{
	/// <summary>
	/// Increments the specified counter instance
	/// </summary>
	/// <param name="counter">The counter to increment</param>
	/// <param name="instance">The instance to increment</param>
	void Increment(Counter counter, Instance instance);
}
