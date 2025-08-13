using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Roblox.Assets.Properties;
using Roblox.Configuration;
using Roblox.EphemeralCounters;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.AssetOwnership;
using Roblox.Platform.Assets;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Email.Properties;
using Roblox.Platform.Email.User.Admin;
using Roblox.Platform.EventStream;
using Roblox.Platform.EventStream.WebEvents;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.Security.SecureBlobs;
using Roblox.Properties;
using Roblox.TranslationResources;
using Roblox.TranslationResources.Communication;
using Roblox.TranslationResources.Feature;

namespace Roblox.Platform.Email.User;

internal class UserEmailVerifier : IUserEmailVerifier
{
	private readonly IEmailSender _EmailSender;

	private readonly IEmailAddressValidator _EmailAddressValidator;

	private readonly IUserEmailChanger _UserEmailChanger;

	private readonly IUserFactory _UserFactory;

	private readonly ISecureBlobAuthority<UserEmailVerificationTicket> _SecureBlobAuthority;

	private readonly IEventStreamer _EventStreamer;

	private readonly IUserEmailFloodCheckerFactory _UserEmailFloodCheckerFactory;

	private readonly IAssetOwnershipAuthority _AssetOwnershipAuthority;

	private readonly ILocalizationResourceProvider _LocalizationResourceProvider;

	private const string _VerificationEmailType = "EmailVerification";

	private const string _ParentalPageLink = "https://corp.roblox.com/parents/";

	private const string _EphemeralCounterSendVerificationEmailBase = "UserEmailVerifier_SendVerificationEmail:";

	internal ICounter SendVerificationEmailCounterAttempt;

	internal ICounter SendVerificationEmailCounterFeatureDisabled;

	internal ICounter SendVerificationEmailCounterAlreadyVerified;

	internal ICounter SendVerificationEmailCounterInvalidEmailFormat;

	internal ICounter SendVerificationEmailCounterBlacklisted;

	internal ICounter SendVerificationEmailCounterInvalidDomain;

	internal ICounter SendVerificationEmailCounterSendFailed;

	internal ICounter SendVerificationEmailCounterSuccess;

	private const string _EphemeralCounterVerifyUserEmailWithTicketBase = "UserEmailVerifier_VerifyUserEmailWithTicket";

	internal ICounter VerifyUserEmailWithTicketCounterAttempt;

	internal ICounter VerifyUserEmailWithTicketCounterFeatureDisabled;

	internal ICounter VerifyUserEmailWithTicketCounterInvalidTicket;

	internal ICounter VerifyUserEmailWithTicketCounterInvalidTicketData;

	internal ICounter VerifyUserEmailWithTicketCounterExpiredTicket;

	internal ICounter VerifyUserEmailWithTicketCounterInvalidEmail;

	internal ICounter VerifyUserEmailWithTicketCounterSuccess;

	[ExcludeFromCodeCoverage]
	internal virtual string NoReplyEmailAddress => $"<{Roblox.Platform.Email.Properties.Settings.Default.NoReplyEmailAddress}>";

	[ExcludeFromCodeCoverage]
	internal virtual string AccountSecurityLink => $"{RobloxEnvironment.WebsiteHttpsUrl}/my/account#!/security";

	[ExcludeFromCodeCoverage]
	internal virtual string AccountPrivacyLink => $"{RobloxEnvironment.WebsiteHttpsUrl}/my/account#!/privacy";

	[ExcludeFromCodeCoverage]
	internal virtual string ParentsLink => $"{RobloxEnvironment.WebsiteHttpsUrl}/info/parents";

	[ExcludeFromCodeCoverage]
	internal virtual string PrivacyLink => $"{RobloxEnvironment.WebsiteHttpsUrl}/info/privacy";

	[ExcludeFromCodeCoverage]
	internal virtual string SupportLink => $"{RobloxEnvironment.WebsiteHttpsUrl}/support";

	[ExcludeFromCodeCoverage]
	internal virtual string RobloxWebsiteLink => $"{RobloxEnvironment.WebsiteHttpsUrl}";

	[ExcludeFromCodeCoverage]
	public virtual TimeSpan EmailVerificationTicketExpiration => Roblox.Platform.Email.Properties.Settings.Default.EmailVerificationTicketExpiration;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsUserEmailVerificationEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsUserEmailVerificationEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsUserEmailChangeEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsUserEmailChangeEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsSettingBasedHelpPageLinkLocalizationEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsSettingBasedHelpPageLinkLocalizationEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsEmailVerificationUsingASTEnabled => Roblox.Properties.Settings.Default.IsEmailVerificationUsingASTEnabled;

	internal UserEmailVerifier(IEmailSender emailSender, IEmailAddressValidator emailAddressValidator, IUserEmailFloodCheckerFactory userEmailFloodCheckerFactory, IUserEmailChanger userEmailChanger, IUserFactory userFactory, IEphemeralCounterFactory ephemeralCounterFactory, IAssetOwnershipAuthority assetOwnershipAuthority, IEventStreamer eventStreamer, ILocalizationResourceProvider localizationResourceProvider)
	{
		if (ephemeralCounterFactory == null)
		{
			throw new PlatformArgumentNullException("ephemeralCounterFactory");
		}
		_EmailSender = emailSender ?? throw new PlatformArgumentNullException("emailSender");
		_EmailAddressValidator = emailAddressValidator ?? throw new PlatformArgumentNullException("emailAddressValidator");
		_UserEmailChanger = userEmailChanger ?? throw new PlatformArgumentNullException("userEmailChanger");
		_UserFactory = userFactory ?? throw new PlatformArgumentNullException("userFactory");
		_SecureBlobAuthority = new SecureBlobAuthority<UserEmailVerificationTicket>(GenerateEmailVerificationTicketSecret);
		_EventStreamer = eventStreamer ?? throw new PlatformArgumentNullException("eventStreamer");
		_UserEmailFloodCheckerFactory = userEmailFloodCheckerFactory ?? throw new PlatformArgumentNullException("userEmailFloodCheckerFactory");
		_AssetOwnershipAuthority = assetOwnershipAuthority ?? throw new PlatformArgumentNullException("assetOwnershipAuthority");
		_LocalizationResourceProvider = localizationResourceProvider ?? throw new PlatformArgumentNullException("localizationResourceProvider");
		InitializeEphemeralCounters(ephemeralCounterFactory);
	}

	public void SendVerificationEmail(IUser user, string emailAddress, bool freeItem = false, string ticket = "")
	{
		SendVerificationEmailValidateInputs(user, emailAddress);
		IFloodChecker verifyEmailFloodChecker = _UserEmailFloodCheckerFactory.GetFloodCheckerForVerifyEmail(user);
		if (verifyEmailFloodChecker.IsFlooded())
		{
			throw new PlatformFloodedException($"User: {user.Id} sent verification email too many times.");
		}
		Tuple<int, string, bool> currentAccountEmailAddress = GetAccountEmailAddress(user);
		bool isEmailUnchanged = currentAccountEmailAddress?.Item2.Equals(emailAddress, StringComparison.OrdinalIgnoreCase) ?? false;
		if (currentAccountEmailAddress != null && isEmailUnchanged && currentAccountEmailAddress.Item3)
		{
			SendVerificationEmailCounterAlreadyVerified.IncrementInBackground();
			throw new PlatformInvalidOperationException();
		}
		SendVerificationEmailValidateEmail(emailAddress);
		if (!IsEmailVerificationUsingASTEnabled)
		{
			ticket = GenerateEmailVerificationTicket(user, emailAddress);
		}
		IMasterResources obj = _LocalizationResourceProvider.GetLocalizationResources(user) ?? throw new PlatformOperationUnavailableException("Cannot find resources needed to send an email.");
		IAccountSettingsResources accountSettingsResources = obj.Feature.AccountSettings;
		ICommonEmailResources commonEmailResources = obj.Communication.CommonEmail;
		string from = (IsUserUnder13(user) ? accountSettingsResources.DescriptionVerificationEmailFromUnder13("\"", "\"", NoReplyEmailAddress) : accountSettingsResources.DescriptionVerificationEmailFromOver13("\"", "\"", NoReplyEmailAddress));
		string subject = (IsUserUnder13(user) ? accountSettingsResources.DescriptionVerificationEmailSubjectUnder13 : accountSettingsResources.DescriptionVerificationEmailSubjectOver13);
		try
		{
			Roblox.Platform.Email.Delivery.Email email = new Roblox.Platform.Email.Delivery.Email(from, emailAddress, subject, EmailBodyType.Mime, "EmailVerification", BuildVerificationEmail(accountSettingsResources, user, ticket, freeItem, htmlFormat: false), BuildVerificationEmail(accountSettingsResources, user, ticket, freeItem, htmlFormat: true));
			_EmailSender.SendEmail(email, commonEmailResources);
			verifyEmailFloodChecker.UpdateCount();
		}
		catch (EmailQueueingException)
		{
			SendVerificationEmailCounterSendFailed.IncrementInBackground();
			throw;
		}
		SendVerificationEmailCounterSuccess.IncrementInBackground();
	}

	private void SendVerificationEmailValidateInputs(IUser user, string emailAddress)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrEmpty(emailAddress))
		{
			throw new PlatformArgumentException("emailAddress");
		}
		SendVerificationEmailCounterAttempt.IncrementInBackground();
		if (!IsUserEmailVerificationEnabled || !IsUserEmailChangeEnabled)
		{
			SendVerificationEmailCounterFeatureDisabled.IncrementInBackground();
			throw new PlatformOperationUnavailableException();
		}
	}

	private void SendVerificationEmailValidateEmail(string emailAddress)
	{
		if (!_EmailAddressValidator.IsValidEmail(emailAddress))
		{
			SendVerificationEmailCounterInvalidEmailFormat.IncrementInBackground();
			throw new PlatformInvalidEmailAddressException("Invalid", "The email cannot be used.");
		}
		if (_EmailAddressValidator.IsShadyProvider(emailAddress) || _EmailAddressValidator.IsBlacklisted(emailAddress))
		{
			SendVerificationEmailCounterBlacklisted.IncrementInBackground();
			throw new PlatformInvalidEmailAddressException("Blacklisted", "The email cannot be used.");
		}
		if (!_EmailAddressValidator.IsEmailDomainValid(emailAddress))
		{
			SendVerificationEmailCounterInvalidDomain.IncrementInBackground();
			throw new PlatformInvalidEmailAddressException("InvalidDomain", "The email does not have a valid domain.");
		}
	}

	private bool IsAccountSecurityTicketExpired(AccountSecurityTicket ticket, int targetEmailId)
	{
		AccountEmailAddress currentUnverified = AccountEmailAddress.GetCurrentUnverified(ticket.AccountID);
		DateTime created = ticket.Created;
		DateTime now = DateTime.Now;
		DateTime end = created.Add(EmailVerificationTicketExpiration);
		if (currentUnverified != null && currentUnverified.ID == targetEmailId)
		{
			return now > end;
		}
		return true;
	}

	public UserEmailVerificationResult VerifyUserEmailWithAccountSecurityTicket(string ticket)
	{
		if (string.IsNullOrEmpty(ticket))
		{
			throw new PlatformArgumentException("ticket");
		}
		VerifyUserEmailWithTicketCounterAttempt.IncrementInBackground();
		if (!IsUserEmailVerificationEnabled || !IsUserEmailChangeEnabled)
		{
			VerifyUserEmailWithTicketCounterFeatureDisabled.IncrementInBackground();
			throw new PlatformOperationUnavailableException();
		}
		AccountSecurityTicket accountSecurityTicket = AccountSecurityTicket.Get(ticket);
		if (!accountSecurityTicket.IsValid)
		{
			throw new PlatformFormatException("Invalid ticket.");
		}
		IUser user = _UserFactory.GetUserByAccountId(accountSecurityTicket.AccountID);
		AccountEmailAddress currentVerifiedEmail = AccountEmailAddress.GetCurrentVerified(accountSecurityTicket.AccountID);
		AccountEmailAddress targetEmail = accountSecurityTicket.AccountEmailAddress;
		int? currentVerifiedEmailId = currentVerifiedEmail?.ID;
		UserEmailVerificationResult verificationResult = new UserEmailVerificationResult
		{
			User = user
		};
		if (currentVerifiedEmailId == targetEmail.ID)
		{
			return verificationResult;
		}
		if (IsAccountSecurityTicketExpired(accountSecurityTicket, targetEmail.ID))
		{
			throw new PlatformExpiredException("Ticket expired.");
		}
		if (user.IsForgotten())
		{
			VerifyUserEmailWithTicketCounterInvalidTicketData.IncrementInBackground();
			throw new PlatformFormatException("Ticket was valid, but has invalid data.");
		}
		if (currentVerifiedEmailId.HasValue)
		{
			_UserEmailChanger.SendRevertEmail(user, currentVerifiedEmailId.GetValueOrDefault(), currentVerifiedEmail?.GetEmailAddress()?.Address, targetEmail?.GetEmailAddress()?.Address);
		}
		if (!targetEmail.IsVerified)
		{
			targetEmail.IsVerified = true;
			targetEmail.Save();
		}
		accountSecurityTicket.Invalidate();
		AwardEmailVerificationAssets(user);
		SendEmailVerifiedEvent(user.Id);
		VerifyUserEmailWithTicketCounterSuccess.IncrementInBackground();
		return verificationResult;
	}

	public UserEmailVerificationResult VerifyUserEmailWithTicket(string ticket)
	{
		if (string.IsNullOrEmpty(ticket))
		{
			throw new PlatformArgumentException("ticket");
		}
		VerifyUserEmailWithTicketCounterAttempt.IncrementInBackground();
		if (!IsUserEmailVerificationEnabled || !IsUserEmailChangeEnabled)
		{
			VerifyUserEmailWithTicketCounterFeatureDisabled.IncrementInBackground();
			throw new PlatformOperationUnavailableException();
		}
		UserEmailVerificationTicket ticketModel;
		try
		{
			ticketModel = GetEmailVerificationTicketModel(ticket);
		}
		catch (PlatformFormatException e2)
		{
			VerifyUserEmailWithTicketCounterInvalidTicket.IncrementInBackground();
			throw new PlatformFormatException("Invalid ticket.", e2);
		}
		catch (PlatformExpiredException e)
		{
			VerifyUserEmailWithTicketCounterExpiredTicket.IncrementInBackground();
			throw new PlatformExpiredException("Ticket expired.", e);
		}
		IUser user = _UserFactory.GetUser(ticketModel.UserId);
		if (user.IsForgotten() || string.IsNullOrEmpty(ticketModel.EmailAddress))
		{
			VerifyUserEmailWithTicketCounterInvalidTicketData.IncrementInBackground();
			throw new PlatformFormatException("Ticket was valid, but has invalid data.");
		}
		try
		{
			string accountSecurityTicket = _UserEmailChanger.ValidateAndSetEmail(user, ticketModel.EmailAddress, forceSet: true, sendRevertEmail: true);
			if (IsEmailVerificationUsingASTEnabled && Roblox.Properties.Settings.Default.IsFallbackToOldEmailVerificationEnabled)
			{
				VerifyUserEmailWithAccountSecurityTicket(accountSecurityTicket);
			}
		}
		catch (PlatformInvalidEmailAddressException)
		{
			VerifyUserEmailWithTicketCounterInvalidEmail.IncrementInBackground();
			throw;
		}
		TryVerifyEmail(user);
		AwardEmailVerificationAssets(user);
		SendEmailVerifiedEvent(user.Id);
		VerifyUserEmailWithTicketCounterSuccess.IncrementInBackground();
		return new UserEmailVerificationResult
		{
			User = user
		};
	}

	internal UserEmailVerificationTicket CreateEmailVerificationTicket(IUser user, string emailAddress)
	{
		return new UserEmailVerificationTicket
		{
			EmailAddress = emailAddress,
			UserId = user.Id
		};
	}

	/// <summary>
	/// Gets the email verification ticket model.
	/// </summary>
	/// <param name="ticket">The ticket.</param>
	/// <returns><see cref="T:Roblox.Platform.Email.User.UserEmailVerificationTicket" /></returns>
	/// <exception cref="T:Roblox.Platform.Core.PlatformArgumentException">Ticket is invalid.</exception>
	/// <exception cref="T:Roblox.Platform.Core.PlatformExpiredException">Ticket is expired.</exception>
	[ExcludeFromCodeCoverage]
	internal virtual UserEmailVerificationTicket GetEmailVerificationTicketModel(string ticket)
	{
		try
		{
			return _SecureBlobAuthority.GetModelFromSecureBlob(ticket);
		}
		catch (FormatException e2)
		{
			throw new PlatformFormatException("Ticket is invalid.", e2);
		}
		catch (SecureBlobExpiredException e)
		{
			throw new PlatformExpiredException("Ticket is expired.", e);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GenerateEmailVerificationTicket(IUser user, string emailAddress)
	{
		UserEmailVerificationTicket ticketModel = CreateEmailVerificationTicket(user, emailAddress);
		return _SecureBlobAuthority.GenerateSecureBlob(ticketModel, EmailVerificationTicketExpiration);
	}

	internal string BuildVerificationEmail(IAccountSettingsResources accountSettingsResources, IUser user, string ticket, bool freeItem, bool htmlFormat)
	{
		string parentalPageLink = (IsSettingBasedHelpPageLinkLocalizationEnabled ? ParentsLink : "https://corp.roblox.com/parents/");
		if (htmlFormat)
		{
			if (IsUserUnder13(user))
			{
				return accountSettingsResources.DescriptionVerificationEmailHtmlBodyUnder13("<br />", "<b>", user.Name, "</b>", "<a href=\"", BuildVerifyEmailUrl(ticket, freeItem), "\">", "<button>", "</button>", "</a>", parentalPageLink, AccountSecurityLink, AccountPrivacyLink, SupportLink, PrivacyLink, RobloxWebsiteLink);
			}
			return accountSettingsResources.DescriptionVerificationEmailHtmlBodyOver13("<br />", user.Name, "<a href=\"", BuildVerifyEmailUrl(ticket, freeItem), "\" target=\"_blank\">", "<button>", "</button>", "</a>");
		}
		if (IsUserUnder13(user))
		{
			return accountSettingsResources.DescriptionVerificationEmailPlainBodyUnder13("\r\n", user.Name, BuildVerifyEmailUrl(ticket, freeItem), parentalPageLink, AccountSecurityLink, AccountPrivacyLink, SupportLink, PrivacyLink, RobloxWebsiteLink);
		}
		return accountSettingsResources.DescriptionVerificationEmailPlainBodyOver13("\r\n", user.Name, BuildVerifyEmailUrl(ticket, freeItem));
	}

	[ExcludeFromCodeCoverage]
	internal virtual string BuildVerifyEmailUrl(string ticket, bool freeItem)
	{
		string result = $"{RobloxEnvironment.WebsiteHttpsUrl}/account/settings/verify-email?ticket={Uri.EscapeDataString(ticket)}";
		if (freeItem)
		{
			result += "&freeItem=true";
		}
		return result;
	}

	/// <summary>
	/// Attempts to verify the current email address for an <see cref="T:Roblox.Platform.Membership.IUser" />.
	/// </summary>
	/// <param name="user">The <see cref="T:Roblox.Platform.Membership.IUser" />.</param>
	[ExcludeFromCodeCoverage]
	internal virtual void TryVerifyEmail(IUser user)
	{
		AccountEmailEntityVerifier.TryVerifyEmail(user);
	}

	[ExcludeFromCodeCoverage]
	internal virtual void AwardEmailVerificationAssets(IUser user)
	{
		IReadOnlyCollection<long> constituentAssetIds = Asset.Get(Roblox.Assets.Properties.Settings.Default.VerifiedUserHatAssetId).GetConstituentAssetIds();
		_AssetOwnershipAuthority.AwardAssets(constituentAssetIds, user.Id);
	}

	[ExcludeFromCodeCoverage]
	internal virtual Tuple<int, string, bool> GetAccountEmailAddress(IUser user)
	{
		AccountEmailAddress emailEntity = AccountEmailAddress.GetCurrent(user.AccountId);
		string emailAddress = emailEntity?.GetEmailAddress()?.Address;
		if (string.IsNullOrEmpty(emailAddress))
		{
			return null;
		}
		return Tuple.Create(emailEntity.ID, emailAddress, emailEntity.IsVerified);
	}

	[ExcludeFromCodeCoverage]
	internal virtual bool IsUserUnder13(IUser user)
	{
		return user.IsUnder13();
	}

	/// <summary>
	/// Generates a secret for the blob hash for an <see cref="T:Roblox.Platform.Membership.IUser" />'s <see cref="T:Roblox.Platform.Email.User.UserEmailVerificationTicket" />.
	/// This secret is being used dual-purpose as a nonce by including information about the current email.
	/// When the email changes, this and any other tickets that may have been sent out to verify emails become invalid
	/// because the secret changes, and the ticket can no longer be validated with it.
	/// </summary>
	/// <param name="ticket">The <see cref="T:Roblox.Platform.Email.User.UserEmailVerificationTicket" /> (used to get the <see cref="T:Roblox.Platform.Membership.IUser" />).</param>
	/// <returns>A secret for the secure blob.</returns>
	[ExcludeFromCodeCoverage]
	internal virtual string GenerateEmailVerificationTicketSecret(UserEmailVerificationTicket ticket)
	{
		AccountEmailAddress currentEmail = AccountEmailAddress.GetCurrent(_UserFactory.GetUser(ticket.UserId).AccountId);
		return "EmailVerification" + $"\nCurrentEmailAddress:{currentEmail?.ID}" + $"\nIsCurrentVerified:{currentEmail?.IsVerified}";
	}

	private void InitializeEphemeralCounters(IEphemeralCounterFactory ephemeralCounterFactory)
	{
		SendVerificationEmailCounterAttempt = ephemeralCounterFactory.GetCounter(string.Format("{0}Attempt", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterFeatureDisabled = ephemeralCounterFactory.GetCounter(string.Format("{0}FeatureDisabled", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterAlreadyVerified = ephemeralCounterFactory.GetCounter(string.Format("{0}AlreadyVerified", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterInvalidEmailFormat = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidEmailFormat", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterBlacklisted = ephemeralCounterFactory.GetCounter(string.Format("{0}Blacklisted", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterSendFailed = ephemeralCounterFactory.GetCounter(string.Format("{0}SendEmailFailed", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterInvalidDomain = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidDomain", "UserEmailVerifier_SendVerificationEmail:"));
		SendVerificationEmailCounterSuccess = ephemeralCounterFactory.GetCounter(string.Format("{0}Success", "UserEmailVerifier_SendVerificationEmail:"));
		VerifyUserEmailWithTicketCounterAttempt = ephemeralCounterFactory.GetCounter(string.Format("{0}Attempt", "UserEmailVerifier_VerifyUserEmailWithTicket"));
		VerifyUserEmailWithTicketCounterFeatureDisabled = ephemeralCounterFactory.GetCounter(string.Format("{0}FeatureDisabled", "UserEmailVerifier_VerifyUserEmailWithTicket"));
		VerifyUserEmailWithTicketCounterInvalidTicket = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidTicket", "UserEmailVerifier_VerifyUserEmailWithTicket"));
		VerifyUserEmailWithTicketCounterInvalidTicketData = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidTicketData", "UserEmailVerifier_VerifyUserEmailWithTicket"));
		VerifyUserEmailWithTicketCounterExpiredTicket = ephemeralCounterFactory.GetCounter(string.Format("{0}ExpiredTicket", "UserEmailVerifier_VerifyUserEmailWithTicket"));
		VerifyUserEmailWithTicketCounterInvalidEmail = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidEmail", "UserEmailVerifier_VerifyUserEmailWithTicket"));
		VerifyUserEmailWithTicketCounterSuccess = ephemeralCounterFactory.GetCounter(string.Format("{0}Success", "UserEmailVerifier_VerifyUserEmailWithTicket"));
	}

	[ExcludeFromCodeCoverage]
	private void SendEmailVerifiedEvent(long userId)
	{
		WebEventArgs eventArgs = new WebEventArgs
		{
			UserId = userId
		};
		new EmailVerifiedEvent(_EventStreamer, eventArgs).Stream();
	}
}
