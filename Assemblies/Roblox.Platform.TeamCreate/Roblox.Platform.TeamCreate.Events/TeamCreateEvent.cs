using System.Runtime.Serialization;

namespace Roblox.Platform.TeamCreate.Events;

[DataContract]
public class TeamCreateEvent
{
	[DataMember(Name = "universeId")]
	public long UniverseId { get; }

	[DataMember(Name = "userId")]
	public long? UserId { get; }

	[DataMember(Name = "changeType")]
	public string ChangeType { get; }

	internal TeamCreateEvent(long universeId, TeamCreateChangeType teamCreateChangeType, long? userId)
	{
		UniverseId = universeId;
		UserId = userId;
		ChangeType = teamCreateChangeType.ToString();
	}
}
