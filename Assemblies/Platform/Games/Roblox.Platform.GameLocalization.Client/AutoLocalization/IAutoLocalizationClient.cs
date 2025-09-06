namespace Roblox.Platform.GameLocalization.Client.AutoLocalization
{
    public interface IAutoLocalizationClient
    {
        AutoLocalizationSettingsResponse GetAutoLocalizationSettings(GetAutoLocalizationSettingsRequest request);
    }
}
