using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Files.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class AddFileRequest
{
	[DataMember(Name = "content")]
	public byte[] Content { get; set; }

	[DataMember(Name = "decompressionMethod")]
	public string DecompressionMethod { get; set; }

	[DataMember(Name = "contentType")]
	public string ContentType { get; set; }

	[DataMember(Name = "isCjvRequest")]
	public bool IsCjvRequest { get; set; }

	[DataMember(Name = "assetType")]
	public string AssetType { get; set; }
}
