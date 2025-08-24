using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetDeviceReportedLocaleByIdRequest
{
	[DataMember(Name = "id")]
	public int Id { get; set; }
}
