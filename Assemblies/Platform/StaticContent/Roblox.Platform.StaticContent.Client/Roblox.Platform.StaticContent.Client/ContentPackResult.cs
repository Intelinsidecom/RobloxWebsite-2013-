using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Roblox.Serialization.Json;

namespace Roblox.StaticContent.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class ContentPackResult
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "component")]
	public string Component { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "items")]
	public ContentPackItemResult[] Items { get; set; }

	[DataMember(Name = "componentDependencies")]
	public string[] ComponentDependencies { get; set; }

	[DataMember(Name = "enabled")]
	public bool Enabled { get; set; }

	[DataMember(Name = "validated")]
	public bool Validated { get; set; }

	[DataMember(Name = "created")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime Created { get; set; }

	[DataMember(Name = "updated")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime Updated { get; set; }
}
