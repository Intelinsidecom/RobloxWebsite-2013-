using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roblox.Platform.Assets;

public static class GearAssetTypes
{
	/// <summary>
	/// All gears
	/// </summary>
	private static readonly ReadOnlyCollection<AssetType> _GearAssetTypes = new ReadOnlyCollection<AssetType>(new AssetType[1] { AssetType.Gear });

	private static readonly ReadOnlyCollection<int> _GearAssetTypeIds = new ReadOnlyCollection<int>(_GearAssetTypes.Select((AssetType at) => at.ToId()).ToList());

	public static IList<AssetType> GetGearAssetTypes => _GearAssetTypes;

	public static IList<int> GetGearAssetTypeIds => _GearAssetTypeIds;
}
