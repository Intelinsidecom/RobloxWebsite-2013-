using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class SupportedLocale
{
	[DataMember(Name = "id")]
	public int Id { get; set; }

	[DataMember(Name = "locale")]
	public SupportedLocaleEnum? Locale { get; set; }

	[DataMember(Name = "localeCode")]
	public string LocaleCode { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "nativeName")]
	public string NativeName { get; set; }

	[DataMember(Name = "language")]
	public LanguageFamily Language { get; set; }
}
