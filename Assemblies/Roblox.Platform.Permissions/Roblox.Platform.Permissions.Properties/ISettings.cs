using System.ComponentModel;

namespace Roblox.Platform.Permissions.Properties;

internal interface ISettings : INotifyPropertyChanged
{
	byte CoppaAgeThreshold { get; }

	string GdprAge13Locations { get; }

	string GdprAge14Locations { get; }

	string GdprAge15Locations { get; }

	string GdprAge16Locations { get; }

	bool AreUserUnderChinaPolicyTestersEnabledForAll { get; }

	string ChinaPolicyWhitelistedUserIdsCsv { get; }
}
