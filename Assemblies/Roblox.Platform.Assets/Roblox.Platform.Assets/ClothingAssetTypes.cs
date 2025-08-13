using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roblox.Platform.Assets;

public static class ClothingAssetTypes
{
	/// <summary>
	/// Pants, TShirts, Shirts.  Note that in some places hats are considered clothing; but here and 
	/// going forward they are accessories.
	/// </summary>
	private static readonly ReadOnlyCollection<AssetType> _ClothingAssetTypes = new ReadOnlyCollection<AssetType>(new AssetType[3]
	{
		AssetType.Pants,
		AssetType.Shirt,
		AssetType.TShirt
	});

	private static readonly ReadOnlyCollection<int> _ClothingAssetTypeIds = new ReadOnlyCollection<int>(_ClothingAssetTypes.Select((AssetType at) => at.ToId()).ToList());

	public static IList<AssetType> GetClothingAssetTypes => _ClothingAssetTypes;

	public static IList<int> GetClothingAssetTypeIds => _ClothingAssetTypeIds;
}
