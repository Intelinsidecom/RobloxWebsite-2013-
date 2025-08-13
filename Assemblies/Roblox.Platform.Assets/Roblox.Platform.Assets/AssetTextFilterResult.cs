namespace Roblox.Platform.Assets;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Platform.Assets.IAssetTextFilterResult" />.
/// </summary>
internal class AssetTextFilterResult : IAssetTextFilterResult, INameAndDescription
{
	public string Name { get; }

	public string Description { get; }

	public AssetTextFilterResult(string name, string description)
	{
		Name = name;
		Description = description;
	}
}
