namespace Roblox.Passwords.Client;

/// <summary>
/// Represents the owner of a password.
///
/// For User a lookup will be done for AccountPasswordHash.
/// </summary>
public enum PasswordOwnerType
{
	/// <summary>
	/// Represents the ID specified is for a user, will perform a lookup to get account ID.
	/// </summary>
	User,
	/// <summary>
	/// Represents the ID specified is for an account.
	/// </summary>
	Account
}
