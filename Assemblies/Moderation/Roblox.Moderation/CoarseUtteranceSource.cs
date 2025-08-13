namespace Roblox.Moderation;

/// <summary>
/// A composite base class for legacy SCL UtteranceSources.
/// </summary>
/// <remarks>
/// This class exists to easily move the legacy SCL UtteranceSources (which were used in pure read-only
/// situations and scrubbing, i.e. writing, situations) into the split <see cref="T:Roblox.Moderation.IUtteranceSource" /> 
/// readers and the <see cref="T:Roblox.Moderation.IUtteranceScrubber" /> writer implementations.
///
/// In part these are "coarse" because the classes that they support have too much responsibility.
/// </remarks>
public abstract class CoarseUtteranceSource : CoarseTextScrub, IUtteranceSource
{
	/// <inheritdoc cref="P:Roblox.Moderation.IUtteranceSource.IsProse" />
	public abstract bool IsProse { get; }

	/// <inheritdoc cref="P:Roblox.Moderation.IUtteranceSource.SourceID" />
	public abstract long? SourceID { get; }

	/// <inheritdoc cref="P:Roblox.Moderation.IUtteranceSource.Type" />
	public abstract UtteranceSourceType Type { get; }
}
