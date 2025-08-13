namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an account phone number owner.
/// </summary>
public interface IAccountPhoneNumberOwner
{
	/// <summary>
	/// The phone number owner's account id.
	/// </summary>
	long AccountId { get; }

	/// <summary>
	/// The phone number owner's account phone number id.
	/// </summary>
	int AccountPhoneNumberId { get; }
}
