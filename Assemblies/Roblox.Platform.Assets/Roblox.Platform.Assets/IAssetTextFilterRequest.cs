using Roblox.TextFilter;

namespace Roblox.Platform.Assets;

public interface IAssetTextFilterRequest
{
	string Description { get; }

	string Name { get; }

	ITextAuthor TextAuthor { get; }

	AssetType AssetType { get; }
}
