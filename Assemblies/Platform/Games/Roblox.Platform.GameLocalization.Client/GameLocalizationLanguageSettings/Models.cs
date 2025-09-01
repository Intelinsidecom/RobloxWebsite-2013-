using System.Collections.Generic;

namespace Roblox.Platform.GameLocalization.Client.GameLocalizationLanguageSettings
{
    public enum LanguageType
    {
        Unknown = 0
    }

    public class GetLanguageSettingsRequest
    {
        public long UniverseId { get; set; }
    }

    public class LanguageSettings
    {
        public LanguageType LanguageType { get; set; }
        public long LanguageTypeTargetId { get; set; }
    }

    public class LanguageSettingsResponse
    {
        public List<LanguageSettings> SettingsByLanguage { get; set; } = new List<LanguageSettings>();
    }

    public class SetLanguageSettingsRequest
    {
        public long UniverseId { get; set; }
        public List<LanguageSettings> SettingsByLanguage { get; set; } = new List<LanguageSettings>();
    }
}
