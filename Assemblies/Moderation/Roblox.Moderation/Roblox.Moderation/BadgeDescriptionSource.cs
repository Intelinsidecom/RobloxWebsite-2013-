namespace Roblox.Moderation;

/// <summary>
/// Badge description utterance source.
/// </summary>
public class BadgeDescriptionSource : BadgeSource
{
	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.IsProse" />
	public override bool IsProse { get; } = true;


	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.Type" />
	public override UtteranceSourceType Type { get; } = UtteranceSourceType.BadgeDescription;


	/// <summary>
	/// The constructor to create a badge description utterance source.
	/// </summary>
	/// <param name="badgeId">The badge identifier</param>
	public BadgeDescriptionSource(long badgeId)
		: base(badgeId)
	{
	}
}
