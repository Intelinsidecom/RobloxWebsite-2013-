namespace Roblox.Platform.Captcha;

/// <summary>
/// Represents a type of <see cref="T:Roblox.Platform.Captcha.Identifier" /> target.
/// </summary>
public enum IdentifierTargetType
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Captcha.Identifier" /> is an IP address.
	/// </summary>
	IpAddress = 1,
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Captcha.Identifier" /> is a username.
	/// </summary>
	Username,
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Captcha.Identifier" /> is a browser tracker ID.
	/// </summary>
	BrowserTrackerID,
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Captcha.Identifier" /> is a user ID.
	/// </summary>
	UserId
}
