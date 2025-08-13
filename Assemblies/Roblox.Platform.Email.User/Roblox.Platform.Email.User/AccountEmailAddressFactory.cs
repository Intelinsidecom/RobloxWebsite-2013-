using System.Collections.Generic;
using System.Linq;
using Roblox.Platform.Core;
using Roblox.Platform.Email.User.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Email.User;

/// <summary>
/// Default implementation of <see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" />.
/// </summary>
internal class AccountEmailAddressFactory : IAccountEmailAddressFactory
{
	internal readonly IEmailAddressFactory _EmailAddressFactory;

	internal readonly IAccountEmailAddressEntityFactory _AccountEmailAddressEntityFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.User.AccountEmailAddressFactory" /> class.
	/// </summary>
	/// <param name="emailAddressFactory">The email address factory.</param>
	/// <param name="accountEmailAddressFactory">The account email address factory.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// emailAddressFactory
	/// or
	/// accountEmailAddressFactory
	/// </exception>
	internal AccountEmailAddressFactory(IEmailAddressFactory emailAddressFactory, IAccountEmailAddressEntityFactory accountEmailAddressFactory)
	{
		_EmailAddressFactory = emailAddressFactory ?? throw new PlatformArgumentNullException("emailAddressFactory");
		_AccountEmailAddressEntityFactory = accountEmailAddressFactory ?? throw new PlatformArgumentNullException("accountEmailAddressFactory");
	}

	/// <summary>
	/// Default implementation of <see cref="M:Roblox.Platform.Email.User.IAccountEmailAddressFactory.Get(Roblox.Platform.Membership.IUser)" />
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" /> whose e-mail we are looking up.</param>
	/// <returns>A <see cref="T:Roblox.Platform.Email.User.IAccountEmail" /> or null if not found.</returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">No user provided</exception>
	public IAccountEmail Get(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		IAccountEmailAddressEntity accountEmailAddressEntity = _AccountEmailAddressEntityFactory.GetCurrentByAccountId(user.AccountId);
		if (accountEmailAddressEntity == null)
		{
			return null;
		}
		IEmailAddress emailAddress = _EmailAddressFactory.GetById(accountEmailAddressEntity.EmailAddressId);
		if (emailAddress == null)
		{
			throw new PlatformDataIntegrityException($"The e-mail ID {accountEmailAddressEntity.EmailAddressId} defined in AccountEmail {accountEmailAddressEntity.Id} does not exist.");
		}
		return MapEntitiesIntoIAccountEmail(accountEmailAddressEntity, emailAddress);
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s by email address.
	/// </summary>
	/// <param name="address">The email address.</param>
	/// <param name="count">The count.</param>
	/// <param name="exclusiveStartId">The exclusive start identifier.</param>
	/// <returns>
	/// A collection of <see cref="T:Roblox.Platform.Email.User.IAccountEmail" />s, if any.
	/// </returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">address
	/// or
	/// exclusiveStartId
	/// or
	/// count</exception>
	public ICollection<IAccountEmail> GetAccountsByEmailAddress(string address, int count, int exclusiveStartId = 0)
	{
		IEmailAddress emailAddress = CheckInputAndGetEmailAddress(address, count, exclusiveStartId);
		if (emailAddress == null)
		{
			return new IAccountEmail[0];
		}
		ICollection<IAccountEmailAddressEntity> accountEmailAddressEntities = _AccountEmailAddressEntityFactory.GetByEmailAddressId(emailAddress.Id, count, exclusiveStartId);
		if (accountEmailAddressEntities == null)
		{
			return new IAccountEmail[0];
		}
		return (from x in accountEmailAddressEntities
			where x != null
			select x into accountEmailAddressEntity
			select MapEntitiesIntoIAccountEmail(accountEmailAddressEntity, emailAddress)).ToList();
	}

	public ICollection<IAccountEmail> GetCurrentAccountsByEmailAddress(string emailAddress, int count, int exclusiveStartId = 0)
	{
		IEmailAddress emailAddressEntity = CheckInputAndGetEmailAddress(emailAddress, count, exclusiveStartId);
		if (emailAddressEntity == null)
		{
			return new IAccountEmail[0];
		}
		List<IAccountEmail> outputEmailAddresses = new List<IAccountEmail>(count);
		ICollection<IAccountEmailAddressEntity> emailAddresses;
		do
		{
			emailAddresses = _AccountEmailAddressEntityFactory.GetByEmailAddressIdByAndIsValid(emailAddressEntity.Id, isValid: true, count, exclusiveStartId);
			IEnumerable<IAccountEmail> currentAccountEmailAddresses = from accountEmailAddressEntity in emailAddresses
				select MapEntitiesIntoIAccountEmail(accountEmailAddressEntity, emailAddressEntity) into address
				where address.IsCurrent
				select address;
			outputEmailAddresses.AddRange(currentAccountEmailAddresses);
			exclusiveStartId = emailAddresses.LastOrDefault()?.Id ?? exclusiveStartId;
		}
		while (outputEmailAddresses.Count < count && emailAddresses.Count == count);
		return outputEmailAddresses.Take(count).ToList();
	}

	public ICollection<IAccountEmail> GetCurrentEmailAccountsByEmailAddressIsVerified(string emailAddress, bool isVerified, int count, int? exclusiveStartId = null)
	{
		IEmailAddress emailAddressEntity = CheckInputAndGetEmailAddress(emailAddress, count, exclusiveStartId ?? 0);
		if (emailAddressEntity == null)
		{
			return new IAccountEmail[0];
		}
		List<IAccountEmail> outputEmailAddresses = new List<IAccountEmail>(count);
		ICollection<IAccountEmailAddressEntity> emailAddresses;
		do
		{
			emailAddresses = _AccountEmailAddressEntityFactory.GetByEmailAddressIdIsVerifiedAndIsValid(emailAddressEntity.Id, isVerified, isValid: true, count, exclusiveStartId);
			IEnumerable<IAccountEmail> currentAccountEmailAddresses = from accountEmailAddressEntity in emailAddresses
				select MapEntitiesIntoIAccountEmail(accountEmailAddressEntity, emailAddressEntity) into address
				where address.IsCurrent
				select address;
			outputEmailAddresses.AddRange(currentAccountEmailAddresses);
			IAccountEmailAddressEntity accountEmailAddressEntity2 = emailAddresses.LastOrDefault();
			exclusiveStartId = ((accountEmailAddressEntity2 != null) ? new int?(accountEmailAddressEntity2.Id) : exclusiveStartId);
		}
		while (outputEmailAddresses.Count < count && emailAddresses.Count == count);
		return outputEmailAddresses.Take(count).ToList();
	}

	private IAccountEmail MapEntitiesIntoIAccountEmail(IAccountEmailAddressEntity accountEmailAddressEntity, IEmailAddress emailAddress)
	{
		return new AccountEmail
		{
			Id = accountEmailAddressEntity.Id,
			Email = emailAddress.Address,
			IsBlacklisted = emailAddress.IsBlacklisted,
			IsVerified = accountEmailAddressEntity.IsVerified,
			IsValid = accountEmailAddressEntity.IsValid,
			AccountId = accountEmailAddressEntity.AccountId,
			IsCurrent = IsCurrent(accountEmailAddressEntity)
		};
	}

	internal virtual bool IsCurrent(IAccountEmailAddressEntity accountEmailAddressEntity)
	{
		if (accountEmailAddressEntity != null)
		{
			return accountEmailAddressEntity.Id == _AccountEmailAddressEntityFactory.GetCurrentByAccountId(accountEmailAddressEntity.AccountId)?.Id;
		}
		return false;
	}

	private IEmailAddress CheckInputAndGetEmailAddress(string emailAddress, int count, int exclusiveStartId)
	{
		if (string.IsNullOrWhiteSpace(emailAddress))
		{
			throw new PlatformArgumentException(string.Format("Parameter {0} can not be null or whitespace", "emailAddress"));
		}
		if (exclusiveStartId < 0)
		{
			throw new PlatformArgumentException(string.Format("Parameter {0} can not be less than default value", "exclusiveStartId"));
		}
		if (count <= 0)
		{
			throw new PlatformArgumentException(string.Format("Parameter {0} can not be less or equal than default value", "count"));
		}
		return _EmailAddressFactory.GetByEmailAddress(emailAddress);
	}
}
