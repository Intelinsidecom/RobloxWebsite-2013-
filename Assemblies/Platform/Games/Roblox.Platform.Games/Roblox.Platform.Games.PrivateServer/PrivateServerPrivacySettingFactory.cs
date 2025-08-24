using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Privacy;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerPrivacySettingFactory : IPrivateServerPrivacySettingFactory
{
	private IUserPrivacyAccessor _UserPrivacyAccessor { get; set; }

	public PrivateServerPrivacySettingFactory(IUserPrivacyAccessor userPrivacyAccessor)
	{
		if (userPrivacyAccessor == null)
		{
			throw new ArgumentNullException("userPrivacyAccessor");
		}
		_UserPrivacyAccessor = userPrivacyAccessor;
	}

	public IPrivateServerPrivacySetting GetOrCreate(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		IUserPrivacySetting setting = _UserPrivacyAccessor.GetOrCreatePrivacyLevelForUserPrivacySetting(UserPrivacySettingType.SendPrivateServerInvite, user, GetDefault());
		return new PrivateServerPrivacySetting(user, setting.PrivacyLevel, _UserPrivacyAccessor, GetDefault());
	}

	private UserPrivacyLevelType GetDefault()
	{
		return UserPrivacyLevelType.Friends;
	}
}
