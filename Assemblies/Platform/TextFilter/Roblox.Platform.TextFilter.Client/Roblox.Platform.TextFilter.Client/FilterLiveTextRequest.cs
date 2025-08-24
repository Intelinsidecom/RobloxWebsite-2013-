using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.TextFilter.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class FilterLiveTextRequest
{
	[DataMember(Name = "text")]
	public virtual string Text { get; set; }

	[DataMember(Name = "author")]
	public virtual IClientTextAuthor Author { get; set; }

	[DataMember(Name = "usageType")]
	public virtual TextFilterUsage UsageType { get; set; } = TextFilterUsage.Unknown;


	[DataMember(Name = "usage")]
	public virtual string TextUsage { get; set; }

	[DataMember(Name = "server")]
	public virtual string Server { get; set; }

	[DataMember(Name = "instanceId")]
	public virtual string InstanceIdentifier { get; set; }
}
