using System;
using Roblox.Instrumentation;

namespace Roblox.Platform.Outfits;

public class BodyColorsPerformanceCounter : IBodyColorsPerformanceCounter
{
	private const string _PerformanceCategory = "Roblox.Platform.Avatar.BodyColorsV2";

	public IRateOfCountsPerSecondCounter ReadAvatarHash { get; internal set; }

	public IRateOfCountsPerSecondCounter WriteAvatarHash { get; internal set; }

	public IRateOfCountsPerSecondCounter SetupDefaultAvatarHash { get; internal set; }

	public IRateOfCountsPerSecondCounter StripTeeShirtFromAvatarHash { get; internal set; }

	public IRateOfCountsPerSecondCounter InvalidBodyColorIdsRetrievedAvatarHash { get; internal set; }

	public IRateOfCountsPerSecondCounter SetupDefaultBodyColorSetID { get; internal set; }

	public IRateOfCountsPerSecondCounter ReadBodyColorSetID { get; internal set; }

	public IRateOfCountsPerSecondCounter WriteBodyColorSetID { get; internal set; }

	public IRateOfCountsPerSecondCounter MigrateAvatarHashToBodyColorSetID { get; internal set; }

	public BodyColorsPerformanceCounter(ICounterRegistry registry)
	{
		if (registry == null)
		{
			throw new ArgumentNullException("registry");
		}
		ReadAvatarHash = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "ReadAvatarHash");
		WriteAvatarHash = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "WriteAvatarHash");
		SetupDefaultAvatarHash = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "SetupDefaultAvatarHash");
		StripTeeShirtFromAvatarHash = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "StripTeeShirtFromAvatarHash");
		InvalidBodyColorIdsRetrievedAvatarHash = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "InvalidBodyColorIdsRetrievedAvatarHash");
		SetupDefaultBodyColorSetID = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "SetupDefaultBodyColorSetID");
		ReadBodyColorSetID = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "ReadBodyColorSetID");
		WriteBodyColorSetID = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "WriteBodyColorSetID");
		MigrateAvatarHashToBodyColorSetID = registry.GetRateOfCountsPerSecondCounter("Roblox.Platform.Avatar.BodyColorsV2", "MigrateAvatarHashToBodyColorSetID");
	}
}
