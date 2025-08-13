using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class LanguageFamily
{
	[DataMember(Name = "id")]
	public int Id { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "nativeName")]
	public string NativeName { get; set; }

	[DataMember(Name = "languageCode")]
	public string LanguageCode { get; set; }
}
