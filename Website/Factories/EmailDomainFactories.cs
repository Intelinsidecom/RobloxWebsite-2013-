using System;
using Roblox.EventLog;
using Roblox.Platform.Core;
using Roblox.Platform.Email.User;
using Roblox.Website.Factories;

namespace Roblox.Platform.Email
{
    /// <summary>
    /// A class holding the factories for the Platform.Email domain.
    /// </summary>
    public class EmailDomainFactories : DomainFactoriesBase
    {
        /// <summary>
        /// Gets the logger.
        /// </summary>
        public virtual ILogger Logger { get; }

        /// <summary>
        /// Gets the user email factory.
        /// </summary>
        public virtual IUserEmailFactory UserEmailFactory { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailDomainFactories" /> class.
        /// </summary>
        /// <param name="logger">The logger.</param>
        public EmailDomainFactories(ILogger logger)
        {
            Logger = logger ?? throw new ArgumentNullException(nameof(logger));
            UserEmailFactory = new Roblox.Platform.Email.UserEmailFactory();
        }
    }
}
