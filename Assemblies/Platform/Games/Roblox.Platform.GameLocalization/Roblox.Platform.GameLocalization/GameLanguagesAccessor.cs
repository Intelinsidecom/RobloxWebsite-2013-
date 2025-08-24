using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.GameLocalization;

internal class GameLanguagesAccessor : IGameLanguagesAccessor
{
	private readonly IGameLocalizationLanguageSettingsAuthority _GameLocalizationLanguageSettingsAuthority;

	public GameLanguagesAccessor(IGameLocalizationLanguageSettingsAuthority gameLocalizationLanguageSettingsAuthority)
	{
		_GameLocalizationLanguageSettingsAuthority = gameLocalizationLanguageSettingsAuthority ?? throw new PlatformArgumentNullException("gameLocalizationLanguageSettingsAuthority");
	}

	public IReadOnlyCollection<ILanguageFamily> GetGameLanguagesForGame(long universeId)
	{
		if (universeId < 1)
		{
			throw new PlatformArgumentException("universeId");
		}
		return _GameLocalizationLanguageSettingsAuthority.GetSupportedLanguageFamiliesForGame(universeId);
	}
}
