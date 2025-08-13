using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public interface ISessionToken
{
	string Value { get; }

	AuthenticationSessionValidationStatus IsValid(IUser user);

	AuthenticationSessionValidationStatus Extend(TimeSpan timeToLive, out bool wasExtended);
}
