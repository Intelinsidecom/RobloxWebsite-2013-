namespace Roblox.Moderation;

/// <summary>
/// This defines an utterance source interface. It is a reading interface.
/// See <see cref="T:Roblox.Moderation.IUtteranceScrubber" /> for the write interface.
///
/// <see cref="T:Roblox.Moderation.IUtteranceSourceFactory" /> is used to instantiate IUtteranceSource.
/// </summary>
public interface IUtteranceSource
{
	/// <summary>
	/// Is the moderatable source made up of words?
	/// </summary>
	bool IsProse { get; }

	/// <summary>
	/// The nullable target ID of the source.
	/// </summary>
	long? SourceID { get; }

	/// <summary>
	/// The <see cref="T:Roblox.Moderation.UtteranceSourceType" /> (an entity DAL) representing
	/// the type of source.
	/// </summary>
	UtteranceSourceType Type { get; }
}
