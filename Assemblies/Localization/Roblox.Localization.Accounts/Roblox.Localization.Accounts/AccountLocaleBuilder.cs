using System;
using System.Data.SqlClient;
using Roblox.EventLog;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Localization.Accounts.Implementations;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Core;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountLocaleBuilder : IAccountLocaleBuilder
{
	private readonly IAccountLocaleEntityFactory _AccountLocaleEntityFactory;

	private readonly IAccountLocaleFloodCheckerFactory _AccountLocaleFloodCheckerFactory;

	private readonly ISupportedLocaleAndLanguageMapper _SupportedLocaleAndLanguageMapper;

	private readonly ISettings _Settings;

	private readonly IAccountLocaleAuditBuilder _AccountLocaleAuditBuilder;

	private readonly IAccountLocalesAuditParameterValidator _AccountLocalesAuditParameterValidator;

	private readonly ICoreLocalizationBuilder _CoreLocalizationBuilder;

	private readonly ILogger _Logger;

	private const int _UniqueKeySqlExceptionNumber = 2601;

	private const string _UniqueKeySqlExceptionMessageStart = "Cannot insert duplicate key";

	private const string _NoDataObservedLocaleCode = "";

	private readonly Lazy<IDeviceReportedLocaleIdentifier> _NoDataDeviceReportedLocale;

	private bool IsSupportedLocaleChangedEventEnabled => _Settings.IsSupportedLocaleChangedEventEnabled;

	public event SupportedLocaleChangedByUserEventHandler SupportedLocaleChangedByUser;

	public AccountLocaleBuilder(IAccountLocaleEntityFactory accountLocaleEntityFactory, ISupportedLocaleAndLanguageMapper supportedLocaleAndLanguageMapper, IAccountLocaleFloodCheckerFactory accountLocaleFloodCheckerFactory, ISettings settings, IAccountLocaleAuditBuilder accountLocaleAuditBuilder, IAccountLocalesAuditParameterValidator accountLocalesAuditParameterValidator, ICoreLocalizationBuilder coreLocalizationBuilder, ILogger logger)
	{
		_AccountLocaleFloodCheckerFactory = accountLocaleFloodCheckerFactory ?? throw new PlatformArgumentNullException("accountLocaleFloodCheckerFactory");
		_SupportedLocaleAndLanguageMapper = supportedLocaleAndLanguageMapper ?? throw new PlatformArgumentNullException("supportedLocaleAndLanguageMapper");
		_AccountLocaleEntityFactory = accountLocaleEntityFactory ?? throw new PlatformArgumentNullException("accountLocaleEntityFactory");
		_Settings = settings ?? throw new PlatformArgumentNullException("settings");
		_AccountLocaleAuditBuilder = accountLocaleAuditBuilder ?? throw new PlatformArgumentNullException("accountLocaleAuditBuilder");
		_AccountLocalesAuditParameterValidator = accountLocalesAuditParameterValidator ?? throw new PlatformArgumentNullException("accountLocalesAuditParameterValidator");
		_CoreLocalizationBuilder = coreLocalizationBuilder ?? throw new PlatformArgumentNullException("coreLocalizationBuilder");
		_Logger = logger ?? throw new PlatformArgumentNullException("logger");
		_NoDataDeviceReportedLocale = new Lazy<IDeviceReportedLocaleIdentifier>(GetNoDataLocale);
	}

	public void SetSupportedLocale(long accountId, ISupportedLocale supportedLocale, IAccountLocalesChangeAgent changeAgent)
	{
		IAccountLocaleEntity accountLocaleEntity = ValidateAndGetAccountLocaleEntity(accountId);
		if (accountLocaleEntity.SupportedLocaleId != supportedLocale?.Id)
		{
			IFloodChecker supportedLocaleUpdateFloodChecker = _AccountLocaleFloodCheckerFactory.GetSupportedLocaleUpdateFloodChecker(accountId);
			if (supportedLocaleUpdateFloodChecker.IsFlooded())
			{
				throw new PlatformFloodedException("supportedLocaleUpdateFloodChecker");
			}
			int? previousAccountLocaleId = accountLocaleEntity.SupportedLocaleId;
			accountLocaleEntity.SupportedLocaleId = supportedLocale?.Id;
			accountLocaleEntity.Update();
			try
			{
				_AccountLocalesAuditParameterValidator.ValidateChangeAgent(changeAgent);
				_AccountLocaleAuditBuilder.CreateAuditRecords(accountLocaleEntity, changeAgent, AccountLocalesAuditEntryMetadataType.SupportedLocaleSetOrChanged);
			}
			catch (Exception ex)
			{
				_Logger.Error(ex);
			}
			supportedLocaleUpdateFloodChecker.UpdateCount();
			SendSupportedLocaleChangedByUserEvent(accountId, previousAccountLocaleId, supportedLocale?.Id, accountId);
		}
	}

	public void SetObservedLocale(long accountId, IDeviceReportedLocaleIdentifier deviceReportedLocale, IAccountLocalesChangeAgent changeAgent)
	{
		IAccountLocaleEntity accountLocaleEntity = ValidateAndGetAccountLocaleEntity(accountId);
		ValidateReportedLocaleIdentifier(deviceReportedLocale);
		if (ShouldAccountLocaleBeUpdatedBasedOnRequest(accountLocaleEntity, deviceReportedLocale))
		{
			accountLocaleEntity.ObservedLocaleId = deviceReportedLocale.Id;
			accountLocaleEntity.Update();
			try
			{
				_AccountLocalesAuditParameterValidator.ValidateChangeAgent(changeAgent);
				_AccountLocaleAuditBuilder.CreateAuditRecords(accountLocaleEntity, changeAgent, AccountLocalesAuditEntryMetadataType.ObservedLocaleSetOrChanged);
			}
			catch (Exception e)
			{
				_Logger.Error($"Unable to create audit records. Message: {e}.");
			}
		}
	}

	public IAccountLocale CreateAccountLocale(long accountId, IDeviceReportedLocaleIdentifier deviceReportedLocale, ISupportedLocale supportedLocale, IAccountLocalesChangeAgent changeAgent)
	{
		ValidateReportedLocaleIdentifier(deviceReportedLocale);
		IAccountLocaleEntity accountLocaleEntity;
		try
		{
			accountLocaleEntity = _AccountLocaleEntityFactory.Create(accountId, deviceReportedLocale.Id, supportedLocale?.Id);
		}
		catch (SqlException sqlException)
		{
			if (IsDuplicateKeyException(sqlException))
			{
				throw new DuplicateKeyException($"AccountLocale with accountId {accountId} already present in database.");
			}
			throw;
		}
		try
		{
			if (_Settings.IsAccountLocalesTableAuditingEnabled)
			{
				_AccountLocaleAuditBuilder.CreateAuditRecords(accountLocaleEntity, changeAgent, AccountLocalesAuditEntryMetadataType.ObservedLocaleSetOrChanged);
				_AccountLocaleAuditBuilder.CreateAuditRecords(accountLocaleEntity, changeAgent, AccountLocalesAuditEntryMetadataType.SupportedLocaleSetOrChanged);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		ISupportedLocale mappedSupportedLocale = _SupportedLocaleAndLanguageMapper.MapSupportedLocale(accountLocaleEntity);
		ILanguageFamily language = _SupportedLocaleAndLanguageMapper.MapLangauge(accountLocaleEntity);
		return new Roblox.Platform.Localization.Accounts.Implementations.AccountLocale
		{
			AccountId = accountId,
			SupportedLocale = mappedSupportedLocale,
			NativeLanguage = language
		};
	}

	private bool ReportedLocaleHasData(IDeviceReportedLocaleIdentifier requestDeviceReportedLocale)
	{
		if (_NoDataDeviceReportedLocale.Value == null)
		{
			return false;
		}
		return requestDeviceReportedLocale.Id != _NoDataDeviceReportedLocale.Value.Id;
	}

	private bool ShouldAccountLocaleBeUpdatedBasedOnRequest(IAccountLocaleEntity accountLocaleEntity, IDeviceReportedLocaleIdentifier requestDeviceReportedLocaleIdentifier)
	{
		if (accountLocaleEntity.ObservedLocaleId == requestDeviceReportedLocaleIdentifier.Id || !ReportedLocaleHasData(requestDeviceReportedLocaleIdentifier))
		{
			return false;
		}
		IFloodChecker observedLocaleUpdateFloodChecker = _AccountLocaleFloodCheckerFactory.GetObservedLocaleUpdateFloodChecker(accountLocaleEntity.AccountId);
		bool num = !observedLocaleUpdateFloodChecker.IsFlooded();
		if (num)
		{
			observedLocaleUpdateFloodChecker.UpdateCount();
		}
		return num;
	}

	private void ValidateReportedLocaleIdentifier(IDeviceReportedLocaleIdentifier deviceReportedLocaleIdentifier)
	{
		if (deviceReportedLocaleIdentifier == null)
		{
			throw new PlatformArgumentNullException("deviceReportedLocaleIdentifier");
		}
	}

	private bool IsDuplicateKeyException(SqlException sqlException)
	{
		if (sqlException.Number != 2601)
		{
			return sqlException.Message.StartsWith("Cannot insert duplicate key");
		}
		return true;
	}

	internal void SendSupportedLocaleChangedByUserEvent(long accountId, int? previousSupportedLocaleId, int? newSupportedLocaleId, long actorAccountId)
	{
		try
		{
			if (IsSupportedLocaleChangedEventEnabled)
			{
				this.SupportedLocaleChangedByUser?.Invoke(accountId, previousSupportedLocaleId, newSupportedLocaleId, actorAccountId);
			}
		}
		catch (Exception)
		{
		}
	}

	private IDeviceReportedLocaleIdentifier GetNoDataLocale()
	{
		try
		{
			return _CoreLocalizationBuilder.RecordDeviceReportedLocale("");
		}
		catch (Exception exception)
		{
			_Logger.Error(exception);
		}
		return null;
	}

	private IAccountLocaleEntity ValidateAndGetAccountLocaleEntity(long accountId)
	{
		return _AccountLocaleEntityFactory.GetByAccountId(accountId) ?? throw new PlatformArgumentException("accountLocaleEntity");
	}
}
