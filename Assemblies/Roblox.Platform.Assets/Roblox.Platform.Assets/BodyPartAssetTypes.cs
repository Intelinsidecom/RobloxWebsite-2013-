using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Roblox.Platform.Assets;

public static class BodyPartAssetTypes
{
	/// <summary>
	/// Traditional body parts, plus face and head.
	/// </summary>
	private static readonly ReadOnlyCollection<AssetType> _BodyPartAssetTypes = new ReadOnlyCollection<AssetType>(new AssetType[7]
	{
		AssetType.Torso,
		AssetType.RightArm,
		AssetType.LeftArm,
		AssetType.RightLeg,
		AssetType.LeftLeg,
		AssetType.Head,
		AssetType.Face
	});

	private static readonly ReadOnlyCollection<int> _BodyPartAssetTypeIds = new ReadOnlyCollection<int>(_BodyPartAssetTypes.Select((AssetType at) => at.ToId()).ToList());

	public static IList<AssetType> GetBodyPartAssetTypes => _BodyPartAssetTypes;

	public static IList<int> GetBodyPartAssetTypeIds => _BodyPartAssetTypeIds;
}
