using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Roblox.Web.Code.Properties;

namespace Roblox.Web.Code.CookieConstraint;

/// <summary>
/// Provides shared functions for dealing with the cookie constraint.
/// </summary>
public class CookieConstraintValidator
{
	private static List<string> _ActiveButtonTextCsv => (from b in Settings.Default.CookieConstraint_AllowedButtonValuesCSV.Split(',')
		select b.ToLower()).ToList();

	/// <summary>
	/// Determines whether the supplied <see cref="T:System.Web.HttpRequest" /> has passed the cookie constraint.
	/// </summary>
	public static bool HasConstrainedCookie(HttpRequest request)
	{
		return request.Cookies[Settings.Default.CookieConstraintCookieName] != null;
	}

	/// <summary>
	/// Sets the cookie indicating the client has passed the cookie constraint.
	/// </summary>
	/// <param name="response">The response to which the cookie should be appended</param>
	/// <param name="host">The host of the request, used to validate that the cookie can be set.</param>
	/// <param name="domainSuffix">The domain suffix to use for the cookie.</param>
	public static void SetConstrainedCookie(HttpResponse response, string host, string domainSuffix)
	{
		HttpCookie constrainedCookie = new HttpCookie(Settings.Default.CookieConstraintCookieName);
		constrainedCookie.Expires = DateTime.Now + Settings.Default.CookieConstraintExpiration;
		if (domainSuffix != "" && host.EndsWith(domainSuffix))
		{
			constrainedCookie.Domain = domainSuffix;
		}
		response.Cookies.Add(constrainedCookie);
	}

	public static bool IsCookieConstraintLetterCorrect(string cookieConstraintButtonLetter)
	{
		return _ActiveButtonTextCsv.Contains(cookieConstraintButtonLetter.ToLower());
	}
}
