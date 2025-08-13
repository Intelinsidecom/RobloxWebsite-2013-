using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class UploadImageRequest
{
	[DataMember(Name = "imageName")]
	public string ImageName { get; set; }

	[DataMember(Name = "imageContent")]
	public byte[] ImageContent { get; set; }
}
