using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Privacy.Properties;

namespace Roblox.Platform.Privacy;

public class ChatPrivacySettingAccessor : IChatPrivacySettingAccessor
{
	internal virtual IUserPrivacySettingCALAccessor _UserPrivacyCAL { get; private set; }

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _GameChatU13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.GameChatMessagingU13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: GameChatMessagingU13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _GameChatO13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.GameChatMessagingO13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: GameChatMessagingO13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _GameChatGuestDefault
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.GameChatMessagingGuestDefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: GameChatMessagingGuestDefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _GameChatU13Override => ParseSetting(Settings.Default.GameChatMessagingU13OverridePrivacySetting);

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _GameChatO13Override => ParseSetting(Settings.Default.GameChatMessagingO13OverridePrivacySetting);

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _AppChatU13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.AppChatMessagingU13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: AppChatMessagingU13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _AppChatO13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.AppChatMessagingO13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: AppChatMessagingO13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _AppChatU13Override => ParseSetting(Settings.Default.AppChatMessagingU13OverridePrivacySetting);

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _AppChatO13Override => ParseSetting(Settings.Default.AppChatMessagingO13OverridePrivacySetting);

	public event Action<IUser, bool> OnAppChatEnablementChanged;

	/// <summary>
	/// We currently create one per game join which is not ideal.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown when any of the input parameters are null</exception>
	internal ChatPrivacySettingAccessor(IUserPrivacySettingCALAccessor userPrivacyCAL)
	{
		if (userPrivacyCAL == null)
		{
			throw new ArgumentNullException("userPrivacyCAL");
		}
		_UserPrivacyCAL = userPrivacyCAL;
	}

	internal UserPrivacyLevelType? ParseSetting(string val)
	{
		return EnumUtils.StrictTryParseEnum<UserPrivacyLevelType>(val);
	}

	internal UserPrivacyLevelType GetDefaultGameChatPrivacyLevelForUser(IUser user)
	{
		if (user == null)
		{
			return _GameChatGuestDefault;
		}
		if (!user.IsUnder13())
		{
			return _GameChatO13Default;
		}
		return _GameChatU13Default;
	}

	internal UserPrivacyLevelType? GetGameChatPrivacyLevelOverride(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		if (!user.IsUnder13())
		{
			return _GameChatO13Override;
		}
		return _GameChatU13Override;
	}

	internal virtual bool IsGameChatPrivacyLevelValid(IUser user, UserPrivacyLevelType userPrivacyLevelType)
	{
		if (userPrivacyLevelType == UserPrivacyLevelType.NoOne || userPrivacyLevelType == UserPrivacyLevelType.AllUsers)
		{
			return true;
		}
		return false;
	}

	public IGameChatPrivacySetting GetOrCreateGameChatPrivacyLevel(IUser user)
	{
		if (user == null)
		{
			return new GameChatPrivacySetting(user, _GameChatGuestDefault);
		}
		UserPrivacyLevelType? chatOverride = GetGameChatPrivacyLevelOverride(user);
		if (chatOverride.HasValue)
		{
			return new GameChatPrivacySetting(user, chatOverride.Value);
		}
		IUserPrivacySetting setting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.GameChatMessaging, user, GetDefaultGameChatPrivacyLevelForUser(user));
		return new GameChatPrivacySetting(user, setting.PrivacyLevel);
	}

	public virtual void SetGameChatPrivacyLevel(IGameChatPrivacySetting newSetting)
	{
		if (newSetting == null)
		{
			throw new ArgumentNullException("newSetting");
		}
		if (newSetting.User == null)
		{
			throw new ArgumentNullException("Cannot save settings for guests!");
		}
		if (GetGameChatPrivacyLevelOverride(newSetting.User).HasValue)
		{
			return;
		}
		IUserPrivacySetting existingSetting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.GameChatMessaging, newSetting.User, GetDefaultGameChatPrivacyLevelForUser(newSetting.User));
		if (existingSetting.PrivacyLevel != newSetting.PrivacyLevel)
		{
			if (!IsGameChatPrivacyLevelValid(newSetting.User, newSetting.PrivacyLevel))
			{
				throw new InvalidPermissionTypeException($"Invalid userPrivacyLevelType {newSetting}");
			}
			existingSetting.PrivacyLevel = newSetting.PrivacyLevel;
			_UserPrivacyCAL.SaveUserPrivacySetting(existingSetting);
		}
	}

	public void SanitizeGameChatSetting(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		IUserPrivacySetting setting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.GameChatMessaging, user, GetDefaultGameChatPrivacyLevelForUser(user));
		if (!IsGameChatPrivacyLevelValid(user, setting.PrivacyLevel))
		{
			UserPrivacyLevelType defaultPrivacy = GetDefaultGameChatPrivacyLevelForUser(user);
			SetGameChatPrivacyLevel(new GameChatPrivacySetting(user, defaultPrivacy));
		}
	}

	internal UserPrivacyLevelType GetDefaultAppChatPrivacyLevelForUser(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!user.IsUnder13())
		{
			return _AppChatO13Default;
		}
		return _AppChatU13Default;
	}

	internal UserPrivacyLevelType? GetAppChatPrivacyLevelOverride(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		if (!user.IsUnder13())
		{
			return _AppChatO13Override;
		}
		return _AppChatU13Override;
	}

	internal virtual bool IsAppChatPrivacyLevelValid(UserPrivacyLevelType privacyLevel)
	{
		if ((uint)(privacyLevel - 1) <= 1u)
		{
			return true;
		}
		return false;
	}

	public IAppChatPrivacySetting GetOrCreateAppChatPrivacyLevel(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("Guests cannot access in-app chat");
		}
		UserPrivacyLevelType? chatOverride = GetAppChatPrivacyLevelOverride(user);
		if (chatOverride.HasValue)
		{
			return new AppChatPrivacySetting(user, chatOverride.Value);
		}
		IUserPrivacySetting setting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.AppChatMessaging, user, GetDefaultAppChatPrivacyLevelForUser(user));
		return new AppChatPrivacySetting(user, setting.PrivacyLevel);
	}

	public virtual void SetAppChatPrivacyLevel(IAppChatPrivacySetting newSetting)
	{
		if (newSetting == null)
		{
			throw new ArgumentNullException("newSetting");
		}
		if (newSetting.User == null)
		{
			throw new ArgumentNullException("Cannot save privacy settings for guests!");
		}
		if (GetAppChatPrivacyLevelOverride(newSetting.User).HasValue)
		{
			return;
		}
		_ = newSetting.User.Id;
		IUserPrivacySetting existingSetting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.AppChatMessaging, newSetting.User, GetDefaultAppChatPrivacyLevelForUser(newSetting.User));
		if (existingSetting.PrivacyLevel != newSetting.PrivacyLevel)
		{
			if (!IsAppChatPrivacyLevelValid(newSetting.PrivacyLevel))
			{
				throw new InvalidPermissionTypeException($"Invalid userPrivacyLevelType {newSetting}");
			}
			existingSetting.PrivacyLevel = newSetting.PrivacyLevel;
			_UserPrivacyCAL.SaveUserPrivacySetting(existingSetting);
			this.OnAppChatEnablementChanged?.Invoke(newSetting.User, newSetting.PrivacyLevel == UserPrivacyLevelType.NoOne);
		}
	}

	public void SanitizeAppChatSetting(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		IUserPrivacySetting setting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.AppChatMessaging, user, GetDefaultAppChatPrivacyLevelForUser(user));
		if (!IsAppChatPrivacyLevelValid(setting.PrivacyLevel))
		{
			UserPrivacyLevelType defaultPrivacy = GetDefaultAppChatPrivacyLevelForUser(user);
			SetAppChatPrivacyLevel(new AppChatPrivacySetting(user, defaultPrivacy));
		}
	}
}
