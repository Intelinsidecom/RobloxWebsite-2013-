using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetSupportedLocalesByParentLanguageRequest
{
	[DataMember(Name = "languageCode")]
	public string LanguageCode { get; set; }
}
