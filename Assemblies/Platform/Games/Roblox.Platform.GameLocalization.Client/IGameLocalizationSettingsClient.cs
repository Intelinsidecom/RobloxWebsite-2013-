using Roblox.Platform.GameLocalization.Client.GameLocalizationSettings;

namespace Roblox.Platform.GameLocalization.Client
{
    public interface IGameLocalizationSettingsClient
    {
        LocalizationSettingsResponse GetLocalizationSettings(GetLocalizationSettingsRequest request);
        LocalizationSettingsForGamesResponse GetLocalizationSettingsForGames(GetLocalizationSettingsForGamesRequest request);
        void SetSourceLanguageFamily(SetSourceLanguageFamilyRequest request);
    }
}
