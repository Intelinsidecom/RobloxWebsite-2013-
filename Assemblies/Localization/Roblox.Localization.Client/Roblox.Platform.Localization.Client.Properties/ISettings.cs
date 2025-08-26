using System;
namespace Roblox.Platform.Localization.Client.Propertiesinternal {
    interface ISettings

{
	TimeSpan LanguageFamilyLocalCacheExpiry { get; }

	TimeSpan SupportedLocaleLocalCacheExpiry { get; }

	TimeSpan DeviceReportedLocaleCacheExpiry { get; }
}


}
