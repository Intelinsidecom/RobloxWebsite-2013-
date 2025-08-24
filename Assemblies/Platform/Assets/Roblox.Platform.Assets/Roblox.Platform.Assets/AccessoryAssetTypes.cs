using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roblox.Platform.Assets;

public static class AccessoryAssetTypes
{
	/// <summary>
	/// Hat are a type of accessory, but also existed before accessories as a concept, so there are lots of switches like "enableAccessories" which enable them all except hats, which are enabled already.
	/// </summary>
	private static readonly ReadOnlyCollection<AssetType> _AccessoryAssetTypes = new ReadOnlyCollection<AssetType>(new AssetType[8]
	{
		AssetType.Hat,
		AssetType.HairAccessory,
		AssetType.FaceAccessory,
		AssetType.NeckAccessory,
		AssetType.ShoulderAccessory,
		AssetType.FrontAccessory,
		AssetType.BackAccessory,
		AssetType.WaistAccessory
	});

	private static readonly ReadOnlyCollection<int> _AccessoryAssetTypeIds = new ReadOnlyCollection<int>(_AccessoryAssetTypes.Select((AssetType at) => at.ToId()).ToList());

	public static IList<AssetType> GetAccessoryAssetTypes => _AccessoryAssetTypes;

	public static IList<int> GetAccessoryAssetTypeIds => _AccessoryAssetTypeIds;
}
