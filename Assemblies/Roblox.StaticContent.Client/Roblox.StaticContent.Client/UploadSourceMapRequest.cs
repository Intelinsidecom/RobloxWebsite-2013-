using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class UploadSourceMapRequest
{
	[DataMember(Name = "sourceMapName")]
	public string SourceMapName { get; set; }

	[DataMember(Name = "sourceMapContent")]
	public string SourceMapContent { get; set; }
}
