using System;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Localization.Accounts.Properties;
using Roblox.Platform.Localization.Audit;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Localization.Accounts;

internal class AccountCountryBuilder : IAccountCountryBuilder
{
	private readonly IAccountCountryEntityFactory _AccountCountryEntityFactory;

	private readonly ICountryFactory _CountryFactory;

	private readonly IAccountCountriesAuditEntryEntityFactory _AccountCountriesAuditEntryEntityFactory;

	private readonly IAccountCountriesAuditMetadataEntityFactory _AccountCountriesAuditMetadataEntityFactory;

	private readonly ISettings _Settings;

	private readonly IAccountCountryFloodCheckerFactory _AccountCountryFloodCheckerFactory;

	private readonly IAuditParameterValidator _AuditParameterValidator;

	private bool IsCountryChangedEventEnabled => _Settings.IsCountryChangedEventEnabled;

	public event CountryChangedByUserEventHandler CountryChangedByUser;

	public AccountCountryBuilder(IAccountCountryEntityFactory accountCountryEntityFactory, ICountryFactory countryFactory, ISettings settings, IAccountCountriesAuditEntryEntityFactory accountCountriesAuditEntryEntityFactory, IAccountCountriesAuditMetadataEntityFactory accountCountriesAuditMetadataEntityFactory, IAccountCountriesAutomationTypeEntityFactory accountCountriesAutomationTypeEntityFactory, IUserFactory userFactory, IAccountCountryFloodCheckerFactory floodCheckerFactory)
	{
		_AccountCountryEntityFactory = accountCountryEntityFactory.AssignOrThrowIfNull("accountCountryEntityFactory");
		_CountryFactory = countryFactory.AssignOrThrowIfNull("countryFactory");
		_Settings = settings.AssignOrThrowIfNull("settings");
		_AccountCountriesAuditEntryEntityFactory = accountCountriesAuditEntryEntityFactory.AssignOrThrowIfNull("accountCountriesAuditEntryEntityFactory");
		_AccountCountriesAuditMetadataEntityFactory = accountCountriesAuditMetadataEntityFactory.AssignOrThrowIfNull("accountCountriesAuditMetadataEntityFactory");
		_AccountCountryFloodCheckerFactory = floodCheckerFactory.AssignOrThrowIfNull("floodCheckerFactory");
		_AuditParameterValidator = new AuditParameterValidator(settings, userFactory, accountCountriesAutomationTypeEntityFactory);
	}

	public void SetCountryVerifiedByUser(long accountId, ICountryIdentifier countryId, IAccountCountriesChangeAgent changeAgent)
	{
		ValidateCountryIdIsNotNull(countryId);
		ValidateCountryId(countryId);
		_AuditParameterValidator.ValidateChangeAgent(changeAgent);
		IFloodChecker accountCountryUpdateFloodChecker = _AccountCountryFloodCheckerFactory.GetAccountCountryUpdateFloodChecker(accountId);
		if (accountCountryUpdateFloodChecker.IsFlooded())
		{
			throw new PlatformFloodedException("accountCountryUpdateFloodChecker");
		}
		bool createdNewEntity;
		IAccountCountryEntity accountCountryEntity = _AccountCountryEntityFactory.GetOrCreate(accountId, out createdNewEntity);
		if (createdNewEntity)
		{
			CreateAuditRecords(accountCountryEntity, changeAgent);
		}
		int? previousCountry = accountCountryEntity.CountryId;
		UpdateAccountCountryEntity(accountCountryEntity, isVerified: true, countryId.Id, changeAgent);
		SendCountryChangedByUserEvent(accountId, previousCountry, countryId.Id, accountId);
		accountCountryUpdateFloodChecker.UpdateCount();
	}

	public void SetDerivedCountry(long accountId, ICountryIdentifier countryId, IAccountCountriesChangeAgent changeAgent)
	{
		_AuditParameterValidator.ValidateChangeAgent(changeAgent);
		bool createdNewEntity;
		IAccountCountryEntity accountCountryEntity = _AccountCountryEntityFactory.GetOrCreate(accountId, out createdNewEntity);
		if (createdNewEntity)
		{
			CreateAuditRecords(accountCountryEntity, changeAgent);
		}
		if (!accountCountryEntity.IsVerified)
		{
			if (countryId == null)
			{
				UpdateAccountCountryEntity(accountCountryEntity, isVerified: false, null, changeAgent);
				return;
			}
			ValidateCountryId(countryId);
			UpdateAccountCountryEntity(accountCountryEntity, isVerified: false, countryId.Id, changeAgent);
		}
	}

	private void ValidateCountryId(ICountryIdentifier countryId)
	{
		if (countryId.Id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "countryId"));
		}
		ICountry country = _CountryFactory.Get(countryId);
		if (country == null || country.Id <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' is not in the list of valid countries.", "countryId"));
		}
		if (!country.IsActive)
		{
			throw new PlatformArgumentException(string.Format("'{0}' is not active country.", "countryId"));
		}
	}

	private void ValidateCountryIdIsNotNull(ICountryIdentifier countryId)
	{
		if (countryId == null)
		{
			throw new PlatformArgumentNullException(string.Format("'{0}' cannot be null", "countryId"));
		}
	}

	internal void SendCountryChangedByUserEvent(long accountId, int? oldCountryId, int newCountryId, long actorAccountId)
	{
		try
		{
			if (IsCountryChangedEventEnabled)
			{
				this.CountryChangedByUser?.Invoke(accountId, oldCountryId, newCountryId, actorAccountId);
			}
		}
		catch (Exception)
		{
		}
	}

	private void UpdateAccountCountryEntity(IAccountCountryEntity accountCountryEntity, bool isVerified, int? countryId, IAccountCountriesChangeAgent changeAgent)
	{
		accountCountryEntity.IsVerified = isVerified;
		accountCountryEntity.CountryId = countryId;
		accountCountryEntity.Update();
		CreateAuditRecords(accountCountryEntity, changeAgent);
	}

	private void CreateAuditRecords(IAccountCountryEntity accountCountryEntity, IAccountCountriesChangeAgent changeAgent)
	{
		try
		{
			if (_Settings.IsAccountCountriesTableAuditingEnabled)
			{
				IAccountCountriesAuditEntryEntity auditEntry = _AccountCountriesAuditEntryEntityFactory.Create(accountCountryEntity);
				_AccountCountriesAuditMetadataEntityFactory.Create(auditEntry, AccountCountriesAuditEntryMetadataType.CountrySetOrChanged, changeAgent.ChangeAgentType, changeAgent.ChangeAgentTargetId);
			}
		}
		catch (Exception)
		{
		}
	}
}
