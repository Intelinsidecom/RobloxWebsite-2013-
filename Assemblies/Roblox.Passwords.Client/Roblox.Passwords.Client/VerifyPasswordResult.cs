namespace Roblox.Passwords.Client;

/// <summary>
/// Represents the result for VerifyPassword
/// </summary>
public enum VerifyPasswordResult
{
	/// <summary>
	/// Unknown/
	/// </summary>
	Unknown,
	/// <summary>
	/// The target does not exist.
	/// </summary>
	TargetNotExist,
	/// <summary>
	/// The password needs reset.
	/// </summary>
	PasswordNeedsReset,
	/// <summary>
	/// The password hash is valid.
	/// </summary>
	ValidPasswordHash
}
