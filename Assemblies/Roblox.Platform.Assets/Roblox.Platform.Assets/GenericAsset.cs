using System;

namespace Roblox.Platform.Assets;

internal class GenericAsset : Asset
{
	internal GenericAsset(AssetDomainFactories domainFactories, IAsset asset)
		: base(domainFactories, asset)
	{
	}

	internal GenericAsset(AssetDomainFactories domainFactories, long id, int typeId, string name, string description, CreatorType creatorType, long creatorTargetId, ulong assetGenres, bool? archived, DateTime created, DateTime updated)
		: base(domainFactories, id, typeId, name, description, creatorType, creatorTargetId, assetGenres, archived, created, updated)
	{
	}
}
