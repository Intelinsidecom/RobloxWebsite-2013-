using System.Collections.Generic;

namespace Roblox.Platform.Demographics;

/// <summary>
/// A public interface producing <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" />es
/// </summary>
public interface IPhoneNumberInternationalPrefixFactory
{
	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" /> by its id
	/// </summary>
	IPhoneNumberInternationalPrefix GetByID(IPhoneNumberInternationalPrefixIdentifier id);

	/// <summary>
	/// Gets an <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" /> by its two-letter ISO code and the prefix number
	/// </summary>
	IPhoneNumberInternationalPrefix GetByCountryAndPrefix(string twoLetterCode, string prefix);

	/// <summary>
	/// Get or create an <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" /> by its two-letter ISO code and the prefix number
	/// </summary>
	IPhoneNumberInternationalPrefix GetOrCreate(string twoLetterCode, string prefix);

	/// <summary>
	/// Get all the <see cref="T:Roblox.Platform.Demographics.IPhoneNumberInternationalPrefix" />es that are active.
	/// </summary>
	ICollection<IPhoneNumberInternationalPrefix> GetAllActivePrefixes();
}
