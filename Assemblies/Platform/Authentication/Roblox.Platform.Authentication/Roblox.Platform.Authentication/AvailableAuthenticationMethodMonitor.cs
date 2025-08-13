using System;
using System.Collections.Generic;
using System.Linq;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;

namespace Roblox.Platform.Authentication;

/// <inheritdoc />
public class AvailableAuthenticationMethodMonitor : IAvailableAuthenticationMethodMonitor
{
	private readonly IFacebookAccountDataAccessor _FacebookAccountDataAccessor;

	private readonly IXboxLiveAccountDataAccessor _XboxLiveAccountDataAccessor;

	private readonly IPasswordsClient _PasswordsClient;

	private readonly IAuthenticationSettings _AuthenticationSettings;

	internal AvailableAuthenticationMethodMonitor(IFacebookAccountDataAccessor facebookAccountDataAccessor, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor)
		: this(facebookAccountDataAccessor, xboxLiveAccountDataAccessor, AccountPasswordHash.PasswordsClient, Settings.Default)
	{
	}

	internal AvailableAuthenticationMethodMonitor(IFacebookAccountDataAccessor facebookAccountDataAccessor, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
	{
		_FacebookAccountDataAccessor = facebookAccountDataAccessor ?? throw new ArgumentNullException("facebookAccountDataAccessor");
		_XboxLiveAccountDataAccessor = xboxLiveAccountDataAccessor ?? throw new ArgumentNullException("xboxLiveAccountDataAccessor");
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
		_AuthenticationSettings = authenticationSettings ?? throw new ArgumentNullException("authenticationSettings");
	}

	/// <summary>
	/// Constructs an <see cref="T:Roblox.Platform.Authentication.AvailableAuthenticationMethodMonitor" />
	/// </summary>
	public AvailableAuthenticationMethodMonitor()
		: this(new FacebookAccountDataAccessor(), new XboxLiveAccountDataAccessor())
	{
	}

	public int GetNumberOfAvailableAuthenticationMethods(long accountId)
	{
		return GetAvailableAuthenticationMethods(accountId).Count();
	}

	public IEnumerable<AuthenticationMethod> GetAvailableAuthenticationMethods(long accountId)
	{
		List<AuthenticationMethod> result = new List<AuthenticationMethod>();
		if (CanAuthenticateWithRobloxAccount(accountId))
		{
			result.Add(AuthenticationMethod.Roblox);
		}
		if (CanAuthenticateWithFacebookAccount(accountId))
		{
			result.Add(AuthenticationMethod.Facebook);
		}
		if (CanAuthenticateWithXboxLiveAccount(accountId))
		{
			result.Add(AuthenticationMethod.Xbox);
		}
		return result;
	}

	protected virtual bool CanAuthenticateWithRobloxAccount(long accountId)
	{
		PasswordStatusResult passwordStatus = _PasswordsClient.GetPasswordStatus(PasswordOwnerType.Account, accountId);
		if (passwordStatus.SetStatus != PasswordSetStatus.ValidPasswordSet)
		{
			return passwordStatus.SetStatus == PasswordSetStatus.PasswordNeedsReset;
		}
		return true;
	}

	protected virtual bool CanAuthenticateWithFacebookAccount(long accountId)
	{
		return _FacebookAccountDataAccessor.GetByAccountId(accountId) != null;
	}

	protected virtual bool CanAuthenticateWithXboxLiveAccount(long accountId)
	{
		return _XboxLiveAccountDataAccessor.GetByAccountId(accountId) != null;
	}
}
