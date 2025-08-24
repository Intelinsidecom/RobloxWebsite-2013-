using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

/// <summary>
/// NOTE: When IGameChatPrivacySetting and IAppChatPrivacySetting are updated to contain more info than IUserPrivacySetting, they will need
/// their own implementations and this class will no longer implement those interfaces
///
/// TODO: Make internal once all external consumers of IUserPrivacyAccessor have been properly refactored
/// </summary>
public class UserPrivacySettingBase : IUserPrivacySetting, IGameChatPrivacySetting, IAppChatPrivacySetting
{
	public UserPrivacyLevelType PrivacyLevel { get; set; }

	public UserPrivacySettingType SettingType { get; protected set; }

	public IUser User { get; protected set; }

	public UserPrivacySettingBase(UserPrivacySettingType settingType, IUser user, UserPrivacyLevelType privacyLevel)
	{
		if (user == null)
		{
			throw new ArgumentNullException("Cannot instantiate privacy setting for null user!");
		}
		PrivacyLevel = privacyLevel;
		SettingType = settingType;
		User = user;
	}
}
