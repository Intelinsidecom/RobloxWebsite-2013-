using System.Linq;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.AccountPins.Entities;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins;

/// <summary>
/// A platform implementation of <see cref="T:Roblox.Platform.AccountPins.IPinValidator" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.IPinValidator" />
internal class PinValidator : IPinValidator
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.PinValidator" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	public PinValidator(AccountPinsDomainFactories domainFactories)
	{
		_DomainFactories = domainFactories ?? throw new PlatformArgumentNullException("domainFactories");
	}

	public bool Validate(IUser user, string inputPin, string sessionStringHash)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(inputPin))
		{
			throw new PlatformArgumentException("inputPin");
		}
		if (string.IsNullOrWhiteSpace(sessionStringHash))
		{
			throw new PlatformArgumentException("sessionStringHash");
		}
		IAccountPinHashEntity realPinHashEntity;
		return ValidateAndFloodCheckInputPin(user, inputPin, out realPinHashEntity);
	}

	public IPinEntry Unlock(IUser user, string inputPin, string sessionStringHash)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(inputPin))
		{
			throw new PlatformArgumentException("inputPin");
		}
		if (string.IsNullOrWhiteSpace(sessionStringHash))
		{
			throw new PlatformArgumentException("sessionStringHash");
		}
		if (!ValidateAndFloodCheckInputPin(user, inputPin, out var realPinHashEntity))
		{
			return null;
		}
		return _DomainFactories.PinEntryFactory_Internal.Create(user, sessionStringHash, realPinHashEntity);
	}

	internal virtual bool ValidateAndFloodCheckInputPin(IUser user, string inputPin, out IAccountPinHashEntity realPinHashEntity)
	{
		IFloodChecker pinInputFloodCheckerForUser = GetPinInputFloodCheckerForUser(user);
		if (pinInputFloodCheckerForUser.IsFlooded())
		{
			throw new PlatformFloodedException("AccountPinInputFloodChecker");
		}
		pinInputFloodCheckerForUser.UpdateCount();
		realPinHashEntity = _DomainFactories.AccountPinHashEntityFactory.GetByAccountIdAndIsValidEnumerative(user.AccountId, isValid: true, 1).FirstOrDefault();
		if (realPinHashEntity == null)
		{
			return false;
		}
		bool num = _DomainFactories.PinHasher.IsValidateUserPin(user, inputPin, realPinHashEntity.PinHash);
		if (!num)
		{
			realPinHashEntity = null;
		}
		return num;
	}

	internal virtual IFloodChecker GetPinInputFloodCheckerForUser(IUser user)
	{
		return new AccountPinInputFloodChecker(user.AccountId, string.Empty);
	}
}
