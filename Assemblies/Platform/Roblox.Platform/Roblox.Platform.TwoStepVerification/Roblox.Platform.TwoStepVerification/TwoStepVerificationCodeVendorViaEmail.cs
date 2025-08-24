using System;
using System.Diagnostics.CodeAnalysis;
using Roblox.Common;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Email.Delivery;
using Roblox.Platform.IpAddresses;
using Roblox.Platform.Localization.Accounts;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification.Properties;
using Roblox.TranslationResources;
using Roblox.TranslationResources.Authentication;
using Roblox.TranslationResources.Communication;

namespace Roblox.Platform.TwoStepVerification;

/// <summary>
/// Implementation of <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeSender" /> that sends codes via email.
/// </summary>
internal class TwoStepVerificationCodeVendorViaEmail : ITwoStepVerificationCodeVendor
{
	private readonly ITwoStepVerificationEmailNotifier _EmailNotifier;

	private readonly ILogger _Logger;

	private readonly string _ApplicationName;

	private readonly Func<bool> _IsTwoStepVerificationLoggingEnabled;

	private readonly ILocalizationResourceProvider _LocalizationResourceProvider;

	private const string _EmailTypeTemplate = "TwoStepVerification";

	private const string _HtmlLineBreak = "<br />";

	private const string _PlainTextLineBreak = "\r\n";

	private const string _KeepAccountSafeArticleLink = "https://en.help.roblox.com/hc/articles/203313380";

	private const string _SupportPageLink = "https://en.help.roblox.com";

	private const string _TwoStepVerificationHelpArticleLink = "https://en.help.roblox.com/hc/articles/212459863";

	private const string _ATagStartWithHref = "<a href=\"";

	private const string _HrefEnd = "\">";

	private const string _ATagEnd = "</a>";

	private const string _SpanStartWithBold = "<span style='font-weight: bold'>";

	private const string _SpanEndTag = "</span>";

	[ExcludeFromCodeCoverage]
	internal virtual string AccountPageInfoLink => $"{RobloxEnvironment.WebsiteUrl}/my/account#!/info";

	[ExcludeFromCodeCoverage]
	internal virtual string AccountSafetyEndpointUrl => $"{RobloxEnvironment.WebsiteUrl}/info/account-safety";

	[ExcludeFromCodeCoverage]
	internal virtual string HelpEndpointUrl => $"{RobloxEnvironment.WebsiteUrl}/info/help";

	[ExcludeFromCodeCoverage]
	internal virtual string TwoStepVerificationEndpointUrl => $"{RobloxEnvironment.WebsiteUrl}/info/2sv";

	[ExcludeFromCodeCoverage]
	internal virtual bool IsSettingBasedHelpPageLinkLocalizationEnabled => Settings.Default.IsSettingBasedHelpPageLinkLocalizationEnabled;

	public TwoStepVerificationCodeVendorViaEmail(ITwoStepVerificationEmailNotifier emailNotifier, ILogger logger, string applicationName, Func<bool> isTwoStepVerificationLoggingEnabled, ILocalizationResourceProvider localizationResourceProvider)
	{
		if (string.IsNullOrEmpty(applicationName))
		{
			throw new PlatformArgumentException("applicationName");
		}
		_EmailNotifier = emailNotifier.AssignOrThrowIfNull("emailNotifier");
		_Logger = logger.AssignOrThrowIfNull("logger");
		_ApplicationName = applicationName;
		_IsTwoStepVerificationLoggingEnabled = isTwoStepVerificationLoggingEnabled.AssignOrThrowIfNull("isTwoStepVerificationLoggingEnabled");
		_LocalizationResourceProvider = localizationResourceProvider.AssignOrThrowIfNull("localizationResourceProvider");
	}

	/// <inheritdoc cref="M:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeVendor.Send(Roblox.Platform.TwoStepVerification.ITwoStepVerificationChallenge,Roblox.Platform.Membership.IUser,Roblox.Platform.IpAddresses.IIpLocation)" />
	public void Send(ITwoStepVerificationChallenge challenge, IUser user, IIpLocation ipLocation)
	{
		if (challenge == null)
		{
			throw new PlatformArgumentNullException("challenge");
		}
		if (user == null)
		{
			throw new PlatformArgumentNullException("user");
		}
		if (ipLocation == null)
		{
			throw new PlatformArgumentNullException("ipLocation");
		}
		IMasterResources obj = _LocalizationResourceProvider.GetLocalizationResources(user) ?? throw new PlatformOperationUnavailableException("Cannot get resource files needed to send email.");
		ITwoStepVerificationResources twoStepVerificationResources = obj.Authentication.TwoStepVerification;
		ICommonEmailResources commonEmailResources = obj.Communication.CommonEmail;
		string subject = twoStepVerificationResources.DescriptionTwoStepVerificationLoginEmailSubject(user.Name);
		ExtractGeoLocationInformation(twoStepVerificationResources, ipLocation, user.Name, out var geolocationInformationPlainText, out var geolocationInformationHtml);
		string keepAccountSafeArticleLink = (IsSettingBasedHelpPageLinkLocalizationEnabled ? AccountSafetyEndpointUrl : "https://en.help.roblox.com/hc/articles/203313380");
		string supportPageLink = (IsSettingBasedHelpPageLinkLocalizationEnabled ? HelpEndpointUrl : "https://en.help.roblox.com");
		string twoStepVerificationHelpArticleLink = (IsSettingBasedHelpPageLinkLocalizationEnabled ? TwoStepVerificationEndpointUrl : "https://en.help.roblox.com/hc/articles/212459863");
		string plainBody = twoStepVerificationResources.DescriptionTwoStepVerificationLoginEmailPlainBody(geolocationInformationPlainText, user.Name, "\r\n", challenge.Passcode, AccountPageInfoLink, twoStepVerificationHelpArticleLink, keepAccountSafeArticleLink, supportPageLink);
		string htmlBody = twoStepVerificationResources.DescriptionTwoStepVerificationLoginEmailHtmlBody(geolocationInformationHtml, "<span style='font-weight: bold'>", user.Name, "<br />", challenge.Passcode, "</span>", "<a href=\"", AccountPageInfoLink, "\">", "</a>", twoStepVerificationHelpArticleLink, keepAccountSafeArticleLink, supportPageLink);
		try
		{
			_EmailNotifier.SendEmail(user, subject, "TwoStepVerification", plainBody, htmlBody, commonEmailResources);
			if (_IsTwoStepVerificationLoggingEnabled())
			{
				_Logger.Info(GetLogInfo(challenge, user));
			}
		}
		catch (EmailQueueingException e)
		{
			throw new PlatformOperationUnavailableException("Failed to send email to user", e);
		}
	}

	private void ExtractGeoLocationInformation(ITwoStepVerificationResources resources, IIpLocation ipLocation, string userName, out string geoLocationInformationPlainText, out string geoLocationInformationHtml)
	{
		geoLocationInformationPlainText = string.Empty;
		geoLocationInformationHtml = string.Empty;
		switch (ipLocation.IpType)
		{
		case IpType.Private:
			geoLocationInformationPlainText = resources.DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(userName, "\r\n");
			geoLocationInformationHtml = resources.DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3("<span style='font-weight: bold'>", userName, "</span>", "<br />");
			break;
		case IpType.Public:
			if (!string.IsNullOrEmpty(ipLocation.Country))
			{
				if (string.IsNullOrEmpty(ipLocation.Region))
				{
					geoLocationInformationPlainText = resources.DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(userName, ipLocation.Country, "\r\n");
					geoLocationInformationHtml = resources.DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4("<span style='font-weight: bold'>", userName, ipLocation.Country, "</span>", "<br />");
				}
				else if (string.IsNullOrEmpty(ipLocation.City))
				{
					geoLocationInformationPlainText = resources.DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(userName, ipLocation.Region, ipLocation.Country, "\r\n");
					geoLocationInformationHtml = resources.DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5("<span style='font-weight: bold'>", userName, ipLocation.Region, ipLocation.Country, "</span>", "<br />");
				}
				else
				{
					geoLocationInformationPlainText = resources.DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(userName, ipLocation.City, ipLocation.Region, ipLocation.Country, "\r\n");
					geoLocationInformationHtml = resources.DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6("<span style='font-weight: bold'>", userName, ipLocation.City, ipLocation.Region, ipLocation.Country, "</span>", "<br />");
				}
			}
			break;
		case IpType.NotFound:
			break;
		}
	}

	[ExcludeFromCodeCoverage]
	protected virtual string GetLogInfo(ITwoStepVerificationChallenge challenge, IUser user)
	{
		return $"{user.Name} is attempting {challenge.ActionType.ToDescription()} from {RobloxEnvironment.Abbreviation}-{_ApplicationName} at {DateTime.Now}";
	}
}
