namespace Roblox.Platform.Localization.Core;

/// <summary>
/// A "Language Family" represents a collection of related locales.
/// Eg. The American English (en_us) and British English (en_uk) locales would both be part of the "English" Language Family (en)
/// </summary>
public interface ILanguageFamily : ILanguageFamilyIdentifier
{
	/// <summary>
	/// Name of the language in English (eg. Korean could be "Korean")
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Name of the language in that native language (eg. Korean could be "한국어")
	/// </summary>
	string NativeName { get; }

	/// <summary>
	/// Language code, generally following ISO standards (eg. Korean could be "ko")
	/// </summary>
	string LanguageCode { get; }
}
