using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class UploadBundleResult
{
	[DataMember(Name = "contentHash")]
	public string ContentHash { get; set; }

	[DataMember(Name = "result")]
	public StaticContentResult Result { get; set; }
}
