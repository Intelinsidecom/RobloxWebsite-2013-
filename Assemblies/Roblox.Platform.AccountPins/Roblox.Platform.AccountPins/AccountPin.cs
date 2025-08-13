using System;
using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.AccountPins.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.AccountPins.IAccountPin" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.IAccountPin" />
internal class AccountPin : IAccountPin
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	private readonly IUser _User;

	public long Id { get; }

	public bool IsValid { get; }

	public DateTime Created { get; }

	internal virtual bool IsAuditingEnabled => Settings.Default.IsAccountPinHashesTableAuditingEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.AccountPin" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <param name="hashEntity">The hash entity.</param>
	/// <param name="user">The user for the account pin</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">
	/// </exception>
	internal AccountPin(AccountPinsDomainFactories domainFactories, IAccountPinHashEntity hashEntity, IUser user)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		if (hashEntity == null)
		{
			throw new PlatformArgumentNullException("hashEntity");
		}
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (user.AccountId != hashEntity.AccountId)
		{
			throw new PlatformArgumentException("Tried to create AccountPin with inconsistent account information.");
		}
		_DomainFactories = domainFactories;
		_User = user;
		Id = hashEntity.Id;
		IsValid = hashEntity.IsValid;
		Created = hashEntity.Created;
	}

	public void Delete(IUserIdentifier actorUserIdentity)
	{
		IAccountPinHashEntity hashEntity = _DomainFactories.AccountPinHashEntityFactory.Get(Id);
		if (hashEntity == null)
		{
			throw new PlatformDataIntegrityException("Unable to retrive a non persistent entity");
		}
		if (hashEntity.AccountId != _User.AccountId)
		{
			throw new PlatformDataIntegrityException("AccountPin entity has inconsisent account data");
		}
		hashEntity.IsValid = false;
		hashEntity.Update();
		if (IsAuditingEnabled)
		{
			hashEntity.BuildAuditEntity(_DomainFactories)?.BuildMetadataEntity(_DomainFactories, _User, AccountPinChangeType.PinDisabled, actorUserIdentity);
		}
	}
}
