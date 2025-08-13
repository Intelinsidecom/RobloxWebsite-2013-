using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class SupportedLocaleEntityFactory : ISupportedLocaleEntityFactory
{
	public ISupportedLocaleEntity Get(int id)
	{
		ValidateId(id);
		return CalToCachedMssql(SupportedLocale.Get(id));
	}

	public ISupportedLocaleEntity Get(ISupportedLocaleIdentifier id)
	{
		if (id != null)
		{
			return Get(id.Id);
		}
		return null;
	}

	public ISupportedLocaleEntity GetByLocale(string locale)
	{
		ValidateNotNullOrWhiteSpace(locale, "locale");
		return CalToCachedMssql(SupportedLocale.GetByLocale(locale));
	}

	public ISupportedLocaleEntity Create(string locale, string name, string nativeName, int languageId)
	{
		ValidateNotNullOrWhiteSpace(locale, "locale");
		ValidateNotNullOrWhiteSpace(name, "name");
		ValidateNotNullOrWhiteSpace(nativeName, "nativeName");
		ValidateLanguageId(languageId);
		return CalToCachedMssql(SupportedLocale.Create(locale, name, nativeName, languageId));
	}

	public IEnumerable<ISupportedLocaleEntity> GetSupportedLocalesPaged(int startRowIndex, int maxRows)
	{
		if (startRowIndex < 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' cannot be negative", "startRowIndex"));
		}
		if (maxRows <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "maxRows"));
		}
		return SupportedLocale.GetSupportedLocalesPaged(startRowIndex, maxRows).Select(CalToCachedMssql);
	}

	private static ISupportedLocaleEntity CalToCachedMssql(SupportedLocale cal)
	{
		if (cal != null)
		{
			return new SupportedLocaleCachedMssqlEntity
			{
				Id = cal.ID,
				Locale = cal.Locale,
				Name = cal.Name,
				NativeName = cal.NativeName,
				LanguageId = cal.LanguageID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	private void ValidateId(int id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "id"));
		}
	}

	private void ValidateLanguageId(int languageId)
	{
		if (languageId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "languageId"));
		}
	}

	private void ValidateNotNullOrWhiteSpace(string value, string parameterName)
	{
		if (string.IsNullOrWhiteSpace(value))
		{
			throw new PlatformArgumentException($"'{parameterName}' cannot be null or empty");
		}
	}
}
