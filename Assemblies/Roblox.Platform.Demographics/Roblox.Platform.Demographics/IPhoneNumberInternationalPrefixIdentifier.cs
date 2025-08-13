namespace Roblox.Platform.Demographics;

/// <summary>
/// Provides a common interface for an object that uniquely identifies a phone number international prefix.
/// </summary>
public interface IPhoneNumberInternationalPrefixIdentifier
{
	/// <summary>
	/// Gets the ID of the internatioanl prefix.
	/// </summary>
	/// <value>
	/// The ID of the international prefix.
	/// </value>
	short Id { get; }
}
