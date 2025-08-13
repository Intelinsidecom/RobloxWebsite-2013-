using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// Controls retrieving, creating and updating the phone discovery privacy level settings, including validation that the user
/// has selected an appropriate setting per their age bracket.
/// </summary>
public interface IPhoneDiscoveryPrivacyAccessor
{
	/// <summary>
	/// Gets the privacy level stored in the system for phone discovery. If the user has no privacy setting yet, it will create one with the default value for the user.
	///
	/// If the privacy level overrides are active, will return the override value instead of the user's individual setting, regardless of
	/// whether the override value is more or less permissive of the stored value.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <returns>The <see cref="T:Roblox.Platform.Privacy.IPhoneDiscoveryPrivacySetting" />.</returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if the <see cref="T:Roblox.Platform.Membership.IUser" /> is null.</exception>
	IPhoneDiscoveryPrivacySetting GetOrCreatePhoneDiscoveryPrivacyLevel(IUser user);

	/// <summary>
	/// Validates and stores a <see cref="T:Roblox.Platform.Membership.IUser" />'s phone discovery privacy level. 
	/// If the chosen privacy level is not valid for the user <see cref="T:Roblox.Platform.Privacy.IPhoneDiscoveryPrivacySetting" />, throws <see cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException" />.
	/// If the phone discovery overrides are active, it will not update at all.
	/// </summary>
	/// <param name="newSetting"><see cref="T:Roblox.Platform.Privacy.IPhoneDiscoveryPrivacySetting" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="newSetting" /> is null.</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if <paramref name="newSetting.User.User" /> is null.</exception>
	/// <exception cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException">Thrown if the chosen <see cref="T:Roblox.Platform.Privacy.UserPrivacyLevelType" /> is invalid for the <see cref="T:Roblox.Platform.Membership.IUser" />.</exception>
	void SetPhoneDiscoveryPrivacyLevel(IPhoneDiscoveryPrivacySetting newSetting);
}
