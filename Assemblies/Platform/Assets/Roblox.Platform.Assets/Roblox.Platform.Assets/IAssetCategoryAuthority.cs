namespace Roblox.Platform.Assets;

/// <summary>
/// Interface of authority to handle asset category reads.
/// </summary>
public interface IAssetCategoryAuthority
{
	/// <summary>
	/// Reads value of flags for asset categories.
	/// </summary>
	/// <param name="asset">An instance of IAsset</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when <paramref name="asset" /> is <see langword="null" /></exception>
	/// <returns>A value of flags</returns>
	ulong GetCategories(IAsset asset);
}
