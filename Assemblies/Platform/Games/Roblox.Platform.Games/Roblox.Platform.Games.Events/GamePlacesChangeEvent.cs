using System.Runtime.Serialization;

namespace Roblox.Platform.Games.Events;

[DataContract]
public class GamePlacesChangeEvent
{
	[DataMember(Name = "universeId")]
	public long UniverseId { get; }

	/// <summary>
	/// The event's <see cref="T:Roblox.Platform.Games.Events.GamePlacesChangeType" />.
	/// </summary>
	[DataMember(Name = "changeType")]
	public GamePlacesChangeType ChangeType { get; }

	/// <summary>
	/// The id of the place involved.
	/// </summary>
	[DataMember(Name = "placeId")]
	public long PlaceId { get; }

	internal GamePlacesChangeEvent(long universeId, GamePlacesChangeType changeType, long placeId)
	{
		UniverseId = universeId;
		ChangeType = changeType;
		PlaceId = placeId;
	}
}
