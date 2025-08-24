namespace Roblox.Platform.Assets;

public interface IBadgeTypeFactory
{
	/// <summary>
	/// Get badge type id by name
	/// </summary>
	/// <param name="name"></param>
	/// <returns>Badge type id</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">if name is null</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">if badge type cannot be found</exception>
	BadgeType GetBadgeTypeByName(string name);

	/// <summary>
	/// Get badge type id by platform AssetBadgeType
	/// </summary>
	/// <param name="assetBadgeType">Platform badge type</param>
	/// <returns>Badge type id of SCL badge type</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">if platform badge type is cannot be found in the enum</exception>
	int GetBadgeTypeIdByBadgeType(BadgeType assetBadgeType);

	/// <summary>
	/// Get platform badge type by SCL badge type id
	/// </summary>
	/// <param name="badgeTypeId"></param>
	/// <returns>Asset badge type</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">if badge type id is invalid</exception>
	BadgeType GetBadgeTypeByBadgeTypeId(int badgeTypeId);
}
