using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

internal class GameChatPrivacySetting : IGameChatPrivacySetting, IUserPrivacySetting
{
	public UserPrivacyLevelType PrivacyLevel { get; set; }

	public UserPrivacySettingType SettingType { get; }

	public IUser User { get; }

	public GameChatPrivacySetting(IUser user, UserPrivacyLevelType privacyLevel)
	{
		User = user;
		SettingType = UserPrivacySettingType.GameChatMessaging;
		PrivacyLevel = privacyLevel;
	}
}
