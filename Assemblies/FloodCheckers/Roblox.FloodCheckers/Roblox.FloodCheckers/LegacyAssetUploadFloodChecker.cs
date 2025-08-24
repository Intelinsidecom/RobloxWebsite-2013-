using Roblox.FloodCheckers.Properties;

namespace Roblox.FloodCheckers;

public class LegacyAssetUploadFloodChecker : FloodChecker
{
	public LegacyAssetUploadFloodChecker(long userId)
		: base($"LegacyAssetUploadFloodChecker_UserId:{userId}", Settings.Default.LegacyAssetUploadFloodCheckLimit, Settings.Default.LegacyAssetUploadFloodCheckExipry)
	{
	}
}
