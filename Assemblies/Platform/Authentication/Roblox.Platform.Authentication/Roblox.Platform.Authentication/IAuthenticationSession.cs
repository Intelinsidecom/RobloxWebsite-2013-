using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public interface IAuthenticationSession
{
	string AccountName { get; }

	IUser User { get; }

	IUser Validate(TimeSpan timeToLive, out AuthenticationSessionValidationStatus authenticationSessionValidationStatus, out bool wasExtended);
}
