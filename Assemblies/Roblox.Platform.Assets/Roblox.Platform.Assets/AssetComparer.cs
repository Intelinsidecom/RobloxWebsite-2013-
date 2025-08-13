using System.Collections.Generic;

namespace Roblox.Platform.Assets;

/// <summary>
/// Comparer class to be used in linq query to check if two assets are
/// equal i.e. they have same id.
/// </summary>
public class AssetComparer : IEqualityComparer<IAsset>
{
	public bool Equals(IAsset x, IAsset y)
	{
		return x.Id == y.Id;
	}

	public int GetHashCode(IAsset obj)
	{
		return obj.Id.GetHashCode();
	}
}
