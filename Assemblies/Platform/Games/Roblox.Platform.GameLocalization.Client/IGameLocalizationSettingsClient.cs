using Roblox.GameLocalization.Client.GameLocalizationSettings;

namespace Roblox.GameLocalization.Client
{
    public interface IGameLocalizationSettingsClient
    {
        LocalizationSettingsResponse GetLocalizationSettings(GetLocalizationSettingsRequest request);
        LocalizationSettingsForGamesResponse GetLocalizationSettingsForGames(GetLocalizationSettingsForGamesRequest request);
        void SetSourceLanguageFamily(SetSourceLanguageFamilyRequest request);
    }
}
