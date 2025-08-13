using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.UserSetting;

/// <summary>
/// Factory for accessing a user's UserSettings.
/// </summary>
public interface IUserSettingsFactory
{
	/// <summary>
	/// Gets the UserSettings for the given user.
	/// </summary>
	/// <param name="user"></param>
	/// <returns><see cref="T:Roblox.Platform.UserSetting.IUserSettings" /></returns>
	IUserSettings GetUserSettings(IUserIdentifier user);
}
