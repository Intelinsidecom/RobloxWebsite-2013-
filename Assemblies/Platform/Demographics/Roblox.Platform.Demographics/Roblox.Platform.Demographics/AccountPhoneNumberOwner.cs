namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an account phone number owner.
/// </summary>
internal class AccountPhoneNumberOwner : IAccountPhoneNumberOwner
{
	/// <inheritdoc />
	public long AccountId { get; set; }

	public int AccountPhoneNumberId { get; set; }
}
