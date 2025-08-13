using System;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <summary>
/// A base implementation for all user credentials classes.
/// </summary>
internal abstract class UserCredentialsBase : CredentialsBase, IRobloxUserCredentials, IRobloxCredentials, ICredentials
{
	private readonly IPasswordsClient _PasswordsClient;

	private readonly IAuthenticationSettings _Settings;

	public abstract CredentialsType CredentialsType { get; }

	public abstract string CredentialValue { get; }

	protected IUser User { get; set; }

	protected UserCredentialsBase(IUserFactory userFactory, IPasswordsClient passwordsClient, IAuthenticationSettings settings)
		: base(userFactory)
	{
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
		_Settings = settings ?? throw new ArgumentNullException("settings");
	}

	/// <summary>
	/// Gets the <see cref="T:Roblox.Platform.Membership.IUser" /> for the current credentials.
	/// </summary>
	/// <returns></returns>
	public abstract IUser GetUser();

	/// <summary>
	/// Verifies the current credentials.
	/// </summary>
	/// <returns></returns>
	public abstract bool Verify();

	protected override IUser DoAuthentication()
	{
		IUser user = User ?? GetUser();
		if (user == null)
		{
			return null;
		}
		if (!Verify())
		{
			return null;
		}
		return user;
	}

	internal virtual bool IsValidPasswordForUser(IUser user, string password)
	{
		if (user == null)
		{
			return false;
		}
		if (string.IsNullOrEmpty(password))
		{
			return false;
		}
		VerifyPasswordResult verifyPasswordResult = _PasswordsClient.VerifyPassword(PasswordOwnerType.Account, user.AccountId, password);
		if (verifyPasswordResult != VerifyPasswordResult.PasswordNeedsReset)
		{
			return verifyPasswordResult == VerifyPasswordResult.ValidPasswordHash;
		}
		return true;
	}
}
