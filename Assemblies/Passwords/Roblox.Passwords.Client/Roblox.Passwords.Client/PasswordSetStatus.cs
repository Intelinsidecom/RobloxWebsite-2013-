namespace Roblox.Passwords.Client;

/// <summary>
/// Represents the set status.
/// </summary>
public enum PasswordSetStatus
{
	/// <summary>
	/// Unknown status
	/// </summary>
	Unknown,
	/// <summary>
	/// Valid password is set
	/// </summary>
	ValidPasswordSet,
	/// <summary>
	/// The set password is invalid.
	/// </summary>
	InvalidPasswordSet,
	/// <summary>
	/// The password needs reset.
	/// </summary>
	PasswordNeedsReset
}
