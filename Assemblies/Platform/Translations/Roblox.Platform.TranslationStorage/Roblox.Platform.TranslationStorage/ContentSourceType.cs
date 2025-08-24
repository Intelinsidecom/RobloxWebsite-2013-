using System.ComponentModel;

namespace Roblox.Platform.TranslationStorage;

/// <summary>
/// An enum defining the content source type.
/// </summary>
public enum ContentSourceType : byte
{
	/// <summary>
	/// Roblox country display names
	/// </summary>
	[Description("Roblox country display names")]
	RobloxCountryDisplayNames,
	/// <summary>
	///             In Game Translations
	/// </summary>
	[Description("In game translations")]
	InGameTranslations,
	/// <summary>
	/// Universe display names
	/// </summary>
	[Description("Universe display names")]
	UniverseDisplayNames,
	/// <summary>
	/// Universe display descriptions
	/// </summary>
	[Description("Universe display descriptions")]
	UniverseDisplayDescriptions,
	/// <summary>
	/// Bundle display name.
	/// </summary>
	[Description("Bundle display name")]
	BundleDisplayName,
	/// <summary>
	/// Bundle display description.
	/// </summary>
	[Description("Bundle display description")]
	BundleDisplayDescription,
	/// <summary>
	/// Asset display name.
	/// </summary>
	[Description("Asset display name")]
	AssetDisplayName,
	/// <summary>
	/// Asset display description.
	/// </summary>
	[Description("Asset display description")]
	AssetDisplayDescription,
	/// <summary>
	/// The universe display icon mapping.
	/// </summary>
	[Description("Universe display icon mapping")]
	UniverseDisplayIconMapping,
	/// <summary>
	/// Roblox language display names
	/// </summary>
	[Description("Roblox language display names")]
	RobloxLanguageDisplayNames,
	/// <summary>
	/// The universe display thumbnails mapping.
	/// </summary>
	[Description("Universe display thumbnails mapping")]
	UniverseDisplayThumbnailsMapping,
	/// <summary>
	/// GamePass display name.
	/// </summary>
	[Description("GamePass display name")]
	GamePassDisplayName,
	/// <summary>
	/// GamePass display description
	/// </summary>
	[Description("GamePass display description")]
	GamePassDisplayDescription,
	/// <summary>
	/// The badge display name
	/// </summary>
	[Description("Badge display name")]
	BadgeDisplayName,
	/// <summary>
	/// The badge display description
	/// </summary>
	[Description("Badge display description")]
	BadgeDisplayDescription,
	/// <summary>
	/// The item tag display name.
	/// </summary>
	[Description("Item tag display name")]
	ItemTagDisplayName,
	/// <summary>
	/// The badge display icon mapping.
	/// </summary>
	[Description("Badge display icon mapping")]
	BadgeDisplayIconMapping,
	/// <summary>
	/// The game pass display icon mapping.
	/// </summary>
	[Description("Game pass display icon mapping")]
	GamePassDisplayIconMapping,
	/// <summary>
	/// The developer product icon mapping.
	/// </summary>
	[Description("Developer product display icon mapping")]
	DeveloperProductDisplayIconMapping
}
