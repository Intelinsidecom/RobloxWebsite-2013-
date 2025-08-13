using System;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

public class UserCredentialsFactory : IUserCredentialsFactory
{
	private readonly IUserFactory _UserFactory;

	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	private readonly IPhoneNumberFactory _PhoneNumberFactory;

	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly IPhoneNumberValidator _PhoneNumberValidator;

	private readonly IPasswordsClient _PasswordsClient;

	private readonly IAuthenticationSettings _AuthenticationSettings;

	/// <summary>
	/// Initializes a new instance of <see cref="T:Roblox.Platform.Authentication.UserCredentialsFactory" />.
	/// </summary>
	/// <param name="userFactory">The <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="accountEmailAddressFactory">The <see cref="T:Roblox.Platform.Email.User.IAccountEmailAddressFactory" />.</param>
	/// <param name="phoneNumberFactory">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberFactory" />.</param>
	/// <param name="accountPhoneNumberFactory">The <see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" />.</param>
	/// <param name="phoneNumberValidator">The <see cref="T:Roblox.Platform.Demographics.IPhoneNumberValidator" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="userFactory" />
	/// - <paramref name="accountEmailAddressFactory" />
	/// - <paramref name="phoneNumberFactory" />
	/// - <paramref name="accountPhoneNumberFactory" />
	/// - <paramref name="phoneNumberValidator" />
	/// </exception>
	public UserCredentialsFactory(IUserFactory userFactory, IAccountEmailAddressFactory accountEmailAddressFactory, IPhoneNumberFactory phoneNumberFactory, IAccountPhoneNumberFactory accountPhoneNumberFactory, IPhoneNumberValidator phoneNumberValidator)
		: this(userFactory, accountEmailAddressFactory, phoneNumberFactory, accountPhoneNumberFactory, phoneNumberValidator, AccountPasswordHash.PasswordsClient, Settings.Default)
	{
	}

	internal UserCredentialsFactory(IUserFactory userFactory, IAccountEmailAddressFactory accountEmailAddressFactory, IPhoneNumberFactory phoneNumberFactory, IAccountPhoneNumberFactory accountPhoneNumberFactory, IPhoneNumberValidator phoneNumberValidator, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_AccountEmailAddressFactory = accountEmailAddressFactory ?? throw new ArgumentNullException("accountEmailAddressFactory");
		_PhoneNumberFactory = phoneNumberFactory ?? throw new ArgumentNullException("phoneNumberFactory");
		_AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new ArgumentNullException("accountPhoneNumberFactory");
		_PhoneNumberValidator = phoneNumberValidator ?? throw new ArgumentNullException("phoneNumberValidator");
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
		_AuthenticationSettings = authenticationSettings ?? throw new ArgumentNullException("authenticationSettings");
	}

	/// <inheritdoc />
	public IRobloxUserCredentials BuildUserCredentials(CredentialsType credentialsType, string credentialsValue, string password)
	{
		if (string.IsNullOrWhiteSpace(credentialsValue))
		{
			throw new ArgumentException("Credentials value can not be null or whitespace", "credentialsValue");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("Credentials password can not be null or empty", "password");
		}
		return credentialsType switch
		{
			CredentialsType.Username => new RobloxUsernameCredentials(credentialsValue, password, _UserFactory, _PasswordsClient, _AuthenticationSettings), 
			CredentialsType.Email => new RobloxEmailCredentials(credentialsValue, password, _UserFactory, _AccountEmailAddressFactory, _PasswordsClient, _AuthenticationSettings), 
			CredentialsType.PhoneNumber => new RobloxPhoneNumberCredentials(credentialsValue, password, _UserFactory, _PhoneNumberFactory, _AccountPhoneNumberFactory, _PhoneNumberValidator, _PasswordsClient, _AuthenticationSettings), 
			_ => throw new ArgumentException("Unsupported credentials type", "credentialsType"), 
		};
	}
}
