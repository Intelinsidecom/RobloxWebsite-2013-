namespace Roblox.Platform.Assets;

public class PlatformAssetPublishedVersionsResponse
{
	/// <summary>
	/// AssetVersion of an Asset
	/// </summary>
	public IAssetVersion AssetVersion { get; set; }

	/// <summary>
	/// Published status of the Asset Version
	/// </summary>
	public bool IsPublished { get; set; }
}
