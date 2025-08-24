using System.Runtime.Serialization;

namespace Roblox.Platform.Universes.Events;

/// <summary>
/// The event model published by the <see cref="T:Roblox.Platform.Universes.Events.IUniverseEventsObserver" /> when an universe is updated.
/// </summary>
[DataContract]
public class UniverseEntityEvent
{
	/// <summary>
	/// The universe's id
	/// </summary>
	[DataMember(Name = "universeId")]
	public long UniverseId { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Platform.Universes.Events.UniverseChangeType" /> as a string.
	/// </summary>
	[DataMember(Name = "changeType")]
	public string ChangeType { get; }

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.Platform.Universes.Events.UniverseEntityEvent" />
	/// </summary>
	/// <param name="universeId">The universe's id</param>
	/// <param name="changeType">The <see cref="T:Roblox.Platform.Universes.Events.UniverseChangeType" /></param>
	internal UniverseEntityEvent(long universeId, UniverseChangeType changeType)
	{
		UniverseId = universeId;
		ChangeType = changeType.ToString();
	}
}
