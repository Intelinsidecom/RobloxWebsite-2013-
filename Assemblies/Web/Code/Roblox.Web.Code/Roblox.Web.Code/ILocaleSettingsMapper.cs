using Roblox.Platform.Localization.Core;

namespace Roblox.Web.Code;

public interface ILocaleSettingsMapper
{
	ILocaleSettings GetLocaleSettings(SupportedLocaleEnum? supportedLocaleCode);
}
