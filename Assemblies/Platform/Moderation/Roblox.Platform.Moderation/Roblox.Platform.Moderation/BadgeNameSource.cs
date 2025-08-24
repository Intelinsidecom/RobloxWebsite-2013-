namespace Roblox.Moderation;

/// <summary>
/// Badge name utterance source.
/// </summary>
public class BadgeNameSource : BadgeSource
{
	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.IsProse" />
	public override bool IsProse { get; } = true;


	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.Type" />
	public override UtteranceSourceType Type { get; } = UtteranceSourceType.BadgeName;


	/// <summary>
	/// The constructor to create a badge name utterance source.
	/// </summary>
	/// <param name="badgeId">The badge identifier</param>
	public BadgeNameSource(long badgeId)
		: base(badgeId)
	{
	}
}
