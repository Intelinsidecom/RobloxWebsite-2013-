using System.Collections.Generic;

namespace Roblox.Platform.GameLocalization.Client
{
    public interface IGameLocalizationLanguageSettingsClient
    {
        Roblox.Platform.GameLocalization.Client.GameLocalizationLanguageSettings.LanguageSettingsResponse GetLanguageSettings(Roblox.Platform.GameLocalization.Client.GameLocalizationLanguageSettings.GetLanguageSettingsRequest request);
        void AddLanguageSettings(Roblox.Platform.GameLocalization.Client.GameLocalizationLanguageSettings.SetLanguageSettingsRequest request);
        void RemoveLanguageSettings(Roblox.Platform.GameLocalization.Client.GameLocalizationLanguageSettings.SetLanguageSettingsRequest request);
    }
}
