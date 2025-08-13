using System.Web;

namespace Roblox.Web.Code.CookieConstraint;

public interface ICookieConstraintVerifier
{
	bool IsVerified(HttpContextBase httpContextBase);
}
