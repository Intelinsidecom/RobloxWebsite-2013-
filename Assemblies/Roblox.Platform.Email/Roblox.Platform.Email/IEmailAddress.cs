namespace Roblox.Platform.Email;

/// <summary>
/// An interface for representing an email address.
/// </summary>
public interface IEmailAddress
{
	/// <summary>
	/// The ID of the email address
	/// </summary>
	int Id { get; }

	/// <summary>
	/// The actual email address
	/// </summary>
	string Address { get; }

	/// <summary>
	/// Whether the email address is blacklisted.  Emails should not be delivered to blacklisted email addresses, not even for account recovery.
	/// </summary>
	bool IsBlacklisted { get; }
}
