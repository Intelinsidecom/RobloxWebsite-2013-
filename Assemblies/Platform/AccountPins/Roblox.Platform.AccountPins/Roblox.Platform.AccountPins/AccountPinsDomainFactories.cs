using System;
using Roblox.Caching.Shared;
using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.AccountPins.Entities.Audit;
using Roblox.Platform.AccountPins.Implementation;
using Roblox.Platform.AccountPins.Interfaces;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// A class for holding reference of all objects needed for AccountPins.
/// </summary>
public class AccountPinsDomainFactories : DomainFactoriesBase
{
	internal virtual IPinEntryEntityFactory PinEntryEntityFactory { get; }

	internal virtual IAccountPinHashEntityFactory AccountPinHashEntityFactory { get; }

	internal virtual IPinHasher PinHasher { get; }

	internal virtual IAccountPinFormatValidator PinFormatValidator { get; }

	internal virtual IAccountPinHashesAuditEntityFactory AccountPinHashesAuditEntityFactory { get; }

	internal virtual IAccountPinHashesAuditMetadataEntityFactory AccountPinHashesAuditMetadataEntityFactory { get; }

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.AccountPins.Interfaces.IAccountPinConfigurationProvider" /> used for configuring the pin.
	/// </summary>
	public virtual IAccountPinConfigurationProvider AccountPinConfigurationProvider { get; }

	/// <summary>
	/// Gets the account pin factory.
	/// </summary>
	/// <value>
	/// The account pin factory.
	/// </value>
	public virtual IAccountPinFactory AccountPinFactory { get; }

	/// <summary>
	/// Gets the pin entry factory.
	/// </summary>
	/// <value>
	/// The pin entry factory.
	/// </value>
	public virtual IPinEntryFactory PinEntryFactory => PinEntryFactory_Internal;

	/// <summary>
	/// Gets the internal pin entry factory.
	/// </summary>
	internal virtual IPinEntryFactory_Internal PinEntryFactory_Internal { get; }

	/// <summary>
	/// Gets the account pin lock provider.
	/// </summary>
	/// <value>
	/// The account pin lock provider.
	/// </value>
	public virtual IAccountPinLockProvider AccountPinLockProvider { get; }

	/// <summary>
	/// Gets the pin validator.
	/// </summary>
	/// <value>
	/// The pin validator.
	/// </value>
	public virtual IPinValidator PinValidator { get; }

	public IAccountPinAuditFactory AuditFactory { get; }

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.AccountPinsDomainFactories" /> class.
	/// </summary>
	public AccountPinsDomainFactories(ISharedCacheClient cacheClient, IUserFactory userFactory)
	{
		if (cacheClient == null)
		{
			throw new ArgumentNullException("cacheClient");
		}
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		AccountPinConfigurationProvider = new AccountPinConfigurationProvider(this);
		PinEntryEntityFactory = new PinEntryEntityFactory(this, cacheClient);
		AccountPinHashEntityFactory = new AccountPinHashEntityFactory(this);
		PinHasher = new PinHasher();
		PinFormatValidator = new AccountPinFormatValidator(this);
		AccountPinHashesAuditEntityFactory = new AccountPinHashesAuditEntityFactory(this);
		AccountPinHashesAuditMetadataEntityFactory accountPinHashesAuditMetadataEntityFactory = (AccountPinHashesAuditMetadataEntityFactory)(AccountPinHashesAuditMetadataEntityFactory = new AccountPinHashesAuditMetadataEntityFactory(this));
		AccountPinFactory = new AccountPinFactory(this);
		PinEntryFactory_Internal = new PinEntryFactory(this);
		AccountPinLockProvider = new AccountPinLockProvider(this);
		PinValidator = new PinValidator(this);
		AuditFactory = new AccountPinAuditFactory(userFactory, accountPinHashesAuditMetadataEntityFactory);
	}
}
