using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Authentication.AccountSecurity;
using Roblox.Platform.Membership;
using Roblox.Platform.Email;

namespace Roblox.Platform.Authentication
{
    /// <summary>
    /// A class holding the factories for the Platform.Authentication domain.
    /// </summary>
    public class AuthenticationDomainFactories : DomainFactoriesBase
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        public virtual ILogger Logger { get; }

        /// <summary>
        /// Gets the account security domain factories.
        /// </summary>
        public virtual SecurityDomainFactories SecurityDomainFactories { get; }

        /// <summary>
        /// Gets the membership domain factories.
        /// </summary>
        public virtual MembershipDomainFactories MembershipDomainFactories { get; }

        /// <summary>
        /// Gets the email domain factories.
        /// </summary>
        public virtual EmailDomainFactories EmailDomainFactories { get; }

        /// <summary>
        /// Gets the credential validator.
        /// </summary>
        public virtual ICredentialValidator CredentialValidator { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthenticationDomainFactories" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="securityDomainFactories">The security domain factories.</param>
        /// <param name="membershipDomainFactories">The membership domain factories.</param>
        /// <param name="emailDomainFactories">The email domain factories.</param>
        public AuthenticationDomainFactories(
            ILogger logger,
            SecurityDomainFactories securityDomainFactories,
            MembershipDomainFactories membershipDomainFactories,
            EmailDomainFactories emailDomainFactories)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            SecurityDomainFactories = securityDomainFactories ?? throw new ArgumentNullException(nameof(securityDomainFactories));
            MembershipDomainFactories = membershipDomainFactories ?? throw new ArgumentNullException(nameof(membershipDomainFactories));
            EmailDomainFactories = emailDomainFactories ?? throw new ArgumentNullException(nameof(emailDomainFactories));
            CredentialValidator = new CredentialValidator();
        }
    }
}
