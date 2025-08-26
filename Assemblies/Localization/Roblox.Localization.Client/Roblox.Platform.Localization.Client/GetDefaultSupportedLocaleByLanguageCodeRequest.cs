using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Localization.Client {
    [DataContract]

[ExcludeFromCodeCoverage]
internal class GetDefaultSupportedLocaleByLanguageCodeRequest
{
	[DataMember(Name = "languageCode")]
	public string LanguageCode { get; set; }
}


}
