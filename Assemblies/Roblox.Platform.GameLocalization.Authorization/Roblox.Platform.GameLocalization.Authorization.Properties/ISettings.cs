namespace Roblox.Platform.GameLocalization.Authorization.Properties;

internal interface ISettings
{
	bool IsContentCreatorAllowedToTranslate { get; }

	bool IsContentCreatorAllowedToEditSupportedLanguages { get; }

	bool IsContentCreatorAllowedToFlushAutoLocalizationTables { get; }

	bool IsContentCreatorAllowedToViewOrEditAutoLocalizationTables { get; }
}
