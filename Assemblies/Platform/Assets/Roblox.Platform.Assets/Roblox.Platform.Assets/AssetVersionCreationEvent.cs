namespace Roblox.Platform.Assets;

public class AssetVersionCreationEvent
{
	/// <summary>
	/// The Id of the new <see cref="T:Roblox.Platform.Assets.IAssetVersion" />.
	/// </summary>
	public long AssetVersionId { get; set; }

	/// <summary>
	/// The locale code to be used instead for moderation review task.
	/// </summary>
	public string LocaleCodeOverride { get; set; }
}
