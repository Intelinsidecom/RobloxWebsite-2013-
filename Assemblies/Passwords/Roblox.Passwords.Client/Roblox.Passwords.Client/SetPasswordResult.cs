namespace Roblox.Passwords.Client;

/// <summary>
/// Represents the result for SetPassword
/// </summary>
public enum SetPasswordResult
{
	/// <summary>
	/// Unknown
	/// </summary>
	Unknown,
	/// <summary>
	/// The target does not exist.
	/// </summary>
	TargetNotExist,
	/// <summary>
	/// The password was set
	/// </summary>
	PasswordSet
}
