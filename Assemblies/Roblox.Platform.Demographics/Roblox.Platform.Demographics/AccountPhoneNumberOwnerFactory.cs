using System.Collections.Generic;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics.Entities;

namespace Roblox.Platform.Demographics;

/// <summary>
/// A factory to create <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberOwner" /> objects.
/// </summary>
internal class AccountPhoneNumberOwnerFactory : IAccountPhoneNumberOwnerFactory
{
	private readonly DemographicsDomainFactories _DomainFactories;

	/// <summary>
	/// Initilizes a new instance of <see cref="T:Roblox.Platform.Demographics.AccountPhoneNumberOwnerFactory" />.
	/// </summary>
	/// <param name="domainFactories">The <see cref="T:Roblox.Platform.Demographics.DemographicsDomainFactories" />.</param>
	public AccountPhoneNumberOwnerFactory(DemographicsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories.AssignOrThrowIfNull("domainFactories");
	}

	/// <inheritdoc />
	public ICollection<IAccountPhoneNumberOwner> GetAccountPhoneNumberOwnersByPhoneNumberValueIsVerifiedAndIsActive(string phoneNumberValue, bool isVerified, bool isActive, int count, int? exclusiveStartId = null)
	{
		if (string.IsNullOrWhiteSpace(phoneNumberValue))
		{
			throw new PlatformArgumentException(string.Format("'{0}' can not be null or whitespace", "phoneNumberValue"));
		}
		if (count <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		string formattedPhoneNumber = _DomainFactories.PhoneNumberValidator.GetFormattedPhoneNumber(phoneNumberValue);
		IPhoneNumberEntity phoneNumberEntity = _DomainFactories.PhoneNumberEntityFactory.GetByValue(formattedPhoneNumber);
		if (phoneNumberEntity == null)
		{
			return new List<IAccountPhoneNumberOwner>();
		}
		return GetAccountPhoneNumberOwnersByPhoneNumberIdValueIsVerifiedAndIsActive(phoneNumberEntity.Id, isVerified, isActive, count, exclusiveStartId);
	}

	/// <inheritdoc />
	public ICollection<IAccountPhoneNumberOwner> GetAccountPhoneNumberOwnersByPhoneNumberIdIsVerifiedAndIsActive(IPhoneNumberIdentifier phoneNumberId, bool isVerified, bool isActive, int count, int? exclusiveStartId = null)
	{
		if (phoneNumberId == null)
		{
			throw new PlatformArgumentNullException(string.Format("'{0}' can not be null", "phoneNumberId"));
		}
		if (count <= 0)
		{
			throw new PlatformArgumentException(string.Format("'{0}' must be positive", "count"));
		}
		return GetAccountPhoneNumberOwnersByPhoneNumberIdValueIsVerifiedAndIsActive(phoneNumberId.Id, isVerified, isActive, count, exclusiveStartId);
	}

	private ICollection<IAccountPhoneNumberOwner> GetAccountPhoneNumberOwnersByPhoneNumberIdValueIsVerifiedAndIsActive(int phoneNumberId, bool isVerified, bool isActive, int count, int? exclusiveStartId = null)
	{
		IEnumerable<IAccountPhoneNumberEntity> byPhoneNumberIDIsVerifiedAndIsActiveEnumerative = _DomainFactories.AccountPhoneNumberEntityFactory.GetByPhoneNumberIDIsVerifiedAndIsActiveEnumerative(phoneNumberId, isVerified, isActive, count, exclusiveStartId);
		List<IAccountPhoneNumberOwner> users = new List<IAccountPhoneNumberOwner>();
		foreach (IAccountPhoneNumberEntity accountPhoneNumberEntity in byPhoneNumberIDIsVerifiedAndIsActiveEnumerative)
		{
			users.Add(new AccountPhoneNumberOwner
			{
				AccountPhoneNumberId = accountPhoneNumberEntity.Id,
				AccountId = accountPhoneNumberEntity.AccountId
			});
		}
		return users;
	}
}
