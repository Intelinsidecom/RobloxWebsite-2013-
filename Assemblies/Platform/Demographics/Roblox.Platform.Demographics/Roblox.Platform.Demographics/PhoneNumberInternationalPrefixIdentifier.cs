namespace Roblox.Platform.Demographics;

public class PhoneNumberInternationalPrefixIdentifier : IPhoneNumberInternationalPrefixIdentifier
{
	public short Id { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.PhoneNumberInternationalPrefixIdentifier" /> class.
	/// </summary>
	public PhoneNumberInternationalPrefixIdentifier(short id)
	{
		Id = id;
	}
}
