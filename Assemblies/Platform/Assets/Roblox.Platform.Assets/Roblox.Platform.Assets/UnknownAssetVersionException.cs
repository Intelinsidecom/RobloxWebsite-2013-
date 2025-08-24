using Roblox.Platform.Core;

namespace Roblox.Platform.Assets;

public class UnknownAssetVersionException : PlatformException
{
	public UnknownAssetVersionException()
		: base("Unknown AssetVersion")
	{
	}

	public UnknownAssetVersionException(long assetVersionId)
		: base("Unknown AssetVersion " + assetVersionId)
	{
	}

	public UnknownAssetVersionException(long assetId, int versionNumber)
		: base("Unknown AssetVersion - AssetId " + assetId + ", VersionNumber " + versionNumber)
	{
	}
}
