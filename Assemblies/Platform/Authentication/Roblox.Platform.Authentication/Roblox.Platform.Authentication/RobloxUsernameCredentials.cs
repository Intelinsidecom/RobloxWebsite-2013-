using System;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <summary>
/// An implementation of <see cref="T:Roblox.Platform.Authentication.IRobloxUserCredentials" /> for username credentials.
/// </summary>
internal class RobloxUsernameCredentials : UserCredentialsBase
{
	public override CredentialsType CredentialsType => CredentialsType.Username;

	public override string CredentialValue => Username;

	internal virtual string Username { get; }

	internal virtual string Password { get; }

	internal RobloxUsernameCredentials(string username, string password, IUserFactory userFactory, IPasswordsClient passwordsClient, IAuthenticationSettings authenticationSettings)
		: base(userFactory, passwordsClient, authenticationSettings)
	{
		if (string.IsNullOrWhiteSpace(username))
		{
			throw new ArgumentException("username");
		}
		if (string.IsNullOrEmpty(password))
		{
			throw new ArgumentException("password");
		}
		Username = username;
		Password = password;
	}

	public override IUser GetUser()
	{
		if (string.IsNullOrWhiteSpace(Username))
		{
			return null;
		}
		base.User = base.UserFactory.GetUserByName(Username);
		return base.User;
	}

	public override bool Verify()
	{
		IUser user = base.User ?? GetUser();
		if (user == null)
		{
			return false;
		}
		return IsValidPasswordForUser(user, Password);
	}
}
