using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class GetSupportedLocaleByLocaleCodeResponse
{
	[DataMember(Name = "supportedLocale")]
	public SupportedLocale SupportedLocale { get; set; }
}
