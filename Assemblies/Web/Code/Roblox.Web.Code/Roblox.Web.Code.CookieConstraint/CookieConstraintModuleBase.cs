using System;
using System.Web;
using Roblox.WebsiteSettings.Properties;

namespace Roblox.Web.Code.CookieConstraint;

/// <summary>
/// Provides a base class for cookie constraint modules used on ASPX pages.
/// </summary>
public abstract class CookieConstraintModuleBase : IHttpModule
{
	/// <summary>
	/// The configuration describing the redirects for the implementation.
	/// </summary>
	protected abstract CookieConstraintRedirectConfiguration Configuration { get; }

	protected abstract ICookieConstraintVerifier CookieConstraintVerifier { get; }

	private void context_BeginRequest(object sender, EventArgs e)
	{
		HttpApplication application = sender as HttpApplication;
		HttpRequest request = application?.Request;
		if (request != null)
		{
			string absPathLowercase = request.Url.AbsolutePath.ToLower();
			if (absPathLowercase.EndsWith(Settings.Default.CookieConstraint_ProtectedPageExtension) && !absPathLowercase.Contains(Configuration.CookieConstraintRedirectRelativeUrl.ToLower()) && !CookieConstraintVerifier.IsVerified(request.RequestContext?.HttpContext))
			{
				string cookieUrl = Configuration.CookieConstraintRedirectAbsoluteUrl;
				application.Response.Redirect($"{cookieUrl}?ReturnUrl={HttpUtility.UrlEncode(application.Request.Url.ToString())}", endResponse: true);
			}
		}
	}

	public void Dispose()
	{
	}

	public void Init(HttpApplication application)
	{
		application.BeginRequest += context_BeginRequest;
	}
}
