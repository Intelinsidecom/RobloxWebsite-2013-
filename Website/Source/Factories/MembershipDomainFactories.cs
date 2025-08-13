using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Website.Factories;
using Roblox.Platform.Email;

namespace Roblox.Platform.Membership
{
    /// <summary>
    /// A class holding the factories for the Platform.Membership domain.
    /// </summary>
    public class MembershipDomainFactories : DomainFactoriesBase
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        public virtual ILogger Logger { get; }

        /// <summary>
        /// Gets the roles domain factories.
        /// </summary>
        public virtual RolesDomainFactories RolesDomainFactories { get; }

        /// <summary>
        /// Gets the email domain factories.
        /// </summary>
        public virtual EmailDomainFactories EmailDomainFactories { get; }

        /// <summary>
        /// Gets the user factory.
        /// </summary>
        public virtual IUserFactory UserFactory { get; }

        /// <summary>
        /// Gets the role set validator.
        /// </summary>
        public virtual IRoleSetValidator RoleSetValidator { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="MembershipDomainFactories" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        /// <param name="rolesDomainFactories">The roles domain factories.</param>
        /// <param name="emailDomainFactories">The email domain factories.</param>
        public MembershipDomainFactories(
            ILogger logger,
            RolesDomainFactories rolesDomainFactories,
            EmailDomainFactories emailDomainFactories)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            RolesDomainFactories = rolesDomainFactories ?? throw new ArgumentNullException(nameof(rolesDomainFactories));
            EmailDomainFactories = emailDomainFactories ?? throw new ArgumentNullException(nameof(emailDomainFactories));
            UserFactory = new Roblox.Platform.Membership.UserFactory();
            RoleSetValidator = new Roblox.Platform.Roles.RoleSetValidator();
        }
    }
}
