namespace Roblox.Platform.CallContext;

/// <summary>
/// Interface for representing request context.
/// </summary>
public interface ICallContext
{
	/// <summary>
	/// The UserID of the currently authenticated user (or null).
	/// </summary>
	long? AuthenticatedUserID { get; }

	/// <summary>
	/// IP address of the origin of the request
	/// </summary>
	string ClientIPAddress { get; }

	/// <summary>
	/// User-Agent string accompanying the request
	/// </summary>
	string UserAgent { get; }
}
