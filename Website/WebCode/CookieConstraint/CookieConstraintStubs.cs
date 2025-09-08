using System.Web;

namespace Roblox.Web.Code.CookieConstraint
{
    public static class CookieConstraintValidator
    {
        public static bool HasConstrainedCookie(HttpRequestBase request) => true;
        public static bool HasConstrainedCookie(HttpRequest request) => true;
    }

    public static class CookieConstraintManager
    {
        public static bool IsRequesterConstrained() => false;
        public static void LiftConstraint(string password, string action) { }
    }
}
