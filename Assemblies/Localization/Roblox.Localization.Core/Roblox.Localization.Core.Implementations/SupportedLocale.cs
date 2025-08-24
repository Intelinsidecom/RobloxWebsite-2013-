namespace Roblox.Platform.Localization.Core.Implementations;

internal class SupportedLocale : ISupportedLocale, ISupportedLocaleIdentifier
{
	public int Id { get; set; }

	public SupportedLocaleEnum? Locale { get; set; }

	public string LocaleCode { get; set; }

	public string Name { get; set; }

	public string NativeName { get; set; }

	public ILanguageFamily Language { get; set; }
}
