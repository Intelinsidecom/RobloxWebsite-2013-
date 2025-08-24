using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Localization.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetSupportedLocaleByIdRequest
{
	[DataMember(Name = "id")]
	public int Id { get; set; }
}
