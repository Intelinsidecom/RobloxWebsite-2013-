using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class UploadSourceMapResult
{
	[DataMember(Name = "result")]
	public StaticContentResult Result { get; set; }
}
