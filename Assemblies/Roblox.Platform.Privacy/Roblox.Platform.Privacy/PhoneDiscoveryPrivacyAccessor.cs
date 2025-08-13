using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Platform.Membership;
using Roblox.Platform.Permissions.Core;
using Roblox.Platform.Privacy.Properties;

namespace Roblox.Platform.Privacy;

/// <inheritdoc />
internal class PhoneDiscoveryPrivacyAccessor : IPhoneDiscoveryPrivacyAccessor
{
	internal virtual IUserPrivacySettingCALAccessor _UserPrivacyCAL { get; }

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _PhoneDiscoveryU13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.PhoneNumberDiscoveryU13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: PhoneNumberDiscoveryU13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _PhoneDiscoveryO13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.PhoneNumberDiscoveryO13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: PhoneNumberDiscoveryO13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _PhoneDiscoveryU13Override => ParseSetting(Settings.Default.PhoneDiscoveryU13OverridePrivacySetting);

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _PhoneDiscoveryO13Override => ParseSetting(Settings.Default.PhoneDiscoveryO13OverridePrivacySetting);

	/// <summary>
	/// Initialize a new instance of <see cref="T:Roblox.Platform.Privacy.PhoneDiscoveryPrivacyAccessor" />.
	/// </summary>
	/// <param name="userPrivacyCAL"><see cref="T:Roblox.Platform.Privacy.IUserPrivacySettingCALAccessor" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when any of the input parameters are null</exception>
	internal PhoneDiscoveryPrivacyAccessor(IUserPrivacySettingCALAccessor userPrivacyCAL)
	{
		_UserPrivacyCAL = userPrivacyCAL ?? throw new ArgumentNullException("userPrivacyCAL");
	}

	/// <inheritdoc />
	public IPhoneDiscoveryPrivacySetting GetOrCreatePhoneDiscoveryPrivacyLevel(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		UserPrivacyLevelType? phoneDiscoveryOverride = PhoneDiscoveryPrivacyLevelOverride(user);
		if (phoneDiscoveryOverride.HasValue)
		{
			return new PhoneDiscoveryPrivacySetting(user, phoneDiscoveryOverride.Value);
		}
		IUserPrivacySetting setting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.PhoneNumberDiscovery, user, GetDefaultPhoneDiscoveryLevelForUser(user));
		return new PhoneDiscoveryPrivacySetting(user, setting.PrivacyLevel);
	}

	/// <inheritdoc />
	public void SetPhoneDiscoveryPrivacyLevel(IPhoneDiscoveryPrivacySetting newSetting)
	{
		if (newSetting == null)
		{
			throw new ArgumentNullException("newSetting");
		}
		if (newSetting.User == null)
		{
			throw new ArgumentException("Cannot save settings for guests!");
		}
		if (PhoneDiscoveryPrivacyLevelOverride(newSetting.User).HasValue)
		{
			return;
		}
		IUserPrivacySetting existingSetting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.PhoneNumberDiscovery, newSetting.User, GetDefaultPhoneDiscoveryLevelForUser(newSetting.User));
		if (existingSetting.PrivacyLevel != newSetting.PrivacyLevel)
		{
			if (!IsPhoneDiscoveryPrivacyLevelValid(newSetting.User, newSetting.PrivacyLevel))
			{
				throw new InvalidPermissionTypeException($"Invalid userPrivacyLevelType {newSetting}");
			}
			existingSetting.PrivacyLevel = newSetting.PrivacyLevel;
			_UserPrivacyCAL.SaveUserPrivacySetting(existingSetting);
		}
	}

	internal UserPrivacyLevelType? ParseSetting(string val)
	{
		return EnumUtils.StrictTryParseEnum<UserPrivacyLevelType>(val);
	}

	internal UserPrivacyLevelType GetDefaultPhoneDiscoveryLevelForUser(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!user.IsUnder13())
		{
			return _PhoneDiscoveryO13Default;
		}
		return _PhoneDiscoveryU13Default;
	}

	internal virtual bool IsPhoneDiscoveryPrivacyLevelValid(IUser user, UserPrivacyLevelType userPrivacyLevelType)
	{
		if (userPrivacyLevelType == UserPrivacyLevelType.NoOne || userPrivacyLevelType == UserPrivacyLevelType.AllUsers)
		{
			return true;
		}
		return false;
	}

	internal UserPrivacyLevelType? PhoneDiscoveryPrivacyLevelOverride(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		if (!user.IsUnder13())
		{
			return _PhoneDiscoveryO13Override;
		}
		return _PhoneDiscoveryU13Override;
	}
}
