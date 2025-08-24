using System;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Email.User;
using Roblox.Platform.Membership;
using Roblox.TranslationResources.Communication;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationEmailNotifier : ITwoStepVerificationEmailNotifier
{
	private readonly IAccountEmailAddressFactory _AccountEmailAddressFactory;

	private readonly IEmailSender _EmailSender;

	private readonly Func<string> _EmailSenderEmailAddress;

	public TwoStepVerificationEmailNotifier(IEmailSender emailSender, IAccountEmailAddressFactory accountEmailAddressFactory, Func<string> emailSenderEmailAddress)
	{
		_EmailSender = emailSender.AssignOrThrowIfNull("emailSender");
		_AccountEmailAddressFactory = accountEmailAddressFactory.AssignOrThrowIfNull("accountEmailAddressFactory");
		_EmailSenderEmailAddress = emailSenderEmailAddress.AssignOrThrowIfNull("emailSenderEmailAddress");
	}

	private IAccountEmail GetAccountEmail(IUser user)
	{
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		IAccountEmail accountEmail = _AccountEmailAddressFactory.Get(user);
		if (string.IsNullOrWhiteSpace(accountEmail?.Email) || !accountEmail.IsVerified)
		{
			throw new TwoStepVerificationUnverifiedMediaTypeException(TwoStepVerificationMediaType.Email);
		}
		return accountEmail;
	}

	public void SendEmail(IUser user, string subject, string emailType, string plainBody, string htmlBody, ICommonEmailResources commonEmailResource)
	{
		IAccountEmail accountEmail = GetAccountEmail(user);
		IEmail email = ConstructEmail(accountEmail, subject, emailType, plainBody, htmlBody);
		_EmailSender.SendEmail(email, commonEmailResource);
	}

	private IEmail ConstructEmail(IAccountEmail accountEmail, string subject, string emailType, string plainBody, string htmlBody)
	{
		return new Roblox.Platform.Email.Delivery.Email(_EmailSenderEmailAddress(), accountEmail.Email, subject, EmailBodyType.Mime, emailType, plainBody, htmlBody);
	}
}
