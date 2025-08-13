using System;
using System.Security.Principal;
using System.Web;
using Roblox.Platform.Membership;

namespace Roblox.Web.Authentication;

public class WebAuthenticationReader : IWebAuthenticationReader
{
	private readonly IUserFactory _UserFactory;

	/// <summary>
	/// Initializes a new instance of the <see cref="T:Roblox.Web.Authentication.WebAuthenticationReader" /> class.
	/// </summary>
	/// <param name="userFactory">An <see cref="T:Roblox.Platform.Membership.IUserFactory" />.</param>
	/// <exception cref="T:System.ArgumentNullException">
	///     Thrown if <paramref name="userFactory" /> is null.
	/// </exception>
	public WebAuthenticationReader(IUserFactory userFactory)
	{
		_UserFactory = userFactory ?? throw new ArgumentNullException("userFactory");
	}

	/// <inheritdoc />
	public IUser GetAuthenticatedUser(HttpContextBase context)
	{
		return GetAuthenticatedUserFromPrincipal(context.User);
	}

	/// <inheritdoc />
	public IUser GetAuthenticatedUser()
	{
		IPrincipal principal = GetPrincipal();
		return GetAuthenticatedUserFromPrincipal(principal);
	}

	private IUser GetAuthenticatedUserFromPrincipal(IPrincipal principal)
	{
		string userName = principal?.Identity?.Name;
		if (string.IsNullOrWhiteSpace(userName))
		{
			return null;
		}
		return _UserFactory.GetUserByName(userName);
	}

	internal virtual IPrincipal GetPrincipal()
	{
		return HttpContext.Current?.User;
	}
}
