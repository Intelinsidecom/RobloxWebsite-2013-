using System;
using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// A platform implementation for <see cref="T:Roblox.Platform.AccountPins.IAccountPinLockProvider" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.IAccountPinLockProvider" />.
internal class AccountPinLockProvider : IAccountPinLockProvider
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.AccountPinLockProvider" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException">Thrown if <paramref name="domainFactories" /> is null.</exception>
	public AccountPinLockProvider(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public bool IsLocked(IUser user, string authenticationSession)
	{
		if (!_DomainFactories.AccountPinConfigurationProvider.IsAccountPinFeatureEnabledForUser(user))
		{
			return false;
		}
		IAccountPinHashEntity pinHashEntity = _DomainFactories.AccountPinHashEntityFactory.GetValid(user.AccountId);
		if (pinHashEntity == null)
		{
			return false;
		}
		IPinEntry pinEntry = _DomainFactories.PinEntryFactory.Get(user, authenticationSession);
		if (pinEntry == null || pinEntry.PinHashId != pinHashEntity.Id || pinEntry.UnlockedUntil < GetNow())
		{
			return true;
		}
		return false;
	}

	internal virtual DateTime GetNow()
	{
		return DateTime.Now;
	}
}
