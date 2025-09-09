using System;
using System.Web;

namespace Roblox.Web.Code.CookieConstraint
{
    // Minimal no-op HTTP module to satisfy web.config module registration
    // Replaces missing type: Roblox.Web.HttpModules.CookieConstraint (Roblox.Web.HttpModules)
    public class CookieConstraintModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            // No behavior required for now. Hook events here if needed.
        }

        public void Dispose()
        {
            // Nothing to dispose.
        }
    }
}
