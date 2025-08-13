namespace Roblox.Platform.Authentication;

/// <summary>
/// Provides a common interface for Facebook credentials.
/// </summary>
public interface IFacebookCredentials : ICredentials
{
	/// <summary>
	/// The Facebook id associated with these credentials.
	/// </summary>
	ulong FacebookId { get; }
}
