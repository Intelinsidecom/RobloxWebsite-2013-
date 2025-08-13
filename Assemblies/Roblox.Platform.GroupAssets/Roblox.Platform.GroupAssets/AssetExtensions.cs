using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Groups;

namespace Roblox.Platform.GroupAssets;

public static class AssetExtensions
{
	public static long GetCreatorAgentId(this IAsset asset, IGroupFactory factory)
	{
		asset.VerifyIsNotNull();
		if (asset.CreatorType == Roblox.Platform.Assets.CreatorType.Group)
		{
			return (factory.GetById(asset.CreatorTargetId) ?? throw new PlatformArgumentException("Creator type is group, but creator target id is invalid group id.")).AgentId;
		}
		return asset.CreatorTargetId;
	}
}
