using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class GetDeviceReportedLocaleByCodeResponse
{
	[DataMember(Name = "deviceReportedLocale")]
	public DeviceReportedLocale DeviceReportedLocale { get; set; }
}
