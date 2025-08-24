using System.Collections.Generic;

namespace Roblox.GameLocalization.Client
{
    public interface IGameLocalizationLanguageSettingsClient
    {
        GameLocalizationLanguageSettings.LanguageSettingsResponse GetLanguageSettings(GameLocalizationLanguageSettings.GetLanguageSettingsRequest request);
        void AddLanguageSettings(GameLocalizationLanguageSettings.SetLanguageSettingsRequest request);
        void RemoveLanguageSettings(GameLocalizationLanguageSettings.SetLanguageSettingsRequest request);
    }
}
