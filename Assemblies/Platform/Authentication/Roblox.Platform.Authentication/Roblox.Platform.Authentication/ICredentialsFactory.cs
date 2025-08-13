using System;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification;

namespace Roblox.Platform.Authentication;

/// <summary>
/// An interface for a factory that generates <see cref="T:Roblox.Platform.Authentication.ICredentials" />.
/// </summary>
public interface ICredentialsFactory
{
	/// <summary>
	/// Builds credentials for login via Facebook.
	/// </summary>
	/// <param name="facebookId">The user's Facebook id.</param>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Authentication.IFacebookCredentials" /> for authentication, or null.</returns>
	IFacebookCredentials BuildFacebookCredentials(ulong facebookId);

	/// <summary>
	/// Builds credentials for login via Xbox.
	/// </summary>
	/// <param name="xboxPairWiseId">The Xbox PairWiseId.</param>
	/// <param name="xboxLiveAccountDataAccessor">An <see cref="T:Roblox.Platform.Authentication.IXboxLiveAccountDataAccessor" />.</param>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Authentication.IXboxLiveCredentials" /> for authentication, or null.</returns>
	IXboxLiveCredentials BuildXboxLiveCredentials(string xboxPairWiseId, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor);

	/// <summary>
	/// Builds credentials for authenticating as a specific <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="name">The other <see cref="T:Roblox.Platform.Membership.IUser" />'s name.</param>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Authentication.IAuthenticateAsUserCredentials" /> for authentication, or null.</returns>
	[Obsolete("Please use the signature that takes an IUser.")]
	IAuthenticateAsUserCredentials BuildAuthenticateAsUserCredentials(string name);

	/// <summary>
	/// Builds credentials for authenticating as a specific <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The other <see cref="T:Roblox.Platform.Membership.IUser" /> to authenticate as.</param>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Authentication.IAuthenticateAsUserCredentials" /> for authentication.</returns>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="user" />
	/// </exception>
	IAuthenticateAsUserCredentials BuildAuthenticateAsUserCredentials(IUser user);

	/// <summary>
	/// Builds credentials for login via Roblox <paramref name="accountName" /> and <paramref name="password" />.
	/// </summary>
	/// <param name="accountName">The name of the account.</param>
	/// <param name="password">The account's password.</param>
	/// <returns>An instance of <see cref="T:Roblox.Platform.Authentication.IRobloxCredentials" /> for authentication, or null.</returns>
	[Obsolete("Use ICredentialsV2Factory.BuildUserCredentials instead. Use CredentialsType.Username for accountName credentials.")]
	IRobloxCredentials BuildRobloxCredentialsFromAccountNameAndPassword(string accountName, string password);

	/// <summary>
	/// Builds 2SV credentials from an <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge" />
	/// </summary>
	/// <param name="challenge">An <see cref="T:Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO" /></param>
	/// <param name="twoStepVerificationCodeValidator">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator" />.</param>
	/// <returns>
	/// An instance of the <see cref="T:Roblox.Platform.Authentication.ITwoStepVerificationCredentials" /> for authentication, or null.
	/// </returns>
	ITwoStepVerificationCredentials BuildTwoStepVerificationCredentialsFromChallenge(ITwoStepVerificationCodeValidator twoStepVerificationCodeValidator, TwoStepVerificationChallengeDTO challenge);
}
