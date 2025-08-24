namespace Roblox.Moderation;

/// <summary>
/// Game Update description utterance source.
/// </summary>
public class GameUpdateBodySource : CoarseUtteranceSource
{
	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.SourceID" />
	public override long? SourceID { get; }

	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.IsProse" />
	public override bool IsProse { get; } = true;


	/// <inheritdoc cref="P:Roblox.Moderation.CoarseUtteranceSource.Type" />
	public override UtteranceSourceType Type { get; } = UtteranceSourceType.GameUpdateBody;


	/// <summary>
	/// The constructor to create a GameUpdate description utterance source.
	/// </summary>
	/// <param name="gameUpdateId">The GameUpdate identifier</param>
	public GameUpdateBodySource(long gameUpdateId)
	{
		SourceID = gameUpdateId;
	}
}
