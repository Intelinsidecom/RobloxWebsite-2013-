using System;
using System.Web;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification;
using Roblox.Platform.XboxLive;

namespace Roblox.Web.Authentication;

public interface IWebAuthenticator
{
	/// <summary>
	/// Verifies the account name and the password
	/// </summary>
	/// <param name="accountName">The account name</param>
	/// <param name="password">The password</param>
	/// <returns>True if verified successfully, False otherwise</returns>
	bool VerifyAccountPassword(string accountName, string password);

	/// <summary>
	/// Signs in a user using accountName and a password
	/// </summary>
	/// <param name="accountName">The account name</param>
	/// <param name="password">The password</param>
	/// <param name="ipAddress">The IP address</param>
	/// <returns>True if signed in, False otherwise</returns>
	[Obsolete("Use IWebAuthenticatorV2.SignInWithUserCredentials instead.")]
	bool SignIn(string accountName, string password, string ipAddress);

	/// <summary>
	/// Signs out a user out of the account
	/// </summary>
	void SignOut();

	/// <summary>
	/// Authenticates directly as an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	/// <param name="ipAddress">The current IP address.</param>
	/// <returns><c>true</c> if successful.</returns>
	bool Impersonate(IUser user, string ipAddress);

	/// <summary>
	/// Signs in via an AuthenticationTicket
	/// </summary>
	/// <remarks>
	/// You may notice that this function doesn't take an AuthenticationTicket as a parameter.  Right now, this is essentially a clone of Impersonate.
	/// This exists to give game launch a separate authentication method that is distinct from Impersonation.  We need to move the AuthenticationTicket
	/// verification to be a proper set of <see cref="T:Roblox.Platform.Authentication.ICredentials" /> and actually pass this information through.
	/// </remarks>
	/// <param name="accountName">The account name</param>
	/// <returns>True if successful, False otherwise</returns>
	bool SignInViaAuthenticationTicket(string accountName);

	/// <summary>
	/// Signs in a user using Facebook credentials
	/// </summary>
	/// <param name="facebookId">The Facebook ID for the social user</param>
	/// <returns>The logged in <see cref="T:Roblox.Platform.Membership.IUser" /> if successful, null otherwise</returns>
	/// <exception cref="T:Roblox.Web.Authentication.FloodedException">Thrown if flooding occurs while signing in via Facebook</exception>
	IUser SignInViaFacebook(ulong facebookId);

	/// <summary>
	/// Signs in a user based on Xbox Live credentials.
	/// </summary>
	/// <param name="pairwiseId">The Xbox Live user's pairwise id.</param>
	/// <param name="gamerTag">The Xbox Live user's GamerTag.</param>
	/// <param name="xboxLiveAccountDataAccessor">An instance of <see cref="T:Roblox.Platform.Authentication.IXboxLiveAccountDataAccessor" />.</param>
	/// <param name="userManager">An instance of <see cref="T:Roblox.Platform.XboxLive.IXboxLiveUserManager" />.</param>
	/// <param name="ipAddress">The IP addess</param>
	/// <returns>True if the successful, False otherwise</returns>
	bool SignInViaXbox(string pairwiseId, string gamerTag, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IXboxLiveUserManager userManager, string ipAddress);

	/// <summary>
	/// Signs in a user using two step verification credentials.
	/// </summary>
	/// <param name="twoStepVerificationCodeValidator">The <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator" />.</param>
	/// <param name="challenge">The <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" />.</param>
	/// <returns><c>True</c> if successful, <c>False</c> otherwise.</returns>
	/// <exception cref="T:Roblox.Web.Authentication.FloodedException">Thrown if flooding occurs while signing in using TwoStep Credentials.</exception>
	bool SignInUsingTwoStepVerificationCredentials(ITwoStepVerificationCodeValidator twoStepVerificationCodeValidator, TwoStepVerificationChallengeDTO challenge);

	/// <summary>
	/// Signs out the currently authenticated user out of all sessions and re-authenticates the current session
	/// </summary>
	/// <param name="ipAddress">The IP addess</param>
	/// <param name="sessionPurger">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger" /></param>
	void SignOutFromAllSessionsAndReauthenticate(string ipAddress, ITwoStepVerificationSessionPurger sessionPurger);

	/// <summary>
	/// Signs an <see cref="T:Roblox.Platform.Membership.IUser" /> out of all sessions.  This destroys all user sessions and does not re-authenticate.
	/// </summary>
	/// <remarks>
	/// This is an extremely dangerous method.  Please be certain that this is the right thing to use before invoking.
	/// </remarks>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	/// <param name="sessionPurger">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger" /></param>
	void SignOutFromAllSessions(IUser user, ITwoStepVerificationSessionPurger sessionPurger);

	/// <summary>
	/// Validates that current authentication cookie and the cooresponding session are valid.
	/// </summary>
	/// <remarks>
	/// If the cookie is not valid it will be deleted.
	/// If the authentication session is not valid it will be deleted along with any existing cookie.
	/// </remarks>
	/// <returns><c>true</c> if current cookie is valid, <c>false</c> otherwise.</returns>
	bool IsAuthCookieAndSessionValid();

	/// <summary>
	/// Provides the authenticated user for the current session
	/// </summary>
	/// <returns>The logged in <see cref="T:Roblox.Platform.Membership.IUser" /> or null if the user is a guest</returns>
	[Obsolete("Use IWebAuthenticationReader.GetAuthenticatedUser instead.")]
	IUser GetAuthenticatedUser();

	/// <summary>
	/// Returns the user name for the currently logged in user or null if guest
	/// </summary>
	/// <returns>The username as string or null if a guest</returns>
	string GetAuthenticatedUsername();

	/// <summary>
	/// Removes the do not share warning from the auth cookie in the given <see cref="T:System.Web.HttpRequest" />.
	/// </summary>
	/// <param name="request">The <see cref="T:System.Web.HttpRequest" /> containing the auth cookie.</param>
	/// <exception cref="T:System.NullReferenceException">Thrown if <paramref name="request" /> is null.</exception>
	void RemoveAuthCookiePrefix(HttpRequest request);

	/// <summary>
	/// Returns the current <see cref="T:Roblox.Platform.Authentication.ISessionToken" />
	/// </summary>
	/// <returns>The current <see cref="T:Roblox.Platform.Authentication.ISessionToken" /> or null if the user is not logged in</returns>
	ISessionToken GetCurrentSessionToken();
}
