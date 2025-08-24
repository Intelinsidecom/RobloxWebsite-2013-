namespace Roblox.Moderation;

/// <summary>
/// The <see cref="T:Roblox.Moderation.IUtteranceSource" /> for SCL.AssetVersion without the need to add a dependency to SCL.
/// </summary>
/// <inheritdoc cref="T:Roblox.Moderation.CoarseUtteranceSource" />
public class AssetVersionSource : CoarseUtteranceSource
{
	public override bool IsProse => false;

	public override long? SourceID { get; }

	public override UtteranceSourceType Type => UtteranceSourceType.AssetVersion;

	public AssetVersionSource(long assetVersionId)
	{
		SourceID = assetVersionId;
	}
}
