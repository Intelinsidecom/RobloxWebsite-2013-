namespace Roblox.Platform.Email.User;

/// <summary>
/// E-mail for a given <see cref="T:Roblox.Platform.Membership.IUser" /> along with validation information.
///
/// Future direction - replace with an IUserEmail abstraction
/// </summary>
public interface IAccountEmail
{
	/// <summary>
	/// The AccountEmailId
	/// </summary>
	int Id { get; }

	/// <summary>
	/// The actual e-mail address
	/// </summary>
	string Email { get; }

	/// <summary>
	/// Has this e-mail address been Blacklisted?
	/// </summary>
	bool IsBlacklisted { get; }

	/// <summary>
	/// Has this e-mail address been verified for the <see cref="T:Roblox.Platform.Membership.IUser" />?
	/// </summary>
	bool IsVerified { get; }

	/// <summary>
	/// If this email is the current email for the user
	/// </summary>
	bool IsCurrent { get; }

	/// <summary>
	/// Has this e-mail been marked as valid for the <see cref="T:Roblox.Platform.Membership.IUser" />?
	/// </summary>
	bool IsValid { get; }

	/// <summary>
	/// The Account identifier.
	/// </summary>
	long AccountId { get; }
}
