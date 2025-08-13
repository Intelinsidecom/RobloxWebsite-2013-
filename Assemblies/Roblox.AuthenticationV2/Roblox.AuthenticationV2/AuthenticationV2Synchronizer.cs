using System;
using System.Linq;
using System.Net;
using System.Web;
using Roblox.AuthenticationV2.Client;
using Roblox.AuthenticationV2.Properties;
using Roblox.Configuration;
using Roblox.EventLog;
using Roblox.Http.Client;
using Roblox.Platform.Authentication.Entities;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication;

namespace Roblox.AuthenticationV2;

/// <inheritdoc />
public class AuthenticationV2Synchronizer : IAuthenticationV2Synchronizer
{
	private readonly WebAuthenticator _WebAuthenticator;

	private readonly IAuthenticationV2Client _AuthenticationV2Client;

	private readonly IAuthenticationV2Telemetry _AuthenticationV2Telemetry;

	private readonly ISettings _Settings;

	private readonly IUserFactory _UserFactory;

	private readonly IRoleSetValidator _RoleSetValidator;

	private readonly IIPAddressHasher _IPAddressHasher;

	private readonly ILogger _Logger;

	/// <summary>
	/// Constructs a new <see cref="T:Roblox.AuthenticationV2.AuthenticationV2Synchronizer" />
	/// </summary>
	/// <param name="logger">An <see cref="T:Roblox.EventLog.ILogger" /></param>
	/// <param name="authenticationV2Telemetry">An <see cref="T:Roblox.AuthenticationV2.IAuthenticationV2Telemetry" /></param>
	/// <param name="webAuthenticator">A <see cref="T:Roblox.Web.Authentication.WebAuthenticator" />.  This cannot be an <see cref="T:Roblox.Web.Authentication.IWebAuthenticator" /> because we need access to events that are internal.</param>
	/// <param name="authenticationV2Client">An <see cref="T:Roblox.AuthenticationV2.Client.IAuthenticationV2Client" /></param>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" /></param>
	/// <param name="roleSetValidator">An <see cref="T:Roblox.Platform.Membership.IRoleSetValidator" /></param>
	/// <param name="ipAddressHasher">An <see cref="T:Roblox.AuthenticationV2.IIPAddressHasher" /></param>
	/// <exception cref="T:System.ArgumentNullException">
	///     <paramref name="logger" />
	///     <paramref name="authenticationV2Telemetry" />
	///     <paramref name="webAuthenticator" />
	///     <paramref name="authenticationV2Client" />
	///     <paramref name="userFactory" />
	///     <paramref name="roleSetValidator" />
	///     <paramref name="ipAddressHasher" />
	/// </exception>
	public AuthenticationV2Synchronizer(ILogger logger, IAuthenticationV2Telemetry authenticationV2Telemetry, WebAuthenticator webAuthenticator, IAuthenticationV2Client authenticationV2Client, IUserFactory userFactory, IRoleSetValidator roleSetValidator, IIPAddressHasher ipAddressHasher)
	{
		_Settings = Settings.Default;
		_Logger = logger ?? throw new ArgumentNullException("logger");
		_AuthenticationV2Telemetry = authenticationV2Telemetry ?? throw new ArgumentNullException("authenticationV2Telemetry");
		_AuthenticationV2Client = authenticationV2Client ?? throw new ArgumentNullException("authenticationV2Client");
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
		_RoleSetValidator = roleSetValidator ?? throw new ArgumentNullException("roleSetValidator");
		_WebAuthenticator = webAuthenticator ?? throw new ArgumentNullException("webAuthenticator");
		_IPAddressHasher = ipAddressHasher ?? throw new ArgumentNullException("ipAddressHasher");
		_WebAuthenticator.OnRobloxUserSessionDestroyed += DeleteRobloxUserSession;
		_WebAuthenticator.OnUserSignedOutFromAllSessions += DeleteAllRobloxUserSessions;
		_WebAuthenticator.OnRobloxUserSessionRequiresSynchronization += SyncRobloxUserSession;
	}

	/// <inheritdoc />
	public void PreSendRequestHeaders(HttpRequestBase request, HttpResponseBase response)
	{
		if (request != null && response != null)
		{
			CookieValidationStatus cookieValidationStatus;
			RobloxAuthenticationCookie authCookie = RobloxAuthenticationCookie.GetCurrent(out cookieValidationStatus);
			if (authCookie != null && cookieValidationStatus == CookieValidationStatus.Success && !request.Cookies.AllKeys.ToList().Contains(_Settings.AuthenticationV2CookieName) && !response.Cookies.AllKeys.ToList().Contains(_Settings.AuthenticationV2CookieName))
			{
				SyncRobloxUserSession(authCookie);
			}
		}
	}

	/// <summary>
	/// Synchronizes an AuthenticationV1 session with AuthenticationV2
	/// </summary>
	/// <param name="authCookie">A <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /></param>
	private void SyncRobloxUserSession(RobloxAuthenticationCookie authCookie)
	{
		if (authCookie == null)
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.NullCookie);
			return;
		}
		IUser user = _UserFactory.GetUserByName(authCookie.AccountName);
		if (user == null)
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.NullUser);
			return;
		}
		if (!IsEnabled(user))
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.DisabledIntent);
			return;
		}
		if (!Guid.TryParse(authCookie.SessionToken?.Value, out var token))
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.BadToken);
			return;
		}
		SessionToken session = SessionToken.GetByToken(token);
		if (session == null)
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.NullSession);
			return;
		}
		if (!session.Expiration.HasValue)
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.SessionWithoutExpiration);
			return;
		}
		if (!IPAddress.TryParse(authCookie.IP, out var ipAddress))
		{
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.BadIpAddress);
			return;
		}
		TimeSpan timeToLive = _WebAuthenticator.GetTimeToLiveForSessionType(authCookie.SessionType);
		string ipAddressHash = _IPAddressHasher.SHA256(ipAddress);
		try
		{
			string encodedJwt = _AuthenticationV2Client.SyncRobloxUserSession(_Settings.RobloxUserClaimType, user.Id.ToString(), session.Token, session.Expiration.Value, ipAddressHash, timeToLive);
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.Success);
			WriteAuthenticationV2Cookie(encodedJwt);
		}
		catch (HttpRequestFailedException e)
		{
			_Logger.Error(e);
			_AuthenticationV2Telemetry.Increment(Counter.SyncRobloxUserSession, Instance.Failure);
		}
	}

	/// <summary>
	/// Deletes an AuthenticationV2 session for the specified <paramref name="session" />
	/// </summary>
	/// <param name="authCookie">A <see cref="T:Roblox.Web.Authentication.RobloxAuthenticationCookie" /></param>
	private void DeleteRobloxUserSession(RobloxAuthenticationCookie authCookie)
	{
		if (authCookie == null)
		{
			_AuthenticationV2Telemetry.Increment(Counter.DeleteRobloxUserSession, Instance.NullCookie);
			return;
		}
		IUser user = _UserFactory.GetUserByName(authCookie.AccountName);
		if (user == null)
		{
			_AuthenticationV2Telemetry.Increment(Counter.DeleteRobloxUserSession, Instance.NullUser);
			return;
		}
		if (!IsEnabled(user))
		{
			_AuthenticationV2Telemetry.Increment(Counter.DeleteRobloxUserSession, Instance.DisabledIntent);
			return;
		}
		if (!Guid.TryParse(authCookie.SessionToken?.Value, out var token))
		{
			_AuthenticationV2Telemetry.Increment(Counter.DeleteRobloxUserSession, Instance.BadToken);
			return;
		}
		try
		{
			_AuthenticationV2Client.DeleteRobloxUserSession(token);
			_AuthenticationV2Telemetry.Increment(Counter.DeleteRobloxUserSession, Instance.Success);
		}
		catch (HttpRequestFailedException e)
		{
			_Logger.Error(e);
			_AuthenticationV2Telemetry.Increment(Counter.DeleteRobloxUserSession, Instance.Failure);
		}
		finally
		{
			DeleteAuthenticationV2Cookie();
		}
	}

	/// <summary>
	/// Deletes all AuthenticationV2 sessions for the specified <paramref name="user" />
	/// </summary>
	/// <param name="user">An <see cref="T:Roblox.Platform.Membership.IUser" /></param>
	private void DeleteAllRobloxUserSessions(IUser user)
	{
		if (user == null)
		{
			_AuthenticationV2Telemetry.Increment(Counter.DeleteAllRobloxUserSessions, Instance.NullUser);
			return;
		}
		if (!IsEnabled(user))
		{
			_AuthenticationV2Telemetry.Increment(Counter.DeleteAllRobloxUserSessions, Instance.DisabledIntent);
			return;
		}
		try
		{
			_AuthenticationV2Client.DeleteAllRobloxUserSessions(_Settings.RobloxUserClaimType, user.Id.ToString());
			_AuthenticationV2Telemetry.Increment(Counter.DeleteAllRobloxUserSessions, Instance.Success);
		}
		catch (HttpRequestFailedException e)
		{
			_Logger.Error(e);
			_AuthenticationV2Telemetry.Increment(Counter.DeleteAllRobloxUserSessions, Instance.Failure);
		}
		finally
		{
			DeleteAuthenticationV2Cookie();
		}
	}

	private bool IsEnabled(IUser user)
	{
		if (!_Settings.IsAuthenticationV2ForSoothsayersEnabled || !_RoleSetValidator.IsSoothsayer(user))
		{
			if (_Settings.IsAuthenticationV2ForEveryoneEnabled)
			{
				return Math.Abs(user.Id) % 10000 <= _Settings.AuthenticationV2RolloutPerMyriad;
			}
			return false;
		}
		return true;
	}

	/// <summary>
	/// Writes the AuthenticationV2 cookie
	/// </summary>
	/// <param name="encodedJwt">The AuthenticationV2 External Jwt representation of a session</param>
	private void WriteAuthenticationV2Cookie(string encodedJwt)
	{
		HttpCookie cookie = new HttpCookie(_Settings.AuthenticationV2CookieName);
		cookie.Expires = DateTime.Now + _Settings.AuthenticationV2CookieTimeToLive;
		cookie.Domain = RobloxEnvironment.Domain;
		cookie.Secure = true;
		cookie.HttpOnly = true;
		cookie.Value = encodedJwt;
		HttpContext.Current.Response.Cookies.Set(cookie);
	}

	/// <summary>
	/// Deletes the AuthenticationV2 cookie
	/// </summary>
	private void DeleteAuthenticationV2Cookie()
	{
		HttpCookie cookie = new HttpCookie(_Settings.AuthenticationV2CookieName);
		cookie.Expires = DateTime.Now.AddDays(-1.0);
		cookie.Domain = RobloxEnvironment.Domain;
		cookie.Secure = true;
		cookie.HttpOnly = true;
		cookie.Value = string.Empty;
		HttpContext.Current.Response.Cookies.Set(cookie);
	}
}
