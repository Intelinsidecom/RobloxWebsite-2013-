using System.Diagnostics.CodeAnalysis;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Core;

[ExcludeFromCodeCoverage]
internal class LanguageEntityFactory : ILanguageEntityFactory
{
	public ILanguageEntity Get(int id)
	{
		if (id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "id"));
		}
		return CalToCachedMssql(Language.Get(id));
	}

	public ILanguageEntity Get(ILanguageFamilyIdentifier id)
	{
		if (id != null)
		{
			return Get(id.Id);
		}
		return null;
	}

	public ILanguageEntity GetByName(string name)
	{
		ValidateLanguageName(name);
		return CalToCachedMssql(Language.GetByName(name));
	}

	public ILanguageEntity GetByLanguageCode(string languageCode)
	{
		ValidateLanguageCode(languageCode);
		return CalToCachedMssql(Language.GetByLanguageCode(languageCode));
	}

	public ILanguageEntity Create(string name, string nativeName, string languageCode)
	{
		ValidateLanguageName(name);
		ValidateLanguageCode(languageCode);
		if (string.IsNullOrWhiteSpace(nativeName))
		{
			throw new PlatformArgumentException(string.Format("'{0}' cannot be null or empty", "nativeName"));
		}
		return CalToCachedMssql(Language.Create(name, nativeName, languageCode));
	}

	private static ILanguageEntity CalToCachedMssql(Language cal)
	{
		if (cal != null)
		{
			return new LanguageCachedMssqlEntity
			{
				Id = cal.ID,
				Name = cal.Name,
				NativeName = cal.NativeName,
				LanguageCode = cal.LanguageCode,
				Created = cal.Created,
				Updated = cal.Updated
			};
		}
		return null;
	}

	private void ValidateLanguageName(string languageName)
	{
		if (string.IsNullOrWhiteSpace(languageName))
		{
			throw new PlatformArgumentException(string.Format("'{0}' cannot be null or empty", "languageName"));
		}
	}

	private void ValidateLanguageCode(string languageCode)
	{
		if (string.IsNullOrWhiteSpace(languageCode))
		{
			throw new PlatformArgumentException(string.Format("'{0}' cannot be null or empty", "languageCode"));
		}
	}
}
