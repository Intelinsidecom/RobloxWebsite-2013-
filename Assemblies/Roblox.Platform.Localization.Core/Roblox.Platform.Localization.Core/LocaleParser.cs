using System.Linq;
using System.Net.Http.Headers;
using Roblox.Common;

namespace Roblox.Platform.Localization.Core;

internal class LocaleParser : ILocaleParser
{
	public string GetLanguageCodeFromStandardizedLocale(string standardizedLocale)
	{
		if (string.IsNullOrWhiteSpace(standardizedLocale))
		{
			return "";
		}
		return standardizedLocale.Split('-', '_')[0].ToLower();
	}

	public string GetStandardizedLocaleFromRawLocaleString(string rawLocale)
	{
		if (string.IsNullOrWhiteSpace(rawLocale))
		{
			return "";
		}
		StringWithQualityHeaderValue locale = (from s in rawLocale.Split(',').Select(GetParsedValue)
			where s != null
			orderby s.Quality.GetValueOrDefault(1.0) descending
			select s).FirstOrDefault();
		if (locale == null)
		{
			return "";
		}
		return locale.Value.Replace("-", "_").ToLower();
	}

	public SupportedLocaleEnum? ParseLocaleCodeToSupportedLocaleEnum(string localeCode)
	{
		return EnumUtils.StrictTryParseEnum<SupportedLocaleEnum>(localeCode);
	}

	private StringWithQualityHeaderValue GetParsedValue(string input)
	{
		if (!StringWithQualityHeaderValue.TryParse(input, out var parsedValue))
		{
			return null;
		}
		return parsedValue;
	}
}
