namespace Roblox.Platform.Email.Delivery;

/// <summary>
/// The set of text/media types that represent supported email body text formats.
/// </summary>
public enum EmailBodyType
{
	/// <summary>
	/// Plain text email body.
	/// </summary>
	Plain = 1,
	/// <summary>
	/// Html format email body.
	/// </summary>
	Html,
	/// <summary>
	/// Mime format email body.
	/// </summary>
	Mime
}
