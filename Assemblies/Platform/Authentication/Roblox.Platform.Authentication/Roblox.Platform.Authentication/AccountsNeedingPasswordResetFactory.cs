using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.EventLog;
using Roblox.Passwords.Client;
using Roblox.Platform.Authentication.Properties;
using Roblox.Platform.Membership;

namespace Roblox.Platform.Authentication;

/// <inheritdoc cref="T:Roblox.Platform.Authentication.IAccountsNeedingPasswordResetFactory" />
public class AccountsNeedingPasswordResetFactory : IAccountsNeedingPasswordResetFactory
{
	private readonly IAuthenticationSettings _AuthenticationSettings;

	private readonly IPasswordsClient _PasswordsClient;

	/// <summary>
	/// Initializes a new <see cref="T:Roblox.Platform.Authentication.AccountsNeedingPasswordResetFactory" />.
	/// </summary>
	/// <param name="passwordsClient">An <see cref="T:Roblox.Passwords.Client.IPasswordsClient" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	/// - <paramref name="passwordsClient" />
	/// - <paramref name="logger" />
	/// </exception>
	[ExcludeFromCodeCoverage]
	public AccountsNeedingPasswordResetFactory(IPasswordsClient passwordsClient, ILogger logger)
		: this(Settings.Default, passwordsClient)
	{
	}

	internal AccountsNeedingPasswordResetFactory(IAuthenticationSettings authenticationSettings, IPasswordsClient passwordsClient)
	{
		_AuthenticationSettings = authenticationSettings ?? throw new ArgumentNullException("authenticationSettings");
		_PasswordsClient = passwordsClient ?? throw new ArgumentNullException("passwordsClient");
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.IAccountsNeedingPasswordResetFactory.GetAccountNeedsPasswordReset(Roblox.Platform.Membership.IUser)" />
	public bool GetAccountNeedsPasswordReset(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (!_AuthenticationSettings.IsAccountsNeedingPasswordResetsEnabled)
		{
			return false;
		}
		return _PasswordsClient.GetPasswordStatus(PasswordOwnerType.Account, user.AccountId).SetStatus == PasswordSetStatus.PasswordNeedsReset;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Authentication.IAccountsNeedingPasswordResetFactory.SetAccountNeedsPasswordReset(Roblox.Platform.Membership.IUser,System.Boolean)" />
	public void SetAccountNeedsPasswordReset(IUser user, bool needsReset)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (_AuthenticationSettings.IsAccountsNeedingPasswordResetsEnabled && DoSetAccountNeedsPasswordReset(user, needsReset) && needsReset)
		{
			DeleteAllAuthenticationSessions(user);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual void DeleteAllAuthenticationSessions(IUser user)
	{
		SessionTokenFactory.DeleteAll(user);
	}

	private bool DoSetAccountNeedsPasswordReset(IUser user, bool needsReset)
	{
		return _PasswordsClient.SetPasswordResetRequired(PasswordOwnerType.Account, user.AccountId, needsReset) == SetPasswordResetRequiredResult.Success;
	}
}
