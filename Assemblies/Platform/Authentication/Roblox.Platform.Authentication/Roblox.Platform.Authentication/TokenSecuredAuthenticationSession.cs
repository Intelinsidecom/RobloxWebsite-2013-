using System;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public class TokenSecuredAuthenticationSession : ITokenSecuredAuthenticationSession, IAuthenticationSession
{
	public string AccountName { get; }

	public IUser User { get; }

	public ISessionToken SessionToken { get; }

	public TokenSecuredAuthenticationSession(IUser user, ISessionToken sessionToken)
	{
		User = user ?? throw new ArgumentNullException("user");
		SessionToken = sessionToken ?? throw new ArgumentNullException("sessionToken");
		AccountName = user.Name;
	}

	[Obsolete("Please use the constructor that takes an IUser.")]
	public TokenSecuredAuthenticationSession(string accountName, ISessionToken sessionToken, IUserFactory userFactory)
	{
		if (userFactory == null)
		{
			throw new ArgumentNullException("userFactory");
		}
		AccountName = accountName;
		SessionToken = sessionToken;
		User = userFactory.GetUserByName(accountName);
	}

	public IUser Validate(TimeSpan timeToLive, out AuthenticationSessionValidationStatus authenticationSessionValidationStatus, out bool wasExtended)
	{
		wasExtended = false;
		if (User == null)
		{
			authenticationSessionValidationStatus = AuthenticationSessionValidationStatus.InvalidUser;
			return null;
		}
		authenticationSessionValidationStatus = SessionToken.Extend(timeToLive, out wasExtended);
		if (authenticationSessionValidationStatus != 0)
		{
			return null;
		}
		authenticationSessionValidationStatus = SessionToken.IsValid(User);
		if (authenticationSessionValidationStatus == AuthenticationSessionValidationStatus.Success)
		{
			return User;
		}
		return null;
	}
}
