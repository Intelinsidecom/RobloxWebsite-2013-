using Roblox.Instrumentation;

namespace Roblox.Platform.Outfits;

public interface IBodyColorsPerformanceCounter
{
	IRateOfCountsPerSecondCounter ReadAvatarHash { get; }

	IRateOfCountsPerSecondCounter WriteAvatarHash { get; }

	IRateOfCountsPerSecondCounter SetupDefaultAvatarHash { get; }

	IRateOfCountsPerSecondCounter StripTeeShirtFromAvatarHash { get; }

	IRateOfCountsPerSecondCounter InvalidBodyColorIdsRetrievedAvatarHash { get; }

	IRateOfCountsPerSecondCounter SetupDefaultBodyColorSetID { get; }

	IRateOfCountsPerSecondCounter ReadBodyColorSetID { get; }

	IRateOfCountsPerSecondCounter WriteBodyColorSetID { get; }

	IRateOfCountsPerSecondCounter MigrateAvatarHashToBodyColorSetID { get; }
}
