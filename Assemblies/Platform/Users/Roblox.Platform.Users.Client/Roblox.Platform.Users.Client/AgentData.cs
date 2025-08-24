using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
public class AgentData
{
	[DataMember(Name = "id")]
	public long Id { get; set; }

	[DataMember(Name = "type")]
	public AssociatedEntityType Type { get; set; }

	[DataMember(Name = "targetId")]
	public long TargetId { get; set; }
}
