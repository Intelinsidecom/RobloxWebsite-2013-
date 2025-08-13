using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.UniverseDisplayInformation;

internal class UniverseDisplayNameForLanguage : IUniverseDisplayNameForLanguage
{
	public ILanguageFamily Language { get; set; }

	public string Name { get; set; }

	public bool IsSourceLanguage { get; set; }
}
