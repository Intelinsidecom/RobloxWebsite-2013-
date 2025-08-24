namespace Roblox.GameLocalization.Client.AutoLocalization
{
    public interface IAutoLocalizationClient
    {
        AutoLocalizationSettingsResponse GetAutoLocalizationSettings(GetAutoLocalizationSettingsRequest request);
    }
}
