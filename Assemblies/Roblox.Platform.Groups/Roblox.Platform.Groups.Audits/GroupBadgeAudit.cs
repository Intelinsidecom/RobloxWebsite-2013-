using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Roblox.Platform.Groups.Audits;

[DataContract]
public class GroupBadgeAudit
{
	[DataMember(Name = "badgeId")]
	public long BadgeId { get; set; }

	[DataMember(Name = "type")]
	[JsonConverter(typeof(StringEnumConverter))]
	public GroupBadgeAuditType? Type { get; set; }
}
