using Roblox.Platform.AccountPins.Interfaces;
using Roblox.Platform.AccountPins.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Membership;

namespace Roblox.Platform.AccountPins.Implementation;

/// <summary>
/// A class implementation for <see cref="T:Roblox.Platform.AccountPins.Interfaces.IAccountPinConfigurationProvider" />.
/// </summary>
/// <seealso cref="T:Roblox.Platform.AccountPins.Interfaces.IAccountPinConfigurationProvider" />
internal class AccountPinConfigurationProvider : IAccountPinConfigurationProvider
{
	private readonly AccountPinsDomainFactories _DomainFactories;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.AccountPins.Implementation.AccountPinConfigurationProvider" /> class.
	/// </summary>
	/// <param name="domainFactories">The domain factories.</param>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentNullException"></exception>
	public AccountPinConfigurationProvider(AccountPinsDomainFactories domainFactories)
	{
		if (domainFactories == null)
		{
			throw new PlatformArgumentNullException("domainFactories");
		}
		_DomainFactories = domainFactories;
	}

	public bool IsAccountPinFeatureEnabledForUser(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if ((!IsAccountPinEnabledForSoothSayers() || !IsUserSoothSayer(user)) && !IsAccountPinEnabledForRegularUser())
		{
			return false;
		}
		return true;
	}

	internal virtual bool IsUserSoothSayer(IUser user)
	{
		return user.IsSoothSayer();
	}

	internal virtual bool IsAccountPinEnabledForSoothSayers()
	{
		return Settings.Default.IsAccountPinEnabledForSoothSayers;
	}

	internal virtual bool IsAccountPinEnabledForRegularUser()
	{
		return Settings.Default.IsAccountPinEnabledForRegularUser;
	}
}
