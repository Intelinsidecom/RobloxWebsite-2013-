using System;

namespace Roblox.Website.Factories
{
    // Placeholder for authentication-related DI factories. Expand as needed.
    public class AuthenticationDomainFactories
    {
        public AuthenticationDomainFactories(
            object logger,
            SecurityDomainFactories securityDomainFactories,
            MembershipDomainFactories membershipDomainFactories,
            EmailDomainFactories emailDomainFactories)
        {
            Logger = logger;
            SecurityDomainFactories = securityDomainFactories;
            MembershipDomainFactories = membershipDomainFactories;
            EmailDomainFactories = emailDomainFactories;
            CredentialValidator = new DefaultCredentialValidator();
        }

        public object Logger { get; }
        public SecurityDomainFactories SecurityDomainFactories { get; }
        public MembershipDomainFactories MembershipDomainFactories { get; }
        public EmailDomainFactories EmailDomainFactories { get; }

        // Minimal stub exposed for Website usage
        public Roblox.Platform.Authentication.ICredentialValidator CredentialValidator { get; }

        private class DefaultCredentialValidator : Roblox.Platform.Authentication.ICredentialValidator
        {
            public Roblox.Platform.Authentication.CredentialValidationResult ValidateCredentials(Roblox.Platform.Authentication.UserCredentials credentials)
            {
                return new Roblox.Platform.Authentication.CredentialValidationResult { IsValid = true };
            }

            public bool ValidateEmail(long userId, string email) => true;
        }
    }
}
