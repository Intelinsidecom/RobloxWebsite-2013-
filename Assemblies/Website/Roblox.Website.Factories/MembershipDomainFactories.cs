using System;
using Roblox.Platform.Membership;

namespace Roblox.Website.Factories
{
    // Placeholder for membership-related DI factories. Expand as needed.
    public class MembershipDomainFactories
    {
        public MembershipDomainFactories(object logger, RolesDomainFactories rolesDomainFactories, EmailDomainFactories emailDomainFactories)
        {
            Logger = logger;
            RolesDomainFactories = rolesDomainFactories;
            EmailDomainFactories = emailDomainFactories;
            UserFactory = new StubUserFactory();
            RoleSetValidator = new StubRoleSetValidator();
        }

        public object Logger { get; }
        public RolesDomainFactories RolesDomainFactories { get; }
        public EmailDomainFactories EmailDomainFactories { get; }

        public IUserFactory UserFactory { get; }
        public IRoleSetValidator RoleSetValidator { get; }
    }
}
