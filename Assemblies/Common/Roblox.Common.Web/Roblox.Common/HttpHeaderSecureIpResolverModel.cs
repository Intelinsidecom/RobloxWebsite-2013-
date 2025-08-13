namespace Roblox.Common;

/// <summary>
/// Model for receiving the client IP via secure header and hash check
/// </summary>
public class HttpHeaderSecureIpResolverModel
{
	/// <summary>
	/// The purported client IP of the request
	/// </summary>
	public string TrueIp;

	/// <summary>
	/// The proxy-reported URL of the request
	/// </summary>
	public string ProxyUrl;

	/// <summary>
	/// Nonce to prevent replay attacks.
	/// </summary>
	public string Nonce;

	/// <summary>
	/// The HMAC signature verifying the client IP
	/// </summary>
	public string SecureHash1;

	/// <summary>
	/// The HMAC signature verifying the client IP, allowing for key rotation
	/// </summary>
	public string SecureHash2;

	/// <summary>
	/// Boolean to determine whether the hash check is enforced
	/// </summary>
	public bool EnableHashCheck;

	/// <summary>
	/// The key used to validate the SecureHash
	/// </summary>
	public string Key1;

	/// <summary>
	/// The key used to validate the SecureHash, allowing for key rotation
	/// </summary>
	public string Key2;
}
