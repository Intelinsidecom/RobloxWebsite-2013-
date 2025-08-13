using System;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;
using Roblox.Platform.Demographics.Entities.Audit;
using Roblox.Platform.Demographics.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Demographics;

/// <summary>
/// Represents an implementation of <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumber" />.
/// </summary>
internal class AccountPhoneNumber : IAccountPhoneNumber
{
	private const short _DefaultNumberOfVisiblePhoneDigits = 4;

	private const char _DefaultPhoneNumberMaskingCharacter = '*';

	private readonly DemographicsDomainFactories _DomainFactories;

	private IPhoneNumber _PhoneNumber;

	public int Id { get; private set; }

	public long AccountId { get; private set; }

	public string FullPhoneNumber => _PhoneNumber?.FullPhoneNumber;

	public string E164PhoneNumber { get; private set; }

	public string Phone => FullPhoneNumber;

	public string CountryCode { get; private set; }

	public string Prefix { get; private set; }

	public int PhoneNumberId { get; private set; }

	public bool IsVerified { get; private set; }

	public bool IsActive { get; private set; }

	public DateTime Created { get; private set; }

	public DateTime Updated { get; private set; }

	internal virtual bool IsAuditingEnabled => Settings.Default.IsAccountPhoneNumberTableAuditingEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Demographics.AccountPhoneNumber" /> class.
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Demographics.DemographicsDomainFactories" /></param>
	/// <param name="entity">The entity.</param>
	/// <param name="phoneNumber">The phone number</param>
	/// <param name="country">The country of the phone number prefix. This may be null for old data</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if the passed in <see cref="T:Roblox.Platform.Demographics.Entities.AccountPhoneNumberCAL" /> is null.</exception>
	internal AccountPhoneNumber(DemographicsDomainFactories domainFactories, IAccountPhoneNumberEntity entity, IPhoneNumber phoneNumber, ICountry country)
	{
		if (entity == null)
		{
			throw new PlatformArgumentNullException("entity");
		}
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (entity.PhoneNumberId != phoneNumber.Id)
		{
			throw new PlatformArgumentNullException("wrong phone number for constructor");
		}
		_DomainFactories = domainFactories;
		Initialize(entity, phoneNumber, country);
	}

	private void Initialize(IAccountPhoneNumberEntity entity, IPhoneNumber phoneNumber, ICountry country)
	{
		_PhoneNumber = phoneNumber;
		ICountryIdentifier obj = _PhoneNumber?.InternationalPrefix?.CountryIdentifier;
		if (country?.Id != obj?.Id)
		{
			throw new PlatformArgumentNullException("country id mismatch");
		}
		E164PhoneNumber = phoneNumber.GetPhoneNumberInE164Format();
		Id = entity.Id;
		AccountId = entity.AccountId;
		PhoneNumberId = _PhoneNumber.Id;
		CountryCode = country?.Code;
		Prefix = _PhoneNumber?.InternationalPrefix?.Value;
		IsVerified = entity.IsVerified ?? false;
		IsActive = entity.IsActive ?? true;
		Created = entity.Created;
		Updated = entity.Updated;
	}

	private IAccountPhoneNumbersAuditEntryEntity Save()
	{
		IAccountPhoneNumberEntity entity = _DomainFactories.AccountPhoneNumberEntityFactory.Get(Id);
		if (entity == null)
		{
			throw new PlatformDataIntegrityException("Unable to find entity");
		}
		entity.AccountId = AccountId;
		entity.Phone = Phone;
		entity.PhoneNumberId = PhoneNumberId;
		entity.IsVerified = IsVerified;
		entity.IsActive = IsActive;
		entity.Update();
		if (!IsAuditingEnabled)
		{
			return null;
		}
		return _DomainFactories.AccountPhoneNumbersAuditEntryEntityFactory.CreateNew(entity);
	}

	public void SetToVerified(IUser user, IUserIdentifier actorUserIdentifier)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (actorUserIdentifier == null)
		{
			throw new PlatformArgumentNullException("actorUserIdentifier");
		}
		if (user.AccountId != AccountId)
		{
			throw new PlatformArgumentException("user does not match AccountPhoneNumber");
		}
		if (user.AgeBracket == Roblox.Platform.Membership.AgeBracket.AgeUnder13)
		{
			throw new PlatformArgumentException("user cannot have phone number");
		}
		IsVerified = true;
		IsActive = true;
		IAccountPhoneNumbersAuditEntryEntity auditEntryEntity = Save();
		if (auditEntryEntity != null)
		{
			_DomainFactories.AccountPhoneNumbersAuditMetadataEntityFactory.CreateNew(user, auditEntryEntity.PublicId, AccountPhoneNumberChangeTypes.PhoneNumberVerified, actorUserIdentifier);
		}
	}
}
