using System;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication.Factories;

/// <summary>
/// An implementation of a factory that builds <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentials" />.
/// </summary>
public class RobloxUnverifiedUserCredentialsFactory : IRobloxUnverifiedUserCredentialsFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	private readonly IPasswordsClient _PasswordsClient;

	private readonly IAuthenticationSettings _AuthenticationSettings;

	/// <summary>
	/// Initializes a new instance of an <see cref="T:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentialsFactory" />
	/// </summary>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="accountEmailAddressFactory">The <see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="userFactory" />
	/// - <paramref name="accountEmailAddressFactory" />
	/// </exception>
	public RobloxUnverifiedUserCredentialsFactory(IUserFactory userFactory, IAccountEmailAddressFactory accountEmailAddressFactory)
		: this(userFactory, accountEmailAddressFactory, AccountPasswordHash.PasswordsClient, Settings.Default)
	{
	}

	internal RobloxUnverifiedUserCredentialsFactory(IUserFactory userFactory, IAccountEmailAddressFactory accountEmailAddressFactory, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_AccountEmailAddressFactory = accountEmailAddressFactory ?? throw new ArgumentNullException("accountEmailAddressFactory");
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
		_AuthenticationSettings = authenticationSettings ?? throw new ArgumentNullException("authenticationSettings");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.IRobloxUnverifiedUserCredentialsFactory.BuildUserCredentials(Roblox.Platform.Authentication.CredentialsType,System.String,System.String)" />
	public IRobloxUnverifiedUserCredentials BuildUserCredentials(CredentialsType credentialsType, string credentialsValue, string password)
	{
		if (string.IsNullOrWhiteSpace(credentialsValue))
		{
			throw new ArgumentException("Credentials value can not be null or whitespace", "credentialsValue");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("Credentials password can not be null or empty", "password");
		}
		if (credentialsType == CredentialsType.Email)
		{
			return new RobloxEmailCredentials(credentialsValue, password, _UserFactory, _AccountEmailAddressFactory, _PasswordsClient, _AuthenticationSettings);
		}
		throw new ArgumentException("Unsupported credentials type", "credentialsType");
	}
}
