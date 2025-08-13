using System;

namespace Roblox.Localization.Client.Properties;

internal interface ISettings
{
	TimeSpan LanguageFamilyLocalCacheExpiry { get; }

	TimeSpan SupportedLocaleLocalCacheExpiry { get; }

	TimeSpan DeviceReportedLocaleCacheExpiry { get; }
}
