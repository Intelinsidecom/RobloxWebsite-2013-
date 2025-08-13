namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an interface for the internatonal prefix of phone numbers 
/// </summary>
public interface IPhoneNumberInternationalPrefix : IPhoneNumberInternationalPrefixIdentifier
{
	/// <summary>
	/// The identifier for the country associated with the prefix.
	/// </summary>
	ICountryIdentifier CountryIdentifier { get; }

	/// <summary>
	/// The string representing the prefix (eg. "1" for America, "44" for the United Kingdoms, "1" for Canada).
	/// </summary>
	string Value { get; }

	/// <summary>
	/// Whether the prefix is active.
	/// </summary>
	bool IsActive { get; set; }
}
