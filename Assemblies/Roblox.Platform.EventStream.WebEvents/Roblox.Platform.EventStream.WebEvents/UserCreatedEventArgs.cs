namespace Roblox.Platform.EventStream.WebEvents;

public class UserCreatedEventArgs : WebEventArgs
{
	/// <summary>
	/// Whether the user was presented with Captcha during signup.
	/// </summary>
	public bool Captcha { get; set; }

	/// <summary>
	/// The count over limit of the etag floodchecker.
	/// </summary>
	public int ETagCountOverLimit { get; set; }

	/// <summary>
	/// The count over limit of the IP address floodchecker.
	/// </summary>
	public int IpAddressCountOverLimit { get; set; }

	/// <summary>
	/// If applicable, the ID of the place through which the user signed up.
	/// </summary>
	public long? PlaceId { get; set; }

	/// <summary>
	/// The page through which the user signed up.
	/// </summary>
	public string Context { get; set; }

	/// <summary>
	/// The username the user signed up with.
	/// </summary>
	public string Username { get; set; }

	/// <summary>
	/// The verification method the user signed up with.
	/// </summary>
	public string VerificationMethod { get; set; }
}
