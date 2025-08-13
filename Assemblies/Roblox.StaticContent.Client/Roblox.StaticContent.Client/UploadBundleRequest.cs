using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class UploadBundleRequest
{
	[DataMember(Name = "componentName")]
	public string ComponentName { get; set; }

	[DataMember(Name = "contentType")]
	public StaticContentContentType ContentType { get; set; }

	[DataMember(Name = "bundleContents")]
	public string BundleContents { get; set; }
}
