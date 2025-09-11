using System;

namespace Roblox.Website.Factories
{
    // Placeholder for roles/permissions-related DI factories. Expand as needed.
    public class RolesDomainFactories
    {
        public RolesDomainFactories()
        {
            Logger = new RobloxWebsiteLogger();
            RoleSetReader = new object();
        }

        public RolesDomainFactories(RobloxWebsiteLogger logger)
        {
            Logger = logger;
            RoleSetReader = new object();
        }

        public RobloxWebsiteLogger Logger { get; }

        // Website code references this, but does not use it for logic here
        public object RoleSetReader { get; }
    }
}
