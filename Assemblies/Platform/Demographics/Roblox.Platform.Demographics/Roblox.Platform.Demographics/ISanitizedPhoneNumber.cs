namespace Roblox.Platform.Demographics;

public interface ISanitizedPhoneNumber
{
	/// <summary>
	/// The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" /> for the sanitized phone
	/// </summary>
	IPhoneNumberInternationalPrefix InternationalPrefix { get; set; }

	/// <summary>
	/// The national number
	/// </summary>
	string NationalNumber { get; set; }

	/// <summary>
	/// The full number (prefix + national number)
	/// </summary>
	string FullNumber { get; set; }
}
