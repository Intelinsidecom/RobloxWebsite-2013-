namespace Roblox.Gigya;

/// <summary>
/// A Gigya Signature and Timestamp for use when executing client side API calls to Gigya.
/// </summary>
/// <remarks>
/// Example usage:
/// http://developers.gigya.com/display/GD/socialize.notifyLogin+REST
/// See UIDSig, UIDTimestamp
/// </remarks>
public interface IGigyaSignatureTimestamp
{
	/// <summary>
	/// The Gigya Signature
	/// </summary>
	string Signature { get; }

	/// <summary>
	/// The Timestamp
	/// </summary>
	int Timestamp { get; }
}
