using System;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification;

namespace Roblox.Web.Authentication;

/// <summary>
/// Represents an object with sign in events.
/// </summary>
public interface ILoginEventSender
{
	/// <summary>
	/// An event for when user login failed.
	/// <remarks>
	/// Sends the <see cref="T:Roblox.Platform.MembershipCore.IUserIdentifier" /> if it was able to get one from credentials. Null otherwise.
	/// Sends the failure reason as a <see cref="T:Roblox.Web.Authentication.LoginFailureStatus" />.
	/// Sends the <see cref="T:Roblox.Platform.Authentication.CredentialsType" /> present on failed login.
	/// Sends user agent.
	/// </remarks>
	/// </summary>
	event Action<IUserIdentifier, LoginFailureStatus, CredentialsType, string> OnUserLoginFailed;

	/// <summary>
	/// An event for when user login succeeded.
	/// <remarks>
	/// Sends the authenticated <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// Sends the used <see cref="T:Roblox.Platform.Authentication.CredentialsType" />.
	/// </remarks>
	/// </summary>
	event Action<IUser, CredentialsType> OnUserLoggedIn;

	/// <summary>
	/// An event for when two step verification succeeded.
	/// <remarks>
	/// Sends the User Agent.
	/// Sends the <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationMediaType" />
	/// Sends the <see cref="T:Roblox.Platform.Membership.IUser" />
	/// Sends the <see cref="T:Roblox.Platform.Authentication.CredentialsType" />
	/// </remarks>
	/// </summary>
	event Action<string, TwoStepVerificationMediaType, IUser, CredentialsType> OnTwoStepVerificationSucceeded;
}
