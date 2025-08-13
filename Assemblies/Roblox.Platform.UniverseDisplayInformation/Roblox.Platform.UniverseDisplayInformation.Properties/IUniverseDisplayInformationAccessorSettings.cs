namespace Roblox.Platform.UniverseDisplayInformation.Properties;

internal interface IUniverseDisplayInformationAccessorSettings
{
	bool IsAccessingTranslationsEnabled { get; }

	bool IsReturningTranslationsEnabled { get; }

	int ShadowRolloutPercentage { get; }
}
