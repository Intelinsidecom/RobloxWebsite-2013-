namespace Roblox.Platform.Localization.Core;

public interface ISupportedLocale : ISupportedLocaleIdentifier
{
	/// <summary>
	/// <see cref="T:Roblox.Platform.Localization.Core.SupportedLocaleEnum" />
	/// It is possible to have locale code which is not present in enum.
	/// </summary>
	SupportedLocaleEnum? Locale { get; }

	/// <summary>
	/// Locale code.
	/// </summary>
	string LocaleCode { get; }

	/// <summary>
	/// Name of locale like English(US)
	/// </summary>
	string Name { get; }

	/// <summary>
	/// Name in native language English(US)
	/// </summary>
	string NativeName { get; }

	/// <summary>
	/// Language associated with supported locale
	/// </summary>
	ILanguageFamily Language { get; }
}
