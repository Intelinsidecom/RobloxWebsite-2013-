using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class FilterTextRequest
{
	[DataMember(Name = "text")]
	public string Text { get; set; }

	[DataMember(Name = "author")]
	public IClientTextAuthor Author { get; set; }

	[DataMember(Name = "usageType")]
	public virtual TextFilterUsage UsageType { get; set; } = TextFilterUsage.Unknown;


	[DataMember(Name = "usage")]
	public string TextUsage { get; set; }

	[DataMember(Name = "instanceId")]
	public string InstanceIdentifier { get; set; }

	[DataMember(Name = "ignoreVerticalFilter")]
	public bool IgnoreVerticalFilter { get; set; }
}
