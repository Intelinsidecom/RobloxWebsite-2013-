using Roblox.Platform.Core;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an object that uniquely identifies a phone number.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Demographics.IPhoneNumberIdentifier" />
public class PhoneNumberIdentifier : IPhoneNumberIdentifier, IDomainObjectIdentifier<int>
{
	public int Id { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.PhoneNumberIdentifier" /> class.
	/// </summary>
	/// <param name="id">The phone number's ID.</param>
	public PhoneNumberIdentifier(int id)
	{
		Id = id;
	}
}
