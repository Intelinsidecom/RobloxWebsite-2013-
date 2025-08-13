using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.EventLog;
using Roblox.GameLocalization.Client;
using Roblox.GameLocalization.Client.GameLocalizationLanguageSettings;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.GameLocalization;

internal class GameLocalizationLanguageSettingsAuthority : IGameLocalizationLanguageSettingsAuthority
{
	private readonly IGameLocalizationLanguageSettingsClient _Client;

	private readonly ICoreLocalizationAccessor _CoreLocalizationAccessor;

	private readonly ILogger _Logger;

	public GameLocalizationLanguageSettingsAuthority(IGameLocalizationLanguageSettingsClient client, ICoreLocalizationAccessor coreLocalizationAccessor, ILogger logger)
	{
		_Client = client ?? throw new PlatformArgumentNullException("client");
		_CoreLocalizationAccessor = coreLocalizationAccessor ?? throw new PlatformArgumentNullException("coreLocalizationAccessor");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
	}

	public IReadOnlyCollection<ILanguageFamily> GetSupportedLanguageFamiliesForGame(long universeId)
	{
		//IL_000e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0013: Unknown result type (might be due to invalid IL or missing references)
		//IL_001b: Expected O, but got Unknown
		if (universeId == 0L)
		{
			throw new PlatformArgumentNullException("universeId");
		}
		GetLanguageSettingsRequest getRequest = new GetLanguageSettingsRequest
		{
			UniverseId = universeId
		};
		LanguageSettingsResponse response = null;
		try
		{
			response = _Client.GetLanguageSettings(getRequest);
		}
		catch (Exception e2)
		{
			_Logger.Error(e2);
			throw;
		}
		IEnumerable<long> languageIds = ((response != null) ? (from x in response.SettingsByLanguage
			where (int)x.LanguageType == 0
			select x.LanguageTypeTargetId) : null) ?? new List<long>();
		try
		{
			return languageIds.Select(GetValidatedLanguageFamilyById).ToList();
		}
		catch (PlatformArgumentException e)
		{
			_Logger.Error(e);
			throw;
		}
	}

	public void RemoveSupportedLanguageFamiliesForGame(long universeId, IReadOnlyCollection<ILanguageFamily> languages)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		if (universeId == 0L)
		{
			throw new PlatformArgumentNullException("universeId");
		}
		if (languages == null || !languages.Any() || languages.Any((ILanguageFamily x) => x == null))
		{
			throw new PlatformArgumentNullException("languages");
		}
		SetLanguageSettingsRequest removeRequest = new SetLanguageSettingsRequest
		{
			UniverseId = universeId,
			SettingsByLanguage = ((IEnumerable<ILanguageFamily>)languages).Select((Func<ILanguageFamily, LanguageSettings>)((ILanguageFamily x) => new LanguageSettings
			{
				LanguageType = (LanguageType)0,
				LanguageTypeTargetId = x.Id
			})).ToList()
		};
		try
		{
			_Client.RemoveLanguageSettings(removeRequest);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
	}

	public void AddSupportedLanguageFamiliesForGame(long universeId, IReadOnlyCollection<ILanguageFamily> languages)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		//IL_0057: Unknown result type (might be due to invalid IL or missing references)
		//IL_0088: Expected O, but got Unknown
		if (universeId == 0L)
		{
			throw new PlatformArgumentNullException("universeId");
		}
		if (languages == null || !languages.Any() || languages.Any((ILanguageFamily x) => x == null))
		{
			throw new PlatformArgumentNullException("languages");
		}
		SetLanguageSettingsRequest addRequest = new SetLanguageSettingsRequest
		{
			UniverseId = universeId,
			SettingsByLanguage = ((IEnumerable<ILanguageFamily>)languages).Select((Func<ILanguageFamily, LanguageSettings>)((ILanguageFamily x) => new LanguageSettings
			{
				LanguageType = (LanguageType)0,
				LanguageTypeTargetId = x.Id
			})).ToList()
		};
		try
		{
			_Client.AddLanguageSettings(addRequest);
		}
		catch (Exception e)
		{
			_Logger.Error(e);
			throw;
		}
	}

	private ILanguageFamily GetValidatedLanguageFamilyById(long languageId)
	{
		if (languageId == 0L)
		{
			throw new PlatformArgumentException($"A language id returned from the service was 0. LanguageId: {languageId}.");
		}
		try
		{
			int languageIdAsInt = Convert.ToInt32(languageId);
			return GetValidatedLanguageFamilyById(languageIdAsInt);
		}
		catch (OverflowException)
		{
			throw new PlatformArgumentException($"A language id returned from the service was larger than int.MaxValue. LanguageId: {languageId}.");
		}
		catch (PlatformArgumentException)
		{
			throw new PlatformArgumentException($"A language id returned from the service was invalid. LanguageId: {languageId}.");
		}
	}

	private ILanguageFamily GetValidatedLanguageFamilyById(int languageId)
	{
		if (languageId == 0)
		{
			throw new PlatformArgumentException($"A language id provided was 0. LanguageId: {languageId}.");
		}
		return _CoreLocalizationAccessor.GetLanguageFamily(new LanguageFamilyIdentifier(languageId)) ?? throw new PlatformArgumentException($"A language id could not be found. LanguageId: {languageId}.");
	}
}
