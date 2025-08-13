using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// Controls retrieving, creating and updating the inventory privacy level settings, including validation that the user
/// has selected an appropriate setting per their age bracket.
/// </summary>
public interface IDisplayInventoryPrivacyAccessor
{
	/// <summary>
	/// <c>true</c> if hiding players inventory feature is currently enabled.
	/// </summary>
	bool IsInventoryHidingFeatureEnabled { get; }

	/// <summary>
	/// Gets the privacy level stored in the system for displaying inventory. If the user has no privacy setting yet, it will create one with the default value for the user.
	///
	/// If the privacy level overrides are active, will return the override value instead of the user's individual setting, regardless of
	/// whether the override value is more or less permissive of the stored value.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="tradePrivacy">The <see cref="T:Roblox.Platform.Privacy.UserPrivacyLevelType" />. If initial inventory privacy setting conflicts with trade privacy, it should match the trade setting.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Privacy.IDisplayInventoryPrivacySetting" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the <see cref="T:Roblox.Platform.Membership.IUser" /> is null.</exception>
	IDisplayInventoryPrivacySetting GetOrCreateDisplayInventoryPrivacyLevel(IUser user, UserPrivacyLevelType? tradePrivacy);

	/// <summary>
	/// Validates and stores a <see cref="T:Roblox.Platform.Membership.IUser" />'s inventory privacy level. 
	/// If the chosen privacy level is not valid for the user <see cref="T:Roblox.Platform.Privacy.IDisplayInventoryPrivacySetting" />, throws <see cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException" />.
	/// If the display inventory overrides are active, it will not update at all.
	/// </summary>
	/// <param name="newSetting"><see cref="T:Roblox.Platform.Privacy.IDisplayInventoryPrivacySetting" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="newSetting" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if <paramref name="newSetting.User.User" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException">Thrown if the chosen <see cref="T:Roblox.Platform.Privacy.UserPrivacyLevelType" /> is invalid for the <see cref="T:Roblox.Platform.Membership.IUser" />.</exception>
	void SetDisplayInventoryPrivacyLevel(IDisplayInventoryPrivacySetting newSetting);
}
