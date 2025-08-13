using System;
using System.Collections.Generic;
using Roblox.Platform.Authentication.Entities;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public static class SessionTokenFactory
{
	private const int _PageSize = 50;

	public static ISessionToken Build(string value)
	{
		return new SessionToken(value);
	}

	public static ISessionToken CreateSessionToken(IUser user, TimeSpan timeToLive)
	{
		Guid sessionTokenGuid = Guid.NewGuid();
		DateTime expiration = DateTime.Now + timeToLive;
		return Build(Roblox.Platform.Authentication.Entities.SessionToken.CreateNew(user.AccountId, sessionTokenGuid, expiration).Token.ToString());
	}

	public static void Delete(ISessionToken sessionToken)
	{
		sessionToken.VerifyIsNotNull();
		Roblox.Platform.Authentication.Entities.SessionToken.GetByToken(new Guid(sessionToken.Value))?.Delete();
	}

	public static void DeleteAll(IUser user)
	{
		bool shouldContinue = true;
		while (shouldContinue)
		{
			ICollection<Roblox.Platform.Authentication.Entities.SessionToken> sessionTokensByAccountID_Paged = Roblox.Platform.Authentication.Entities.SessionToken.GetSessionTokensByAccountID_Paged(user.AccountId, 0, 50);
			shouldContinue = sessionTokensByAccountID_Paged.Count >= 50;
			foreach (Roblox.Platform.Authentication.Entities.SessionToken item in sessionTokensByAccountID_Paged)
			{
				item?.Delete();
			}
		}
	}
}
