using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization.Authorization;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization;

internal class GameLanguagesBuilder : IGameLanguagesBuilder
{
	private readonly IUniverseFactory _UniverseFactory;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly IGameLocalizationAuthorizer _GameLocalizationAuthorizer;

	private readonly IGameLocalizationLanguageSettingsAuthority _GameLocalizationLanguageSettingsAuthority;

	public GameLanguagesBuilder(IUniverseFactory universeFactory, ICoreLocalizationAccessor coreLocalizationAccessor, IGameLocalizationAuthorizer gameLocalizationAuthorizer, IGameLocalizationLanguageSettingsAuthority gameLocalizationLanguageSettingsAuthority)
	{
		_UniverseFactory = universeFactory ?? throw new PlatformArgumentNullException("universeFactory");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_GameLocalizationAuthorizer = gameLocalizationAuthorizer ?? throw new PlatformArgumentNullException("gameLocalizationAuthorizer");
		_GameLocalizationLanguageSettingsAuthority = gameLocalizationLanguageSettingsAuthority ?? throw new PlatformArgumentNullException("gameLocalizationLanguageSettingsAuthority");
	}

	public void AddGameLanguages(long universeId, IReadOnlyCollection<string> languageCodes, IActor actor)
	{
		ValidateUniverseAndLanguageCodes(universeId, languageCodes);
		if (!_GameLocalizationAuthorizer.IsAuthorizedToEditSupportedLanguages(universeId, actor))
		{
			throw new UnauthorizedAccessException($"Actor is not allowed to edit the languages for universe: {universeId}");
		}
		IReadOnlyCollection<ILanguageFamily> languageFamilies = GetLanguageFamiliesFromLanguageCodes(languageCodes);
		HashSet<int> supportedLanguageIds = new HashSet<int>(from x in _CoreLocalizationAccessor.GetSupportedLocales()
			select x.Language.Id);
		if (languageFamilies.Any((ILanguageFamily x) => !supportedLanguageIds.Contains(x.Id)))
		{
			throw new PlatformArgumentException("Non supported languages are not allowed.");
		}
		_GameLocalizationLanguageSettingsAuthority.AddSupportedLanguageFamiliesForGame(universeId, languageFamilies);
	}

	public void RemoveGameLanguages(long universeId, IReadOnlyCollection<string> languageCodes, IActor actor)
	{
		ValidateUniverseAndLanguageCodes(universeId, languageCodes);
		if (!_GameLocalizationAuthorizer.IsAuthorizedToEditSupportedLanguages(universeId, actor))
		{
			throw new UnauthorizedAccessException($"Actor is not allowed to edit the languages for universe: {universeId}");
		}
		IReadOnlyCollection<ILanguageFamily> languageFamilies = GetLanguageFamiliesFromLanguageCodes(languageCodes);
		_GameLocalizationLanguageSettingsAuthority.RemoveSupportedLanguageFamiliesForGame(universeId, languageFamilies);
	}

	private void ValidateUniverseAndLanguageCodes(long universeId, IReadOnlyCollection<string> languageCodes)
	{
		if (universeId < 1)
		{
			throw new PlatformArgumentException("universeId");
		}
		if (_UniverseFactory.GetUniverse(universeId) == null)
		{
			throw new PlatformArgumentNullException("universeId");
		}
		if (languageCodes == null || !languageCodes.Any() || languageCodes.Any(string.IsNullOrWhiteSpace))
		{
			throw new PlatformArgumentNullException("languageCodes");
		}
	}

	private IReadOnlyCollection<ILanguageFamily> GetLanguageFamiliesFromLanguageCodes(IReadOnlyCollection<string> languageCodes)
	{
		List<ILanguageFamily> languageFamilies = new List<ILanguageFamily>();
		foreach (string languageCode in languageCodes)
		{
			ILanguageFamily languageFamily = _CoreLocalizationAccessor.GetLanguageFamily(languageCode);
			if (languageFamily == null)
			{
				throw new PlatformArgumentException("Invalid language code.");
			}
			languageFamilies.Add(languageFamily);
		}
		return languageFamilies;
	}
}
