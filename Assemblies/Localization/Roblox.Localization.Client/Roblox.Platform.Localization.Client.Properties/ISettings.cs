using System;
namespace Roblox.Platform.Localization.Client.Properties
{
    public interface ISettings

{
	TimeSpan LanguageFamilyLocalCacheExpiry { get; }

	TimeSpan SupportedLocaleLocalCacheExpiry { get; }

	TimeSpan DeviceReportedLocaleCacheExpiry { get; }
}


}
