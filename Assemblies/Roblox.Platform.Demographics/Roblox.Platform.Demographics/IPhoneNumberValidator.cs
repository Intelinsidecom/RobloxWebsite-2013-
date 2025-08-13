namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an interface for validating a phone number
/// </summary>
public interface IPhoneNumberValidator
{
	/// <summary>
	/// Checks whether a phone is valid.
	/// </summary>
	/// <param name="phone">The phone to test validity for.</param>
	/// <returns>
	/// True if the passed in account phone number is valid, false otherwise.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="phone.Phone.Phone" /> is null or empty.</exception>
	bool IsValid(string phone);

	/// <summary>
	/// Checks whether a phone number is valid.
	/// </summary>
	/// <param name="internationalPrefix"></param>
	/// <param name="nationalPhoneNumber"></param>
	/// <param name="twoLetterCountryCode"></param>
	/// <returns>Whether the phone number is correct</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if any param is null or empty.</exception>
	bool IsValid(string internationalPrefix, string nationalPhoneNumber, string twoLetterCountryCode);

	/// <summary>
	/// Gets a valid and sanitized phone number
	/// </summary>
	/// <param name="internationalPrefix"></param>
	/// <param name="nationalPhoneNumber"></param>
	/// <param name="twoLetterCountryCode"></param>
	/// <returns>The <see cref="T:Roblox.Platform.Demographics.ISanitizedPhoneNumber" /> or null if the phone is not valid </returns>
	ISanitizedPhoneNumber GetSanitizedPhoneNumber(string internationalPrefix, string nationalPhoneNumber, string twoLetterCountryCode);

	/// <summary>
	/// Tries to get a <see cref="T:Roblox.Platform.Demographics.ISanitizedPhoneNumber" /> from a string representation of a phone number.
	/// <remarks>
	///     Works for valid international phone number starting or not with the + sign. 
	///     Works for national phone numbers although for these, <see cref="P:Roblox.Platform.Demographics.ISanitizedPhoneNumber.InternationalPrefix" /> will always be null
	///     unless you supply a valid <paramref name="twoLetterCountryCode" />.
	///     This will strip away any special characters and letters besides one leading + sign.
	///     For example the phone number "+++123%456A7890" becomes "+1234567890".
	/// </remarks>
	/// </summary>
	/// <param name="phoneNumber">A string representation of a phone number.</param>
	/// <param name="sanitizedPhoneNumber">An out <see cref="T:Roblox.Platform.Demographics.ISanitizedPhoneNumber" />.</param>
	/// <param name="twoLetterCountryCode">
	///     An optional twoLetterCountryCode. You need to provide a valid twoLetterCountryCode and a valid 
	///     national/international phone number to get the <see cref="P:Roblox.Platform.Demographics.ISanitizedPhoneNumber.InternationalPrefix" /> information. 
	///     Otherwise it will be null.
	/// </param>
	/// <returns>True if <paramref name="sanitizedPhoneNumber" /> was assigned a non null <see cref="T:Roblox.Platform.Demographics.ISanitizedPhoneNumber" />. False otherwise.</returns>
	bool TryGetSanitizedPhoneNumberFromPhoneNumber(string phoneNumber, out ISanitizedPhoneNumber sanitizedPhoneNumber, string twoLetterCountryCode = null);

	/// <summary>
	/// Gets a formatted number from an international phone number.
	/// If the phone number is valid, outputs the country code + the national phone number
	/// without the symbols or spaces that the provided phone number might content.
	/// If a country code is passed will try to validate the phone number region.
	/// If no country code is passed then will use an unknown region code for validation.
	/// </summary>
	/// <param name="phoneNumber">The string representation of a phone number</param>
	/// <param name="twoLetterCountryCode">The two letter country code, if none is passed the 
	/// parser will try to infer it by using the unknown region.</param>
	/// <returns>The formatted phone number.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Thrown if <paramref name="phoneNumber" /> is null or empty.</exception>
	/// <exception cref="T:Roblox.Platform.Demographics.PlatformInvalidPhoneNumberException">
	///     Thrown if <paramref name="phoneNumber" /> is an invalid phone or
	///     a valid national phone and no <paramref name="twoLetterCountryCode" /> was provided.
	/// </exception>
	string GetFormattedPhoneNumber(string phoneNumber, string twoLetterCountryCode = null);

	/// <summary>
	/// Strips all invalid (non-digit) characters from a given phone number.
	/// </summary>
	/// <param name="phoneNumber">The phone number</param>
	/// <returns>The stripped phone number</returns>
	string StripInvalidCharacters(string phoneNumber);
}
