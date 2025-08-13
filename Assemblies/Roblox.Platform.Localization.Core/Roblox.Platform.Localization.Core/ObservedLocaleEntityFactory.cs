using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class ObservedLocaleEntityFactory : IObservedLocaleEntityFactory
{
	private const string _NoDataObservedLocaleCode = "NO_DATA";

	public IObservedLocaleEntity Get(int id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "id"));
		}
		return CalToCachedMssql(ObservedLocale.Get(id));
	}

	public IObservedLocaleEntity Get(IDeviceReportedLocaleIdentifier identifier)
	{
		if (identifier != null)
		{
			return Get(identifier.Id);
		}
		return null;
	}

	public IObservedLocaleEntity GetByLocale(string locale)
	{
		if (string.IsNullOrWhiteSpace(locale))
		{
			locale = "NO_DATA";
		}
		return CalToCachedMssql(ObservedLocale.GetByLocale(locale));
	}

	public IObservedLocaleEntity Create(string locale, int? languageId, int? supportedLocaleId)
	{
		ValidateLanguageId(languageId);
		ValidateSupportedLocaleId(supportedLocaleId);
		if (string.IsNullOrWhiteSpace(locale))
		{
			locale = "NO_DATA";
		}
		return CalToCachedMssql(ObservedLocale.Create(locale, languageId, supportedLocaleId));
	}

	private static IObservedLocaleEntity CalToCachedMssql(ObservedLocale cal)
	{
		if (cal != null)
		{
			return new ObservedLocaleCachedMssqlEntity
			{
				Id = cal.ID,
				Locale = ((cal.Locale != "NO_DATA") ? cal.Locale : string.Empty),
				LanguageId = cal.LanguageID,
				SupportedLocaleId = cal.SupportedLocaleID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	private void ValidateLanguageId(int? languageId)
	{
		if (languageId.HasValue && languageId.Value <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "languageId"));
		}
	}

	private void ValidateSupportedLocaleId(int? supportedLocaleId)
	{
		if (supportedLocaleId.HasValue && supportedLocaleId.Value <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "supportedLocaleId"));
		}
	}
}
