namespace Roblox.Platform.Avatar;

public enum AccessoryLimitModeEnum
{
	/// <summary>
	/// Avatars can wear 1 of each asset type, but they can wear 3 hats
	/// </summary>
	ThreeHats,
	/// <summary>
	/// Avatars can wear 1 of each asset type, but for accessories you can wear up to 10, with any combination.
	/// For example, you can wear 5 shoulder accessories and 3 hats and 2 face accessories
	/// </summary>
	TenTotalAccessories
}
