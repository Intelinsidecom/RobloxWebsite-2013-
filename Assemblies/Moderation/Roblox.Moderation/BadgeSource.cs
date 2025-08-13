namespace Roblox.Moderation;

/// <summary>
/// Abstract class for Badge utterance sources
/// </summary>
public abstract class BadgeSource : CoarseUtteranceSource
{
	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.SourceID" />
	public override long? SourceID { get; }

	protected BadgeSource(long badgeId)
	{
		SourceID = badgeId;
	}
}
