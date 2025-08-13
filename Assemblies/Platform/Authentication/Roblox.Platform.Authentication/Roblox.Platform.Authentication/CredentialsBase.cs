using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public abstract class CredentialsBase : ICredentials
{
	protected IUserFactory UserFactory { get; set; }

	protected abstract IUser DoAuthentication();

	protected CredentialsBase(IUserFactory userFactory)
	{
		UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	public IAuthenticationSession Authenticate(TimeSpan timeToLive)
	{
		IUser user = DoAuthentication();
		if (user == null || user.IsForgotten())
		{
			return null;
		}
		AuthenticatedEventArgs eventArgs = new AuthenticatedEventArgs(user);
		AuthenticationEvents.RaiseAuthenticated(this, eventArgs);
		ISessionToken sessionToken = CreateSessionToken(user, timeToLive);
		return new TokenSecuredAuthenticationSession(user, sessionToken);
	}

	protected virtual ISessionToken CreateSessionToken(IUser user, TimeSpan timeToLive)
	{
		return SessionTokenFactory.CreateSessionToken(user, timeToLive);
	}
}
