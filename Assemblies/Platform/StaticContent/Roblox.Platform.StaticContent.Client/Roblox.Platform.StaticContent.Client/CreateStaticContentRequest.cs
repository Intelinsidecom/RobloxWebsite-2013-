using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class CreateStaticContentRequest
{
	[DataMember(Name = "component")]
	public string Component { get; set; }

	[DataMember(Name = "contentType")]
	public string ContentType { get; set; }

	[DataMember(Name = "contentHash")]
	public string ContentHash { get; set; }
}
