using System.Collections.Generic;
using System.Data.SqlClient;
using Roblox.Platform.Core;

namespace Roblox.Platform.Localization.Core;

internal class CoreLocalizationBuilder : ICoreLocalizationBuilder
{
	private static readonly List<string> _TraditionalChineseLanguageIndicators = new List<string> { "zh_hant", "zh_tw", "zh_hk" };

	private const int _UniqueKeySqlExceptionNumber = 2601;

	private const string _UniqueKeySqlExceptionMessageStart = "Cannot insert duplicate key";

	private const string _ChineseOldLanguageCode = "zh";

	private const string _SimplifiedChineseLanguageCode = "zh-hans";

	private const string _TraditionalChineseLanguageCode = "zh-hant";

	private readonly ILanguageEntityFactory _LanguageEntityFactory;

	private readonly IObservedLocaleEntityFactory _ObservedLocaleEntityFactory;

	private readonly ILocaleParser _LocaleParser;

	public CoreLocalizationBuilder(IObservedLocaleEntityFactory observedLocaleEntityFactory, ILanguageEntityFactory languageEntityFactory, ILocaleParser localeParser)
	{
		_ObservedLocaleEntityFactory = observedLocaleEntityFactory ?? throw new PlatformArgumentNullException("observedLocaleEntityFactory");
		_LanguageEntityFactory = languageEntityFactory ?? throw new PlatformArgumentNullException("languageEntityFactory");
		_LocaleParser = localeParser ?? throw new PlatformArgumentNullException("localeParser");
	}

	public IDeviceReportedLocaleIdentifier RecordDeviceReportedLocale(string rawDeviceReportedLocaleCode)
	{
		string standardizedLocale = _LocaleParser.GetStandardizedLocaleFromRawLocaleString(rawDeviceReportedLocaleCode);
		IObservedLocaleEntity observedLocaleEntity = _ObservedLocaleEntityFactory.GetByLocale(standardizedLocale);
		if (observedLocaleEntity == null)
		{
			int? languageId = GetLanguageIdFromStandardizedLocale(standardizedLocale);
			try
			{
				observedLocaleEntity = _ObservedLocaleEntityFactory.Create(standardizedLocale, languageId, null);
			}
			catch (SqlException sqlException) when (IsDuplicateKeyException(sqlException))
			{
				observedLocaleEntity = _ObservedLocaleEntityFactory.GetByLocale(standardizedLocale);
			}
		}
		return new DeviceReportedLocaleIdentifier(observedLocaleEntity.Id);
	}

	public void MapDeviceReportedLocaleToLanguageFamily(IDeviceReportedLocale deviceReportedLocale, ILanguageFamily languageFamily)
	{
		if (languageFamily == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot null.", "languageFamily"));
		}
		ValidateLocaleInformation(deviceReportedLocale);
		IObservedLocaleEntity andValidateObservedLocaleEntity = GetAndValidateObservedLocaleEntity(deviceReportedLocale);
		andValidateObservedLocaleEntity.LanguageId = languageFamily.Id;
		andValidateObservedLocaleEntity.Update();
	}

	public void MapDeviceReportedLocaleToSupportedLocale(IDeviceReportedLocale deviceReportedLocale, ISupportedLocale supportedLocale)
	{
		if (supportedLocale == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot null.", "supportedLocale"));
		}
		ValidateLocaleInformation(deviceReportedLocale);
		IObservedLocaleEntity andValidateObservedLocaleEntity = GetAndValidateObservedLocaleEntity(deviceReportedLocale);
		andValidateObservedLocaleEntity.SupportedLocaleId = supportedLocale.Id;
		andValidateObservedLocaleEntity.Update();
	}

	private void ValidateLocaleInformation(IDeviceReportedLocale deviceReportedLocale)
	{
		if (deviceReportedLocale == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot null.", "deviceReportedLocale"));
		}
		if (deviceReportedLocale.DeviceReportedLocaleId == null)
		{
			throw new PlatformArgumentNullException(string.Format("{0} cannot null.", "DeviceReportedLocaleId"));
		}
	}

	private IObservedLocaleEntity GetAndValidateObservedLocaleEntity(IDeviceReportedLocale deviceReportedLocale)
	{
		return _ObservedLocaleEntityFactory.Get(deviceReportedLocale.DeviceReportedLocaleId) ?? throw new PlatformArgumentException($"ObservedLocale with id {deviceReportedLocale.DeviceReportedLocaleId.Id} not found.");
	}

	private int? GetLanguageIdFromStandardizedLocale(string standardizedLocale)
	{
		string languageCode = _LocaleParser.GetLanguageCodeFromStandardizedLocale(standardizedLocale);
		if (!string.IsNullOrWhiteSpace(languageCode))
		{
			if (languageCode.Equals("zh"))
			{
				languageCode = "zh-hans";
				foreach (string code in _TraditionalChineseLanguageIndicators)
				{
					if (standardizedLocale.Contains(code))
					{
						languageCode = "zh-hant";
						break;
					}
				}
			}
			return _LanguageEntityFactory.GetByLanguageCode(languageCode)?.Id;
		}
		return null;
	}

	private bool IsDuplicateKeyException(SqlException sqlException)
	{
		if (sqlException == null)
		{
			return false;
		}
		if (sqlException.Number != 2601)
		{
			return sqlException.Message.StartsWith("Cannot insert duplicate key");
		}
		return true;
	}
}
