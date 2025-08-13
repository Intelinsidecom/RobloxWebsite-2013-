using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using Roblox.Common;
using Roblox.EventLog;
using Roblox.Http.ServiceClient;
using Roblox.Identities.Client;
using Roblox.Identities.Models;
using Roblox.Platform.Authentication;
using Roblox.Platform.Core;
using Roblox.Platform.Devices;
using Roblox.Platform.Membership;
using Roblox.Platform.TwoStepVerification;
using Roblox.Platform.XboxLive;
using Roblox.RequestContext;
using Roblox.Web.Authentication.Floodcheckers;
using Roblox.Web.Authentication.Interfaces;
using Roblox.Web.Authentication.Properties;
using Roblox.Web.Devices;

namespace Roblox.Web.Authentication;

public class WebAuthenticator : IWebAuthenticator
{
	private readonly ICredentialsFactory _CredentialsFactory;

	private readonly IAccountsNeedingPasswordResetFactory _AccountsNeedingPasswordResetFactory;

	private readonly ILogger _Logger;

	private readonly IUserFactory _UserFactory;

	private readonly IClientDeviceIdentifier _ClientDeviceIdentifier;

	private readonly IRequestContextLoader _RequestContextLoader;

	private readonly IIdentitiesClient _IdentitiesClient;

	private const string _FloodedMessage = "Flooded";

	/// <summary>
	/// Event fired when a user signs in.
	/// </summary>
	public event Action<IUser> OnUserSignedIn;

	/// <summary>
	/// Event fired when a user signs out.
	/// </summary>
	public event Action<IUser, IPlatform, ISessionToken> OnUserSignedOut;

	/// <summary>
	/// Event fired when a user signs out of all sessions.
	/// </summary>
	/// <remarks>
	/// This event is not fired at the same time as <see cref="E:Roblox.Web.Authentication.WebAuthenticator.OnUserSignedOut" /> because the current session is recreated and the user has indirectly logged out of other sessions.
	/// </remarks>
	public event Action<IUser> OnUserSignedOutFromAllSessions;

	/// <summary>
	/// Event fired when an authentication session fails validation.
	/// </summary>
	internal event Action<CookieValidationStatus, IAuthenticationSession, IUser> OnFailedSessionValidation;

	internal event Action<RobloxAuthenticationCookie> OnRobloxUserSessionDestroyed;

	internal event Action<RobloxAuthenticationCookie> OnRobloxUserSessionRequiresSynchronization;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.WebAuthenticator" /> class.
	/// </summary>
	/// <param name="credentialsFactory">An <see cref="T:Roblox.Platform.Authentication.ICredentialsFactory" />.</param>
	/// <param name="accountsNeedingPasswordResetFactory">An <see cref="T:Roblox.Platform.Authentication.IAccountsNeedingPasswordResetFactory" />.</param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" />.</param>
	/// <param name="clientDeviceIdentifier">An <see cref="T:Roblox.Web.Devices.IClientDeviceIdentifier" />.</param>
	/// <param name="requestContextLoader">An <see cref="T:Roblox.RequestContext.IRequestContextLoader" /></param>
	/// <param name="identitiesClient">An <see cref="T:Roblox.Identities.Client.IIdentitiesClient" /></param>
	/// <exception cref="T:System.ArgumentNullException">Thrown if <paramref name="credentialsFactory" />, <paramref name="accountsNeedingPasswordResetFactory" />, <paramref name="logger" />, <paramref name="userFactory" />, <paramref name="clientDeviceIdentifier" /> or is null.</exception>
	public WebAuthenticator(ICredentialsFactory credentialsFactory, IAccountsNeedingPasswordResetFactory accountsNeedingPasswordResetFactory, IUserFactory userFactory, ILogger logger, IClientDeviceIdentifier clientDeviceIdentifier, IRequestContextLoader requestContextLoader, IIdentitiesClient identitiesClient)
	{
		_CredentialsFactory = credentialsFactory ?? throw new ArgumentNullException("credentialsFactory");
		_AccountsNeedingPasswordResetFactory = accountsNeedingPasswordResetFactory ?? throw new ArgumentNullException("accountsNeedingPasswordResetFactory");
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_ClientDeviceIdentifier = clientDeviceIdentifier ?? throw new ArgumentNullException("clientDeviceIdentifier");
		_RequestContextLoader = requestContextLoader ?? throw new ArgumentNullException("requestContextLoader");
		_IdentitiesClient = identitiesClient ?? throw new ArgumentNullException("identitiesClient");
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.GetAuthenticatedUser" />
	[Obsolete("Use IWebAuthenticationReader.GetAuthenticatedUser instead.")]
	public IUser GetAuthenticatedUser()
	{
		string userName = GetAuthenticatedUsername();
		if (string.IsNullOrWhiteSpace(userName))
		{
			return null;
		}
		return _UserFactory.GetUserByName(userName);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.Impersonate(Roblox.Platform.Membership.IUser,System.String)" />
	public bool Impersonate(IUser user, string ipAddress)
	{
		if (user == null)
		{
			throw new ArgumentNullException("user");
		}
		if (string.IsNullOrWhiteSpace(ipAddress))
		{
			throw new ArgumentException("Value cannot be null or whitespace.", "ipAddress");
		}
		IAuthenticateAsUserCredentials credentials = _CredentialsFactory.BuildAuthenticateAsUserCredentials(user);
		if (credentials == null)
		{
			return false;
		}
		AuthenticationSessionType sessionType = GetAuthenticationSessionType();
		IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
		return SetAuthCookie(authenticationSession, ipAddress, sessionType);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignInViaAuthenticationTicket(System.String)" />
	public bool SignInViaAuthenticationTicket(string accountName)
	{
		IAuthenticateAsUserCredentials credentials = _CredentialsFactory.BuildAuthenticateAsUserCredentials(accountName);
		if (credentials == null)
		{
			return false;
		}
		string ipAddress = GetCurrentIpAddress();
		AuthenticationSessionType sessionType = GetAuthenticationSessionType();
		IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
		return SetAuthCookie(authenticationSession, ipAddress, sessionType);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignIn(System.String,System.String,System.String)" />
	[Obsolete("Use IWebAuthenticatorV2.SignInWithUserCredentials instead.")]
	public bool SignIn(string accountName, string password, string ipAddress)
	{
		IRobloxCredentials credentials = _CredentialsFactory.BuildRobloxCredentialsFromAccountNameAndPassword(accountName, password);
		if (credentials == null)
		{
			return false;
		}
		IUser user = _UserFactory.GetUserByName(accountName);
		if (_AccountsNeedingPasswordResetFactory.GetAccountNeedsPasswordReset(user))
		{
			return false;
		}
		AuthenticationSessionType sessionType = GetAuthenticationSessionType();
		IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
		return SetAuthCookie(authenticationSession, ipAddress, sessionType);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignInViaFacebook(System.UInt64)" />
	public IUser SignInViaFacebook(ulong facebookId)
	{
		ISignInWithFacebookFloodCheckers signInWithFacebookFloodCheckers = GetSignInWithFacebookFloodCheckers(facebookId);
		if (signInWithFacebookFloodCheckers.SignInWithFacebookByFacebookIdFloodChecker.IsFlooded())
		{
			throw new FloodedException("SignInWithFacebookByFacebookIdFloodChecker");
		}
		signInWithFacebookFloodCheckers.SignInWithFacebookByFacebookIdFloodChecker.UpdateCount();
		if (signInWithFacebookFloodCheckers.SignInWithFacebookByIpAndFacebookIdFloodChecker.IsFlooded())
		{
			throw new FloodedException("SignInWithFacebookByIpAndFacebookIdFloodChecker");
		}
		signInWithFacebookFloodCheckers.SignInWithFacebookByIpAndFacebookIdFloodChecker.UpdateCount();
		IFacebookCredentials facebookCredentials = _CredentialsFactory.BuildFacebookCredentials(facebookId);
		AuthenticationSessionType sessionType = GetAuthenticationSessionType();
		IAuthenticationSession authenticationSession = facebookCredentials?.Authenticate(GetTimeToLiveForSessionType(sessionType));
		if (string.IsNullOrWhiteSpace(authenticationSession?.AccountName))
		{
			return null;
		}
		IUser user = _UserFactory.GetUserByName(authenticationSession.AccountName);
		if (IsPrivilegedUser(user))
		{
			throw new ExceptionHandler.PresentableException("Privileged accounts cannot login via Facebook.  Use your regular name and password.", "Sorry to troll you but...");
		}
		string ipAddress = GetCurrentIpAddress();
		if (!SetAuthCookie(authenticationSession, ipAddress, sessionType))
		{
			return null;
		}
		return user;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignInViaXbox(System.String,System.String,Roblox.Platform.Authentication.IXboxLiveAccountDataAccessor,Roblox.Platform.XboxLive.IXboxLiveUserManager,System.String)" />
	public bool SignInViaXbox(string pairwiseId, string gamerTag, IXboxLiveAccountDataAccessor xboxLiveAccountDataAccessor, IXboxLiveUserManager userManager, string ipAddress)
	{
		IXboxLiveCredentials credentials = _CredentialsFactory.BuildXboxLiveCredentials(pairwiseId, xboxLiveAccountDataAccessor);
		try
		{
			AuthenticationSessionType sessionType = GetAuthenticationSessionType();
			IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
			if (!string.IsNullOrWhiteSpace(authenticationSession?.AccountName))
			{
				userManager.SynchronizeGamerTagHash(pairwiseId, gamerTag);
				return SetAuthCookie(authenticationSession, ipAddress, sessionType);
			}
		}
		catch (ExceptionHandler.PresentableException)
		{
			throw;
		}
		catch (Exception exp)
		{
			_Logger.Error(exp);
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignInUsingTwoStepVerificationCredentials(Roblox.Platform.TwoStepVerification.ITwoStepVerificationCodeValidator,Roblox.Platform.TwoStepVerification.TwoStepVerificationChallengeDTO)" />
	public bool SignInUsingTwoStepVerificationCredentials(ITwoStepVerificationCodeValidator twoStepVerificationCodeValidator, TwoStepVerificationChallengeDTO challenge)
	{
		if (twoStepVerificationCodeValidator == null)
		{
			return false;
		}
		ITwoStepVerificationCredentials credentials = _CredentialsFactory.BuildTwoStepVerificationCredentialsFromChallenge(twoStepVerificationCodeValidator, challenge);
		if (credentials == null)
		{
			return false;
		}
		try
		{
			AuthenticationSessionType sessionType = GetAuthenticationSessionType();
			IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
			if (string.IsNullOrWhiteSpace(authenticationSession?.AccountName))
			{
				return false;
			}
			string ipAddress = GetCurrentIpAddress();
			return SetAuthCookie(authenticationSession, ipAddress, sessionType);
		}
		catch (PlatformFloodedException ex2)
		{
			throw new FloodedException("Flooded", ex2);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignOut" />
	public void SignOut()
	{
		IUser user = GetAuthenticatedUser();
		ISessionToken currentSessionToken = GetCurrentSessionToken();
		SignOutFromRobloxAuthentication();
		SignOutFromFormsAuthentication();
		if (user != null)
		{
			IPlatform platform = null;
			string userAgent = GetUserAgent();
			if (!string.IsNullOrEmpty(userAgent))
			{
				platform = _ClientDeviceIdentifier.GetPlatformByUserAgent(userAgent);
			}
			this.OnUserSignedOut?.Invoke(user, platform, currentSessionToken);
		}
	}

	internal virtual void SignOutFromRobloxAuthentication()
	{
		try
		{
			RobloxAuthenticationCookie authCookie = GetCurrentRobloxAuthenticationCookie();
			if (!string.IsNullOrEmpty(authCookie?.SessionToken?.Value))
			{
				SessionTokenFactory.Delete(authCookie.SessionToken);
				this.OnRobloxUserSessionDestroyed?.Invoke(authCookie);
			}
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignOutFromAllSessionsAndReauthenticate(System.String,Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger)" />
	public void SignOutFromAllSessionsAndReauthenticate(string ipAddress, ITwoStepVerificationSessionPurger twoStepVerificationSessionPurger)
	{
		if (twoStepVerificationSessionPurger == null)
		{
			throw new ArgumentNullException("twoStepVerificationSessionPurger");
		}
		RobloxAuthenticationCookie currentCookie = GetCurrentRobloxAuthenticationCookie();
		IUser user = GetAuthenticatedUser();
		DeleteAuthenticationAndTwoStepSessions(user, twoStepVerificationSessionPurger);
		IAuthenticateAsUserCredentials credentials = _CredentialsFactory.BuildAuthenticateAsUserCredentials(user);
		if (credentials != null)
		{
			AuthenticationSessionType sessionType = GetRobloxAuthenticationCookieSessionType(currentCookie);
			IAuthenticationSession authenticationSession = credentials.Authenticate(GetTimeToLiveForSessionType(sessionType));
			SetAuthCookie(authenticationSession, ipAddress, sessionType);
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.SignOutFromAllSessions(Roblox.Platform.Membership.IUser,Roblox.Platform.TwoStepVerification.ITwoStepVerificationSessionPurger)" />
	public void SignOutFromAllSessions(IUser user, ITwoStepVerificationSessionPurger twoStepVerificationSessionPurger)
	{
		if (twoStepVerificationSessionPurger == null)
		{
			throw new ArgumentNullException("twoStepVerificationSessionPurger");
		}
		DeleteAuthenticationAndTwoStepSessions(user, twoStepVerificationSessionPurger);
	}

	private void DeleteAuthenticationAndTwoStepSessions(IUser user, ITwoStepVerificationSessionPurger twoStepVerificationSessionPurger)
	{
		DeleteAllSessions(user);
		twoStepVerificationSessionPurger.DeleteSessionsForUser(user);
		this.OnUserSignedOutFromAllSessions?.Invoke(user);
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.IsAuthCookieAndSessionValid" />
	public bool IsAuthCookieAndSessionValid()
	{
		CookieValidationStatus cookieValidationStatus;
		RobloxAuthenticationCookie currentCookie = GetCurrentRobloxAuthenticationCookie(out cookieValidationStatus);
		if (currentCookie == null)
		{
			SignOutFromFormsAuthentication();
			this.OnFailedSessionValidation?.Invoke(cookieValidationStatus, null, null);
			return false;
		}
		currentCookie.EnsureTimeToLiveIsCurrent();
		AuthenticationSessionValidationStatus authenticationSessionValidationStatus;
		IAuthenticationSession authenticationSession = GetAuthenticationSession(currentCookie, out authenticationSessionValidationStatus);
		IUser user;
		if (authenticationSession == null)
		{
			user = _UserFactory.GetUserByName(GetRobloxAuthenticationCookieAccountName(currentCookie));
			SignOutFromFormsAuthentication();
			this.OnFailedSessionValidation?.Invoke(GetCookieValidationStatus(authenticationSessionValidationStatus), null, user);
			return false;
		}
		user = authenticationSession.Validate(GetTimeToLiveForSessionType(GetRobloxAuthenticationCookieSessionType(currentCookie)), out authenticationSessionValidationStatus, out var wasExtended);
		if (user == null)
		{
			SignOutFromFormsAuthentication();
			this.OnFailedSessionValidation?.Invoke(GetCookieValidationStatus(authenticationSessionValidationStatus), authenticationSession, null);
			return false;
		}
		if (IsPrivilegedUser(user) && !OriginIpAddressIsValid(currentCookie))
		{
			InvalidateRobloxSession(CookieValidationStatus.IpAddressMismatch, authenticationSession, user);
			return false;
		}
		if (IsTencentSessionCheckEnabled(user, GetCheckWeChatSessionByRolesetRolloutPercentage(), GetCheckWeChatSessionByRequestContextRolloutPercentage()) && IsWeChatSessionInvalid(user))
		{
			InvalidateRobloxSession(CookieValidationStatus.WeChatSessionNotFound, authenticationSession, user);
			return false;
		}
		if (IsTencentSessionCheckEnabled(user, GetCheckTencentSessionByRolesetRolloutPercentage(), GetCheckTencentSessionByRequestContextRolloutPercentage()) && IsTencentSessionInvalid(user))
		{
			InvalidateRobloxSession(CookieValidationStatus.TencentSessionNotFound, authenticationSession, user);
			return false;
		}
		if (wasExtended)
		{
			this.OnRobloxUserSessionRequiresSynchronization?.Invoke(currentCookie);
		}
		return true;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.VerifyAccountPassword(System.String,System.String)" />
	public bool VerifyAccountPassword(string accountName, string password)
	{
		return _CredentialsFactory.BuildRobloxCredentialsFromAccountNameAndPassword(accountName, password)?.Verify() ?? false;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.GetAuthenticatedUsername" />
	public virtual string GetAuthenticatedUsername()
	{
		string name = HttpContext.Current?.User?.Identity?.Name;
		if (!string.IsNullOrEmpty(name))
		{
			return name;
		}
		return null;
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.RemoveAuthCookiePrefix(System.Web.HttpRequest)" />
	public void RemoveAuthCookiePrefix(HttpRequest request)
	{
		if (!Settings.Default.ShouldRemoveDoNotShareWarningFromAuthCookie)
		{
			return;
		}
		HttpCookie rawAuthenticationCookie = request.Cookies[RobloxAuthenticationCookie.AuthCookieIdentifier.Name];
		if (rawAuthenticationCookie != null)
		{
			bool wasChanged;
			string newValue = DoNotShareWarning.RemoveWarning(rawAuthenticationCookie.Value, out wasChanged);
			if (wasChanged)
			{
				rawAuthenticationCookie.Value = newValue;
			}
		}
	}

	/// <inheritdoc cref="M:Roblox.Web.Authentication.IWebAuthenticator.GetCurrentSessionToken" />
	public ISessionToken GetCurrentSessionToken()
	{
		return RobloxAuthenticationCookie.GetCurrent()?.SessionToken;
	}

	internal virtual bool SetAuthCookie(IAuthenticationSession authenticationSession, string ip, AuthenticationSessionType sessionType)
	{
		if (authenticationSession is ITokenSecuredAuthenticationSession securedAuthenticationSession)
		{
			return SetAuthCookie(authenticationSession.User, ip, sessionType, securedAuthenticationSession.SessionToken);
		}
		return false;
	}

	internal bool IsFeatureEnabledForUserId(IUser user, int rolloutPercentage)
	{
		return user.Id % 100 < rolloutPercentage;
	}

	internal virtual int GetCheckWeChatSessionByRolesetRolloutPercentage()
	{
		return Settings.Default.CheckWeChatSessionByRolesetRolloutPercentage;
	}

	internal virtual int GetCheckWeChatSessionByRequestContextRolloutPercentage()
	{
		return Settings.Default.CheckWeChatSessionByRequestContextRolloutPercentage;
	}

	internal virtual int GetCheckTencentSessionByRolesetRolloutPercentage()
	{
		return Settings.Default.CheckTencentSessionByRolesetRolloutPercentage;
	}

	internal virtual int GetCheckTencentSessionByRequestContextRolloutPercentage()
	{
		return Settings.Default.CheckTencentSessionByRequestContextRolloutPercentage;
	}

	internal virtual string GetCurrentIpAddress()
	{
		return HttpContext.Current?.GetOriginIP();
	}

	internal virtual bool IsPrivilegedUser(IUser user)
	{
		return user.IsPrivilegedUser();
	}

	internal virtual bool IsChinaLicenseUser(IUser user)
	{
		return user.IsChinaLicenseUser();
	}

	internal virtual RobloxAuthenticationCookie GetCurrentRobloxAuthenticationCookie(out CookieValidationStatus cookieValidationStatus)
	{
		return RobloxAuthenticationCookie.GetCurrent(out cookieValidationStatus);
	}

	internal virtual RobloxAuthenticationCookie GetCurrentRobloxAuthenticationCookie()
	{
		CookieValidationStatus dummy;
		return GetCurrentRobloxAuthenticationCookie(out dummy);
	}

	internal virtual void DeleteAllSessions(IUser user)
	{
		user.DeleteAllSessions();
	}

	internal virtual IAuthenticationSession GetAuthenticationSession(RobloxAuthenticationCookie cookie, out AuthenticationSessionValidationStatus authenticationSessionValidationStatus)
	{
		if (string.IsNullOrWhiteSpace(cookie.AccountName))
		{
			authenticationSessionValidationStatus = AuthenticationSessionValidationStatus.InvalidUser;
			return null;
		}
		if (cookie.SessionToken == null)
		{
			authenticationSessionValidationStatus = AuthenticationSessionValidationStatus.InvalidSessionToken;
			return null;
		}
		authenticationSessionValidationStatus = AuthenticationSessionValidationStatus.Success;
		return new TokenSecuredAuthenticationSession(cookie.AccountName, cookie.SessionToken, _UserFactory);
	}

	internal virtual string GetRobloxAuthenticationCookieAccountName(RobloxAuthenticationCookie cookie)
	{
		return cookie.AccountName;
	}

	internal virtual AuthenticationSessionType GetRobloxAuthenticationCookieSessionType(RobloxAuthenticationCookie cookie)
	{
		return cookie.SessionType;
	}

	internal virtual bool OriginIpAddressIsValid(RobloxAuthenticationCookie cookie)
	{
		return cookie.OriginIpAddressIsValid();
	}

	internal virtual void SignOutFromFormsAuthentication()
	{
		FormsAuthentication.SignOut();
		HttpContext.Current.User = null;
	}

	private bool SetAuthCookie(IUser user, string ip, AuthenticationSessionType sessionType, ISessionToken sessionToken)
	{
		if (user == null)
		{
			return false;
		}
		RobloxAuthenticationCookie authCookie = RobloxAuthenticationCookie.GetOrCreate(user.Name, sessionType);
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
		this.OnRobloxUserSessionRequiresSynchronization?.Invoke(authCookie);
		try
		{
			this.OnUserSignedIn?.Invoke(user);
		}
		catch (Exception ex)
		{
			_Logger.Error(ex);
		}
		return true;
	}

	internal CookieValidationStatus GetCookieValidationStatus(AuthenticationSessionValidationStatus authenticationSessionValidationStatus)
	{
		return authenticationSessionValidationStatus switch
		{
			AuthenticationSessionValidationStatus.Success => CookieValidationStatus.Success, 
			AuthenticationSessionValidationStatus.InvalidUser => CookieValidationStatus.InvalidUser, 
			AuthenticationSessionValidationStatus.InvalidSessionForUser => CookieValidationStatus.InvalidSessionForUser, 
			AuthenticationSessionValidationStatus.InvalidSessionToken => CookieValidationStatus.InvalidSessionToken, 
			AuthenticationSessionValidationStatus.SessionTokenMissing => CookieValidationStatus.SessionTokenNotFound, 
			AuthenticationSessionValidationStatus.SessionTokenExpired => CookieValidationStatus.SessionTokenExpired, 
			AuthenticationSessionValidationStatus.SessionTokenMissingOnExtend => CookieValidationStatus.SessionTokenNotFoundOnExtend, 
			_ => throw new ArgumentOutOfRangeException("authenticationSessionValidationStatus"), 
		};
	}

	internal virtual string GetUserAgent()
	{
		return HttpContext.Current?.Request.UserAgent;
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
			return Settings.Default.GameSessionTokenTimeToLive;
		}
		return Settings.Default.WebSessionTokenTimeToLive;
	}

	internal virtual ISignInWithFacebookFloodCheckers GetSignInWithFacebookFloodCheckers(ulong facebookId)
	{
		return new SignInWithFacebookFloodCheckers(HttpContext.Current.GetOriginIP(), facebookId);
	}

	private void InvalidateRobloxSession(CookieValidationStatus cookieValidationStatus, IAuthenticationSession authenticationSession, IUser user)
	{
		SignOutFromRobloxAuthentication();
		SignOutFromFormsAuthentication();
		this.OnFailedSessionValidation?.Invoke(cookieValidationStatus, authenticationSession, user);
	}

	/// <summary>
	/// Checks whether to validate the user's tencent session using 2 methods:
	/// 1) Checks if the user has the ChinaLicenseUser roleset
	/// 2) Checks if the RequestContext has the LicenseBuildChina policy
	/// </summary>
	private bool IsTencentSessionCheckEnabled(IUser user, int byRoleSetRolloutPercentage, int byRequestContextRolloutPercentage)
	{
		if (IsFeatureEnabledForUserId(user, byRoleSetRolloutPercentage) && IsChinaLicenseUser(user))
		{
			return true;
		}
		if (IsFeatureEnabledForUserId(user, byRequestContextRolloutPercentage) && _RequestContextLoader.GetCurrentContext().ApplicablePolicies.Contains(Policy.LicenseBuildChina))
		{
			return true;
		}
		return false;
	}

	private bool IsWeChatSessionInvalid(IUser user)
	{
		string userAgent = GetUserAgent();
		WeChatIdentityPlatform platform = ((!_ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent) && !_ClientDeviceIdentifier.IsRobloxIOSApp(userAgent)) ? WeChatIdentityPlatform.Web : WeChatIdentityPlatform.Mobile);
		try
		{
			if (_IdentitiesClient.GetWeChatSessionDataByAccountIdAndIdentityPlatform(user.AccountId, platform) == WeChatSessionDataResult.Empty)
			{
				return true;
			}
		}
		catch (ServiceOperationErrorException ex)
		{
			if (ex.Code != "NotFoundSessionData" && ex.Code != "NotFoundIdentityData")
			{
				_Logger.Error((Exception)(object)ex);
			}
			return true;
		}
		return false;
	}

	private bool IsTencentSessionInvalid(IUser user)
	{
		string userAgent = GetUserAgent();
		ExternalIdentityPlatformType platformType = ((!_ClientDeviceIdentifier.IsRobloxAndroidApp(userAgent) && !_ClientDeviceIdentifier.IsRobloxIOSApp(userAgent)) ? ExternalIdentityPlatformType.Web : ExternalIdentityPlatformType.Mobile);
		List<ExternalIdentityType> externalIdentityTypes = _IdentitiesClient.GetExternalIdentityTypesWithValidSessions(user.AccountId, platformType)?.ToList();
		if (!externalIdentityTypes.Contains(ExternalIdentityType.WeChat))
		{
			return !externalIdentityTypes.Contains(ExternalIdentityType.QQ);
		}
		return false;
	}
}
