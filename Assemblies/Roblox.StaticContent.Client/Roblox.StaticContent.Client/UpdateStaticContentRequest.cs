using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class UpdateStaticContentRequest
{
	[DataMember(Name = "contentHash")]
	public string ContentHash { get; set; }

	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	[DataMember(Name = "validated")]
	public bool Validated { get; set; }
}
