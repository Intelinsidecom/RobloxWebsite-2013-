using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Platform.Membership;
using Roblox.Platform.Privacy.Properties;

namespace Roblox.Platform.Privacy;

internal class DisplayInventoryPrivacyAccessor : IDisplayInventoryPrivacyAccessor
{
	/// <inheritdoc cref="P:Roblox.Platform.Privacy.IDisplayInventoryPrivacyAccessor.IsInventoryHidingFeatureEnabled" />
	[ExcludeFromCodeCoverage]
	public virtual bool IsInventoryHidingFeatureEnabled => Settings.Default.InventoryHidingFeatureEnabled;

	internal virtual IUserPrivacySettingCALAccessor _UserPrivacyCAL { get; }

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _DisplayInventoryU13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.DisplayInventoryU13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: DisplayInventoryU13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType _DisplayInventoryO13Default
	{
		get
		{
			UserPrivacyLevelType? setting = ParseSetting(Settings.Default.DisplayInventoryO13DefaultPrivacySetting);
			if (setting.HasValue)
			{
				return setting.Value;
			}
			throw new Exception("Unable to parse setting: DisplayInventoryO13DefaultPrivacySetting");
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _DisplayInventoryU13Override => ParseSetting(Settings.Default.DisplayInventoryU13OverridePrivacySetting);

	[ExcludeFromCodeCoverage]
	internal virtual UserPrivacyLevelType? _DisplayInventoryO13Override => ParseSetting(Settings.Default.DisplayInventoryO13OverridePrivacySetting);

	/// <summary>
	/// Initialize a new instance of <see cref="T:Roblox.Platform.Privacy.DisplayInventoryPrivacyAccessor" />.
	/// </summary>
	/// <param name="userPrivacyCAL"><see cref="T:Roblox.Platform.Privacy.IUserPrivacySettingCALAccessor" />.</param>
	/// <exception cref="T:System.ArgumentNullException">Thrown when any of the input parameters are null</exception>
	internal DisplayInventoryPrivacyAccessor(IUserPrivacySettingCALAccessor userPrivacyCAL)
	{
		_UserPrivacyCAL = userPrivacyCAL ?? throw new ArgumentNullException("userPrivacyCAL");
	}

	/// <inheritdoc />
	public IDisplayInventoryPrivacySetting GetOrCreateDisplayInventoryPrivacyLevel(IUser user, UserPrivacyLevelType? tradeOverride)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		UserPrivacyLevelType? displayInventoryOverride = DisplayInventoryPrivacyLevelOverride(user);
		if (displayInventoryOverride.HasValue)
		{
			return new DisplayInventoryPrivacySetting(user, displayInventoryOverride.Value);
		}
		IUserPrivacySetting setting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.DisplayInventory, user, InitialInventoryPrivacyLevel(user, tradeOverride));
		return new DisplayInventoryPrivacySetting(user, setting.PrivacyLevel);
	}

	/// <inheritdoc />
	public void SetDisplayInventoryPrivacyLevel(IDisplayInventoryPrivacySetting newSetting)
	{
		if (newSetting == null)
		{
			throw new ArgumentNullException("newSetting");
		}
		if (newSetting.User == null)
		{
			throw new ArgumentException("Cannot save settings for guests!");
		}
		if (!DisplayInventoryPrivacyLevelOverride(newSetting.User).HasValue)
		{
			IUserPrivacySetting existingSetting = _UserPrivacyCAL.GetOrCreate(UserPrivacySettingType.DisplayInventory, newSetting.User, GetDefaultDisplayInventoryLevelForUser(newSetting.User));
			if (existingSetting.PrivacyLevel != newSetting.PrivacyLevel)
			{
				existingSetting.PrivacyLevel = newSetting.PrivacyLevel;
				_UserPrivacyCAL.SaveUserPrivacySetting(existingSetting);
			}
		}
	}

	internal UserPrivacyLevelType? ParseSetting(string val)
	{
		return EnumUtils.StrictTryParseEnum<UserPrivacyLevelType>(val);
	}

	public UserPrivacyLevelType GetDefaultDisplayInventoryLevelForUser(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!user.IsUnder13())
		{
			return _DisplayInventoryO13Default;
		}
		return _DisplayInventoryU13Default;
	}

	internal UserPrivacyLevelType? DisplayInventoryPrivacyLevelOverride(IUser user)
	{
		if (user == null)
		{
			return null;
		}
		if (!user.IsUnder13())
		{
			return _DisplayInventoryO13Override;
		}
		return _DisplayInventoryU13Override;
	}

	/// <summary>
	/// If the default inventory setting for existing bc member is conflict with his trade privacy setting, initial inventory privacy setting should match trade privacy instead of using default value.
	/// </summary>
	internal UserPrivacyLevelType InitialInventoryPrivacyLevel(IUser user, UserPrivacyLevelType? tradeLevelType)
	{
		UserPrivacyLevelType defaultInventoryPrivacy = GetDefaultDisplayInventoryLevelForUser(user);
		if (tradeLevelType.HasValue && tradeLevelType > defaultInventoryPrivacy)
		{
			return tradeLevelType.Value;
		}
		return defaultInventoryPrivacy;
	}
}
