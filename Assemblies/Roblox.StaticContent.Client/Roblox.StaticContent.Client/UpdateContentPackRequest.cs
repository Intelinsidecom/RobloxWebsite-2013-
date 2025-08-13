using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class UpdateContentPackRequest
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	[DataMember(Name = "validated")]
	public bool Validated { get; set; }
}
