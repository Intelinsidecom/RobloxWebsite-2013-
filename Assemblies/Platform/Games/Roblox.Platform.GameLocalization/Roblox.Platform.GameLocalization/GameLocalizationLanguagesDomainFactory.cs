using Roblox.EventLog;
using Roblox.GameLocalization.Client;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization.Authorization;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization;

/// <summary>
/// A domain factory for accessors and builders.
/// </summary>
public class GameLocalizationLanguagesDomainFactory
{
	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly IGameLocalizationLanguageSettingsAuthority _GameLocalizationLanguageSettingsAuthority;

	public GameLocalizationLanguagesDomainFactory(IGameLocalizationLanguageSettingsClient gameLocalizationLanguageSettingsClient, ICoreLocalizationAccessor coreLocalizationAccessor, ILogger logger)
	{
		if (gameLocalizationLanguageSettingsClient == null)
		{
			throw new PlatformArgumentNullException("gameLocalizationLanguageSettingsClient");
		}
		if (logger == null)
		{
			throw new PlatformArgumentNullException("logger");
		}
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_GameLocalizationLanguageSettingsAuthority = new GameLocalizationLanguageSettingsAuthority(gameLocalizationLanguageSettingsClient, coreLocalizationAccessor, logger);
	}

	/// <summary>
	/// Creates a new GameLanguagesBuilder.
	/// </summary>
	/// <returns>A new <see cref="T:Roblox.Platform.GameLocalization.IGameLanguagesBuilder" />.</returns>
	public IGameLanguagesBuilder GetGameLanguagesBuilder(IUniverseFactory universeFactory, IGameLocalizationAuthorizer gameLocalizationAuthorizer)
	{
		return new GameLanguagesBuilder(universeFactory, _CoreLocalizationAccessor, gameLocalizationAuthorizer, _GameLocalizationLanguageSettingsAuthority);
	}

	/// <summary>
	/// Creates a new GameLanguagesAccessor.
	/// </summary>
	/// <returns>A new <see cref="T:Roblox.Platform.GameLocalization.IGameLanguagesAccessor" />.</returns>
	public IGameLanguagesAccessor GetGameLanguagesAccessor()
	{
		return new GameLanguagesAccessor(_GameLocalizationLanguageSettingsAuthority);
	}
}
