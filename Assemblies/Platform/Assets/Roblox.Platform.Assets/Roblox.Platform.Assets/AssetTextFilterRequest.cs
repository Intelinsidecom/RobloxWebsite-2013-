using Roblox.TextFilter;

namespace Roblox.Platform.Assets;

/// <summary>
/// Wrapper class for submitting Asset Name and Description to be set or changed.
/// </summary>
internal class AssetTextFilterRequest : IAssetTextFilterRequest
{
	public ITextAuthor TextAuthor { get; }

	public string Name { get; }

	public string Description { get; }

	public AssetType AssetType { get; }

	public AssetTextFilterRequest(ITextAuthor textAuthor, string name, string description, AssetType assetType)
	{
		TextAuthor = textAuthor;
		Name = name;
		Description = description;
		AssetType = assetType;
	}

	internal AssetTextFilterRequest(IAssetNameAndDescription assetNameAndDescription, AssetType assetType)
	{
		AssetType = assetType;
		TextAuthor = assetNameAndDescription.TextAuthor;
		Name = assetNameAndDescription.Name;
		Description = assetNameAndDescription.Description;
	}
}
