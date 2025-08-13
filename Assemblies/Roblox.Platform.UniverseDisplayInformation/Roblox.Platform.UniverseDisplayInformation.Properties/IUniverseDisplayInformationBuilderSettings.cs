namespace Roblox.Platform.UniverseDisplayInformation.Properties;

internal interface IUniverseDisplayInformationBuilderSettings
{
	bool IsModifyingOrDeletingTranslationsEnabled { get; }

	int UniverseNameMaxLength { get; }

	int UniverseDescriptionMaxLength { get; }

	bool IsAllowingNullOrWhitespaceNameEnabled { get; }
}
