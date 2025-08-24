using System;

namespace Roblox.Platform.Demographics.Properties;

internal interface ICountryNameTranslationCacheSettings
{
	TimeSpan CountryNameTranslationCachingExpiration { get; }
}
