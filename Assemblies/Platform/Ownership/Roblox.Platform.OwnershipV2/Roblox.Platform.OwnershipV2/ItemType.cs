namespace Roblox.Platform.OwnershipV2;

/// <summary>
/// The types of items that can be owned
/// This is actually only related to OV2
/// </summary>
public enum ItemType
{
	/// <summary>
	/// <see cref="!:Assets.IGamePass" />
	/// </summary>
	GamePass = 1,
	AssetInstance,
	/// <summary>
	/// See Roblox.Platform.Bundles
	/// </summary>
	BundleInstance
}
