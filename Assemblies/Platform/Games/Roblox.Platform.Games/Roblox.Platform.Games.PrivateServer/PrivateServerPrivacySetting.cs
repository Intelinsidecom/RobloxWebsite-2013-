using System;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Privacy;

namespace Roblox.Platform.Games.PrivateServer;

internal class PrivateServerPrivacySetting : IPrivateServerPrivacySetting
{
	private IUser _User { get; set; }

	internal IUserPrivacyAccessor _UserPrivacyAccessor { get; set; }

	private UserPrivacyLevelType _DefaultPrivacyLevel { get; set; }

	public UserPrivacyLevelType PrivacyLevel { get; }

	internal PrivateServerPrivacySetting(IUser user, UserPrivacyLevelType privacyLevel, IUserPrivacyAccessor userPrivacyAccessor, UserPrivacyLevelType defaultPrivacyLevel)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (userPrivacyAccessor == null)
		{
			throw new ArgumentNullException("userPrivacyAccessor");
		}
		_User = user;
		PrivacyLevel = privacyLevel;
		_UserPrivacyAccessor = userPrivacyAccessor;
		_DefaultPrivacyLevel = defaultPrivacyLevel;
	}

	public virtual void UpdatePrivacyLevel(UserPrivacyLevelType newPrivacyLevel)
	{
		if (!IsValid(newPrivacyLevel))
		{
			throw new InvalidPermissionTypeException("Invalid privacy level for Private Server Invite");
		}
		IUserPrivacySetting setting = _UserPrivacyAccessor.GetOrCreatePrivacyLevelForUserPrivacySetting(UserPrivacySettingType.SendPrivateServerInvite, _User, _DefaultPrivacyLevel);
		if (setting.PrivacyLevel != newPrivacyLevel)
		{
			setting.PrivacyLevel = newPrivacyLevel;
			_UserPrivacyAccessor.SetPrivacyLevelForUserPrivacySetting(setting);
		}
	}

	internal virtual bool IsValid(UserPrivacyLevelType privacyLevel)
	{
		if (_User.IsUnder13())
		{
			if ((uint)(privacyLevel - 1) <= 1u)
			{
				return true;
			}
			return false;
		}
		if ((uint)(privacyLevel - 1) <= 3u || privacyLevel == UserPrivacyLevelType.AllUsers)
		{
			return true;
		}
		return false;
	}

	public void Sanitize()
	{
		if (!IsValid(PrivacyLevel))
		{
			UpdatePrivacyLevel(_DefaultPrivacyLevel);
		}
	}
}
