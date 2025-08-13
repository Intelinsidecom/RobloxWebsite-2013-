using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Configuration;
using Roblox.Platform.Authentication;
using Roblox.Platform.Authentication.AccountSecurity.Properties;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Core;
using Roblox.Platform.Demographics;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Membership;
using Roblox.Platform.Security;
using Roblox.Platform.Security.SecureBlobs;
using Roblox.Platform.TwoStepVerification;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication.Passwords;

/// <inheritdoc cref="T:Roblox.Web.Authentication.Passwords.IPasswordChangeAuthority" />
public class PasswordChangeAuthority : IPasswordChangeAuthority
{
	private readonly IPasswordValidatorFactory _PasswordValidatorFactory;

	private readonly IAccountsNeedingPasswordResetFactory _AccountsNeedingPasswordResetFactory;

	private readonly IWebAuthenticator _WebAuthenticator;

	private readonly IEmailSender _EmailSender;

	private readonly IAccountSecurityTicketsFactory _AccountSecurityTicketsFactory;

	private readonly IAccountPhoneNumberFactory _AccountPhoneNumberFactory;

	private readonly ITwoStepVerificationSessionPurger _TwoStepVerificationSessionPurger;

	private readonly ISecureBlobAuthority<PasswordRevertTicket> _SecureBlobAuthority;

	private const string _RevertAccountEmailFrom = "\"Roblox Password Reset\" <no-reply@roblox.com>";

	private const string _RevertAccountEmailSubject = "Roblox Password Reset";

	private const string _RevertAccountEmailType = "RevertAccount:Password";

	private const string _RevertAccountEmailBodyPlainText = "We noticed that the password changed for your Roblox account: {0}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\r\n{1}\r\n\r\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up.\r\nPlease do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";

	private const string _RevertAccountEmailBodyHtml = "We noticed that the password changed for your Roblox account: {0}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\r\n<br />\r\n<a href=\"{1}\">{2}</a>\r\n<br />\r\n<br />\r\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up.\r\nPlease do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.Passwords.PasswordChangeAuthority" /> class.
	/// </summary>
	/// <param name="passwordValidatorFactory"><see cref="T:Roblox.Platform.Membership.IPasswordValidatorFactory" /></param>
	/// <param name="accountsNeedingPasswordResetFactory"><see cref="T:Roblox.Platform.Authentication.IAccountsNeedingPasswordResetFactory" /></param>
	/// <param name="webAuthenticator"><see cref="T:Roblox.Web.Authentication.IWebAuthenticator" /></param>
	/// <param name="emailClient"><see cref="!:IEmailClient" /></param>
	/// <param name="accountSecurityTicketsFactory"><see cref="T:Roblox.Platform.Authentication.AccountSecurityTickets.IAccountSecurityTicketsFactory" /></param>
	/// <param name="twoStepVerificationSessionPurger"><see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger" /></param>
	/// <param name="accountPhoneNumberFactory"><see cref="T:Roblox.Platform.Demographics.IAccountPhoneNumberFactory" /></param>
	/// <exception cref="T:System.ArgumentNullException">Any arguments are null.</exception>
	public PasswordChangeAuthority(IPasswordValidatorFactory passwordValidatorFactory, IAccountsNeedingPasswordResetFactory accountsNeedingPasswordResetFactory, IWebAuthenticator webAuthenticator, IEmailSender emailClient, IAccountSecurityTicketsFactory accountSecurityTicketsFactory, ITwoStepVerificationSessionPurger twoStepVerificationSessionPurger, IAccountPhoneNumberFactory accountPhoneNumberFactory)
	{
		_PasswordValidatorFactory = passwordValidatorFactory ?? throw new ArgumentNullException("passwordValidatorFactory");
		_AccountsNeedingPasswordResetFactory = accountsNeedingPasswordResetFactory ?? throw new ArgumentNullException("accountsNeedingPasswordResetFactory");
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentNullException("webAuthenticator");
		_EmailSender = emailClient ?? throw new ArgumentNullException("emailClient");
		_AccountSecurityTicketsFactory = accountSecurityTicketsFactory ?? throw new ArgumentNullException("accountSecurityTicketsFactory");
		_TwoStepVerificationSessionPurger = twoStepVerificationSessionPurger ?? throw new ArgumentNullException("twoStepVerificationSessionPurger");
		_AccountPhoneNumberFactory = accountPhoneNumberFactory ?? throw new ArgumentNullException("accountPhoneNumberFactory");
		_SecureBlobAuthority = new SecureBlobAuthority<PasswordRevertTicket>(GeneratePasswordRevertTicketSecret);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.Passwords.IPasswordChangeAuthority.ChangePassword(Roblox.Platform.Membership.IUser,System.String,System.Boolean,System.Boolean)" />
	public void ChangePassword(IUser user, string newPassword, bool sendRevertEmail, bool checkPasswordRules)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrEmpty(newPassword))
		{
			throw new PlatformArgumentNullException("newPassword");
		}
		if (checkPasswordRules && !_PasswordValidatorFactory.CheckPasswordRulesAndPasswordIsNotCurrent(user, newPassword, out var errorMessage))
		{
			throw new InvalidPasswordException(errorMessage);
		}
		SetPassword(user, newPassword);
		_WebAuthenticator.SignOutFromAllSessions(user, _TwoStepVerificationSessionPurger);
		if (_AccountsNeedingPasswordResetFactory.GetAccountNeedsPasswordReset(user))
		{
			_AccountsNeedingPasswordResetFactory.SetAccountNeedsPasswordReset(user, needsReset: false);
		}
		if (!sendRevertEmail)
		{
			return;
		}
		string email;
		Guid accountSecurityTicket = CreateAccountSecurityTicket(user, out email);
		string ticket;
		if (Roblox.Web.Authentication.Properties.Settings.Default.IsRevertTicketSecureBlobEnabled)
		{
			PasswordRevertTicket revertTicket = new PasswordRevertTicket
			{
				Email = email,
				Guid = accountSecurityTicket
			};
			EncryptionKey encryptionKey = EncryptionKey.Classic;
			if (SecurityKeySettings.Default.UsePasswordResetSignatureKey)
			{
				encryptionKey = EncryptionKey.PasswordReset;
			}
			ticket = _SecureBlobAuthority.GenerateSecureBlob(revertTicket, encryptionKey).ToString();
		}
		else
		{
			ticket = accountSecurityTicket.ToString();
		}
		if (!accountSecurityTicket.Equals(Guid.Empty))
		{
			_EmailSender.SendEmail(new Email("\"Roblox Password Reset\" <no-reply@roblox.com>", email, "Roblox Password Reset", EmailBodyType.Mime, "RevertAccount:Password", BuildRevertEmail(user, ticket, isHtmlFormat: false), BuildRevertEmail(user, ticket, isHtmlFormat: true)));
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.Passwords.IPasswordChangeAuthority.GetRevertTicketFromSecureBlob(System.String)" />
	public PasswordRevertTicket GetRevertTicketFromSecureBlob(string ticket)
	{
		EncryptionKey[] encryptionKeys = GetEncryptionKeysForBlobDecryption();
		return _SecureBlobAuthority.GetModelFromSecureBlob(ticket, encryptionKeys);
	}

	private EncryptionKey[] GetEncryptionKeysForBlobDecryption()
	{
		List<EncryptionKey> encryptionKeys = new List<EncryptionKey>();
		if (SecurityKeySettings.Default.UsePasswordResetSignatureKey)
		{
			encryptionKeys.Add(EncryptionKey.PasswordReset);
			if (SecurityKeySettings.Default.UseClassicAndNewKeyForPasswordReset)
			{
				encryptionKeys.Add(EncryptionKey.Classic);
			}
		}
		else
		{
			encryptionKeys.Add(EncryptionKey.Classic);
		}
		return encryptionKeys.ToArray();
	}

	internal string BuildRevertEmail(IUser user, string ticket, bool isHtmlFormat)
	{
		if (!isHtmlFormat)
		{
			return $"We noticed that the password changed for your Roblox account: {user.Name}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\r\n{BuildResetPasswordUrl(ticket)}\r\n\r\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up.\r\nPlease do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";
		}
		return $"We noticed that the password changed for your Roblox account: {user.Name}. If you didn't intend to change it, or you think someone else changed it by mistake, please click this link to undo the action:\r\n<br />\r\n<a href=\"{BuildResetPasswordUrl(ticket)}\">{BuildResetPasswordUrl(null)}</a>\r\n<br />\r\n<br />\r\nIf you are happy with your new Roblox password, you don't have to do anything! It's already set up.\r\nPlease do not reply to this message. If you have any questions, please see the Roblox help page (https://www.roblox.com/help).";
	}

	[ExcludeFromCodeCoverage]
	internal virtual string BuildResetPasswordUrl(string ticket)
	{
		if (string.IsNullOrEmpty(ticket))
		{
			return $"{RobloxEnvironment.WebsiteHttpsUrl}/login/revertAccount";
		}
		return $"{RobloxEnvironment.WebsiteHttpsUrl}/login/revertAccount?ticket={ticket}";
	}

	[ExcludeFromCodeCoverage]
	internal virtual Guid CreateAccountSecurityTicket(IUser user, out string email)
	{
		AccountEmailAddress accountEmailAddress = AccountEmailAddress.GetCurrent(user.AccountId);
		if (accountEmailAddress == null)
		{
			email = null;
			return Guid.Empty;
		}
		AccountPasswordHash oldAccountPasswordHash = AccountPasswordHash.GetCurrent(user.AccountId);
		Account account = Account.Get(user.AccountId);
		AccountSecurityTicket accountSecurityTicket = AccountSecurityTicket.CreateNew(account, accountEmailAddress, oldAccountPasswordHash);
		if (Roblox.Platform.Authentication.AccountSecurity.Properties.Settings.Default.IsAccountSecurityTicketsV2Enabled)
		{
			IAccountPhoneNumber currentPhoneNumber = _AccountPhoneNumberFactory.GetVerifiedForUser(user);
			_AccountSecurityTicketsFactory.CreateAccountSecurityTickets(account.ID, accountSecurityTicket.GUID, accountEmailAddress.ID, oldAccountPasswordHash.ID, currentPhoneNumber?.PhoneNumberId);
		}
		email = account.Email;
		return accountSecurityTicket.GUID;
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GeneratePasswordRevertTicketSecret(PasswordRevertTicket ticket)
	{
		return "PasswordRevertByEmail" + $"\nEmail:{ticket.Email}" + $"\nGuid:{ticket.Guid}";
	}

	[ExcludeFromCodeCoverage]
	internal virtual void SetPassword(IUser user, string newPassword)
	{
		Account.Get(user.AccountId).SetPassword(newPassword);
	}
}
