using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class MapDeviceReportedLocaleToLanguageFamilyRequest
{
	[DataMember(Name = "languageFamilyId")]
	public int LanguageFamilyId { get; set; }

	[DataMember(Name = "deviceReportedLocaleId")]
	public int DeviceReportedLocaleId { get; set; }
}
