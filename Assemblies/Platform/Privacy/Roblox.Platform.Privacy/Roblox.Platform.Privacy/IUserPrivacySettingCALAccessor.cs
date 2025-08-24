using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// Cache access layer object for <see cref="T:Roblox.Platform.Privacy.IUserPrivacyAccessor" />. Ideally should use this instead of IUserPrivacyAccessor directly.
/// </summary>
internal interface IUserPrivacySettingCALAccessor
{
	/// <summary>
	/// Gets or creates a privacy setting for the given <paramref name="user" /> and system (as denoted by <paramref name="userPrivacySettingType" />).
	/// If the setting is created, uses the provided <paramref name="defaultPrivacyLevel" />.
	/// </summary>
	/// <param name="userPrivacySettingType">Which system this privacy setting is for.</param>
	/// <param name="user"></param>
	/// <param name="defaultPrivacyLevel">If the setting does not exist and needs to be created, uses this as the default value.</param>
	/// <returns><see cref="T:Roblox.Platform.Privacy.IUserPrivacySetting" /></returns>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if the user's id is the default int</exception>
	IUserPrivacySetting GetOrCreate(UserPrivacySettingType userPrivacySettingType, IUser user, UserPrivacyLevelType defaultPrivacyLevel);

	/// <summary>
	/// Saves the the new privacy setting to both the cache and the database.
	/// </summary>
	/// <param name="privacyLevel">Setting being updated</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="privacyLevel" /> is null</exception>
	/// <exception cref="T:System.ArgumentException">Thrown if the user's id is the default int</exception>
	void SaveUserPrivacySetting(IUserPrivacySetting privacyLevel);
}
