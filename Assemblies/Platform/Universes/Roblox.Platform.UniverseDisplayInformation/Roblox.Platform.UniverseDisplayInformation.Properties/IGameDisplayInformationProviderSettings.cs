namespace Roblox.Platform.UniverseDisplayInformation.Properties;

internal interface IGameDisplayInformationProviderSettings
{
	bool IsUniverseDescriptionInsteadOfPlaceDescriptionEnabled { get; }

	bool IsAccessingTranslationsEnabled { get; }

	bool IsReturningTranslationsEnabled { get; }
}
