using System;
using Roblox.Platform.MembershipCore;

namespace Roblox.Platform.Authentication;

public class AuthenticatedEventArgs : EventArgs
{
	public IUserIdentifier UserIdentifier { get; }

	public AuthenticatedEventArgs(IUserIdentifier userIdentifier)
	{
		UserIdentifier = userIdentifier;
	}
}
