using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Roblox.BriteVerify;
using Roblox.Configuration;
using Roblox.EphemeralCounters;
using Roblox.Instrumentation;
using Roblox.Kickbox;
using Roblox.Platform.Authentication.AccountSecurityTickets;
using Roblox.Platform.Authentication.AccountSecurityTickets.Properties;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Email.Properties;
using Roblox.Platform.Email.User.Entities;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Properties;
using Roblox.TranslationResources;
using Roblox.TranslationResources.Communication;
using Roblox.TranslationResources.Feature;

namespace Roblox.Platform.Email.User;

internal class UserEmailChanger : IUserEmailChanger
{
	private readonly ICounterRegistry _CounterRegistry;

	private readonly IEmailAddressFactory _EmailAddressFactory;

	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	private readonly IEmailAddressValidator _EmailAddressValidator;

	private readonly IAccountSecurityTicketsFactory _AccountSecurityTicketsFactory;

	private readonly IEmailSender _EmailSender;

	private readonly IBriteVerifyClient _BriteVerifyEmailVerifier;

	private readonly Lazy<IKickboxClient> _KickboxClient;

	private readonly IAccountEmailAddressEntityFactory _AccountEmailAddressEntityFactory;

	private readonly IEmailAddressDeleter _EmailDeleter;

	private readonly ILocalizationResourceProvider _LocalizationResourceProvider;

	private const string _RevertAccountEmailType = "RevertAccount:Email";

	private const string _EphemeralCounterSetEmailBase = "UserEmailChange_SetEmail:";

	internal readonly ICounter SetEmailCounterAttempt;

	internal readonly ICounter SetEmailCounterFeatureDisabled;

	internal readonly ICounter SetEmailCounterNoChange;

	internal readonly ICounter SetEmailCounterInvalidFormat;

	internal readonly ICounter SetEmailCounterBlacklisted;

	internal readonly ICounter SetEmailCounterInvalidDomain;

	internal readonly ICounter SetEmailCounterDisposableDomain;

	internal readonly ICounter SetEmailCounterSuccess;

	internal int PurgePageSize = 1000;

	[ExcludeFromCodeCoverage]
	internal virtual string NoReplyEmailAddress => $"<{Roblox.Platform.Email.Properties.Settings.Default.NoReplyEmailAddress}>";

	[ExcludeFromCodeCoverage]
	internal virtual bool IsUserEmailChangeEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsUserEmailChangeEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual string RobloxInfoEmailAddress => Roblox.Platform.Email.Properties.Settings.Default.RobloxInfoEmailAddress;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsEmailValidationBriteVerifyCheckEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsEmailValidationBriteVerifyCheckEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual int MaxValidAccountsPerEmailAddress => Roblox.Platform.Email.Properties.Settings.Default.MaxValidAccountsPerEmailAddress;

	[ExcludeFromCodeCoverage]
	internal virtual bool AllowAcceptAll => Roblox.Platform.Email.Properties.Settings.Default.AllowAcceptAll;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsKickboxEmailValidationEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsKickboxEmailValidationEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsKickboxEmailDomainValidationEnabled => Roblox.Platform.Email.Properties.Settings.Default.IsKickboxEmailDomainValidationEnabled;

	[ExcludeFromCodeCoverage]
	internal virtual bool IsEmailVerificationUsingASTEnabled => Roblox.Properties.Settings.Default.IsEmailVerificationUsingASTEnabled;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Platform.Email.User.UserEmailChanger" /> class.
	/// </summary>
	/// <exception cref="T:System.ArgumentNullException">Thrown if any of the arguments is null.</exception>
	internal UserEmailChanger(ICounterRegistry counterRegistry, IEmailAddressFactory emailAddressFactory, IAccountEmailAddressFactory accountEmailAddressFactory, IEmailAddressValidator emailAddressValidator, IEphemeralCounterFactory ephemeralCounterFactory, IAccountSecurityTicketsFactory accountSecurityTicketsFactory, IEmailSender emailSender, IBriteVerifyClient briteVerifyEmailVerifier, IAccountEmailAddressEntityFactory accountEmailAddressEntityFactory, IEmailAddressDeleter emailDeleter, ILocalizationResourceProvider localizationResourceProvider)
	{
		if (ephemeralCounterFactory == null)
		{
			throw new ArgumentNullException("ephemeralCounterFactory");
		}
		_CounterRegistry = counterRegistry ?? throw new ArgumentNullException("counterRegistry");
		_EmailAddressFactory = emailAddressFactory ?? throw new ArgumentNullException("emailAddressFactory");
		_AccountEmailAddressFactory = accountEmailAddressFactory ?? throw new ArgumentNullException("accountEmailAddressFactory");
		_EmailAddressValidator = emailAddressValidator ?? throw new ArgumentNullException("emailAddressValidator");
		_AccountSecurityTicketsFactory = accountSecurityTicketsFactory ?? throw new ArgumentNullException("accountSecurityTicketsFactory");
		_EmailSender = emailSender ?? throw new ArgumentNullException("emailSender");
		_BriteVerifyEmailVerifier = briteVerifyEmailVerifier ?? throw new ArgumentNullException("briteVerifyEmailVerifier");
		_AccountEmailAddressEntityFactory = accountEmailAddressEntityFactory ?? throw new ArgumentNullException("accountEmailAddressEntityFactory");
		_EmailDeleter = emailDeleter ?? throw new ArgumentNullException("emailDeleter");
		_LocalizationResourceProvider = localizationResourceProvider ?? throw new ArgumentNullException("localizationResourceProvider");
		SetEmailCounterAttempt = ephemeralCounterFactory.GetCounter(string.Format("{0}Attempt", "UserEmailChange_SetEmail:"));
		SetEmailCounterFeatureDisabled = ephemeralCounterFactory.GetCounter(string.Format("{0}FeatureDisabled", "UserEmailChange_SetEmail:"));
		SetEmailCounterNoChange = ephemeralCounterFactory.GetCounter(string.Format("{0}NoChange", "UserEmailChange_SetEmail:"));
		SetEmailCounterInvalidFormat = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidFormat", "UserEmailChange_SetEmail:"));
		SetEmailCounterBlacklisted = ephemeralCounterFactory.GetCounter(string.Format("{0}Blacklisted", "UserEmailChange_SetEmail:"));
		SetEmailCounterInvalidDomain = ephemeralCounterFactory.GetCounter(string.Format("{0}InvalidDomain", "UserEmailChange_SetEmail:"));
		SetEmailCounterDisposableDomain = ephemeralCounterFactory.GetCounter(string.Format("{0}DisposableDomain", "UserEmailChange_SetEmail:"));
		SetEmailCounterSuccess = ephemeralCounterFactory.GetCounter(string.Format("{0}Success", "UserEmailChange_SetEmail:"));
		_KickboxClient = new Lazy<IKickboxClient>(() => new KickboxClient(_CounterRegistry));
	}

	public string ValidateAndSetEmail(IUser user, string emailAddress, bool forceSet, bool sendRevertEmail)
	{
		ValidateInputs(user, emailAddress);
		SetEmailCounterAttempt.IncrementInBackground();
		ValidateSettings();
		ValidateEmailAddress(emailAddress);
		if (IsEmailVerificationUsingASTEnabled)
		{
			int newEmailAddressId = SetEmailAddress(user, emailAddress);
			SetEmailCounterSuccess.IncrementInBackground();
			return CreateAccountSecurityTicket(user, newEmailAddressId);
		}
		SetEmail(user, emailAddress, forceSet, sendRevertEmail);
		return null;
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.User.IUserEmailChanger.ValidateAndSetEmail(Roblox.Platform.Membership.IUser,System.String,System.Boolean,System.Boolean)" />
	public void SetEmail(IUser user, string emailAddress, bool forceSet, bool sendRevertEmail)
	{
		ValidateInputs(user, emailAddress);
		int? accountEmailAddressId;
		string currentEmailAddress = GetAccountEmailAddress(user, out accountEmailAddressId);
		if (!IsCurrentEmail(emailAddress, currentEmailAddress))
		{
			IAccountEmail accountEmail = _AccountEmailAddressFactory.Get(user);
			bool isExistingVerifiedEmail = accountEmail?.IsVerified ?? false;
			if (accountEmail == null || !isExistingVerifiedEmail || forceSet)
			{
				SetEmailAddress(user, emailAddress);
				SetEmailCounterSuccess.IncrementInBackground();
			}
			else
			{
				_EmailAddressFactory.GetOrCreateByEmailAddress(emailAddress);
			}
			if (sendRevertEmail && isExistingVerifiedEmail && accountEmailAddressId.HasValue && !string.IsNullOrEmpty(currentEmailAddress))
			{
				SendRevertEmail(user, accountEmailAddressId.Value, currentEmailAddress, emailAddress);
			}
		}
	}

	public void SendRevertEmail(IUser user, int accountEmailAddressIdToRevert, string currentEmailAddress, string emailAddress)
	{
		IMasterResources obj = _LocalizationResourceProvider.GetLocalizationResources(user) ?? throw new PlatformOperationUnavailableException("Cannot find resources needed to send email.");
		IAccountSettingsResources accountSettingsResources = obj.Feature.AccountSettings;
		ICommonEmailResources commonEmailResources = obj.Communication.CommonEmail;
		string from = accountSettingsResources.DescriptionAccountEmailRevertEmailFrom("\"", "\"", NoReplyEmailAddress);
		string subject = accountSettingsResources.DescriptionAccountEmailRevertEmailSubject;
		string revertTicket = CreateAccountSecurityTicket(user, accountEmailAddressIdToRevert);
		Roblox.Platform.Email.Delivery.Email email = new Roblox.Platform.Email.Delivery.Email(from, currentEmailAddress, subject, EmailBodyType.Mime, "RevertAccount:Email", BuildRevertEmail(accountSettingsResources, user, revertTicket, currentEmailAddress, emailAddress, isHtmlFormat: false), BuildRevertEmail(accountSettingsResources, user, revertTicket, currentEmailAddress, emailAddress, isHtmlFormat: true));
		_EmailSender.SendEmail(email, commonEmailResources);
	}

	public bool EmailHasMaxAccounts(string emailAddress)
	{
		if (string.IsNullOrWhiteSpace(emailAddress))
		{
			throw new PlatformArgumentException("emailAddress");
		}
		return _AccountEmailAddressFactory.GetCurrentAccountsByEmailAddress(emailAddress, MaxValidAccountsPerEmailAddress).Count >= MaxValidAccountsPerEmailAddress;
	}

	public virtual void PurgeEmailAddress(IUser user)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		ICollection<IAccountEmailAddressEntity> allEmails = new List<IAccountEmailAddressEntity>();
		do
		{
			allEmails = _AccountEmailAddressEntityFactory.GetByAccountIdPaged(user.AccountId, 0, PurgePageSize);
			foreach (IAccountEmailAddressEntity accountEmail in allEmails)
			{
				accountEmail.Delete();
				if (!_AccountEmailAddressEntityFactory.GetByEmailAddressId(accountEmail.EmailAddressId, 2, 0).Any())
				{
					_EmailDeleter.Delete(accountEmail.EmailAddressId);
				}
			}
		}
		while (allEmails.Any());
	}

	private void ValidateSettings()
	{
		if (!IsUserEmailChangeEnabled)
		{
			SetEmailCounterFeatureDisabled.IncrementInBackground();
			throw new PlatformOperationUnavailableException();
		}
	}

	private void ValidateInputs(IUser user, string emailAddress)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (string.IsNullOrEmpty(emailAddress))
		{
			throw new PlatformArgumentException("emailAddress");
		}
	}

	private bool IsCurrentEmail(string emailAddress, string currentEmailAddress)
	{
		if (!string.IsNullOrEmpty(currentEmailAddress) && emailAddress.Equals(currentEmailAddress, StringComparison.OrdinalIgnoreCase))
		{
			SetEmailCounterNoChange.IncrementInBackground();
			return true;
		}
		return false;
	}

	private void ValidateEmailAddress(string address)
	{
		if (!_EmailAddressValidator.IsValidEmail(address))
		{
			SetEmailCounterInvalidFormat.IncrementInBackground();
			throw new PlatformInvalidEmailAddressException("Invalid", "The email cannot be used.");
		}
		if (_EmailAddressValidator.IsShadyProvider(address) || _EmailAddressValidator.IsBlacklisted(address))
		{
			SetEmailCounterBlacklisted.IncrementInBackground();
			throw new PlatformInvalidEmailAddressException("Blacklisted", "The email cannot be used.");
		}
		if (!_EmailAddressValidator.IsEmailDomainValid(address))
		{
			SetEmailCounterInvalidDomain.IncrementInBackground();
			throw new PlatformInvalidEmailAddressException("InvalidDomain", "The email does not have a valid domain.");
		}
		if (IsKickboxEmailDomainValidationEnabled)
		{
			KickboxVerifyDomainRequest kickboxDomainRequest = new KickboxVerifyDomainRequest(address.Split('@').Last().ToLowerInvariant());
			if (_KickboxClient.Value.VerifyDomain(kickboxDomainRequest).Disposable)
			{
				SetEmailCounterDisposableDomain.IncrementInBackground();
				throw new PlatformInvalidEmailAddressException("InvalidDomain", "The email domain may not be used.");
			}
		}
		if (!IsEmailValidationBriteVerifyCheckEnabled)
		{
			return;
		}
		EmailAddress emailAddress = EmailAddress.Get(address);
		if (emailAddress != null && emailAddress.IsReviewed)
		{
			if (!emailAddress.IsApproved)
			{
				SetEmailCounterBlacklisted.IncrementInBackground();
				throw new PlatformInvalidEmailAddressException("Blacklisted", "The email cannot be used.");
			}
		}
		else
		{
			VerifyEmailByBriteVerify(address, emailAddress);
		}
	}

	/// <inheritdoc cref="M:Roblox.Platform.Email.User.IUserEmailChanger.VerifyEmailByBriteVerify(System.String,Roblox.EmailAddress)" />
	public void VerifyEmailByBriteVerify(string address, EmailAddress emailAddress)
	{
		try
		{
			BriteVerifyEmailRequest request = new BriteVerifyEmailRequest(address, AllowAcceptAll);
			IBriteVerifyEmailResult result = _BriteVerifyEmailVerifier.VerifyEmail(request);
			bool isVerifiedEmailAddress = string.Equals(result.Status, "valid");
			if (emailAddress == null)
			{
				emailAddress = EmailAddress.GetOrCreate(address);
			}
			emailAddress?.SetReviewed(isVerifiedEmailAddress);
			if (!isVerifiedEmailAddress)
			{
				throw new PlatformInvalidEmailAddressException(result.Status, result.Error);
			}
		}
		catch (BriteVerifyException)
		{
		}
	}

	internal string BuildRevertEmail(IAccountSettingsResources accountSettingsResources, IUser user, string ticket, string oldEmailAddress, string newEmailAddress, bool isHtmlFormat)
	{
		string body = string.Empty;
		if (isHtmlFormat)
		{
			return accountSettingsResources.DescriptionAccountEmailRevertEmailHtmlBody("<br />", user.Name, oldEmailAddress, newEmailAddress, "<a href=\"", BuildRevertAccountUrl(ticket), "\">", BuildRevertAccountUrl(null), "</a>", RobloxInfoEmailAddress);
		}
		return accountSettingsResources.DescriptionAccountEmailRevertEmailPlainBody("\r\n", user.Name, oldEmailAddress, newEmailAddress, BuildRevertAccountUrl(ticket), RobloxInfoEmailAddress);
	}

	[ExcludeFromCodeCoverage]
	internal virtual string BuildRevertAccountUrl(string ticket)
	{
		if (!string.IsNullOrEmpty(ticket))
		{
			return $"{RobloxEnvironment.WebsiteHttpsUrl}/login/revertAccount?ticket={ticket}";
		}
		return $"{RobloxEnvironment.WebsiteHttpsUrl}/login/revertAccount";
	}

	[ExcludeFromCodeCoverage]
	internal virtual int SetEmailAddress(IUser user, string emailAddress)
	{
		return AccountEmailAddress.CreateNew(user.AccountId, emailAddress, newsletter: false).ID;
	}

	[ExcludeFromCodeCoverage]
	internal virtual string CreateAccountSecurityTicket(IUser user, int accountEmailAddressId)
	{
		Account account = Account.Get(user.AccountId);
		AccountEmailAddress accountEmailAddress = AccountEmailAddress.Get(accountEmailAddressId);
		AccountPasswordHash accountPasswordHash = AccountPasswordHash.GetCurrent(user.AccountId);
		AccountSecurityTicket accountSecurityTicket = AccountSecurityTicket.CreateNew(account, accountEmailAddress, accountPasswordHash);
		if (Roblox.Platform.Authentication.AccountSecurityTickets.Properties.Settings.Default.IsAccountSecurityTicketsV2Enabled)
		{
			_AccountSecurityTicketsFactory.CreateAccountSecurityTickets(account.ID, accountSecurityTicket.GUID, accountEmailAddress.ID, accountPasswordHash?.ID);
		}
		return accountSecurityTicket.GUID.ToString();
	}

	[ExcludeFromCodeCoverage]
	internal virtual string GetAccountEmailAddress(IUser user, out int? accountEmailAddressId)
	{
		AccountEmailAddress accountEmailAddress = AccountEmailAddress.GetCurrent(user.AccountId);
		accountEmailAddressId = accountEmailAddress?.ID;
		return accountEmailAddress?.GetEmailAddress()?.Address;
	}
}
