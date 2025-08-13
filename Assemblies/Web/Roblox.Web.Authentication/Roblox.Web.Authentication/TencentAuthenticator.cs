using System;
using System.Web;
using System.Web.Security;
using Roblox.Common;
using Roblox.Platform.Authentication;
using Roblox.Platform.Membership;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication;

public class TencentAuthenticator : ITencentAuthenticator
{
	private readonly ISettings _Settings;

	private readonly ISessionFactory _SessionFactory;

	public TencentAuthenticator(ISessionFactory sessionFactory)
		: this(Settings.Default, sessionFactory)
	{
	}

	internal TencentAuthenticator(ISettings settings, ISessionFactory sessionFactory)
	{
		_Settings = settings ?? throw new ArgumentNullException("settings");
		_SessionFactory = sessionFactory ?? throw new ArgumentNullException("sessionFactory");
	}

	public ILoginResult Authenticate(IUser user)
	{
		AuthenticationSessionType sessionType = AuthenticationSessionType.Website;
		string ipAddress = HttpContext.Current.GetOriginIP();
		IAuthenticationSession authenticationSession = _SessionFactory.CreateSession(user, _Settings.WebSessionTokenTimeToLive);
		if (SetAuthCookie(authenticationSession, ipAddress, sessionType, user))
		{
			return new LoginResult(user);
		}
		return new LoginResult(LoginFailureStatus.InvalidCredentials);
	}

	private bool SetAuthCookie(IAuthenticationSession authenticationSession, string ip, AuthenticationSessionType sessionType, IUser user)
	{
		if (authenticationSession is ITokenSecuredAuthenticationSession securedAuthenticationSession)
		{
			return SetAuthCookie(user, ip, sessionType, securedAuthenticationSession.SessionToken);
		}
		return false;
	}

	private bool SetAuthCookie(IUser user, string ip, AuthenticationSessionType sessionType, ISessionToken sessionToken = null)
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
		if (!string.IsNullOrEmpty(sessionToken?.Value))
		{
			authCookie.SessionToken = SessionTokenFactory.Build(sessionToken.Value);
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
}
