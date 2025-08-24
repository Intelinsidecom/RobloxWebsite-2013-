using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetUriRequest
{
	[DataMember(Name = "Hash")]
	public string Hash { get; set; }

	[DataMember(Name = "IsRequestSecure")]
	public bool IsRequestSecure { get; set; }
}
