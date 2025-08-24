using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class ContentPackItemResult
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "type")]
	public ContentPackItemType Type { get; set; }

	[DataMember(Name = "value")]
	public string Value { get; set; }
}
