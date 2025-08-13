using Roblox.TextFilter.Client;

namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper class for submitting Asset Name and Description to be set or changed.
/// </summary>
internal class AssetTextFilterRequestV2 : IAssetTextFilterRequestV2
{
	public IClientTextAuthor ClientTextAuthor { get; }

	public string Name { get; }

	public string Description { get; }

	public AssetType AssetType { get; }

	public AssetTextFilterRequestV2(IClientTextAuthor clientTextAuthor, string name, string description, AssetType assetType)
	{
		ClientTextAuthor = clientTextAuthor;
		Name = name;
		Description = description;
		AssetType = assetType;
	}

	internal AssetTextFilterRequestV2(IAssetNameAndDescription assetNameAndDescription, AssetType assetType)
	{
		AssetType = assetType;
		ClientTextAuthor = assetNameAndDescription.ClientTextAuthor;
		Name = assetNameAndDescription.Name;
		Description = assetNameAndDescription.Description;
	}
}
