using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.TranslationResources;
using Roblox.TranslationResources.Authentication;
using Roblox.TranslationResources.Communication;

namespace Roblox.Platform.TwoStepVerification;

internal class TwoStepVerificationSettingChangeEmailNotifier : ITwoStepVerificationSettingChangeNotifier
{
	private readonly ITwoStepVerificationEmailNotifier _EmailNotifier;

	private readonly ILogger _Logger;

	private readonly string _ApplicationName;

	private readonly Func<bool> _IsTwoStepVerificationLoggingEnabled;

	private readonly ILocalizationResourceProvider _LocalizationResourceProvider;

	private const string _EmailTypeTemplate = "TwoStepVerification{0}";

	private const string _HtmlLineBreak = "<br />";

	private const string _PlainTextLineBreak = "\r\n";

	public TwoStepVerificationSettingChangeEmailNotifier(ITwoStepVerificationEmailNotifier emailNotifier, ILogger logger, string applicationName, Func<bool> isTwoStepVerificationLoggingEnabled, ILocalizationResourceProvider localizationResourceProvider)
	{
		if (string.IsNullOrEmpty(applicationName))
		{
			throw new PlatformArgumentException("applicationName");
		}
		_EmailNotifier = emailNotifier.AssignOrThrowIfNull("emailNotifier");
		_ApplicationName = applicationName;
		_Logger = logger.AssignOrThrowIfNull("logger");
		_IsTwoStepVerificationLoggingEnabled = isTwoStepVerificationLoggingEnabled.AssignOrThrowIfNull("isTwoStepVerificationLoggingEnabled");
		_LocalizationResourceProvider = localizationResourceProvider.AssignOrThrowIfNull("localizationResourceProvider");
	}

	public void Send(TwoStepEventArgs e)
	{
		if (e == null)
		{
			throw new PlatformArgumentNullException("e");
		}
		if (e.User == null)
		{
			throw new PlatformArgumentNullException("User");
		}
		if (e.IsEnabledChanged)
		{
			Send(e.User, e.IsEnabled);
		}
	}

	private void Send(IUser user, bool isEnabled)
	{
		try
		{
			IMasterResources obj = _LocalizationResourceProvider.GetLocalizationResources(user) ?? throw new PlatformOperationUnavailableException("Cannot get resources needed to send an email.");
			ITwoStepVerificationResources twoStepVerificationResources = obj.Authentication.TwoStepVerification;
			ICommonEmailResources commonEmailResources = obj.Communication.CommonEmail;
			string subject = (isEnabled ? twoStepVerificationResources.DescriptionTwoStepVerificationActivationEmailSubject(user.Name) : twoStepVerificationResources.DescriptionTwoStepVerificationDeactivationEmailSubject(user.Name));
			string plainBody;
			string htmlBody;
			if (IsUserUnder13(user))
			{
				if (isEnabled)
				{
					plainBody = twoStepVerificationResources.DescriptionTwoStepVerificationActivationEmailBodyUnder13("\r\n", user.Name);
					htmlBody = twoStepVerificationResources.DescriptionTwoStepVerificationActivationEmailBodyUnder13("<br />", user.Name);
				}
				else
				{
					plainBody = twoStepVerificationResources.DescriptionTwoStepVerificationDeactivationEmailBodyUnder13("\r\n", user.Name);
					htmlBody = twoStepVerificationResources.DescriptionTwoStepVerificationDeactivationEmailBodyUnder13("<br />", user.Name);
				}
			}
			else if (isEnabled)
			{
				plainBody = twoStepVerificationResources.DescriptionTwoStepVerificationActivationEmailBodyOver13(user.Name, "\r\n");
				htmlBody = twoStepVerificationResources.DescriptionTwoStepVerificationActivationEmailBodyOver13(user.Name, "<br />");
			}
			else
			{
				plainBody = twoStepVerificationResources.DescriptionTwoStepVerificationDeactivationEmailBodyOver13(user.Name, "\r\n");
				htmlBody = twoStepVerificationResources.DescriptionTwoStepVerificationDeactivationEmailBodyOver13(user.Name, "<br />");
			}
			string activated = (isEnabled ? "Activated" : "Deactivated");
			string emailType = $"TwoStepVerification{activated}";
			_EmailNotifier.SendEmail(user, subject, emailType, plainBody, htmlBody, commonEmailResources);
			if (_IsTwoStepVerificationLoggingEnabled())
			{
				_Logger.Info(GetLogInfo(user, isEnabled));
			}
		}
		catch (EmailQueueingException e)
		{
			throw new PlatformOperationUnavailableException("Failed to send email to user", e);
		}
	}

	[ExcludeFromCodeCoverage]
	internal virtual bool IsUserUnder13(IUser user)
	{
		return user.IsUnder13();
	}

	[ExcludeFromCodeCoverage]
	protected virtual string GetLogInfo(IUser user, bool isEnabled)
	{
		return string.Format("{0} is {1} 2SV from {2}-{3} at {4}", user.Name, isEnabled ? "activating" : "deactivating", RobloxEnvironment.Abbreviation, _ApplicationName, DateTime.Now);
	}
}
