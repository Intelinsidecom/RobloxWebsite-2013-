using System;

namespace Roblox.Website.Factories
{
    // Placeholder for security-related DI factories. Expand as needed.
    public class SecurityDomainFactories
    {
        public SecurityDomainFactories()
        {
            Logger = new RobloxWebsiteLogger();
        }

        public SecurityDomainFactories(object logger)
        {
            Logger = new RobloxWebsiteLogger();
        }

        public SecurityDomainFactories(RobloxWebsiteLogger logger)
        {
            Logger = logger;
        }

        public RobloxWebsiteLogger Logger { get; }
    }
}
