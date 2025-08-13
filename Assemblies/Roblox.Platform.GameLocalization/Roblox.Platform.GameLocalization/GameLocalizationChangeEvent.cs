using System.Runtime.Serialization;
using Roblox.Platform.GameLocalization.Events;

namespace Roblox.Platform.GameLocalization;

[DataContract]
public class GameLocalizationChangeEvent
{
	[DataMember(Name = "gameId")]
	public long GameId { get; }

	[DataMember(Name = "changeType")]
	public string ChangeType { get; }

	internal GameLocalizationChangeEvent(long gameId, GameLocalizationChangeType changeType)
	{
		GameId = gameId;
		ChangeType = changeType.ToString();
	}
}
