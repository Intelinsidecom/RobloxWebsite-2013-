using System.Runtime.Serialization;

namespace Roblox.Platform.UniverseSettings.Events;

[DataContract]
public class UniverseSettingsEvent
{
	[DataMember(Name = "universeId")]
	public long UniverseId { get; }

	internal UniverseSettingsEvent(long universeId)
	{
		UniverseId = universeId;
	}
}
