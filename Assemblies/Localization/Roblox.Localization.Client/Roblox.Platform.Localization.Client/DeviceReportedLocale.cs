using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class DeviceReportedLocale
{
	[DataMember(Name = "id")]
	public int Id { get; set; }

	[DataMember(Name = "standardizedLocale")]
	public string StandardizedLocale { get; set; }

	[DataMember(Name = "languageFamily")]
	public LanguageFamily LanguageFamily { get; set; }

	[DataMember(Name = "supportedLocale")]
	public SupportedLocale SupportedLocale { get; set; }
}
