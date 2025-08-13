using System;
using System.Collections.Specialized;
using System.Linq;
using System.Web;
using System.Web.Security;
using Roblox.Common;
using Roblox.Libraries.Cookies;
using Roblox.Platform.Authentication;
using Roblox.Web.Authentication.Properties;

namespace Roblox.Web.Authentication;

public class RobloxAuthenticationCookie : RobloxCookieBase
{
	private FormsAuthenticationTicketDecorator _Ticket;

	public static readonly RobloxCookieIdentifier AuthCookieIdentifier = new RobloxCookieIdentifier(FormsAuthentication.FormsCookieName);

	protected override string Name => AuthCookieIdentifier.Name;

	protected override TimeSpan? _ExpirationLength => FormsAuthentication.Timeout;

	public string AccountName => _Ticket.Ticket.Name;

	public override string Domain
	{
		get
		{
			if (!string.IsNullOrEmpty(base.Domain))
			{
				return base.Domain;
			}
			return FormsAuthentication.CookieDomain;
		}
		set
		{
			base.Domain = value;
		}
	}

	public string Version
	{
		get
		{
			return _Ticket.GetUserData("Version") ?? string.Empty;
		}
		private set
		{
			_Ticket.SetUserData("Version", value);
		}
	}

	public string IP
	{
		get
		{
			return _Ticket.GetUserData("IP") ?? string.Empty;
		}
		set
		{
			_Ticket.SetUserData("IP", value);
		}
	}

	public ISessionToken SessionToken
	{
		get
		{
			return SessionTokenFactory.Build(_Ticket.GetUserData("SessionToken"));
		}
		set
		{
			_Ticket.SetUserData("SessionToken", value.Value);
		}
	}

	public AuthenticationSessionType SessionType
	{
		get
		{
			AuthenticationSessionType? sessionType = EnumUtils.StrictTryParseEnum<AuthenticationSessionType>(_Ticket.GetUserData("SessionType"));
			if (sessionType.HasValue)
			{
				return sessionType.Value;
			}
			return AuthenticationSessionType.Undefined;
		}
		set
		{
			_Ticket.SetUserData("SessionType", value.ToString());
		}
	}

	public override void DoDeSerializeValues(NameValueCollection keyValues)
	{
		string stringToDecrypt = keyValues[0];
		if (Settings.Default.ShouldRemoveDoNotShareWarningFromAuthCookie)
		{
			bool wasChanged;
			string newValue = DoNotShareWarning.RemoveWarning(keyValues[0], out wasChanged);
			if (wasChanged)
			{
				stringToDecrypt = newValue;
			}
		}
		_Ticket = new FormsAuthenticationTicketDecorator(FormsAuthentication.Decrypt(stringToDecrypt));
	}

	public override NameValueCollection DoSerializeValues()
	{
		return new NameValueCollection { [null] = FormsAuthentication.Encrypt(_Ticket.Ticket) };
	}

	public virtual void EnsureTimeToLiveIsCurrent()
	{
		TimeSpan timeToLive = _Ticket.Expiration.ToUniversalTime() - _Ticket.IssueDate.ToUniversalTime();
		if (Settings.Default.IsEnsureExpirationIsCurrentEnabled && timeToLive < FormsAuthentication.Timeout)
		{
			_Ticket.Expiration = _Ticket.IssueDate + FormsAuthentication.Timeout;
			Save();
		}
	}

	public override void Save()
	{
		string valueToSet = (Settings.Default.ShouldAppendDoNotShareWarningToAuthCookie ? DoNotShareWarning.AddWarning(FormsAuthentication.Encrypt(_Ticket.Ticket)) : FormsAuthentication.Encrypt(_Ticket.Ticket));
		HttpCookie cookie = new HttpCookie(Name)
		{
			Value = valueToSet,
			Expires = _Ticket.Expiration,
			Path = Path,
			HttpOnly = true,
			Domain = Domain,
			Secure = FormsAuthentication.RequireSSL
		};
		HttpContext.Current.Response.Cookies.Set(cookie);
	}

	public static RobloxAuthenticationCookie GetCurrent()
	{
		CookieValidationStatus cookieValidationStatus;
		return GetCurrent(out cookieValidationStatus);
	}

	internal static RobloxAuthenticationCookie GetCurrent(out CookieValidationStatus cookieValidationStatus)
	{
		RobloxAuthenticationCookie authCookie = RobloxCookieHelper.Get<RobloxAuthenticationCookie>(AuthCookieIdentifier);
		if (authCookie == null)
		{
			cookieValidationStatus = CookieValidationStatus.CookieRetrievalFailed;
			return null;
		}
		if (authCookie.Version != Settings.Default.AuthCookieVersion)
		{
			authCookie.Delete();
			cookieValidationStatus = CookieValidationStatus.CookieVersionMismatch;
			return null;
		}
		cookieValidationStatus = CookieValidationStatus.Success;
		return authCookie;
	}

	/// <summary>
	/// Gets or creates a properly versioned authentication cookie
	/// </summary>
	/// <remarks>
	/// The logic here is a bit counter-intuitive primarily to support the website's use of ASP.NET's login control
	/// </remarks>
	internal static RobloxAuthenticationCookie GetOrCreate(string accountName, AuthenticationSessionType sessionType)
	{
		RobloxAuthenticationCookie authCookie = RobloxCookieHelper.Get<RobloxAuthenticationCookie>(AuthCookieIdentifier);
		if (authCookie == null || authCookie.AccountName != accountName)
		{
			if (authCookie == null && Settings.Default.RemoveDeletedAuthCookieOnGetOrCreateEnabled && HttpContext.Current.Response.Cookies.AllKeys.Contains(AuthCookieIdentifier.Name))
			{
				HttpContext.Current.Response.Cookies.Remove(AuthCookieIdentifier.Name);
			}
			FormsAuthentication.SetAuthCookie(accountName, createPersistentCookie: true);
			authCookie = RobloxCookieHelper.Get<RobloxAuthenticationCookie>(AuthCookieIdentifier);
		}
		try
		{
			authCookie.Version = Settings.Default.AuthCookieVersion;
			authCookie.SessionType = sessionType;
			authCookie.Save();
			return authCookie;
		}
		catch (NullReferenceException e)
		{
			if (HttpContext.Current.Request.Cookies.AllKeys.Contains(AuthCookieIdentifier.Name))
			{
				HttpCookie cookie = HttpContext.Current.Request.Cookies[AuthCookieIdentifier.Name];
				throw new Exception($"RobloxAuthenticationCookie.GetOrCreate failed with auth cookie in request: '{cookie.Name}'='{cookie.Value}'", e);
			}
			throw e;
		}
	}
}
