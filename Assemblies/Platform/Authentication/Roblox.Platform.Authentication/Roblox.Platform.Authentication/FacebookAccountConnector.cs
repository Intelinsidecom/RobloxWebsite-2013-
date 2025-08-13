using System;
using Roblox.Platform.Core;

namespace Roblox.Platform.Authentication;

public class FacebookAccountConnector : IFacebookAccountConnector
{
	private readonly IFacebookAccountDataAccessor _FacebookAccountDataAccessor;

	private readonly IAvailableAuthenticationMethodMonitor _AvailableAuthenticationMethodMonitor;

	public event Action<long> OnFacebookAccountDisconnected;

	public FacebookAccountConnector()
		: this(new AvailableAuthenticationMethodMonitor(), new FacebookAccountDataAccessor())
	{
	}

	internal FacebookAccountConnector(IAvailableAuthenticationMethodMonitor authenticationMonitor, IFacebookAccountDataAccessor facebookAccountDataAccessor)
	{
		if (facebookAccountDataAccessor == null)
		{
			throw new PlatformArgumentNullException("facebookAccountDataAccessor");
		}
		if (authenticationMonitor == null)
		{
			throw new PlatformArgumentNullException("authenticationMonitor");
		}
		_FacebookAccountDataAccessor = facebookAccountDataAccessor;
		_AvailableAuthenticationMethodMonitor = authenticationMonitor;
	}

	public bool Connect(long accountId, ulong facebookId)
	{
		IFacebookAccount facebookAccount = _FacebookAccountDataAccessor.GetByAccountId(accountId);
		if (facebookAccount != null)
		{
			if (facebookAccount.FacebookId != facebookId)
			{
				throw new PlatformArgumentException("accountId");
			}
			return true;
		}
		facebookAccount = _FacebookAccountDataAccessor.GetByFacebookId(facebookId);
		if (facebookAccount != null)
		{
			return false;
		}
		_FacebookAccountDataAccessor.Save(new FacebookAccount
		{
			AccountId = accountId,
			FacebookId = facebookId
		});
		return true;
	}

	public bool Disconnect(long accountId, bool force = false)
	{
		IFacebookAccount facebookAccount = _FacebookAccountDataAccessor.GetByAccountId(accountId);
		if (facebookAccount == null)
		{
			return true;
		}
		if (!force && _AvailableAuthenticationMethodMonitor.GetNumberOfAvailableAuthenticationMethods(facebookAccount.AccountId) == 1)
		{
			return false;
		}
		_FacebookAccountDataAccessor.Invalidate(facebookAccount);
		this.OnFacebookAccountDisconnected?.Invoke(accountId);
		return true;
	}

	public IFacebookAccountIdentifier GetConnectedFacebookAccountIdentifier(long accountId)
	{
		return _FacebookAccountDataAccessor.GetByAccountId(accountId);
	}

	public IFacebookAccountIdentifier GetConnectedFacebookAccountIdentifier(ulong facebookId)
	{
		return _FacebookAccountDataAccessor.GetByFacebookId(facebookId);
	}

	public IFacebookAccount GetConnectedFacebookAccount(long accountId)
	{
		return _FacebookAccountDataAccessor.GetByAccountId(accountId);
	}

	public void Forget(long accountId)
	{
		_FacebookAccountDataAccessor.Forget(accountId);
		this.OnFacebookAccountDisconnected?.Invoke(accountId);
	}
}
