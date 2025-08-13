namespace Roblox.Platform.Social;

/// <summary>
/// Represents a privacy type the determines who can send a user a message.
/// </summary>
public enum MessagePrivacyType
{
	/// <summary>
	/// Any user can send the user a message.
	/// </summary>
	All,
	/// <summary>
	/// Only best friend can send the user a message.
	/// </summary>
	TopFriends,
	/// <summary>
	/// Only friends can send the user a message.
	/// </summary>
	Friends,
	/// <summary>
	/// Nobody can send the user a message.
	/// </summary>
	NoOne,
	/// <summary>
	/// No longer used - deprecated privacy type.
	/// </summary>
	Disabled,
	/// <summary>
	/// Only friends and users the user is following can send the user a message
	/// </summary>
	Following,
	/// <summary>
	/// Only friends, users the user is following, and users following the user can send the user a message
	/// </summary>
	Followers
}
