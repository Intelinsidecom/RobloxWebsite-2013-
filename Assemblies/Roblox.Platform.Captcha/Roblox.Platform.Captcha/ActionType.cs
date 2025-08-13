namespace Roblox.Platform.Captcha;

/// <summary>
/// Represents a type of action that is protected by Captcha.
/// </summary>
public enum ActionType
{
	/// <summary>
	/// A user is signing up.
	/// </summary>
	Signup = 1,
	/// <summary>
	/// A user is logging in.
	/// </summary>
	Login,
	/// <summary>
	/// Not used.
	/// </summary>
	PrivateMessage,
	/// <summary>
	/// All actions inside the site after a user is logged in.
	/// </summary>
	UserAction,
	/// <summary>
	/// Redeem Robux card
	/// </summary>
	GamecardRedemption,
	/// <summary>
	/// Reset password
	/// </summary>
	ResetPassword
}
