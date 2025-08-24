using System;
using Roblox.Platform.AssetsCore;

namespace Roblox.Platform.Assets;

internal class Lua : Asset, ILua, IAsset, IAssetIdentifier
{
	internal Lua(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
		if (asset.TypeId != Roblox.AssetType.LuaID)
		{
			throw new ArgumentException("Asset " + asset.Id + " is not of AssetType Lua.");
		}
	}
}
