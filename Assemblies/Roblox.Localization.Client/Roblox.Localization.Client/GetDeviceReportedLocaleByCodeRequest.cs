using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetDeviceReportedLocaleByCodeRequest
{
	[DataMember(Name = "deviceReportedLocaleCode")]
	public string DeviceReportedLocaleCode { get; set; }
}
