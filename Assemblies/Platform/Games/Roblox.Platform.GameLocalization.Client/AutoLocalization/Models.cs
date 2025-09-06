using System;

namespace Roblox.Platform.GameLocalization.Client.AutoLocalization
{
    public class GetAutoLocalizationSettingsRequest
    {
        public long UniverseId { get; set; }
    }

    public class AutoLocalizationSettingsResponse
    {
        public Guid? AutoLocalizationDestinationTableId { get; set; }
    }
}
