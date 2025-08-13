namespace Roblox.Platform.AssetsCore;

public static class AssetIdentifierFactory
{
	public static IAssetIdentifier GetAssetIdentifier(long id)
	{
		return new AssetIdentifier(id);
	}
}
