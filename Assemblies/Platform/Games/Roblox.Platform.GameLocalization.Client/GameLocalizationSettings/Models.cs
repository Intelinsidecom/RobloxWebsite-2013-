using System.Collections.Generic;

namespace Roblox.Platform.GameLocalization.Client.GameLocalizationSettings
{
    public class BaseLocalizationSettings
    {
        public long? SourceLanguageFamilyId { get; set; }
    }

    public class GetLocalizationSettingsRequest
    {
        public long UniverseId { get; set; }
    }

    public class LocalizationSettingsResponse : BaseLocalizationSettings
    {
    }

    public class GetLocalizationSettingsForGamesRequest
    {
        public IEnumerable<long> UniverseIds { get; set; }
    }

    public class LocalizationSettingsForGame : BaseLocalizationSettings
    {
        public long UniverseId { get; set; }
    }

    public class LocalizationSettingsForGamesResponse
    {
        public List<LocalizationSettingsForGame> LocalizationSettingsForGames { get; set; } = new List<LocalizationSettingsForGame>();
    }

    public class SetSourceLanguageFamilyRequest
    {
        public long UniverseId { get; set; }
        public long LanguageFamilyId { get; set; }
    }
}
