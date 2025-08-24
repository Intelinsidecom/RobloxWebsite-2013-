using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.AccountPins.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.AccountPins.IAccountPinFactory" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.IAccountPinFactory" />
internal class AccountPinFactory : IAccountPinFactory
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	internal virtual bool IsAuditingEnabled => Settings.Default.IsAccountPinHashesTableAuditingEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.AccountPinFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	public AccountPinFactory(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public IAccountPin Create(IUser user, string pin, IUserIdentifier actorUserIdentity)
	{
		ValidateUserForPinCreation(user);
		ValidatePinEntryForPinCreation(pin);
		IAccountPinHashEntity oldHashEntity = _DomainFactories.AccountPinHashEntityFactory.GetValid(user.AccountId);
		if (oldHashEntity != null)
		{
			oldHashEntity.IsValid = false;
			oldHashEntity.Update();
		}
		string pinHash = _DomainFactories.PinHasher.HashUserPin(user, pin);
		IAccountPinHashEntity hashEntity = _DomainFactories.AccountPinHashEntityFactory.CreateNew(user.AccountId, pinHash);
		AccountPin result = new AccountPin(_DomainFactories, hashEntity, user);
		OnCreate(user, actorUserIdentity, oldHashEntity, hashEntity);
		return result;
	}

	private void ValidatePinEntryForPinCreation(string pin)
	{
		if (!_DomainFactories.PinFormatValidator.ValidatePin(pin))
		{
			throw new PlatformAccountPinInvalidFormatException("Invalid pin format");
		}
	}

	private void ValidateUserForPinCreation(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (user.AccountId <= 0)
		{
			throw new PlatformArgumentException("AccountId");
		}
		if (!DoesUserHaveVerifiedEmail(user))
		{
			throw new PlatformUnverifiedEmailAddressException("user", "User does not have a verified email.");
		}
		if (!_DomainFactories.AccountPinConfigurationProvider.IsAccountPinFeatureEnabledForUser(user))
		{
			throw new AccountPinFeatureDisabledException();
		}
	}

	private void OnCreate(IUser user, IUserIdentifier actorUserIdentity, IAccountPinHashEntity oldHashEntity, IAccountPinHashEntity hashEntity)
	{
		if (IsAuditingEnabled)
		{
			(oldHashEntity?.BuildAuditEntity(_DomainFactories))?.BuildMetadataEntity(_DomainFactories, user, AccountPinChangeType.PinReplaced, actorUserIdentity);
			(hashEntity?.BuildAuditEntity(_DomainFactories))?.BuildMetadataEntity(_DomainFactories, user, AccountPinChangeType.PinAdded, actorUserIdentity);
		}
	}

	public IAccountPin GetValidAccountPin(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (user.AccountId == 0L)
		{
			throw new PlatformArgumentException("user");
		}
		IAccountPinHashEntity hashEntity = _DomainFactories.AccountPinHashEntityFactory.GetValid(user.AccountId);
		if (hashEntity != null)
		{
			return new AccountPin(_DomainFactories, hashEntity, user);
		}
		return null;
	}

	internal virtual bool DoesUserHaveVerifiedEmail(IUser user)
	{
		return user.HasVerifiedEmail();
	}
}
