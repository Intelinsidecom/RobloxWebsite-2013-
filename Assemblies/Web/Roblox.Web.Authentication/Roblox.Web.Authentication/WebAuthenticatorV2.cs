using System;
using System.Diagnostics;
using System.Web;
using System.Web.Security;
using Roblox.Captcha.Captcha.V1;
using Roblox.Common;
using Roblox.FloodCheckers.Core;
using Roblox.Platform.Authentication;
using Roblox.Platform.Captcha;
using Roblox.Platform.Core;
using Roblox.Platform.Marketing;
using Roblox.Platform.Membership;
using Roblox.Platform.MembershipCore;
using Roblox.Platform.TwoStepVerification;
using Roblox.Platform.TwoStepVerification.Properties;
using Roblox.Web.Authentication.Floodcheckers;
using Roblox.Web.Authentication.Login;
using Roblox.Web.Authentication.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Authentication;

public class WebAuthenticatorV2 : IWebAuthenticatorV2, ILoginEventSender
{
	private readonly IWebAuthenticationReader _WebAuthenticationReader;

	private readonly IAccountsNeedingPasswordResetFactory _AccountsNeedingPasswordResetFactory;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly Factories _CaptchaFactories;

	private readonly ITwoStepAuthenticator _TwoStepAuthenticator;

	private readonly ITwoStepVerificationCodeSender _TwoStepVerificationCodeSender;

	private readonly ITwoStepVerificationConfigurationProvider _TwoStepVerificationConfigurationProvider;

	private readonly IBrowserTrackerDetailProvider _BrowserTrackerDetailProvider;

	private readonly IWebAuthenticationCaptchaAuthority _CaptchaAuthority;

	private readonly IUserFactory _UserFactory;

	private readonly ICaptchaGrpcClient _CaptchaGrpcClient;

	internal virtual bool SignInWithUserCredentialsActionLoggingEnabled => Roblox.Web.Authentication.Properties.Settings.Default.SignInWithUserCredentialsActionLoggingEnabled;

	internal virtual bool ExistingLoginSessionShouldFailEnabled => Roblox.Web.Authentication.Properties.Settings.Default.ExistingLoginSessionShouldFailEnabled;

	internal virtual bool IsLoginAttemptByIpFloodCheckEnabled => Roblox.Web.Authentication.Properties.Settings.Default.IsLoginAttemptByIpFloodCheckEnabled;

	public event Action<string, string, long> SignInWithUserCredentialsActionProcessed;

	public event System.Action OnAccountMismatchSignOut;

	public event System.Action OnLoginSessionAlreadyExists;

	public event Action<IUserIdentifier, LoginFailureStatus, CredentialsType, string> OnUserLoginFailed;

	public event Action<IUser, CredentialsType> OnUserLoggedIn;

	public event Action<string, TwoStepVerificationMediaType, IUser, CredentialsType> OnTwoStepVerificationSucceeded;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.WebAuthenticatorV2" /> class.
	/// </summary>
	/// <param name="webAuthenticationReader">An <see cref="T:Roblox.Web.Authentication.IWebAuthenticationReader" />.</param>
	/// <param name="accountsNeedingPasswordResetFactory">An <see cref="T:Roblox.Platform.Authentication.IAccountsNeedingPasswordResetFactory" />.</param>
	/// <param name="clientDeviceIdentifier">An <see cref="T:Roblox.Web.Devices.IClientDeviceIdentifier" />.</param>
	/// <param name="captchaFactories">An <see cref="T:Roblox.Platform.Captcha.Factories" />.</param>
	/// <param name="twoStepAuthenticator">An <see cref="T:Roblox.Web.Authentication.ITwoStepAuthenticator" />.</param>
	/// <param name="twoStepVerificationCodeSender">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeSender" />.</param>
	/// <param name="twoStepVerificationConfigurationProvider">An <see cref="T:Roblox.Platform.TwoStepVerification.ITwoStepVerificationConfigurationProvider" />.</param>
	/// <param name="browserTrackerDetailProvider">An <see cref="T:Roblox.Platform.Marketing.IBrowserTrackerDetailProvider" />.</param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///     Thrown if <paramref name="webAuthenticationReader" />, <paramref name="accountsNeedingPasswordResetFactory" />, 
	///     <paramref name="clientDeviceIdentifier" />, <paramref name="captchaFactories" />,
	///     <paramref name="twoStepAuthenticator" />, <paramref name="twoStepVerificationCodeSender" />, <paramref name="twoStepVerificationConfigurationProvider" />  
	///     or <paramref name="browserTrackerDetailProvider" /> is null.
	/// </exception>
	public WebAuthenticatorV2(IWebAuthenticationReader webAuthenticationReader, IAccountsNeedingPasswordResetFactory accountsNeedingPasswordResetFactory, IClientDeviceIdentifier clientDeviceIdentifier, Factories captchaFactories, ITwoStepAuthenticator twoStepAuthenticator, ITwoStepVerificationCodeSender twoStepVerificationCodeSender, ITwoStepVerificationConfigurationProvider twoStepVerificationConfigurationProvider, IBrowserTrackerDetailProvider browserTrackerDetailProvider, IUserFactory userFactory, ICaptchaGrpcClient captchaGrpcClient)
	{
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_AccountsNeedingPasswordResetFactory = accountsNeedingPasswordResetFactory ?? throw new ArgumentNullException("accountsNeedingPasswordResetFactory");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_CaptchaFactories = captchaFactories ?? throw new ArgumentNullException("captchaFactories");
		_TwoStepAuthenticator = twoStepAuthenticator ?? throw new ArgumentNullException("twoStepAuthenticator");
		_TwoStepVerificationCodeSender = twoStepVerificationCodeSender ?? throw new ArgumentNullException("twoStepVerificationCodeSender");
		_TwoStepVerificationConfigurationProvider = twoStepVerificationConfigurationProvider ?? throw new ArgumentNullException("twoStepVerificationConfigurationProvider");
		_BrowserTrackerDetailProvider = browserTrackerDetailProvider ?? throw new ArgumentNullException("browserTrackerDetailProvider");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_CaptchaAuthority = new WebAuthenticationCaptchaAuthority(_ClientDeviceIdentifier);
		_CaptchaGrpcClient = captchaGrpcClient ?? throw new ArgumentNullException("captchaGrpcClient");
	}

	internal WebAuthenticatorV2(IWebAuthenticationReader webAuthenticationReader, IAccountsNeedingPasswordResetFactory accountsNeedingPasswordResetFactory, IClientDeviceIdentifier clientDeviceIdentifier, Factories captchaFactories, ITwoStepAuthenticator twoStepAuthenticator, ITwoStepVerificationCodeSender twoStepVerificationCodeSender, ITwoStepVerificationConfigurationProvider twoStepVerificationConfigurationProvider, IBrowserTrackerDetailProvider browserTrackerDetailProvider, IWebAuthenticationCaptchaAuthority captchaAuthority, IUserFactory userFactory, ICaptchaGrpcClient captchaGrpcClient)
	{
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
		_AccountsNeedingPasswordResetFactory = accountsNeedingPasswordResetFactory ?? throw new ArgumentNullException("accountsNeedingPasswordResetFactory");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_CaptchaFactories = captchaFactories ?? throw new ArgumentNullException("captchaFactories");
		_TwoStepAuthenticator = twoStepAuthenticator ?? throw new ArgumentNullException("twoStepAuthenticator");
		_TwoStepVerificationCodeSender = twoStepVerificationCodeSender ?? throw new ArgumentNullException("twoStepVerificationCodeSender");
		_TwoStepVerificationConfigurationProvider = twoStepVerificationConfigurationProvider ?? throw new ArgumentNullException("twoStepVerificationConfigurationProvider");
		_BrowserTrackerDetailProvider = browserTrackerDetailProvider ?? throw new ArgumentNullException("browserTrackerDetailProvider");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_CaptchaAuthority = captchaAuthority;
		_CaptchaGrpcClient = captchaGrpcClient ?? throw new ArgumentNullException("captchaGrpcClient");
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticatorV2.SignInWithUserCredentials(Roblox.Platform.Authentication.IRobloxUserCredentials,Roblox.Platform.Marketing.IBrowserTracker,Roblox.Web.Authentication.ICaptchaParameter)" />
	public ILoginResult SignInWithUserCredentials(IRobloxUserCredentials credentials, IBrowserTracker browserTracker, ICaptchaParameter captchaParameter)
	{
		if (credentials == null)
		{
			throw new ArgumentNullException("credentials");
		}
		if (string.IsNullOrWhiteSpace(credentials.CredentialValue))
		{
			throw new ArgumentException("Credentials value can not be null or whitespace", "CredentialValue");
		}
		string ipAddress = GetOriginIP();
		IFloodChecker userCredentialsFloodChecker;
		bool loginAttemptFloodCheckersFlooded;
		bool captchaAuthorityCaptchaRequired;
		IAction loginCaptchaAction;
		bool loginCaptchaActionPassed;
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "UserCredentialsFloodChecker", sw.ElapsedMilliseconds);
		}))
		{
			IFloodChecker loginAttemptByIpFloodChecker = GetLoginAttemptByIpFloodChecker(ipAddress);
			userCredentialsFloodChecker = GetUserCredentialsFloodChecker(credentials);
			loginAttemptFloodCheckersFlooded = userCredentialsFloodChecker.IsFlooded() || loginAttemptByIpFloodChecker.IsFlooded();
			captchaAuthorityCaptchaRequired = _CaptchaAuthority.IsCaptchaRequired(GetUserAgent(), browserTracker);
			loginCaptchaAction = GetLoginCaptchaAction(credentials.CredentialValue);
			loginCaptchaActionPassed = loginCaptchaAction.HasPassed(DateTime.Now);
			if (!loginCaptchaActionPassed && captchaParameter != null && captchaParameter.IsBedev2ForBackendWebLoginEnabled)
			{
				loginCaptchaActionPassed = _CaptchaGrpcClient.CaptchaPassed(captchaParameter, (ActionType)3);
			}
			if (!loginCaptchaActionPassed && (captchaAuthorityCaptchaRequired || loginAttemptFloodCheckersFlooded) && !_CaptchaAuthority.IsCredentialValueExemptFromAttemptCaptcha(credentials.CredentialValue))
			{
				InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.CaptchaFailed, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.CaptchaFailed);
			}
			loginAttemptByIpFloodChecker.UpdateCount();
			userCredentialsFloodChecker.UpdateCount();
		}
		IUser user;
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "GetUser", sw.ElapsedMilliseconds);
		}))
		{
			try
			{
				user = credentials.GetUser();
				if (user == null || user.IsForgotten() || IsUserChinaLoginRestricted(user))
				{
					InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
					InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.UserNotFound, credentials.CredentialsType);
					return new LoginResult(LoginFailureStatus.UserNotFound);
				}
			}
			catch (CredentialsCollisionException)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.CredentialsCollision, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.CredentialsCollision);
			}
			catch (MultipleUsersPerCredentialException)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.MultipleUsersPerCredentials, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.MultipleUsersPerCredentials);
			}
			catch (UnverifiedCredentialsException exception)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(exception.UserId, LoginFailureStatus.UnverifiedCredentials, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.UnverifiedCredentials);
			}
			catch (UnverifiedCredentialsMultipleUsersException)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.UnverifiedCredentialsMultipleUsers, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.UnverifiedCredentialsMultipleUsers);
			}
			catch (TooManyUsersLinkedToCredentialsException)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.TooManyUsersPerCredentials, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.TooManyUsersPerCredentials);
			}
			catch (InvalidCredentialsException)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(null, LoginFailureStatus.InvalidCredentials, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.InvalidCredentials);
			}
		}
		IUser authenticatedUser = _WebAuthenticationReader.GetAuthenticatedUser();
		if (authenticatedUser != null)
		{
			this.OnLoginSessionAlreadyExists?.Invoke();
			if (ExistingLoginSessionShouldFailEnabled)
			{
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, loginAttemptFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(authenticatedUser, LoginFailureStatus.LoginSessionAlreadyExists, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.LoginSessionAlreadyExists);
			}
			if (authenticatedUser.Id == user.Id)
			{
				return new LoginResult(authenticatedUser);
			}
			this.OnAccountMismatchSignOut?.Invoke();
		}
		ulong browserTrackerId = (ulong)(browserTracker?.Id ?? 0);
		ILoginFloodCheckers loginFloodCheckers = GetLoginFloodCheckers(user, ipAddress, browserTrackerId);
		bool userLoginFloodCheckersFlooded = loginFloodCheckers.FailedLoginFloodCheckerSet.IsFlooded() || loginFloodCheckers.SuccessfulLoginFloodChecker.IsFlooded();
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "Check Captcha", sw.ElapsedMilliseconds);
		}))
		{
			if (!loginCaptchaActionPassed && userLoginFloodCheckersFlooded)
			{
				InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.CaptchaFailed, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.CaptchaFailed);
			}
		}
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "Verify Credentials", sw.ElapsedMilliseconds);
		}))
		{
			if (!credentials.Verify())
			{
				loginFloodCheckers.FailedLoginFloodCheckerSet.UpdateCount();
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, userLoginFloodCheckersFlooded);
				if (!HasValidPasswordSet(user))
				{
					InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.UserWithNullPassword, credentials.CredentialsType);
					return new LoginResult(LoginFailureStatus.UserWithNullPassword);
				}
				InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.InvalidCredentials, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.InvalidCredentials);
			}
			userCredentialsFloodChecker.Reset();
		}
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "Check If Password Reset Required", sw.ElapsedMilliseconds);
		}))
		{
			if (_AccountsNeedingPasswordResetFactory.GetAccountNeedsPasswordReset(user))
			{
				loginFloodCheckers.FailedLoginFloodCheckerSet.UpdateCount();
				InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, userLoginFloodCheckersFlooded);
				InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.PasswordResetRequired, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.PasswordResetRequired);
			}
		}
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "Check Two Step Verification", sw.ElapsedMilliseconds);
		}))
		{
			if (_TwoStepAuthenticator.IsTwoStepChallengeRequired(user))
			{
				try
				{
					if (Roblox.Web.Authentication.Properties.Settings.Default.IsTwoStepVerificationUnavailable)
					{
						InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.TwoStepVerificationFailed, credentials.CredentialsType);
						return new LoginResult(LoginFailureStatus.TwoStepVerificationServiceUnavailable);
					}
					TwoStepVerificationChallengeDTO challenge = _TwoStepVerificationCodeSender.GenerateChallengeAndSendCode(user, TwoStepVerificationActionType.Login, ipAddress);
					TwoStepVerificationMediaType mediaType = _TwoStepVerificationConfigurationProvider.GetTwoStepSettingForUser(user).MediaType;
					string ticket = (Roblox.Platform.TwoStepVerification.Properties.Settings.Default.IsTwoStepSecureBlobEnabled ? _TwoStepAuthenticator.CreateChallengeSecureBlob(challenge.Id) : challenge.Id.ToString());
					LoginTwoStepVerificationData twoStepVerificationData = new LoginTwoStepVerificationData
					{
						Ticket = ticket,
						MediaType = mediaType
					};
					this.OnTwoStepVerificationSucceeded?.Invoke(GetUserAgent(), mediaType, user, credentials.CredentialsType);
					return new LoginResult(user, twoStepVerificationData);
				}
				catch (PlatformOperationUnavailableException)
				{
					InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.TwoStepVerificationFailed, credentials.CredentialsType);
					return new LoginResult(LoginFailureStatus.TwoStepVerificationServiceUnavailable);
				}
				catch (TwoStepVerificationUnverifiedMediaTypeException)
				{
					InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.TwoStepVerificationFailed, credentials.CredentialsType);
					return new LoginResult(LoginFailureStatus.TwoStepVerificationFailed);
				}
				catch (PlatformFloodedException)
				{
					InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.TwoStepVerificationFailed, credentials.CredentialsType);
					return new LoginResult(LoginFailureStatus.Flooded);
				}
				catch (Exception)
				{
					InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.TwoStepVerificationFailed, credentials.CredentialsType);
					return new LoginResult(LoginFailureStatus.TwoStepVerificationFailed);
				}
			}
		}
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "Authentication", sw.ElapsedMilliseconds);
		}))
		{
			AuthenticationSessionType sessionType = GetAuthenticationSessionType();
			IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
			if (!SetAuthCookie(authenticationSession, ipAddress, sessionType))
			{
				loginFloodCheckers.FailedLoginFloodCheckerSet.UpdateCount();
				InvokeOnUserLoginFailedEvent(user, LoginFailureStatus.InvalidCredentials, credentials.CredentialsType);
				return new LoginResult(LoginFailureStatus.InvalidCredentials);
			}
		}
		using (new DisposableStopWatch(SignInWithUserCredentialsActionLoggingEnabled, delegate(Stopwatch sw)
		{
			OnActionProcessed("SignInWithUserCredentials", "Finish SignIn", sw.ElapsedMilliseconds);
		}))
		{
			loginFloodCheckers.SuccessfulLoginFloodChecker.UpdateCount();
			InvalidateLoginCaptchaActionWhenFlooded(loginCaptchaAction, captchaAuthorityCaptchaRequired, forceInvalidation: true);
			this.OnUserLoggedIn?.Invoke(user, credentials.CredentialsType);
		}
		return new LoginResult(user);
	}

	internal virtual IFloodChecker GetUserCredentialsFloodChecker(IRobloxUserCredentials credentials)
	{
		return new UserCredentialsFloodChecker(GetOriginIP(), credentials.CredentialsType, credentials.CredentialValue);
	}

	internal virtual IFloodChecker GetLoginAttemptByIpFloodChecker(string ipAddress)
	{
		return new LoginAttemptByIpFloodChecker(ipAddress, IsLoginAttemptByIpFloodCheckEnabled);
	}

	internal virtual bool HasValidPasswordSet(IUser user)
	{
		return user.HasValidPasswordSet();
	}

	internal virtual IAction GetLoginCaptchaAction(string credentialValue)
	{
		return new LoginCaptchaAction(credentialValue, _CaptchaFactories);
	}

	internal virtual ILoginFloodCheckers GetLoginFloodCheckers(IUser user, string ipAddress, ulong browserTrackerId)
	{
		return new LoginFloodCheckers(user, ipAddress, browserTrackerId);
	}

	internal virtual bool SetAuthCookie(IAuthenticationSession authenticationSession, string ip, AuthenticationSessionType sessionType)
	{
		if (authenticationSession is ITokenSecuredAuthenticationSession securedAuthenticationSession)
		{
			return SetAuthCookie(authenticationSession.AccountName, ip, sessionType, securedAuthenticationSession.SessionToken);
		}
		return false;
	}

	private bool SetAuthCookie(string accountName, string ip, AuthenticationSessionType sessionType, ISessionToken sessionToken = null)
	{
		if (_UserFactory.GetUserByName(accountName) != null)
		{
			RobloxAuthenticationCookie authCookie = RobloxAuthenticationCookie.GetOrCreate(accountName, sessionType);
			if (ip != null)
			{
				authCookie.IP = ip;
			}
			if (sessionToken != null)
			{
				authCookie.SessionToken = sessionToken;
			}
			if (!HttpContext.Current.Request.IsLocal)
			{
				string domain = FormsAuthentication.CookieDomain;
				if (!string.IsNullOrEmpty(domain) && HttpContext.Current.Request.Url.Host.EndsWith(domain))
				{
					authCookie.Domain = domain;
				}
			}
			authCookie.Save();
			return true;
		}
		return false;
	}

	internal virtual string GetUserAgent()
	{
		return HttpContext.Current?.Request.UserAgent;
	}

	internal virtual string GetOriginIP()
	{
		return HttpContext.Current.GetOriginIP();
	}

	internal virtual HttpRequest GetCurrentRequest()
	{
		return HttpContext.Current?.Request;
	}

	private AuthenticationSessionType GetAuthenticationSessionType()
	{
		string userAgent = GetUserAgent();
		if (_ClientDeviceIdentifier.IsRobloxClient(userAgent))
		{
			return AuthenticationSessionType.Game;
		}
		return AuthenticationSessionType.Website;
	}

	internal virtual TimeSpan GetTimeToLiveForSessionType(AuthenticationSessionType sessionType)
	{
		if ((uint)sessionType > 1u && sessionType == AuthenticationSessionType.Game)
		{
			return Roblox.Web.Authentication.Properties.Settings.Default.GameSessionTokenTimeToLive;
		}
		return Roblox.Web.Authentication.Properties.Settings.Default.WebSessionTokenTimeToLive;
	}

	internal virtual bool IsUserChinaLoginRestricted(IUser user)
	{
		if (!Roblox.Web.Authentication.Properties.Settings.Default.IsCredentialsLoginForChinaLicenseUsersEnabled)
		{
			return user.IsChinaLicenseUser();
		}
		return false;
	}

	private void OnActionProcessed(string actionName, string actionDescription, long actionProcessingTime)
	{
		if (SignInWithUserCredentialsActionLoggingEnabled && this.SignInWithUserCredentialsActionProcessed != null)
		{
			this.SignInWithUserCredentialsActionProcessed(actionName, actionDescription, actionProcessingTime);
		}
	}

	private void InvokeOnUserLoginFailedEvent(IUserIdentifier userIdentifier, LoginFailureStatus loginFailureStatus, CredentialsType credentialsType)
	{
		string userAgent = GetUserAgent();
		this.OnUserLoginFailed?.Invoke(userIdentifier, loginFailureStatus, credentialsType, userAgent);
	}

	/// <summary>
	/// Invalidates the login captcha action if captcha was required because of a floodchecker having been flooded.
	/// Subsequent attempts must pass captcha again if the action is invalidated.
	/// </summary>
	/// <remarks>
	/// This prevents someone from unnecessarily solving captchas for each login attempt if captcha is always
	/// required for login and they have not exceeded any rate limits.
	/// </remarks>
	/// <param name="loginCaptchaAction"></param>
	/// <param name="captchaRequiredForAllAttempts"></param>
	/// <param name="forceInvalidation"></param>
	private void InvalidateLoginCaptchaActionWhenFlooded(IAction loginCaptchaAction, bool captchaRequiredForAllAttempts, bool forceInvalidation)
	{
		if (!captchaRequiredForAllAttempts || forceInvalidation)
		{
			loginCaptchaAction.Invalidate();
		}
	}
}
