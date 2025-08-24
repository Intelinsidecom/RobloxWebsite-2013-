using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetFileContentLocationRequest
{
	[DataMember(Name = "Hash")]
	public string Hash { get; set; }
}
