namespace Roblox.Passwords.Client;

/// <summary>
/// Result from GetPasswordStatus
/// </summary>
public class PasswordStatusResult
{
	/// <summary>
	/// The ID of the AccountPasswordHash
	/// </summary>
	public long? Id { get; set; }

	/// <summary>
	/// The password set status.
	/// </summary>
	public PasswordSetStatus SetStatus { get; set; }
}
