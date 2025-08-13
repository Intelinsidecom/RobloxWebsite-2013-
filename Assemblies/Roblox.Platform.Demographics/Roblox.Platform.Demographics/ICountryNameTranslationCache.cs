using Roblox.Platform.Localization.Core;
using Roblox.Platform.TranslationStorage;

namespace Roblox.Platform.Demographics;

internal interface ICountryNameTranslationCache
{
	ITranslationForContentSourceTargetId Get(string id, ISupportedLocale supportedLocale);

	void Set(string id, ISupportedLocale supportedLocale, ITranslationForContentSourceTargetId translation);
}
