using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class UniverseDisplayDescriptionForLanguage : IUniverseDisplayDescriptionForLanguage
{
	public ILanguageFamily Language { get; set; }

	public string Description { get; set; }

	public bool IsSourceLanguage { get; set; }
}
