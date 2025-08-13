using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.GameLocalization.Client;
using Roblox.GameLocalization.Client.GameLocalizationSettings;
using Roblox.Platform.Core;
using Roblox.Platform.GameLocalization.Events;
using Roblox.Platform.Localization.Core;
using Roblox.Platform.Universes;

namespace Roblox.Platform.GameLocalization;

public class GameLocalizationSettingsAuthority : IGameLocalizationSettingsAuthority
{
	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly IGameLocalizationSettingsClient _Client;

	private readonly ILogger _Logger;

	private readonly IGameLocalizationChangeReporter _Reporter;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.GameLocalization.GameLocalizationSettingsAuthority" /> class.
	/// </summary>
	/// <param name="coreLocalizationAccessor">The <see cref="T:Roblox.Platform.Localization.Core.ICoreLocalizationAccessor" />.</param>
	/// <param name="client">The <see cref="T:Roblox.GameLocalization.Client.IGameLocalizationSettingsClient" />.</param>
	/// <param name="publisher">The <see cref="T:Roblox.Platform.GameLocalization.IGameLocalizationChangeEventsPublisher" />.</param>
	/// <param name="logger">The <see cref="T:Roblox.EventLog.ILogger" />.</param>
	public GameLocalizationSettingsAuthority(ICoreLocalizationAccessor coreLocalizationAccessor, IGameLocalizationSettingsClient client, IGameLocalizationChangeEventsPublisher publisher, ILogger logger)
		: this(coreLocalizationAccessor, client, publisher, new GameLocalizationChangeReporter(), logger)
	{
	}

	internal GameLocalizationSettingsAuthority(ICoreLocalizationAccessor coreLocalizationAccessor, IGameLocalizationSettingsClient client, IGameLocalizationChangeEventsPublisher publisher, IGameLocalizationChangeReporter reporter, ILogger logger)
	{
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_Client = client ?? throw new PlatformArgumentNullException("client");
		if (publisher == null)
		{
			throw new PlatformArgumentNullException("publisher");
		}
		_Reporter = reporter ?? throw new PlatformArgumentNullException("reporter");
		publisher.Subscribe(_Reporter);
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public ILanguageFamily GetSourceLanguageFamily(IUniverse universe)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		//IL_001d: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected O, but got Unknown
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		LocalizationSettingsResponse settings = _Client.GetLocalizationSettings(new GetLocalizationSettingsRequest
		{
			UniverseId = universe.Id
		});
		return GetSourceLanguageFamilyById(((BaseLocalizationSettings)settings).SourceLanguageFamilyId);
	}

	public IReadOnlyDictionary<IUniverse, ILanguageFamily> GetSourceLanguageFamiliesForGames(IReadOnlyCollection<IUniverse> universes)
	{
		//IL_005a: Unknown result type (might be due to invalid IL or missing references)
		//IL_005f: Unknown result type (might be due to invalid IL or missing references)
		//IL_006b: Expected O, but got Unknown
		if (universes == null)
		{
			throw new PlatformArgumentNullException("universes");
		}
		if (!universes.Any())
		{
			return new Dictionary<IUniverse, ILanguageFamily>();
		}
		IEnumerable<long> universeIds = universes.Select((IUniverse universe) => universe.Id).Distinct();
		LocalizationSettingsForGamesResponse settingsForGamesResponse = _Client.GetLocalizationSettingsForGames(new GetLocalizationSettingsForGamesRequest
		{
			UniverseIds = universeIds
		});
		Dictionary<long, ILanguageFamily> idLanguageDictionary = settingsForGamesResponse.LocalizationSettingsForGames.ToDictionary((LocalizationSettingsForGame setting) => setting.UniverseId, (LocalizationSettingsForGame setting) => GetSourceLanguageFamilyById(((BaseLocalizationSettings)setting).SourceLanguageFamilyId));
		return universes.ToDictionary((IUniverse universe) => universe, (IUniverse universe) => idLanguageDictionary[universe.Id]);
	}

	public void SetSourceLanguageFamily(IUniverse universe, ILanguageFamily languageFamily)
	{
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0063: Unknown result type (might be due to invalid IL or missing references)
		//IL_0075: Expected O, but got Unknown
		universe = universe ?? throw new PlatformArgumentNullException("universe");
		languageFamily = languageFamily ?? throw new PlatformArgumentNullException("languageFamily");
		if (!_CoreLocalizationAccessor.GetAvailableLanguageFamiliesForOutOfGameUgc().Contains(languageFamily))
		{
			throw new PlatformInvalidOperationException(string.Format("Cannot set the source language of a game to language: {0}", "LanguageCode"));
		}
		_Client.SetSourceLanguageFamily(new SetSourceLanguageFamilyRequest
		{
			UniverseId = universe.Id,
			LanguageFamilyId = languageFamily.Id
		});
		_Reporter.OnGameLocalizationSettingChanged(universe.Id, GameLocalizationChangeType.SourceLanguageChange);
	}

	private ILanguageFamily GetSourceLanguageFamilyById(long? id)
	{
		if (!id.HasValue)
		{
			return null;
		}
		return _CoreLocalizationAccessor.GetLanguageFamily(new LanguageFamilyIdentifier(Convert.ToInt32(id.Value)));
	}
}
