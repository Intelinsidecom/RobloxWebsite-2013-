using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class MapDeviceReportedLocaleToSupportedLocaleRequest
{
	[DataMember(Name = "supportedLocaleId")]
	public int SupportedLocaleId { get; set; }

	[DataMember(Name = "deviceReportedLocaleId")]
	public int DeviceReportedLocaleId { get; set; }
}
