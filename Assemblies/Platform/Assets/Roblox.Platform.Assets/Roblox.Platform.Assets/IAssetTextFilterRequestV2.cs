using Roblox.TextFilter.Client;

namespace Roblox.Platform.Assets;

public interface IAssetTextFilterRequestV2
{
	string Description { get; }

	string Name { get; }

	IClientTextAuthor ClientTextAuthor { get; }

	AssetType AssetType { get; }
}
