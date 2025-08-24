using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class UploadImageResult
{
	[DataMember(Name = "result")]
	public StaticContentResult Result { get; set; }
}
