using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Roblox.DataV2.Core;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetContentPacksRequest
{
	[DataMember(Name = "component")]
	public string Component { get; set; }

	[DataMember(Name = "enabled")]
	public bool? Enabled { get; set; }

	[DataMember(Name = "validated")]
	public bool? Validated { get; set; }

	[DataMember(Name = "sortOrder")]
	public SortOrder SortOrder { get; set; }

	[DataMember(Name = "exclusiveStartContentPackId")]
	public long? ExclusiveStartContentPackId { get; set; }

	[DataMember(Name = "count")]
	public int Count { get; set; }
}
