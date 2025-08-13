using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Privacy;

internal class AppChatPrivacySetting : UserPrivacySettingBase, IAppChatPrivacySetting, IUserPrivacySetting
{
	public AppChatPrivacySetting(IUser user, UserPrivacyLevelType privacyLevel)
		: base(UserPrivacySettingType.AppChatMessaging, user, privacyLevel)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
	}
}
