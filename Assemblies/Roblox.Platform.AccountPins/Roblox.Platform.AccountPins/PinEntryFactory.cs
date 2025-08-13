using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.AccountPins.IPinEntryFactory" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.IPinEntryFactory" />
internal class PinEntryFactory : IPinEntryFactory_Internal, IPinEntryFactory
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.PinEntryFactory" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	public PinEntryFactory(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public IPinEntry Create(IUser user, string sessionString, IAccountPinHashEntity pinHashEntity)
	{
		IPinEntryEntity entity = _DomainFactories.PinEntryEntityFactory.CreateNew(user.AccountId, sessionString, pinHashEntity.Id);
		return new PinEntry(_DomainFactories, entity);
	}

	public IPinEntry Get(IUser user, string sessionString)
	{
		IPinEntryEntity entity = _DomainFactories.PinEntryEntityFactory.Get(user.AccountId, sessionString);
		if (entity != null)
		{
			return new PinEntry(_DomainFactories, entity);
		}
		return null;
	}
}
