using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public interface ISessionFactory
{
	IAuthenticationSession CreateSession(IUser user, TimeSpan timeToLive);
}
