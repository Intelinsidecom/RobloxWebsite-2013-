using System;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification;

namespace Roblox.Platform.Authentication;

public class CredentialsFactory : ICredentialsFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IPasswordsClient _PasswordsClient;

	private readonly IAuthenticationSettings _AuthenticationSettings;

	public CredentialsFactory(IUserFactory userFactory)
		: this(userFactory, AccountPasswordHash.PasswordsClient, Settings.Default)
	{
	}

	public CredentialsFactory(IUserFactory userFactory, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
		_AuthenticationSettings = authenticationSettings ?? throw new ArgumentNullException("authenticationSettings");
	}

	public IFacebookCredentials BuildFacebookCredentials(ulong facebookId)
	{
		return new FacebookCredentials(facebookId, _UserFactory);
	}

	public IXboxLiveCredentials BuildXboxLiveCredentials(string xboxPairWiseId, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor)
	{
		if (string.IsNullOrWhiteSpace(xboxPairWiseId))
		{
			return null;
		}
		return new XboxLiveCredentials(xboxPairWiseId, xboxLiveAccountDataAccessor, _UserFactory);
	}

	[Obsolete("Please use the signature that takes an IUser.")]
	public IAuthenticateAsUserCredentials BuildAuthenticateAsUserCredentials(string name)
	{
		if (string.IsNullOrWhiteSpace(name))
		{
			return null;
		}
		return new AuthenticateAsUserCredentials(name, _UserFactory);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.ICredentialsFactory.BuildAuthenticateAsUserCredentials(Roblox.Platform.Membership.IUser)" />
	public IAuthenticateAsUserCredentials BuildAuthenticateAsUserCredentials(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		return new AuthenticateAsUserCredentials(user, _UserFactory);
	}

	[Obsolete("Use CredentialsV2Factory.BuildUserCredentials instead. Use CredentialsType.Username for accountName credentials.")]
	public IRobloxCredentials BuildRobloxCredentialsFromAccountNameAndPassword(string accountName, string password)
	{
		if (string.IsNullOrWhiteSpace(accountName) || string.IsNullOrWhiteSpace(password))
		{
			return null;
		}
		IUser user = _UserFactory.GetUserByName(accountName);
		if (user == null)
		{
			return null;
		}
		return new RobloxCredentials(user, password, _UserFactory, _PasswordsClient, _AuthenticationSettings);
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.ICredentialsFactory.BuildTwoStepVerificationCredentialsFromChallenge(Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator,Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO)" />
	public ITwoStepVerificationCredentials BuildTwoStepVerificationCredentialsFromChallenge(ITwoStepVerificationCodeValidator twoStepVerificationCodeValidator, TwoStepVerificationChallengeDTO challenge)
	{
		if (challenge?.UserIdentifier == null)
		{
			return null;
		}
		if (_UserFactory.GetUser(challenge.UserIdentifier.Id) == null)
		{
			return null;
		}
		return new TwoStepVerificationCredentials(twoStepVerificationCodeValidator, _UserFactory, challenge);
	}
}
