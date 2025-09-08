using System.Web;
using System.Web.Mvc;
// using Roblox.Web.Mvc; // Removed: BaseActionFilterAttribute not available in current setup

namespace Roblox.Website {
    public class FilterConfig {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters) {
            filters.Add(new HandleErrorAttribute());
            // filters.Add(new BaseActionFilterAttribute());
        }
    }
}
