using System.Diagnostics.CodeAnalysis;
using System.Runtime.Serialization;

namespace Roblox.Users.Client;

[DataContract]
[ExcludeFromCodeCoverage]
internal class GetAgentIdByTypeAndTargetIdRequest
{
	[DataMember(Name = "type")]
	public AssociatedEntityType Type { get; set; }

	[DataMember(Name = "targetId")]
	public long TargetId { get; set; }
}
