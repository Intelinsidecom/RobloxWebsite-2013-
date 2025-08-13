using System;
using System.Collections.Generic;

namespace Roblox.TranslationResources.Authentication;

internal class LoginResources_en_us : TranslationResourcesBase, ILoginResources, ITranslationResources
{
	private readonly Lazy<IReadOnlyDictionary<string, string>> _AllKeys;

	/// <summary>
	/// Key: "Action.Cancel"
	/// Cancel button text
	/// English String: "Cancel"
	/// </summary>
	public virtual string ActionCancel => "Cancel";

	/// <summary>
	/// Key: "Action.Facebook"
	/// facebook button label
	/// English String: "Facebook"
	/// </summary>
	public virtual string ActionFacebook => "Facebook";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestion"
	/// English String: "Forgot password or username?"
	/// </summary>
	public virtual string ActionForgotPasswordOrUsernameQuestion => "Forgot password or username?";

	/// <summary>
	/// Key: "Action.ForgotPasswordOrUsernameQuestionCapitalized"
	/// link under login form
	/// English String: "Forgot Password or Username?"
	/// </summary>
	public virtual string ActionForgotPasswordOrUsernameQuestionCapitalized => "Forgot Password or Username?";

	/// <summary>
	/// Key: "Action.Login"
	/// English String: "Login"
	/// </summary>
	public virtual string ActionLogin => "Login";

	/// <summary>
	/// Key: "Action.LogInCapitalized"
	/// login button label. please note this is different from 'Login' or 'Log in'.
	/// English String: "Log In"
	/// </summary>
	public virtual string ActionLogInCapitalized => "Log In";

	/// <summary>
	/// Key: "Action.Ok"
	/// button text
	/// English String: "OK"
	/// </summary>
	public virtual string ActionOk => "OK";

	/// <summary>
	/// Key: "Action.PlayAsGuest"
	/// Play as Guest
	/// English String: "Play as Guest"
	/// </summary>
	public virtual string ActionPlayAsGuest => "Play as Guest";

	/// <summary>
	/// Key: "Action.Resend"
	/// button text for resending verification email
	/// English String: "Resend"
	/// </summary>
	public virtual string ActionResend => "Resend";

	/// <summary>
	/// Key: "Action.ResendEmail"
	/// link that resends verification email to user
	/// English String: "Resend Email"
	/// </summary>
	public virtual string ActionResendEmail => "Resend Email";

	/// <summary>
	/// Key: "Action.SendVerificationEmail"
	/// button user can click to send a verification link to their email
	/// English String: "Send Verification Email"
	/// </summary>
	public virtual string ActionSendVerificationEmail => "Send Verification Email";

	/// <summary>
	/// Key: "Action.SignIn"
	/// Sign In button text
	/// English String: "Sign In"
	/// </summary>
	public virtual string ActionSignIn => "Sign In";

	/// <summary>
	/// Key: "Action.SignInWithFacebook"
	/// Sign In with Facebook
	/// English String: "Sign In with Facebook"
	/// </summary>
	public virtual string ActionSignInWithFacebook => "Sign In with Facebook";

	/// <summary>
	/// Key: "Action.SignUp"
	/// English String: "Sign up"
	/// </summary>
	public virtual string ActionSignUp => "Sign up";

	/// <summary>
	/// Key: "Action.SignUpCapitalized"
	/// link which takes user to sign up page
	/// English String: "Sign Up"
	/// </summary>
	public virtual string ActionSignUpCapitalized => "Sign Up";

	/// <summary>
	/// Key: "Action.WeChatLogin"
	/// button text for logging in with WeChat
	/// English String: "WeChat Login"
	/// </summary>
	public virtual string ActionWeChatLogin => "WeChat Login";

	/// <summary>
	/// Key: "Heading.Login"
	/// heading on the login page
	/// English String: "Login"
	/// </summary>
	public virtual string HeadingLogin => "Login";

	/// <summary>
	/// Key: "Heading.LoginRoblox"
	/// current login page heading
	/// English String: "Login to Roblox"
	/// </summary>
	public virtual string HeadingLoginRoblox => "Login to Roblox";

	public virtual string HeadingSignUpMakeFriends => "Sign Up to Build & Make Friends";

	/// <summary>
	/// Key: "Label.AccountNotNeeded"
	/// You don't need an account to play Roblox
	/// English String: "You don't need an account to play Roblox"
	/// </summary>
	public virtual string LabelAccountNotNeeded => "You don't need an account to play Roblox";

	/// <summary>
	/// Key: "Label.EmailNeedsVerification"
	/// modal header used for prompting user they need to verify their email in order to log in with it
	/// English String: "Your email needs verification"
	/// </summary>
	public virtual string LabelEmailNeedsVerification => "Your email needs verification";

	/// <summary>
	/// Key: "Label.FacebookCreatePasswordWarning"
	/// If you have been signing in with Facebook, you must set a password.
	/// English String: "If you have been signing in with Facebook, you must set a password."
	/// </summary>
	public virtual string LabelFacebookCreatePasswordWarning => "If you have been signing in with Facebook, you must set a password.";

	/// <summary>
	/// Key: "Label.ForgotUsernamePassword"
	/// landing page top right link for password reset
	/// English String: "Forgot Username/Password?"
	/// </summary>
	public virtual string LabelForgotUsernamePassword => "Forgot Username/Password?";

	/// <summary>
	/// Key: "Label.LearnMore"
	/// learn more link text
	/// English String: "Learn more"
	/// </summary>
	public virtual string LabelLearnMore => "Learn more";

	/// <summary>
	/// Key: "Label.LoggingInSpinnerText"
	/// English String: "Logging in…"
	/// </summary>
	public virtual string LabelLoggingInSpinnerText => "Logging in…";

	/// <summary>
	/// Key: "Label.Login"
	/// English String: "Log in"
	/// </summary>
	public virtual string LabelLogin => "Log in";

	/// <summary>
	/// Key: "Label.LoginWithYour"
	/// Label for a partition line between login with email and facebook login. Please keep the text in lowercase for roman characters.
	/// English String: "login with your"
	/// </summary>
	public virtual string LabelLoginWithYour => "login with your";

	/// <summary>
	/// Key: "Label.NoAccount"
	/// Don't have an account?
	/// English String: "Don't have an account?"
	/// </summary>
	public virtual string LabelNoAccount => "Don't have an account?";

	/// <summary>
	/// Key: "Label.NonAMemberQuestion"
	/// The question heading for the section on the login page to take use to sign up page.
	/// English String: "Not a member?"
	/// </summary>
	public virtual string LabelNonAMemberQuestion => "Not a member?";

	/// <summary>
	/// Key: "Label.NotReceived"
	/// prompt for allowing users to resend verification email
	/// English String: "Didn't receive it?"
	/// </summary>
	public virtual string LabelNotReceived => "Didn't receive it?";

	/// <summary>
	/// Key: "Label.Or"
	/// partition between email login and facebook login
	/// English String: "Or"
	/// </summary>
	public virtual string LabelOr => "Or";

	/// <summary>
	/// Key: "Label.Password"
	/// Password
	/// English String: "Password"
	/// </summary>
	public virtual string LabelPassword => "Password";

	/// <summary>
	/// Key: "Label.PasswordWithColumn"
	/// label for the password field on the login page
	/// English String: "Password:"
	/// </summary>
	public virtual string LabelPasswordWithColumn => "Password:";

	/// <summary>
	/// Key: "Label.StartPlaying"
	/// You can start playing right now, in guest mode!
	/// English String: "You can start playing right now, in guest mode!"
	/// </summary>
	public virtual string LabelStartPlaying => "You can start playing right now, in guest mode!";

	/// <summary>
	/// Key: "Label.UnverifiedEmailInstructions"
	/// message shown in a modal when user logs in with unverified email
	/// English String: "To log in with your email, it must be verified. You can also log in with your username."
	/// </summary>
	public virtual string LabelUnverifiedEmailInstructions => "To log in with your email, it must be verified. You can also log in with your username.";

	/// <summary>
	/// Key: "Label.Username"
	/// English String: "Username"
	/// </summary>
	public virtual string LabelUsername => "Username";

	/// <summary>
	/// Key: "Label.UsernameEmail"
	/// placeholder text for input field that accepts username or email
	/// English String: "Username/Email"
	/// </summary>
	public virtual string LabelUsernameEmail => "Username/Email";

	/// <summary>
	/// Key: "Label.UsernameEmailPhone"
	/// placeholder text for input fields that accept username, email or phone
	/// English String: "Username/Email/Phone"
	/// </summary>
	public virtual string LabelUsernameEmailPhone => "Username/Email/Phone";

	/// <summary>
	/// Key: "Label.UsernamePhone"
	/// placeholder text for input field that accepts username or phone
	/// English String: "Username/Phone"
	/// </summary>
	public virtual string LabelUsernamePhone => "Username/Phone";

	/// <summary>
	/// Key: "Label.UsernameWithColumn"
	/// label for username field on login page
	/// English String: "Username:"
	/// </summary>
	public virtual string LabelUsernameWithColumn => "Username:";

	/// <summary>
	/// Key: "Label.VerificationEmailSent"
	/// message telling user a verification email was sent to them
	/// English String: "Verification Email Sent!"
	/// </summary>
	public virtual string LabelVerificationEmailSent => "Verification Email Sent!";

	/// <summary>
	/// Key: "Label.WeChatAntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public virtual string LabelWeChatAntiAddictionText => "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle.";

	/// <summary>
	/// Key: "Message.UnknownErrorTryAgain"
	/// An unknown error occurred. Please try again.
	/// English String: "An unknown error occurred. Please try again."
	/// </summary>
	public virtual string MessageUnknownErrorTryAgain => "An unknown error occurred. Please try again.";

	/// <summary>
	/// Key: "Message.UsernameAndPasswordRequired"
	/// message shown to user when they attempt to login without entering a username or password
	/// English String: "Username and password required"
	/// </summary>
	public virtual string MessageUsernameAndPasswordRequired => "Username and password required";

	/// <summary>
	/// Key: "Response.AccountIssueErrorContactSupport"
	/// English String: "Account issue. Please contact Support."
	/// </summary>
	public virtual string ResponseAccountIssueErrorContactSupport => "Account issue. Please contact Support.";

	/// <summary>
	/// Key: "Response.AccountLockedRequestReset"
	/// Account has been locked. Please request a password reset.
	/// English String: "Account has been locked. Please request a password reset."
	/// </summary>
	public virtual string ResponseAccountLockedRequestReset => "Account has been locked. Please request a password reset.";

	/// <summary>
	/// Key: "Response.AccountNotFound"
	/// Account not found. Please try again.
	/// English String: "Account not found. Please try again."
	/// </summary>
	public virtual string ResponseAccountNotFound => "Account not found. Please try again.";

	/// <summary>
	/// Key: "Response.EmailLinkedToMultipleAccountsLoginWithUsername"
	/// error message displayed when user attempts to log in with an email that is linked to multiple accounts
	/// English String: "Your email is associated with more than 1 username. Please login with your username."
	/// </summary>
	public virtual string ResponseEmailLinkedToMultipleAccountsLoginWithUsername => "Your email is associated with more than 1 username. Please login with your username.";

	/// <summary>
	/// Key: "Response.EmailSent"
	/// response telling user that a verification email has been sent to them
	/// English String: "Email sent!"
	/// </summary>
	public virtual string ResponseEmailSent => "Email sent!";

	/// <summary>
	/// Key: "Response.IncorrectEmailOrPassword"
	/// error message displayed when user logs in with an invalid email or password
	/// English String: "Incorrect email or password."
	/// </summary>
	public virtual string ResponseIncorrectEmailOrPassword => "Incorrect email or password.";

	/// <summary>
	/// Key: "Response.IncorrectPhoneOrPassword"
	/// error message displayed when user logs in with an invalid phone or password
	/// English String: "Incorrect phone or password."
	/// </summary>
	public virtual string ResponseIncorrectPhoneOrPassword => "Incorrect phone or password.";

	/// <summary>
	/// Key: "Response.IncorrectUsernamePassword"
	/// English String: "Incorrect username or password."
	/// </summary>
	public virtual string ResponseIncorrectUsernamePassword => "Incorrect username or password.";

	/// <summary>
	/// Key: "Response.LoginWithUsername"
	/// error message shown when user attempts to login with method other than username and an error occurred
	/// English String: "Something went wrong. Please login with your username."
	/// </summary>
	public virtual string ResponseLoginWithUsername => "Something went wrong. Please login with your username.";

	/// <summary>
	/// Key: "Response.PasswordNotProvided"
	/// password field is empty
	/// English String: "You must enter a password."
	/// </summary>
	public virtual string ResponsePasswordNotProvided => "You must enter a password.";

	/// <summary>
	/// Key: "Response.TooManyAttemptsPleaseWait"
	/// English String: "Too many attempts. Please wait a bit."
	/// </summary>
	public virtual string ResponseTooManyAttemptsPleaseWait => "Too many attempts. Please wait a bit.";

	/// <summary>
	/// Key: "Response.UnknownError"
	/// English String: "Unknown Error"
	/// </summary>
	public virtual string ResponseUnknownError => "Unknown Error";

	/// <summary>
	/// Key: "Response.UnknownLoginError"
	/// Unknown login failure.
	/// English String: "Unknown login failure."
	/// </summary>
	public virtual string ResponseUnknownLoginError => "Unknown login failure.";

	/// <summary>
	/// Key: "Response.UnverifiedEmailLoginWithUsername"
	/// error message shown when user attempts to login with unverified email
	/// English String: "Your email is not verified. Please login with your username."
	/// </summary>
	public virtual string ResponseUnverifiedEmailLoginWithUsername => "Your email is not verified. Please login with your username.";

	/// <summary>
	/// Key: "Response.UnverifiedPhoneLoginWithUsername"
	/// error message shown when user attempts to login with an unverified phone number
	/// English String: "Your phone is not verified. Please login with your username."
	/// </summary>
	public virtual string ResponseUnverifiedPhoneLoginWithUsername => "Your phone is not verified. Please login with your username.";

	/// <summary>
	/// Key: "Response.UsernameNotProvided"
	/// username field is empty
	/// English String: "You must enter a username."
	/// </summary>
	public virtual string ResponseUsernameNotProvided => "You must enter a username.";

	/// <summary>
	/// Key: "Response.UseSocialSignOn"
	/// Unable to login. Please use Social Network sign on.
	/// English String: "Unable to login. Please use Social Network sign on."
	/// </summary>
	public virtual string ResponseUseSocialSignOn => "Unable to login. Please use Social Network sign on.";

	/// <summary>
	/// Key: "WeChat.AntiAddictionText"
	/// English String: "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle."
	/// </summary>
	public virtual string WeChatAntiAddictionText => "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle.";

	/// <summary>
	/// Key: "WeChat.RealNameNotVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html"
	/// </summary>
	public virtual string WeChatRealNameNotVerified => "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html";

	public LoginResources_en_us(TranslationResourceState state)
		: base(state)
	{
		_AllKeys = new Lazy<IReadOnlyDictionary<string, string>>(() => new Dictionary<string, string>
		{
			{
				"Action.Cancel",
				_GetTemplateForActionCancel()
			},
			{
				"Action.Facebook",
				_GetTemplateForActionFacebook()
			},
			{
				"Action.ForgotPasswordOrUsernameQuestion",
				_GetTemplateForActionForgotPasswordOrUsernameQuestion()
			},
			{
				"Action.ForgotPasswordOrUsernameQuestionCapitalized",
				_GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
			},
			{
				"Action.Login",
				_GetTemplateForActionLogin()
			},
			{
				"Action.LogInCapitalized",
				_GetTemplateForActionLogInCapitalized()
			},
			{
				"Action.Ok",
				_GetTemplateForActionOk()
			},
			{
				"Action.PlayAsGuest",
				_GetTemplateForActionPlayAsGuest()
			},
			{
				"Action.Resend",
				_GetTemplateForActionResend()
			},
			{
				"Action.ResendEmail",
				_GetTemplateForActionResendEmail()
			},
			{
				"Action.SendVerificationEmail",
				_GetTemplateForActionSendVerificationEmail()
			},
			{
				"Action.SignIn",
				_GetTemplateForActionSignIn()
			},
			{
				"Action.SignInWithFacebook",
				_GetTemplateForActionSignInWithFacebook()
			},
			{
				"Action.SignUp",
				_GetTemplateForActionSignUp()
			},
			{
				"Action.SignUpCapitalized",
				_GetTemplateForActionSignUpCapitalized()
			},
			{
				"Action.WeChatLogin",
				_GetTemplateForActionWeChatLogin()
			},
			{
				"Heading.Login",
				_GetTemplateForHeadingLogin()
			},
			{
				"Heading.LoginRoblox",
				_GetTemplateForHeadingLoginRoblox()
			},
			{
				"Heading.SignUpMakeFriends",
				_GetTemplateForHeadingSignUpMakeFriends()
			},
			{
				"Label.AccountNotNeeded",
				_GetTemplateForLabelAccountNotNeeded()
			},
			{
				"Label.EmailNeedsVerification",
				_GetTemplateForLabelEmailNeedsVerification()
			},
			{
				"Label.FacebookCreatePasswordWarning",
				_GetTemplateForLabelFacebookCreatePasswordWarning()
			},
			{
				"Label.ForgotUsernamePassword",
				_GetTemplateForLabelForgotUsernamePassword()
			},
			{
				"Label.GreetingForNewAccount",
				_GetTemplateForLabelGreetingForNewAccount()
			},
			{
				"Label.LearnMore",
				_GetTemplateForLabelLearnMore()
			},
			{
				"Label.LoggingInSpinnerText",
				_GetTemplateForLabelLoggingInSpinnerText()
			},
			{
				"Label.Login",
				_GetTemplateForLabelLogin()
			},
			{
				"Label.LoginWithYour",
				_GetTemplateForLabelLoginWithYour()
			},
			{
				"Label.NoAccount",
				_GetTemplateForLabelNoAccount()
			},
			{
				"Label.NonAMemberQuestion",
				_GetTemplateForLabelNonAMemberQuestion()
			},
			{
				"Label.NotReceived",
				_GetTemplateForLabelNotReceived()
			},
			{
				"Label.Or",
				_GetTemplateForLabelOr()
			},
			{
				"Label.Password",
				_GetTemplateForLabelPassword()
			},
			{
				"Label.PasswordWithColumn",
				_GetTemplateForLabelPasswordWithColumn()
			},
			{
				"Label.StartPlaying",
				_GetTemplateForLabelStartPlaying()
			},
			{
				"Label.UnverifiedEmailInstructions",
				_GetTemplateForLabelUnverifiedEmailInstructions()
			},
			{
				"Label.Username",
				_GetTemplateForLabelUsername()
			},
			{
				"Label.UsernameEmail",
				_GetTemplateForLabelUsernameEmail()
			},
			{
				"Label.UsernameEmailPhone",
				_GetTemplateForLabelUsernameEmailPhone()
			},
			{
				"Label.UsernamePhone",
				_GetTemplateForLabelUsernamePhone()
			},
			{
				"Label.UsernameWithColumn",
				_GetTemplateForLabelUsernameWithColumn()
			},
			{
				"Label.VerificationEmailSent",
				_GetTemplateForLabelVerificationEmailSent()
			},
			{
				"Label.WeChatAntiAddictionText",
				_GetTemplateForLabelWeChatAntiAddictionText()
			},
			{
				"Message.UnknownErrorTryAgain",
				_GetTemplateForMessageUnknownErrorTryAgain()
			},
			{
				"Message.UsernameAndPasswordRequired",
				_GetTemplateForMessageUsernameAndPasswordRequired()
			},
			{
				"Response.AccountIssueErrorContactSupport",
				_GetTemplateForResponseAccountIssueErrorContactSupport()
			},
			{
				"Response.AccountLockedRequestReset",
				_GetTemplateForResponseAccountLockedRequestReset()
			},
			{
				"Response.AccountNotFound",
				_GetTemplateForResponseAccountNotFound()
			},
			{
				"Response.EmailLinkedToMultipleAccountsLoginWithUsername",
				_GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
			},
			{
				"Response.EmailSent",
				_GetTemplateForResponseEmailSent()
			},
			{
				"Response.IncorrectEmailOrPassword",
				_GetTemplateForResponseIncorrectEmailOrPassword()
			},
			{
				"Response.IncorrectPhoneOrPassword",
				_GetTemplateForResponseIncorrectPhoneOrPassword()
			},
			{
				"Response.IncorrectUsernamePassword",
				_GetTemplateForResponseIncorrectUsernamePassword()
			},
			{
				"Response.LoginWithUsername",
				_GetTemplateForResponseLoginWithUsername()
			},
			{
				"Response.PasswordNotProvided",
				_GetTemplateForResponsePasswordNotProvided()
			},
			{
				"Response.TooManyAttemptsPleaseWait",
				_GetTemplateForResponseTooManyAttemptsPleaseWait()
			},
			{
				"Response.UnknownError",
				_GetTemplateForResponseUnknownError()
			},
			{
				"Response.UnknownLoginError",
				_GetTemplateForResponseUnknownLoginError()
			},
			{
				"Response.UnverifiedEmailLoginWithUsername",
				_GetTemplateForResponseUnverifiedEmailLoginWithUsername()
			},
			{
				"Response.UnverifiedPhoneLoginWithUsername",
				_GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
			},
			{
				"Response.UsernameNotProvided",
				_GetTemplateForResponseUsernameNotProvided()
			},
			{
				"Response.UseSocialSignOn",
				_GetTemplateForResponseUseSocialSignOn()
			},
			{
				"Response.WeChatNotRealNameVerified",
				_GetTemplateForResponseWeChatNotRealNameVerified()
			},
			{
				"WeChat.AntiAddictionText",
				_GetTemplateForWeChatAntiAddictionText()
			},
			{
				"WeChat.RealNameNotVerified",
				_GetTemplateForWeChatRealNameNotVerified()
			}
		});
	}

	public IReadOnlyDictionary<string, string> GetAllKeys()
	{
		return _AllKeys.Value;
	}

	public string GetFullContentNamespaceName()
	{
		return "Authentication.Login";
	}

	protected virtual string _GetTemplateForActionCancel()
	{
		return "Cancel";
	}

	protected virtual string _GetTemplateForActionFacebook()
	{
		return "Facebook";
	}

	protected virtual string _GetTemplateForActionForgotPasswordOrUsernameQuestion()
	{
		return "Forgot password or username?";
	}

	protected virtual string _GetTemplateForActionForgotPasswordOrUsernameQuestionCapitalized()
	{
		return "Forgot Password or Username?";
	}

	protected virtual string _GetTemplateForActionLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForActionLogInCapitalized()
	{
		return "Log In";
	}

	protected virtual string _GetTemplateForActionOk()
	{
		return "OK";
	}

	protected virtual string _GetTemplateForActionPlayAsGuest()
	{
		return "Play as Guest";
	}

	protected virtual string _GetTemplateForActionResend()
	{
		return "Resend";
	}

	protected virtual string _GetTemplateForActionResendEmail()
	{
		return "Resend Email";
	}

	protected virtual string _GetTemplateForActionSendVerificationEmail()
	{
		return "Send Verification Email";
	}

	protected virtual string _GetTemplateForActionSignIn()
	{
		return "Sign In";
	}

	protected virtual string _GetTemplateForActionSignInWithFacebook()
	{
		return "Sign In with Facebook";
	}

	protected virtual string _GetTemplateForActionSignUp()
	{
		return "Sign up";
	}

	protected virtual string _GetTemplateForActionSignUpCapitalized()
	{
		return "Sign Up";
	}

	protected virtual string _GetTemplateForActionWeChatLogin()
	{
		return "WeChat Login";
	}

	protected virtual string _GetTemplateForHeadingLogin()
	{
		return "Login";
	}

	protected virtual string _GetTemplateForHeadingLoginRoblox()
	{
		return "Login to Roblox";
	}

	protected virtual string _GetTemplateForHeadingSignUpMakeFriends()
	{
		return "Sign Up to Build & Make Friends";
	}

	protected virtual string _GetTemplateForLabelAccountNotNeeded()
	{
		return "You don't need an account to play Roblox";
	}

	protected virtual string _GetTemplateForLabelEmailNeedsVerification()
	{
		return "Your email needs verification";
	}

	protected virtual string _GetTemplateForLabelFacebookCreatePasswordWarning()
	{
		return "If you have been signing in with Facebook, you must set a password.";
	}

	protected virtual string _GetTemplateForLabelForgotUsernamePassword()
	{
		return "Forgot Username/Password?";
	}

	/// <summary>
	/// Key: "Label.GreetingForNewAccount"
	/// Shown when a username doesn't exist on the login page to invite to create a new account.
	/// English String: "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}"
	/// </summary>
	public virtual string LabelGreetingForNewAccount(string username, string linkStartSignup, string linkEndSignup)
	{
		return $"Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}";
	}

	protected virtual string _GetTemplateForLabelGreetingForNewAccount()
	{
		return "Nice to meet you, {username}. {linkStartSignup}Let's make an account! {linkEndSignup}";
	}

	protected virtual string _GetTemplateForLabelLearnMore()
	{
		return "Learn more";
	}

	protected virtual string _GetTemplateForLabelLoggingInSpinnerText()
	{
		return "Logging in…";
	}

	protected virtual string _GetTemplateForLabelLogin()
	{
		return "Log in";
	}

	protected virtual string _GetTemplateForLabelLoginWithYour()
	{
		return "login with your";
	}

	protected virtual string _GetTemplateForLabelNoAccount()
	{
		return "Don't have an account?";
	}

	protected virtual string _GetTemplateForLabelNonAMemberQuestion()
	{
		return "Not a member?";
	}

	protected virtual string _GetTemplateForLabelNotReceived()
	{
		return "Didn't receive it?";
	}

	protected virtual string _GetTemplateForLabelOr()
	{
		return "Or";
	}

	protected virtual string _GetTemplateForLabelPassword()
	{
		return "Password";
	}

	protected virtual string _GetTemplateForLabelPasswordWithColumn()
	{
		return "Password:";
	}

	protected virtual string _GetTemplateForLabelStartPlaying()
	{
		return "You can start playing right now, in guest mode!";
	}

	protected virtual string _GetTemplateForLabelUnverifiedEmailInstructions()
	{
		return "To log in with your email, it must be verified. You can also log in with your username.";
	}

	protected virtual string _GetTemplateForLabelUsername()
	{
		return "Username";
	}

	protected virtual string _GetTemplateForLabelUsernameEmail()
	{
		return "Username/Email";
	}

	protected virtual string _GetTemplateForLabelUsernameEmailPhone()
	{
		return "Username/Email/Phone";
	}

	protected virtual string _GetTemplateForLabelUsernamePhone()
	{
		return "Username/Phone";
	}

	protected virtual string _GetTemplateForLabelUsernameWithColumn()
	{
		return "Username:";
	}

	protected virtual string _GetTemplateForLabelVerificationEmailSent()
	{
		return "Verification Email Sent!";
	}

	protected virtual string _GetTemplateForLabelWeChatAntiAddictionText()
	{
		return "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle.";
	}

	protected virtual string _GetTemplateForMessageUnknownErrorTryAgain()
	{
		return "An unknown error occurred. Please try again.";
	}

	protected virtual string _GetTemplateForMessageUsernameAndPasswordRequired()
	{
		return "Username and password required";
	}

	protected virtual string _GetTemplateForResponseAccountIssueErrorContactSupport()
	{
		return "Account issue. Please contact Support.";
	}

	protected virtual string _GetTemplateForResponseAccountLockedRequestReset()
	{
		return "Account has been locked. Please request a password reset.";
	}

	protected virtual string _GetTemplateForResponseAccountNotFound()
	{
		return "Account not found. Please try again.";
	}

	protected virtual string _GetTemplateForResponseEmailLinkedToMultipleAccountsLoginWithUsername()
	{
		return "Your email is associated with more than 1 username. Please login with your username.";
	}

	protected virtual string _GetTemplateForResponseEmailSent()
	{
		return "Email sent!";
	}

	protected virtual string _GetTemplateForResponseIncorrectEmailOrPassword()
	{
		return "Incorrect email or password.";
	}

	protected virtual string _GetTemplateForResponseIncorrectPhoneOrPassword()
	{
		return "Incorrect phone or password.";
	}

	protected virtual string _GetTemplateForResponseIncorrectUsernamePassword()
	{
		return "Incorrect username or password.";
	}

	protected virtual string _GetTemplateForResponseLoginWithUsername()
	{
		return "Something went wrong. Please login with your username.";
	}

	protected virtual string _GetTemplateForResponsePasswordNotProvided()
	{
		return "You must enter a password.";
	}

	protected virtual string _GetTemplateForResponseTooManyAttemptsPleaseWait()
	{
		return "Too many attempts. Please wait a bit.";
	}

	protected virtual string _GetTemplateForResponseUnknownError()
	{
		return "Unknown Error";
	}

	protected virtual string _GetTemplateForResponseUnknownLoginError()
	{
		return "Unknown login failure.";
	}

	protected virtual string _GetTemplateForResponseUnverifiedEmailLoginWithUsername()
	{
		return "Your email is not verified. Please login with your username.";
	}

	protected virtual string _GetTemplateForResponseUnverifiedPhoneLoginWithUsername()
	{
		return "Your phone is not verified. Please login with your username.";
	}

	protected virtual string _GetTemplateForResponseUsernameNotProvided()
	{
		return "You must enter a username.";
	}

	protected virtual string _GetTemplateForResponseUseSocialSignOn()
	{
		return "Unable to login. Please use Social Network sign on.";
	}

	/// <summary>
	/// Key: "Response.WeChatNotRealNameVerified"
	/// English String: "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}"
	/// </summary>
	public virtual string ResponseWeChatNotRealNameVerified(string url)
	{
		return $"Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}";
	}

	protected virtual string _GetTemplateForResponseWeChatNotRealNameVerified()
	{
		return "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit {url}";
	}

	protected virtual string _GetTemplateForWeChatAntiAddictionText()
	{
		return "Boycott bad games, refuse pirated games. Be aware of self-defense and being deceived. Playing games is good for your brain, but too much game play can harm your health. Manage your time well and enjoy a healthy lifestyle.";
	}

	protected virtual string _GetTemplateForWeChatRealNameNotVerified()
	{
		return "Your WeChat is not real-name verified. Please use a real-name verified WeChat account and try again. Please visit https://jiazhang.qq.com/zk/home.html";
	}
}
