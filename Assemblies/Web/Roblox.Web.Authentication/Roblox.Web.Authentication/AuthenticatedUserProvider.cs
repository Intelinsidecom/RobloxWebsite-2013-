using System;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

public class AuthenticatedUserProvider : IAuthenticatedUserProvider
{
	private IWebAuthenticationReader _WebAuthenticationReader;

	/// <inheritdoc />
	public IUser AuthenticatedUser => _GetCachedUser();

	/// <summary>
	/// Default constructor
	/// </summary>
	/// <param name="webAuthenticationReader"></param>
	public AuthenticatedUserProvider(IWebAuthenticationReader webAuthenticationReader)
	{
		_WebAuthenticationReader = webAuthenticationReader ?? throw new ArgumentNullException("webAuthenticationReader");
	}

	private IUser _GetCachedUser()
	{
		if (!HttpContext.Current.Items.Contains("AuthenticatedUser"))
		{
			HttpContext.Current.Items["AuthenticatedUser"] = _WebAuthenticationReader.GetAuthenticatedUser();
		}
		return (IUser)HttpContext.Current.Items["AuthenticatedUser"];
	}
}
