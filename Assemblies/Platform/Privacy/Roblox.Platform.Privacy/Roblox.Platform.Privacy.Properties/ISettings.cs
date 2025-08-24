using System;

namespace Roblox.Platform.Privacy.Properties;

public interface ISettings
{
	bool IsLeasedLockForGetOrCreateUserPrivacySettingEnabled { get; }

	TimeSpan LeasedLockForGetOrCreateUserPrivacySettingTimeSpan { get; }
}
