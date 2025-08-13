using System;
using System.Collections.Generic;
using System.Linq;
using PhoneNumbers;
using Roblox.Configuration;
using Roblox.EphemeralCounters;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;
using Roblox.Platform.Demographics.Entities.Audit;
using Roblox.Platform.Demographics.Properties;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an implementation of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" />.
public class AccountPhoneNumberFactory : IAccountPhoneNumberFactory
{
	private readonly DemographicsDomainFactories _DomainFactories;

	private readonly IAccountSecurityTicketsFactory _AccountSecurityTicketsFactory;

	private readonly IEmailSender _EmailSender;

	private readonly IEphemeralCounterFactory _EphemeralCounterFactory;

	private const short _DefaultNumberOfVisiblePhoneDigits = 4;

	private const char _DefaultPhoneNumberMaskingCharacter = '*';

	private const string _PhoneNumberEmailType = "PhoneNumberChanged";

	private const string _PhoneNumberEmailFrom = "\"Roblox Phone Number Added or Changed\" <no-reply@roblox.com>";

	private const string _PhoneNumberEmailSubject = "Roblox Phone Number Added or Changed";

	private const string _RevertPhoneNumberEmailBodyPlainText = "We noticed that a phone number was added or changed for your Roblox account: {0}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action: {1}";

	private const string _RevertPhoneNumberEmailBodyHtml = "We noticed that a phone number was added or changed for your Roblox account: {0}. \r\n<br />If you didn't intend to change it, or you think someone else changed it by mistake, please undo the action by clicking the button below.\r\n<br /><br /><a href=\"{1}\"><button>Revert Account</button></a>";

	private const string _AddUnverifiedPhoneNumberAttemptCounter = "AddUnverifiedPhoneNumber_Attempt";

	private const string _AddUnverifiedPhoneNumberSuccessCounter = "AddUnverifiedPhoneNumber_Success";

	private const string _AddUnverifiedPhoneNumberFailureCounter = "AddUnverifiedPhoneNumbe_Failure";

	private const string _AddUnverifiedInvalidPhoneNumberFailureCounter = "AddUnverifiedPhoneNumber_InvalidPhone";

	private const string _AddUnverifiedPhoneNumberUserHasANumberFailureCounter = "AddUnverifiedPhoneNumber_UserHasNumber";

	private const string _DeletePhoneNumberAttemptCounter = "AcntPhoneNumberFtry_DeletePhoneNumber_Attempt";

	private const string _DeletePhoneNumberSuccessCounter = "AcntPhoneNumberFtry_DeletePhoneNumber_Success";

	private const string _DeletePhoneNumberFailureCounter = "AcntPhoneNumberFtry_DeletePhoneNumber_Failure";

	private const string _GetVerifiedPhoneNumberAttemptCounter = "GetVerifiedPhoneNumber_Attempt";

	private const string _GetVerifiedPhoneNumberSuccessCounter = "GetVerifiedPhoneNumber_Success";

	private const string _GetVerifiedPhoneNumberFailureCounter = "GetVerifiedPhoneNumber_Failure";

	private const string _GetVerifiedPhoneNumberNotAllowedCounter = "GetVerifiedPhoneNumber_NotAllowed";

	private const string _GetVerifiedPhoneNumberNotFoundCounter = "GetVerifiedPhoneNumber_NoPhoneFound";

	private const string _GetByPhoneNumberAttemptCounter = "AcntPhoneNumberFtry_GetByPhoneNumber_Attempt";

	private const string _GetByPhoneNumberSuccessCounter = "AcntPhoneNumberFtry_GetByPhoneNumber_Success";

	private const string _GetByPhoneNumberNotFoundCounter = "AcntPhoneNumberFtry_GetByPhoneNumber_Notfound";

	private const string _GetByPhoneNumberFailureCounter = "AcntPhoneNumberFtry_GetByPhoneNumber_Failure";

	private const string _GetByPhoneNumberInvalidPhoneNumberFailureCounter = "AcntPhoneNumberFtry_GetByPhoneNumber_InvalidPhone";

	internal virtual bool IsAuditingEnabled => Settings.Default.IsAccountPhoneNumberTableAuditingEnabled;

	internal virtual bool ArePhoneNumberEphemeralCountersEnabled => Settings.Default.ArePhoneNumberEphemeralCountersEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.AccountPhoneNumberFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Demographics.DemographicsDomainFactories" /></param>
	/// <param name="accountSecurityTicketsFactory">The <see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsFactory" />.</param>
	/// <param name="emailClient">The <see cref="!:IEmailClient" />.</param>
	/// <param name="ephemeralCounterFactory">The <see cref="T:Roblox.EphemeralCounters.IEphemeralCounterFactory" />.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"> If any of the args are null </exception>
	public AccountPhoneNumberFactory(DemographicsDomainFactories domainFactories, IAccountSecurityTicketsFactory accountSecurityTicketsFactory, IEmailSender emailClient, IEphemeralCounterFactory ephemeralCounterFactory)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
		_AccountSecurityTicketsFactory = accountSecurityTicketsFactory.AssignOrThrowIfNull("accountSecurityTicketsFactory");
		_EmailSender = emailClient.AssignOrThrowIfNull("emailClient");
		_EphemeralCounterFactory = ephemeralCounterFactory.AssignOrThrowIfNull("ephemeralCounterFactory");
	}

	internal void MigratePhoneNumberId(IAccountPhoneNumberEntity entity, IPhoneNumber phoneNumber, IUserIdentifier user)
	{
		entity.PhoneNumberId = phoneNumber.Id;
		entity.Update();
		CreateAuditPhoneNumber(entity, user, AccountPhoneNumberChangeTypes.DataMigration, null);
	}

	public IAccountPhoneNumber AddUnverifiedForUser(IUser user, string internationalPrefixNumber, string nationalNumber, string twoLetterCountryCode, IUser actorUser)
	{
		IncrementEphemeralCounter("AddUnverifiedPhoneNumber_Attempt");
		if (!CheckUserCanHavePhoneNumber(user))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumbe_Failure");
			throw new PlatformArgumentException("User cannot have phone number");
		}
		if (string.IsNullOrWhiteSpace(internationalPrefixNumber))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumbe_Failure");
			throw new PlatformArgumentException("internationalPrefixNumber");
		}
		if (string.IsNullOrWhiteSpace(nationalNumber))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumbe_Failure");
			throw new PlatformArgumentException("nationalNumber");
		}
		if (string.IsNullOrWhiteSpace(twoLetterCountryCode))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumbe_Failure");
			throw new PlatformArgumentException("twoLetterCountryCode");
		}
		if (!_DomainFactories.PhoneNumberValidator.IsValid(internationalPrefixNumber, nationalNumber, twoLetterCountryCode))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumber_InvalidPhone");
			throw new PlatformInvalidPhoneNumberException();
		}
		IPhoneNumber phoneNumber = _DomainFactories.PhoneNumberFactory.GetOrCreate(internationalPrefixNumber, nationalNumber, twoLetterCountryCode);
		if (DoesPhoneNumberAlreadyExist(phoneNumber.Id))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumber_UserHasNumber");
			throw new PlatformPhoneNumberAlreadyActiveException("phoneNumber", "Number is already associated with another account.");
		}
		IAccountPhoneNumber result = CreateNew(user, phoneNumber, actorUser);
		IncrementEphemeralCounter("AddUnverifiedPhoneNumber_Success");
		return result;
	}

	[Obsolete("Use AddUnverifiedForUser(IUser user, string internationalPrefixNumber, string nationalNumber, string twoLetterCountryCode, IUser actorUser)")]
	public IAccountPhoneNumber AddUnverifiedForUser(IUser user, string simplePhoneNumber, IUser actorUser)
	{
		IncrementEphemeralCounter("AddUnverifiedPhoneNumber_Attempt");
		if (!CheckUserCanHavePhoneNumber(user))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumbe_Failure");
			throw new PlatformArgumentException("User cannot have phone number");
		}
		if (!_DomainFactories.PhoneNumberValidator.IsValid(simplePhoneNumber))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumber_InvalidPhone");
			throw new PlatformArgumentException("simplePhoneNumber");
		}
		IPhoneNumber phoneNumber = _DomainFactories.PhoneNumberFactory.GetOrCreate(simplePhoneNumber);
		if (DoesPhoneNumberAlreadyExist(phoneNumber.Id))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumber_UserHasNumber");
			throw new PlatformPhoneNumberAlreadyActiveException("phoneNumber", "Number is already associated with another account.");
		}
		IAccountPhoneNumber result = CreateNew(user, phoneNumber, actorUser);
		IncrementEphemeralCounter("AddUnverifiedPhoneNumber_Success");
		return result;
	}

	public IAccountPhoneNumber AddUnverifiedForUser(IUser user, IPhoneNumber phoneNumber, IUser actorUser)
	{
		IncrementEphemeralCounter("AddUnverifiedPhoneNumber_Attempt");
		if (DoesPhoneNumberAlreadyExist(phoneNumber.Id))
		{
			IncrementEphemeralCounter("AddUnverifiedPhoneNumber_UserHasNumber");
			throw new PlatformPhoneNumberAlreadyActiveException("phoneNumber", "Number is already associated with another account.");
		}
		IAccountPhoneNumber result = CreateNew(user, phoneNumber, actorUser);
		IncrementEphemeralCounter("AddUnverifiedPhoneNumber_Success");
		return result;
	}

	public IAccountPhoneNumber GetVerifiedForUser(IUser user)
	{
		IncrementEphemeralCounter("GetVerifiedPhoneNumber_Attempt");
		if (!CheckUserCanHavePhoneNumber(user))
		{
			IncrementEphemeralCounter("GetVerifiedPhoneNumber_NotAllowed");
			return null;
		}
		long accountId = user.AccountId;
		IAccountPhoneNumberEntity entity = _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdIsVerifiedAndIsActiveEnumerative(accountId, true, true, 1).FirstOrDefault();
		if (entity == null)
		{
			IncrementEphemeralCounter("GetVerifiedPhoneNumber_NoPhoneFound");
			return null;
		}
		IPhoneNumber phoneNumber = GetOrCreateIPhoneNumberFromAccountPhoneNumberEntity(entity);
		try
		{
			IAccountPhoneNumber fromEntity = GetFromEntity(entity, phoneNumber, user);
			IncrementEphemeralCounter("GetVerifiedPhoneNumber_Success");
			return fromEntity;
		}
		catch (PlatformArgumentNullException)
		{
			IncrementEphemeralCounter("GetVerifiedPhoneNumber_Failure");
			return null;
		}
	}

	public IAccountPhoneNumber GetByPhoneNumber(IPhoneNumberIdentifier phoneNumberIdentifier)
	{
		if (phoneNumberIdentifier == null)
		{
			throw new PlatformArgumentNullException("phoneNumberIdentifier");
		}
		IAccountPhoneNumberEntity accountPhoneNumberEntity = _DomainFactories.AccountPhoneNumberEntityFactory.GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(phoneNumberIdentifier.Id, true, true, 1)?.FirstOrDefault();
		if (accountPhoneNumberEntity == null)
		{
			return null;
		}
		IPhoneNumber phoneNumberEntity = _DomainFactories.PhoneNumberFactory.Get(phoneNumberIdentifier);
		if (phoneNumberEntity != null)
		{
			return GetFromEntity(accountPhoneNumberEntity, phoneNumberEntity);
		}
		return null;
	}

	/// <inheritdoc />
	public ICollection<IAccountPhoneNumber> GetByPhoneNumberIsVerifiedAndIsActive(IPhoneNumberIdentifier phoneNumberIdentifier, bool isVerified, bool isActive, int count, int? exclusiveStartId = null)
	{
		if (phoneNumberIdentifier == null)
		{
			throw new PlatformArgumentNullException(string.Format("'{0}' must not be null.", "phoneNumberIdentifier"));
		}
		if (count <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive.", "count"));
		}
		IPhoneNumber phoneNumberEntity = _DomainFactories.PhoneNumberFactory.Get(phoneNumberIdentifier);
		if (phoneNumberEntity == null)
		{
			return new List<IAccountPhoneNumber>();
		}
		return (from accountPhoneNumberEntity in _DomainFactories.AccountPhoneNumberEntityFactory.GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(phoneNumberIdentifier.Id, isVerified, isActive, count, exclusiveStartId)
			select GetFromEntity(accountPhoneNumberEntity, phoneNumberEntity)).ToList();
	}

	public IAccountPhoneNumber GetByPhoneNumber(string target)
	{
		IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Attempt");
		if (string.IsNullOrEmpty(target))
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Failure");
			throw new PlatformArgumentNullException("target");
		}
		string[] phoneNumberData = target.Split(',');
		if (phoneNumberData.Length != 3)
		{
			throw new PlatformInvalidPhoneNumberException("Phone number should have 3 parts, received " + phoneNumberData.Length);
		}
		string internationalPrefixNumber = phoneNumberData[0].Trim();
		string nationalNumber = phoneNumberData[1].Trim();
		string twoLetterCountryCode = phoneNumberData[2].Trim().ToUpper();
		return GetByPhoneNumber(internationalPrefixNumber, nationalNumber, twoLetterCountryCode);
	}

	public IAccountPhoneNumber GetByPhoneNumber(string internationalPrefixNumber, string nationalNumber, string twoLetterCountryCode)
	{
		IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Attempt");
		if (string.IsNullOrEmpty(nationalNumber))
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Failure");
			throw new PlatformArgumentNullException("nationalNumber");
		}
		if (string.IsNullOrEmpty(internationalPrefixNumber))
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Failure");
			throw new PlatformArgumentNullException("internationalPrefixNumber");
		}
		if (string.IsNullOrEmpty(twoLetterCountryCode))
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Failure");
			throw new PlatformArgumentNullException("twoLetterCountryCode");
		}
		IPhoneNumber phoneNumberEntity = null;
		try
		{
			phoneNumberEntity = _DomainFactories.PhoneNumberFactory.GetByPhoneNumber(internationalPrefixNumber, nationalNumber, twoLetterCountryCode);
		}
		catch (PlatformInvalidPhoneNumberException)
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_InvalidPhone");
			throw;
		}
		if (phoneNumberEntity == null)
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Notfound");
			return null;
		}
		IAccountPhoneNumberEntity accountPhoneNumberEntity = _DomainFactories.AccountPhoneNumberEntityFactory.GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(phoneNumberEntity.Id, true, true, 1).FirstOrDefault();
		if (accountPhoneNumberEntity == null)
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Failure");
			return null;
		}
		IncrementEphemeralCounter("AcntPhoneNumberFtry_GetByPhoneNumber_Success");
		return GetFromEntity(accountPhoneNumberEntity, phoneNumberEntity);
	}

	public bool DeletePhoneNumberForUser(IUser user, IUser actorUser, int? exclusiveStartId = null)
	{
		IncrementEphemeralCounter("AcntPhoneNumberFtry_DeletePhoneNumber_Attempt");
		if (user == null)
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_DeletePhoneNumber_Failure");
			throw new PlatformArgumentNullException("user");
		}
		if (actorUser == null)
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_DeletePhoneNumber_Failure");
			throw new PlatformArgumentNullException("actorUser");
		}
		long accountId = user.AccountId;
		IEnumerable<IAccountPhoneNumberEntity> entities = (exclusiveStartId.HasValue ? _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdIsVerifiedAndIsActiveEnumerative(accountId, true, true, int.MaxValue, exclusiveStartId) : _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdIsVerifiedAndIsActiveEnumerative(accountId, true, true, int.MaxValue));
		if (entities == null)
		{
			IncrementEphemeralCounter("AcntPhoneNumberFtry_DeletePhoneNumber_Failure");
			return false;
		}
		foreach (IAccountPhoneNumberEntity entity in entities)
		{
			CreateAuditPhoneNumber(entity, user, AccountPhoneNumberChangeTypes.PhoneNumberDeleted, actorUser);
			entity.IsActive = false;
			entity.Update();
		}
		IncrementEphemeralCounter("AcntPhoneNumberFtry_DeletePhoneNumber_Success");
		return true;
	}

	public void PurgePhoneNumber(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		PurgePhoneEntities(user, 1000);
		PurgeAccountPhoneAudit(user, 1000);
	}

	internal void PurgePhoneEntities(IUser user, int pageSize)
	{
		List<IAccountPhoneNumberEntity> entities = new List<IAccountPhoneNumberEntity>();
		do
		{
			entities = _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdEnumerative(user.AccountId, pageSize).ToList();
			foreach (IAccountPhoneNumberEntity item in entities)
			{
				int? phoneNumberId = item.PhoneNumberId;
				item.Delete();
				if (phoneNumberId.HasValue && IsPhoneNumberUnused(phoneNumberId.Value))
				{
					_DomainFactories.PhoneNumberEntityFactory.Get(phoneNumberId.Value).Delete();
				}
			}
		}
		while (entities.Any());
	}

	private bool? GetValue(int i)
	{
		return i switch
		{
			0 => null, 
			1 => true, 
			2 => false, 
			_ => throw new Exception($"Unexpected case {i}"), 
		};
	}

	internal virtual bool IsPhoneNumberUnused(int phoneNumberId)
	{
		for (int i = 0; i < 3; i++)
		{
			for (int j = 0; j < 3; j++)
			{
				if (_DomainFactories.AccountPhoneNumberEntityFactory.GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(phoneNumberId, GetValue(i), GetValue(j), 2).Any())
				{
					return false;
				}
			}
		}
		return true;
	}

	internal void PurgeAccountPhoneAudit(IUser user, int pageSize)
	{
		List<IAccountPhoneNumbersAuditMetadataEntity> auditMetadata = new List<IAccountPhoneNumbersAuditMetadataEntity>();
		do
		{
			auditMetadata = _DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.GetByUserIdEnumerative(user.Id, pageSize, null).ToList();
			foreach (IAccountPhoneNumbersAuditMetadataEntity data in auditMetadata)
			{
				IAccountPhoneNumbersAuditEntryEntity byPublicId = _DomainFactories.AccountPhoneNumbersAuditEntryEntityFactory.GetByPublicId(data.AccountPhoneNumbersAuditEntriesPublicId);
				data.Delete();
				byPublicId?.Delete();
			}
		}
		while (auditMetadata.Any());
	}

	public IAccountPhoneNumber GetPendingVerificationPhoneNumber(IUser user)
	{
		if (!CheckUserCanHavePhoneNumber(user))
		{
			return null;
		}
		long accountId = user.AccountId;
		IAccountPhoneNumberEntity entity = _DomainFactories.AccountPhoneNumberEntityFactory.GetByAccountIdEnumerative(accountId, 1).FirstOrDefault();
		if (entity == null)
		{
			return null;
		}
		if (entity.IsVerified.HasValue && entity.IsVerified.Value)
		{
			return null;
		}
		IPhoneNumber phoneNumber = GetOrCreateIPhoneNumberFromAccountPhoneNumberEntity(entity);
		if (DoesPhoneNumberAlreadyExist(phoneNumber.Id))
		{
			throw new PlatformPhoneNumberAlreadyActiveException("phoneNumber", "Number is already associated with another account.");
		}
		return GetFromEntity(entity, phoneNumber, user);
	}

	public bool DoesPhoneNumberAlreadyExist(int phoneNumberId)
	{
		if (_DomainFactories.AccountPhoneNumberEntityFactory.GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(phoneNumberId, true, true, 1).Any())
		{
			return true;
		}
		return false;
	}

	public string GetMaskedAndFormattedPhoneNumberString(string phone, string countryCode, int numberOfVisibleDigits = 4, char maskCharacter = '*')
	{
		if (string.IsNullOrEmpty(phone))
		{
			return string.Empty;
		}
		if (string.IsNullOrEmpty(countryCode))
		{
			return string.Empty;
		}
		PhoneNumberUtil instance = PhoneNumberUtil.GetInstance();
		PhoneNumber phoneParsed = instance.Parse(phone, countryCode);
		phone = instance.Format(phoneParsed, (PhoneNumberFormat)1);
		if (phone.Length <= numberOfVisibleDigits)
		{
			return phone;
		}
		if (countryCode == "US" && numberOfVisibleDigits == 4)
		{
			return $"1 (***)***-{phone.Substring(Math.Max(0, phone.Length - numberOfVisibleDigits))}";
		}
		char[] splitPhoneNumber = phone.ToCharArray();
		int firstSpace = phone.IndexOf(" ");
		int digitsFound = 0;
		char[] maskedNumber = new char[splitPhoneNumber.Length];
		for (int i = splitPhoneNumber.Length - 1; i >= 0; i--)
		{
			if (i < firstSpace)
			{
				maskedNumber[i] = splitPhoneNumber[i];
			}
			else if (char.IsDigit(splitPhoneNumber[i]))
			{
				if (digitsFound < numberOfVisibleDigits)
				{
					maskedNumber[i] = splitPhoneNumber[i];
				}
				else
				{
					maskedNumber[i] = '*';
				}
				digitsFound++;
			}
			else
			{
				maskedNumber[i] = splitPhoneNumber[i];
			}
		}
		return new string(maskedNumber);
	}

	public bool SendRevertPhoneNumberEmail(IUser user, AccountEmailAddress accountEmailAddress)
	{
		string accountSecurityTicket = CreateAccountSecurityTicket(user, accountEmailAddress);
		Guid empty = Guid.Empty;
		if (!accountSecurityTicket.Equals(empty.ToString()))
		{
			Roblox.Platform.Email.Delivery.Email emailModel = new Roblox.Platform.Email.Delivery.Email("\"Roblox Phone Number Added or Changed\" <no-reply@roblox.com>", accountEmailAddress.GetEmailAddress().Address, "Roblox Phone Number Added or Changed", EmailBodyType.Mime, "PhoneNumberChanged", BuildRevertEmail(user, accountSecurityTicket, isHtmlFormat: false), BuildRevertEmail(user, accountSecurityTicket, isHtmlFormat: true));
			_EmailSender.SendEmail(emailModel);
		}
		return true;
	}

	private void CreateAuditPhoneNumber(IAccountPhoneNumberEntity accountPhoneNumberEntity, IUserIdentifier user, AccountPhoneNumberChangeTypes changeType, IUserIdentifier actorUser)
	{
		if (IsAuditingEnabled)
		{
			IAccountPhoneNumbersAuditEntryEntity auditEntryEntity = _DomainFactories.AccountPhoneNumbersAuditEntryEntityFactory.CreateNew(accountPhoneNumberEntity);
			if (auditEntryEntity != null)
			{
				_DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.CreateNew(user, auditEntryEntity.PublicId, changeType, actorUser);
			}
		}
	}

	private static bool CheckUserCanHavePhoneNumber(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		return user.AgeBracket == Roblox.Platform.Membership.AgeBracket.Age13OrOver;
	}

	private IPhoneNumber GetOrCreateIPhoneNumberFromAccountPhoneNumberEntity(IAccountPhoneNumberEntity entity)
	{
		IPhoneNumber phonenumber = null;
		if (entity.PhoneNumberId.HasValue)
		{
			phonenumber = _DomainFactories.PhoneNumberFactory_Internal.GetById(entity.PhoneNumberId.Value);
		}
		else
		{
			try
			{
				phonenumber = _DomainFactories.PhoneNumberFactory.GetOrCreate(entity.Phone);
			}
			catch (Exception ex)
			{
				ExceptionHandler.LogException(ex);
			}
		}
		return phonenumber;
	}

	private IAccountPhoneNumber CreateNew(IUser user, IPhoneNumber phoneNumber, IUserIdentifier actorUserIdentifier)
	{
		long accountId = user.AccountId;
		IAccountPhoneNumberEntity entity = _DomainFactories.AccountPhoneNumberEntityFactory.CreateNew(accountId, phoneNumber);
		IAccountPhoneNumber fromEntity = GetFromEntity(entity, phoneNumber, user);
		CreateAuditPhoneNumber(entity, user, AccountPhoneNumberChangeTypes.UnverifiedPhoneNumberEntered, actorUserIdentifier);
		return fromEntity;
	}

	private IAccountPhoneNumber GetFromEntity(IAccountPhoneNumberEntity entity, IPhoneNumber phoneNumber, IUserIdentifier user = null)
	{
		if (!entity.PhoneNumberId.HasValue && user != null)
		{
			MigratePhoneNumberId(entity, phoneNumber, user);
		}
		ICountryIdentifier countryIdentifier = phoneNumber.InternationalPrefix?.CountryIdentifier;
		ICountry country = ((countryIdentifier != null) ? _DomainFactories.CountryFactory.Get(countryIdentifier) : null);
		return new AccountPhoneNumber(_DomainFactories, entity, phoneNumber, country);
	}

	internal virtual string BuildRevertPhoneNumberUrl(string ticket)
	{
		return $"{RobloxEnvironment.WebsiteHttpsUrl}{Settings.Default.AccountSecurityTicketRevertUrl}{ticket}";
	}

	internal string BuildRevertEmail(IUser user, string ticket, bool isHtmlFormat)
	{
		if (!isHtmlFormat)
		{
			return $"We noticed that a phone number was added or changed for your Roblox account: {user.Name}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action: {BuildRevertPhoneNumberUrl(ticket)}";
		}
		return $"We noticed that a phone number was added or changed for your Roblox account: {user.Name}. \r\n<br />If you didn't intend to change it, or you think someone else changed it by mistake, please undo the action by clicking the button below.\r\n<br /><br /><a href=\"{BuildRevertPhoneNumberUrl(ticket)}\"><button>Revert Account</button></a>";
	}

	internal virtual string CreateAccountSecurityTicket(IUser user, AccountEmailAddress accountEmailAddress)
	{
		Account account = Account.Get(user.AccountId);
		AccountPasswordHash accountPasswordHash = AccountPasswordHash.GetCurrent(user.AccountId);
		AccountSecurityTicket accountSecurityTicket = AccountSecurityTicket.CreateNew(account, accountEmailAddress, accountPasswordHash);
		IAccountPhoneNumber verifiedNumber = GetVerifiedForUser(user);
		_AccountSecurityTicketsFactory.CreateAccountSecurityTickets(account.ID, accountSecurityTicket.GUID, accountEmailAddress.ID, accountPasswordHash.ID, verifiedNumber?.PhoneNumberId);
		return accountSecurityTicket.GUID.ToString();
	}

	private void IncrementEphemeralCounter(string counterName)
	{
		if (ArePhoneNumberEphemeralCountersEnabled)
		{
			_EphemeralCounterFactory.GetCounter(counterName).IncrementInBackground();
		}
	}
}
