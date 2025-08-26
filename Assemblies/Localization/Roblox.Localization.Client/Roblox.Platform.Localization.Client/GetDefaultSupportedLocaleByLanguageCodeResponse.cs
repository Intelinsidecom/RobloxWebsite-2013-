using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
namespace Roblox.Platform.Localization.Client {
    [DataContract]

[ExcludeFromCodeCoverage]
public class GetDefaultSupportedLocaleByLanguageCodeResponse
{
	[DataMember(Name = "supportedLocale")]
	public SupportedLocale SupportedLocale { get; set; }
}


}
