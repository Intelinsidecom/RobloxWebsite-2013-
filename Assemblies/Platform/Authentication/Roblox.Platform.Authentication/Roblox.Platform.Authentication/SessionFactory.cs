using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public class SessionFactory : ISessionFactory
{
	public IAuthenticationSession CreateSession(IUser user, TimeSpan timeToLive)
	{
		ISessionToken sessionToken = CreateSessionToken(user, timeToLive);
		return new TokenSecuredAuthenticationSession(user, sessionToken);
	}

	internal virtual ISessionToken CreateSessionToken(IUser user, TimeSpan timeToLive)
	{
		return SessionTokenFactory.CreateSessionToken(user, timeToLive);
	}
}
