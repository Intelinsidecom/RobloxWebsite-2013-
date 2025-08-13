using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Roblox.Serialization.Json;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class HistoricalUsername
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "name")]
	public string Name { get; set; }

	[DataMember(Name = "userId")]
	public long UserId { get; set; }

	[DataMember(Name = "created")]
	[JsonConverter(typeof(KindAwareDateTimeConverter))]
	public DateTime Created { get; set; }
}
