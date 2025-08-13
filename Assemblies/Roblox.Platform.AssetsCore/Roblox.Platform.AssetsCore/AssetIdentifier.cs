namespace Roblox.Platform.AssetsCore;

public class AssetIdentifier : IAssetIdentifier
{
	public long Id { get; }

	public AssetIdentifier(long id)
	{
		Id = id;
	}
}
