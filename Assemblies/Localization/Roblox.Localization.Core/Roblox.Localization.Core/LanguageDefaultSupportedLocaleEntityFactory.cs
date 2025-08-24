using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class LanguageDefaultSupportedLocaleEntityFactory : ILanguageDefaultSupportedLocaleEntityFactory
{
	public ILanguageDefaultSupportedLocaleEntity Get(int id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "id"));
		}
		return CalToCachedMssql(LanguageDefaultSupportedLocale.Get(id));
	}

	public ILanguageDefaultSupportedLocaleEntity GetByLanguageId(int languageId)
	{
		ValidateLanguageId(languageId);
		return CalToCachedMssql(LanguageDefaultSupportedLocale.GetByLanguageID(languageId));
	}

	public ILanguageDefaultSupportedLocaleEntity Create(int languageId, int supportedLocaleId)
	{
		ValidateLanguageId(languageId);
		if (supportedLocaleId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "supportedLocaleId"));
		}
		return CalToCachedMssql(LanguageDefaultSupportedLocale.Create(languageId, supportedLocaleId));
	}

	private static ILanguageDefaultSupportedLocaleEntity CalToCachedMssql(LanguageDefaultSupportedLocale cal)
	{
		if (cal != null)
		{
			return new LanguageDefaultSupportedLocaleCachedMssqlEntity
			{
				Id = cal.ID,
				LanguageId = cal.LanguageID,
				SupportedLocaleId = cal.SupportedLocaleID,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	private void ValidateLanguageId(int languageId)
	{
		if (languageId <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "languageId"));
		}
	}
}
