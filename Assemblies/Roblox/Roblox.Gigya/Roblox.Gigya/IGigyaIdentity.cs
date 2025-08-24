namespace Roblox.Gigya;

/// <summary>
/// Provides a common interface for a social network identity.
/// </summary>
public interface IGigyaIdentity
{
	/// <summary>
	/// The social network provider for which this identity is valid. E.g. facebook, twitter, googleplus.
	/// </summary>
	string Provider { get; }

	/// <summary>
	/// The identity's unique identifier in the given provider.
	/// </summary>
	string ProviderUid { get; }

	/// <summary>
	/// A URL to the identity's profile on the given provider.
	/// </summary>
	string ProfileUrl { get; }
}
