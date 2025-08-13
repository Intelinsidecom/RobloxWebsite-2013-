namespace Roblox.Platform.CallContext;

/// <summary>
/// Interface for a factory of ICallContext instances.
/// </summary>
public interface ICallContextFactory
{
	/// <summary>
	/// Create an ICallContext object to represent current session context.
	/// </summary>
	/// <returns>Fresh ICallContext instance.</returns>
	ICallContext GetCallContext();
}
