using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// Controls retrieving and updating the in-game and app (website, mobile apps) chat privacy level settings, including validation that the user
/// has selected an appropriate setting per their age bracket.
/// </summary>
public interface IChatPrivacySettingAccessor
{
	/// <summary>
	/// Sends a real time notification. See Roblox.Platform.Chat.ChatPrivacySettingsChangeHandler
	/// </summary>
	event Action<IUser, bool> OnAppChatEnablementChanged;

	/// <summary>
	/// Gets the privacy level stored in the system for in-App chat. If the user has no privacy setting yet, it will create one with the default value for the user.
	///
	/// If the privacy level overrides are active, will return the override value instead of the user's individual setting, regardless of
	/// whether the override value is more or less permissive of the stored value.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null - guests cannot access in-App chat</exception>
	IAppChatPrivacySetting GetOrCreateAppChatPrivacyLevel(IUser user);

	/// <summary>
	/// Validates and stores a user's in-App chat privacy level. If the chosen privacy level is not valid for the user, throws an exception. If the chat overrides are active,
	/// it will not update at all.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="newSetting" /> or the IUser property of newSetting is null</exception>
	/// <exception cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException">Thrown if the chosen privacy level is invalid for the user</exception>
	void SetAppChatPrivacyLevel(IAppChatPrivacySetting newSetting);

	/// <summary>
	/// Gets the privacy level stored in the system for in-Game chat. If the user has no privacy setting yet, it will create one with the default value for the user.
	///
	/// If the privacy level overrides are active, will return the override value instead of the user's individual setting, regardless of
	/// whether the override value is more or less permissive of the stored value.
	/// </summary>
	IGameChatPrivacySetting GetOrCreateGameChatPrivacyLevel(IUser user);

	/// <summary>
	/// Validates and stores a user's in-Game chat privacy level. If the chosen privacy level is not valid for the user, throws an exception. If the chat overrides are active,
	/// it will not update at all.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="newSetting" /> or the IUser property of newSetting is null</exception>
	/// <exception cref="T:Roblox.Platform.Permissions.Core.InvalidPermissionTypeException">Thrown if the chosen privacy level is invalid</exception>
	void SetGameChatPrivacyLevel(IGameChatPrivacySetting userPrivacyLevelType);

	/// <summary>
	/// Checks value of the user's saved setting and resets to the default value if the existing value is invalid for the user
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null</exception>
	void SanitizeAppChatSetting(IUser user);

	/// <summary>
	/// Checks value of the user's saved setting and resets to the default value if the existing value is invalid for the user
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="user" /> is null</exception>
	void SanitizeGameChatSetting(IUser user);
}
