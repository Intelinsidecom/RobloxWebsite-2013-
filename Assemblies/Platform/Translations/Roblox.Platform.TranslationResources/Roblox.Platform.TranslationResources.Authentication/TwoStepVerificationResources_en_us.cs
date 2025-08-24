using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class TwoStepVerificationResources_en_us : TranslationResourcesBase, ITwoStepVerificationResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Resend"
	/// English String: "Resend Code"
	/// </summary>
	public virtual string ActionResend => "Resend Code";

	/// <summary>
	/// Key: "Action.StartOver"
	/// link text to restart verification
	/// English String: "Start Over"
	/// </summary>
	public virtual string ActionStartOver => "Start Over";

	/// <summary>
	/// Key: "Action.Submit"
	/// submit button text
	/// English String: "Submit"
	/// </summary>
	public virtual string ActionSubmit => "Submit";

	/// <summary>
	/// Key: "Action.Verify"
	/// English String: "Verify"
	/// </summary>
	public virtual string ActionVerify => "Verify";

	/// <summary>
	/// Key: "Label.Code"
	/// verification code for 2 factor authentication
	/// English String: "Code"
	/// </summary>
	public virtual string LabelCode => "Code";

	/// <summary>
	/// Key: "Label.DidNotReceive"
	/// English String: "Didn't receive the code?"
	/// </summary>
	public virtual string LabelDidNotReceive => "Didn't receive the code?";

	/// <summary>
	/// Key: "Label.EnterCode"
	/// English String: "Enter Code (6-digit)"
	/// </summary>
	public virtual string LabelEnterCode => "Enter Code (6-digit)";

	/// <summary>
	/// Key: "Label.EnterEmailCode"
	/// English String: "Enter the code we just sent you via email"
	/// </summary>
	public virtual string LabelEnterEmailCode => "Enter the code we just sent you via email";

	/// <summary>
	/// Key: "Label.EnterTextCode"
	/// English String: "Enter the code we just sent you via text message"
	/// </summary>
	public virtual string LabelEnterTextCode => "Enter the code we just sent you via text message";

	/// <summary>
	/// Key: "Label.EnterTwoStepVerificationCode"
	/// Enter your two step verification code.
	/// English String: "Enter your two step verification code."
	/// </summary>
	public virtual string LabelEnterTwoStepVerificationCode => "Enter your two step verification code.";

	/// <summary>
	/// Key: "Label.FacebookPasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public virtual string LabelFacebookPasswordWarning => "If you have been signing in with Facebook, you must set a password.";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// Learn More link text
	/// English String: "Learn More"
	/// </summary>
	public virtual string LabelLearnMore => "Learn More";

	/// <summary>
	/// Key: "Label.NewCode"
	/// verification code resent, label changes to new code
	/// English String: "New Code"
	/// </summary>
	public virtual string LabelNewCode => "New Code";

	/// <summary>
	/// Key: "Label.RobloxSupport"
	/// English String: "Roblox Support"
	/// </summary>
	public virtual string LabelRobloxSupport => "Roblox Support";

	/// <summary>
	/// Key: "Label.TrustThisDevice"
	/// English String: "Trust this device for 30 days"
	/// </summary>
	public virtual string LabelTrustThisDevice => "Trust this device for 30 days";

	/// <summary>
	/// Key: "Label.TwoStepVerification"
	/// English String: "2-Step Verification"
	/// </summary>
	public virtual string LabelTwoStepVerification => "2-Step Verification";

	/// <summary>
	/// Key: "Response.CodeSent"
	/// English String: "Code Sent"
	/// </summary>
	public virtual string ResponseCodeSent => "Code Sent";

	/// <summary>
	/// Key: "Response.FeatureNotAvailable"
	/// English String: "Feature not available. Please contact support."
	/// </summary>
	public virtual string ResponseFeatureNotAvailable => "Feature not available. Please contact support.";

	/// <summary>
	/// Key: "Response.InvalidCode"
	/// English String: "Invalid code."
	/// </summary>
	public virtual string ResponseInvalidCode => "Invalid code.";

	/// <summary>
	/// Key: "Response.SystemErrorReturnToLogin"
	/// English String: "System error. Please return to login screen."
	/// </summary>
	public virtual string ResponseSystemErrorReturnToLogin => "System error. Please return to login screen.";

	/// <summary>
	/// Key: "Response.TooManyAttempts"
	/// English String: "Too many attempts. Please try again later."
	/// </summary>
	public virtual string ResponseTooManyAttempts => "Too many attempts. Please try again later.";

	/// <summary>
	/// Key: "Response.TooManyCharacters"
	/// error message
	/// English String: "Too many characters"
	/// </summary>
	public virtual string ResponseTooManyCharacters => "Too many characters";

	public TwoStepVerificationResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Resend",
				_GetTemplateForActionResend()
			},
			{
				"Action.StartOver",
				_GetTemplateForActionStartOver()
			},
			{
				"Action.Submit",
				_GetTemplateForActionSubmit()
			},
			{
				"Action.Verify",
				_GetTemplateForActionVerify()
			},
			{
				"Description.TwoStepVerificationActivationEmail.Body.Over13",
				_GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
			},
			{
				"Description.TwoStepVerificationActivationEmail.Body.Under13",
				_GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
			},
			{
				"Description.TwoStepVerificationActivationEmail.Subject",
				_GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
			},
			{
				"Description.TwoStepVerificationDeactivationEmail.Body.Over13",
				_GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
			},
			{
				"Description.TwoStepVerificationDeactivationEmail.Body.Under13",
				_GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
			},
			{
				"Description.TwoStepVerificationDeactivationEmail.Subject\t",
				_GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
			},
			{
				"Description.TwoStepVerificationLoginEmail.HtmlBody",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainBody",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
			},
			{
				"Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
			},
			{
				"Description.TwoStepVerificationLoginEmail.Subject",
				_GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
			},
			{
				"Label.Code",
				_GetTemplateForLabelCode()
			},
			{
				"Label.CodeInputPlaceholderText",
				_GetTemplateForLabelCodeInputPlaceholderText()
			},
			{
				"Label.DidNotReceive",
				_GetTemplateForLabelDidNotReceive()
			},
			{
				"Label.EnterCode",
				_GetTemplateForLabelEnterCode()
			},
			{
				"Label.EnterEmailCode",
				_GetTemplateForLabelEnterEmailCode()
			},
			{
				"Label.EnterTextCode",
				_GetTemplateForLabelEnterTextCode()
			},
			{
				"Label.EnterTwoStepVerificationCode",
				_GetTemplateForLabelEnterTwoStepVerificationCode()
			},
			{
				"Label.FacebookPasswordWarning",
				_GetTemplateForLabelFacebookPasswordWarning()
			},
			{
				"Label.LearnMore",
				_GetTemplateForLabelLearnMore()
			},
			{
				"Label.NeedHelpContactSupport",
				_GetTemplateForLabelNeedHelpContactSupport()
			},
			{
				"Label.NewCode",
				_GetTemplateForLabelNewCode()
			},
			{
				"Label.RobloxSupport",
				_GetTemplateForLabelRobloxSupport()
			},
			{
				"Label.TrustThisDevice",
				_GetTemplateForLabelTrustThisDevice()
			},
			{
				"Label.TwoStepVerification",
				_GetTemplateForLabelTwoStepVerification()
			},
			{
				"Response.CodeSent",
				_GetTemplateForResponseCodeSent()
			},
			{
				"Response.FeatureNotAvailable",
				_GetTemplateForResponseFeatureNotAvailable()
			},
			{
				"Response.InvalidCode",
				_GetTemplateForResponseInvalidCode()
			},
			{
				"Response.SystemErrorReturnToLogin",
				_GetTemplateForResponseSystemErrorReturnToLogin()
			},
			{
				"Response.TooManyAttempts",
				_GetTemplateForResponseTooManyAttempts()
			},
			{
				"Response.TooManyCharacters",
				_GetTemplateForResponseTooManyCharacters()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.TwoStepVerification";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionResend()
	{
		return "Resend Code";
	}

	protected virtual string _GetTemplateForActionStartOver()
	{
		return "Start Over";
	}

	protected virtual string _GetTemplateForActionSubmit()
	{
		return "Submit";
	}

	protected virtual string _GetTemplateForActionVerify()
	{
		return "Verify";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Over13"
	/// Body for 2SV activation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationActivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyOver13()
	{
		return "Hi {accountName},{lineBreak}{lineBreak}You have activated 2-Step Verification for your Roblox account. Next time you log in from a new device, you will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Body.Under13"
	/// Body for 2SV activation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationActivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationActivationEmailBodyUnder13()
	{
		return "Hi,{lineBreak}{lineBreak}2-Step Verification has been activated for your child's Roblox account, {accountName}. Next time they log in from a new device, they will need to enter a 6-digit security code that Roblox sends to you via email.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationActivationEmail.Subject"
	/// Subject for 2SV activation email
	/// English String: "2-Step Verification Activated for Roblox Account: {accountName}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationActivationEmailSubject(string accountName)
	{
		return $"2-Step Verification Activated for Roblox Account: {accountName}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationActivationEmailSubject()
	{
		return "2-Step Verification Activated for Roblox Account: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Over13"
	/// Body for 2SV deactivation email for over 13 users
	/// English String: "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationDeactivationEmailBodyOver13(string accountName, string lineBreak)
	{
		return $"Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyOver13()
	{
		return "Hi {accountName},{lineBreak}{lineBreak}You have deactivated 2-Step Verification for your Roblox account. A security code will no longer be required when you log into your account.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Body.Under13"
	/// Body for 2SV deactivation email for under 13 users
	/// English String: "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationDeactivationEmailBodyUnder13(string lineBreak, string accountName)
	{
		return $"Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailBodyUnder13()
	{
		return "Hi,{lineBreak}{lineBreak}2-Step Verification has been deactivated for your child's Roblox account, {accountName}. A security code will no longer be required when they log into the account.{lineBreak}{lineBreak}Roblox";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationDeactivationEmail.Subject	"
	/// Subject for 2SV deactivation email
	/// English String: "2-Step Verification Deactivated for Roblox Account: {accountName}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationDeactivationEmailSubject(string accountName)
	{
		return $"2-Step Verification Deactivated for Roblox Account: {accountName}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationDeactivationEmailSubject()
	{
		return "2-Step Verification Deactivated for Roblox Account: {accountName}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo1"
	/// Geolocation information about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1(string spanStartTagWithBold, string username, string region, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo1()
	{
		return "{spanStartTagWithBold}Login request received from {username} located in {region}, {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo2"
	/// Geolocation info about IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2(string spanStartTagWithBold, string username, string country, string ipAddress, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo2()
	{
		return "{spanStartTagWithBold}Login request received from {username} located in {country} ({ipAddress}).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo3"
	/// Geolocation info about IP trying to log in
	/// English String: "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3(string spanStartTagWithBold, string username, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo3()
	{
		return "{spanStartTagWithBold}Login request received from {username} (From Roblox Internal).{spanEndTag}{lineBreak}{lineBreak}\t";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4(string spanStartTagWithBold, string username, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo4()
	{
		return "{spanStartTagWithBold}Login request received from {username} located in {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5(string spanStartTagWithBold, string username, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo5()
	{
		return "{spanStartTagWithBold}Login request received from {username} located in {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Html.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6(string spanStartTagWithBold, string username, string city, string region, string country, string spanEndTag, string lineBreak)
	{
		return $"{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlGeolocationInfo6()
	{
		return "{spanStartTagWithBold}Login request received from {username} located in {city}, {region}, {country}.{spanEndTag}{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.HtmlBody"
	/// Html body for 2SV login email
	/// English String: "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailHtmlBody(string geoLocationInformation, string spanStartTagWithBold, string accountName, string lineBreak, string code, string spanEndTag, string aTagStartWithHref, string ChangePasswordLink, string hrefEnd, string aTagEnd, string TwoStepVerificationArticleLink, string AccountSafetyArticleLink, string SupportLink)
	{
		return $"{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailHtmlBody()
	{
		return "{geoLocationInformation}{spanStartTagWithBold}Login code for {accountName}: {lineBreak}{lineBreak}{code} {spanEndTag}{lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes.{lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request.{lineBreak}{lineBreak}Resources:{lineBreak}{aTagStartWithHref}{ChangePasswordLink}{hrefEnd}Change Your Password{aTagEnd} {lineBreak}{aTagStartWithHref}{TwoStepVerificationArticleLink}{hrefEnd}Learn More About 2-Step Verification{aTagEnd} {lineBreak}{aTagStartWithHref}{AccountSafetyArticleLink}{hrefEnd}Keeping Your Account Safe{aTagEnd} {lineBreak}{aTagStartWithHref}{SupportLink}{hrefEnd}General Roblox Support{aTagEnd} {lineBreak}{lineBreak}Thank you,{lineBreak}{lineBreak}The Roblox Team";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainBody"
	/// Plain body for 2SV login email
	/// English String: "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainBody(string geoLocationInformation, string accountName, string lineBreak, string code, string accountInfoPageLink, string twoStepVerificationHelpArticleLink, string keepAccountSafeArticleLink, string supportPageLink)
	{
		return $"{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainBody()
	{
		return "{geoLocationInformation}Login code for {accountName}: {lineBreak}{lineBreak} {code} {lineBreak}{lineBreak}Enter this code into the 2-Step Verification screen to finish logging in. This code will expire in 15 minutes. {lineBreak}{lineBreak}This email was sent because your account tried to login to Roblox from a new browser or device. If you haven't tried logging into Roblox, someone else may be trying to access your account. You are strongly advised to change your password if you did not generate this request. {lineBreak}{lineBreak}Resources: {lineBreak}Change Your Password [{accountInfoPageLink}] {lineBreak}Learn More About 2-Step Verification [{twoStepVerificationHelpArticleLink}]{lineBreak}Keeping Your Account Safe [{keepAccountSafeArticleLink}] {lineBreak}General Roblox Support [{supportPageLink}] {lineBreak}{lineBreak}Thank you, {lineBreak}{lineBreak}The Roblox Team";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo1"
	/// GeoLocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1(string username, string region, string country, string ipAddress, string lineBreak)
	{
		return $"Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo1()
	{
		return "Login request received from {username} located in {region}, {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo2"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2(string username, string country, string ipAddress, string lineBreak)
	{
		return $"Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo2()
	{
		return "Login request received from {username} located in {country} ({ipAddress}).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo3"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3(string username, string lineBreak)
	{
		return $"Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo3()
	{
		return "Login request received from {username} (From Roblox Internal).{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo4"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4(string username, string country, string lineBreak)
	{
		return $"Login request received from {username} located in {country}.{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo4()
	{
		return "Login request received from {username} located in {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo5"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5(string username, string region, string country, string lineBreak)
	{
		return $"Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo5()
	{
		return "Login request received from {username} located in {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.PlainText.GeolocationInfo6"
	/// Geolocation info of IP trying to login
	/// English String: "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6(string username, string city, string region, string country, string lineBreak)
	{
		return $"Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailPlainTextGeolocationInfo6()
	{
		return "Login request received from {username} located in {city}, {region}, {country}.{lineBreak}{lineBreak}";
	}

	/// <summary>
	/// Key: "Description.TwoStepVerificationLoginEmail.Subject"
	/// Subject for 2SV login email
	/// English String: "Verification Code for Roblox Account: {accountName}"
	/// </summary>
	public virtual string DescriptionTwoStepVerificationLoginEmailSubject(string accountName)
	{
		return $"Verification Code for Roblox Account: {accountName}";
	}

	protected virtual string _GetTemplateForDescriptionTwoStepVerificationLoginEmailSubject()
	{
		return "Verification Code for Roblox Account: {accountName}";
	}

	protected virtual string _GetTemplateForLabelCode()
	{
		return "Code";
	}

	/// <summary>
	/// Key: "Label.CodeInputPlaceholderText"
	/// example: Enter 4-digit code
	/// English String: "Enter {codeLength}-digit Code"
	/// </summary>
	public virtual string LabelCodeInputPlaceholderText(string codeLength)
	{
		return $"Enter {codeLength}-digit Code";
	}

	protected virtual string _GetTemplateForLabelCodeInputPlaceholderText()
	{
		return "Enter {codeLength}-digit Code";
	}

	protected virtual string _GetTemplateForLabelDidNotReceive()
	{
		return "Didn't receive the code?";
	}

	protected virtual string _GetTemplateForLabelEnterCode()
	{
		return "Enter Code (6-digit)";
	}

	protected virtual string _GetTemplateForLabelEnterEmailCode()
	{
		return "Enter the code we just sent you via email";
	}

	protected virtual string _GetTemplateForLabelEnterTextCode()
	{
		return "Enter the code we just sent you via text message";
	}

	protected virtual string _GetTemplateForLabelEnterTwoStepVerificationCode()
	{
		return "Enter your two step verification code.";
	}

	protected virtual string _GetTemplateForLabelFacebookPasswordWarning()
	{
		return "If you have been signing in with Facebook, you must set a password.";
	}

	protected virtual string _GetTemplateForLabelLearnMore()
	{
		return "Learn More";
	}

	/// <summary>
	/// Key: "Label.NeedHelpContactSupport"
	/// label for the support article link
	/// English String: "Need help? Contact {supportLink}"
	/// </summary>
	public virtual string LabelNeedHelpContactSupport(string supportLink)
	{
		return $"Need help? Contact {supportLink}";
	}

	protected virtual string _GetTemplateForLabelNeedHelpContactSupport()
	{
		return "Need help? Contact {supportLink}";
	}

	protected virtual string _GetTemplateForLabelNewCode()
	{
		return "New Code";
	}

	protected virtual string _GetTemplateForLabelRobloxSupport()
	{
		return "Roblox Support";
	}

	protected virtual string _GetTemplateForLabelTrustThisDevice()
	{
		return "Trust this device for 30 days";
	}

	protected virtual string _GetTemplateForLabelTwoStepVerification()
	{
		return "2-Step Verification";
	}

	protected virtual string _GetTemplateForResponseCodeSent()
	{
		return "Code Sent";
	}

	protected virtual string _GetTemplateForResponseFeatureNotAvailable()
	{
		return "Feature not available. Please contact support.";
	}

	protected virtual string _GetTemplateForResponseInvalidCode()
	{
		return "Invalid code.";
	}

	protected virtual string _GetTemplateForResponseSystemErrorReturnToLogin()
	{
		return "System error. Please return to login screen.";
	}

	protected virtual string _GetTemplateForResponseTooManyAttempts()
	{
		return "Too many attempts. Please try again later.";
	}

	protected virtual string _GetTemplateForResponseTooManyCharacters()
	{
		return "Too many characters";
	}
}
